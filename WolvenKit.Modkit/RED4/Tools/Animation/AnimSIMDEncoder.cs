using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;

using static WolvenKit.Modkit.RED4.Animation.Const;
using static WolvenKit.Modkit.RED4.Animation.Fun;

using TranslationsAtTimes = System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>;
using RotationsAtTimes = System.Collections.Generic.Dictionary<float, System.Numerics.Quaternion>;
using ScalesAtTimes = System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>;

namespace WolvenKit.Modkit.RED4.Animation
{
    /// <summary>
    /// SIMD animation buffer encoder — the inverse of <see cref="SIMD.DecodeSimdAnimationData"/>.
    ///
    /// Encodes <see cref="AnimationBufferData"/> (sparse keyframe dictionaries in glTF Y-up RHS coords)
    /// into the dense, uniformly-sampled, SIMD-aligned binary format used by the game's
    /// <see cref="animAnimationBufferSimd"/> type.
    ///
    /// Binary layout (written in this order):
    ///   1. Rotations        — SIMD-interleaved blocks of 4, quantized or float32
    ///   2. Eval translations — SIMD-interleaved blocks of 4, float32, only for animated joints
    ///   3. Scales            — Constant (single Vec3 padded to 4 floats) or SIMD-interleaved
    ///   4. Track data        — Constant (single float) or per-frame per-track, 4-aligned
    ///   5. Copy translations — float32 Vec3 for joints with static translation
    ///   6. Copy indices      — int16 joint indices for static translations
    ///   7. Eval indices      — int16 joint indices for animated translations (SIMD-padded)
    /// </summary>
    internal static class SIMDEncoder
    {
        private const int SimdBlockWidth = 4;
        private const float TranslationEpsilon = 0.0001f;
        private const float TrackEpsilon = 0.00001f;

        /// <summary>
        /// Encode animation data into a SIMD animation buffer and data chunk.
        /// This is the exact inverse of <see cref="SIMD.DecodeSimdAnimationData"/>.
        /// </summary>
        internal static void EncodeSimdAnimationData(
            out animAnimDataChunk newAnimDataChunk,
            out animAnimationBufferSimd newSimdBuffer,
            in AnimationBufferData data,
            animAnimDataAddress chunkDataAddress,
            ILoggerService logger)
        {
            var jointsCountActual = data.JointsCountActual;
            var numJoints = data.NumJoints;
            var numExtraJoints = data.NumExtraJoints;
            var numTracks = data.NumTracks;
            var numExtraTracks = data.NumExtraTracks;
            var duration = data.Duration;
            var frameCount = data.FrameCount;

            // Frame count must be >= 2 for SIMD (uniform sampling needs at least start + end)
            if (frameCount < 2)
            {
                frameCount = 2;
            }

            var frameTime = duration / (frameCount - 1);

            // SIMD alignment
            var numJointsSimdAligned = (uint)((jointsCountActual + SimdBlockWidth - 1) & (~(SimdBlockWidth - 1)));

            // Determine quantization — use the original bit depth if available,
            // otherwise derive from the compression enum (0 = uncompressed, else 16-bit default)
            var isQuantized = data.CompressionUsed == AnimationCompression.QuaternionAsFixed3x16bit;
            ushort quantizationBits = data.SimdQuantizationBits > 0
                ? data.SimdQuantizationBits
                : (isQuantized ? (ushort)16 : (ushort)0);
            isQuantized = quantizationBits > 0;

            // --- Classify translations: which joints animate, which are static ---
            ClassifyTranslations(
                in data, jointsCountActual, frameCount, frameTime,
                out var evalJointIndices, out var copyJointIndices,
                out var copyPositions);

            // SIMD-align the eval count
            var numTranslationsToEval = (ushort)evalJointIndices.Count;
            var numTranslationsToEvalAligned = (ushort)((numTranslationsToEval + SimdBlockWidth - 1) & (~(SimdBlockWidth - 1)));
            var numTranslationsToCopy = (ushort)copyJointIndices.Count;

            // Pad eval indices to SIMD alignment with -1 sentinels
            var evalIndicesPadded = new short[numTranslationsToEvalAligned];
            for (var i = 0; i < numTranslationsToEvalAligned; i++)
            {
                evalIndicesPadded[i] = i < evalJointIndices.Count ? (short)evalJointIndices[i] : (short)-1;
            }

            // --- Classify scales ---
            var isScaleConstant = ClassifyScalesConstant(in data, jointsCountActual, frameCount, frameTime);

            // --- Classify tracks ---
            var isTrackConstant = ClassifyTracksConstant(in data);

            // --- Resample all data to uniform frames ---
            var rotationsForFrame = ResampleRotations(in data, jointsCountActual, numJointsSimdAligned, frameCount, frameTime);
            var evalPositionsForFrame = ResampleEvalTranslations(in data, evalJointIndices, evalIndicesPadded, numTranslationsToEvalAligned, frameCount, frameTime);
            var scalesForFrame = isScaleConstant ? null : ResampleScales(in data, jointsCountActual, numJointsSimdAligned, frameCount, frameTime);
            var constantScale = isScaleConstant ? GetConstantScale(in data, jointsCountActual) : Vec3.One;

            // --- Write binary buffer ---
            using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);

            // 1. ROTATIONS
            WriteRotations(bw, rotationsForFrame, frameCount, numJointsSimdAligned, jointsCountActual, isQuantized, quantizationBits);

            // 2. EVAL TRANSLATIONS (animated positions, SIMD-interleaved)
            WriteEvalTranslations(bw, evalPositionsForFrame, frameCount, numTranslationsToEvalAligned);

            // 3. SCALES
            WriteScales(bw, scalesForFrame, constantScale, isScaleConstant, frameCount, numJointsSimdAligned, jointsCountActual);

            // 4. TRACKS
            WriteTracks(bw, in data, isTrackConstant, frameCount, frameTime, numTracks);

            // 5. COPY TRANSLATIONS (static positions)
            foreach (var pos in copyPositions)
            {
                bw.Write(pos.X);
                bw.Write(pos.Y);
                bw.Write(pos.Z);
            }

            // 6. COPY INDICES
            foreach (var idx in copyJointIndices)
            {
                bw.Write((short)idx);
            }

            // 7. EVAL INDICES
            foreach (var idx in evalIndicesPadded)
            {
                bw.Write(idx);
            }

            bw.Flush();
            var bufferBytes = ms.ToArray();

            // --- Build the SIMD buffer descriptor ---
            var fallbackIndices = data.FallbackFrameIndices.Select(fi => (CUInt16)fi).ToList();

            newSimdBuffer = new animAnimationBufferSimd()
            {
                Duration = duration,
                NumFrames = frameCount,
                NumJoints = numJoints,
                NumExtraJoints = numExtraJoints,
                NumTracks = numTracks,
                NumExtraTracks = numExtraTracks,
                NumTranslationsToCopy = numTranslationsToCopy,
                NumTranslationsToEvalAlignedToSimd = numTranslationsToEvalAligned,
                QuantizationBits = quantizationBits,
                IsScaleConstant = isScaleConstant,
                IsTrackConstant = isTrackConstant,
                DataAddress = chunkDataAddress,
                FallbackFrameIndices = new CArray<CUInt16>(fallbackIndices),
                ExtraDataNames = new(),
            };

            // Set buffer size in data address
            newSimdBuffer.DataAddress.ZeInBytes = (uint)bufferBytes.Length;

            newAnimDataChunk = new() { Buffer = new SerializationDeferredDataBuffer(bufferBytes) };

            logger.Info($"Encoded SIMD animation: {frameCount} frames, {jointsCountActual} joints " +
                        $"({numTranslationsToEval} eval + {numTranslationsToCopy} copy translations), " +
                        $"{numTracks} tracks, quantization={quantizationBits}bit, " +
                        $"scaleConst={isScaleConstant}, trackConst={isTrackConstant}, " +
                        $"buffer={bufferBytes.Length} bytes");
        }

        #region Classification

        /// <summary>
        /// Classify joints into those with animated translations (eval) vs static (copy).
        /// A joint is "static" if its translation doesn't change across frames.
        /// </summary>
        private static void ClassifyTranslations(
            in AnimationBufferData data, ushort jointsCountActual,
            uint frameCount, float frameTime,
            out List<ushort> evalJointIndices, out List<ushort> copyJointIndices,
            out List<Vec3> copyPositions)
        {
            evalJointIndices = new List<ushort>();
            copyJointIndices = new List<ushort>();
            copyPositions = new List<Vec3>();

            for (ushort j = 0; j < jointsCountActual; j++)
            {
                // Merge linear + const translations for this joint
                var linearTimes = data.Translations.GetValueOrDefault(j);
                var constTimes = data.ConstTranslations.GetValueOrDefault(j);

                if ((linearTimes == null || linearTimes.Count == 0) && (constTimes == null || constTimes.Count == 0))
                {
                    // No translation data at all — treat as static at origin
                    copyJointIndices.Add(j);
                    // Convert Vec3.Zero from glTF to RED4 coords
                    copyPositions.Add(TVectorWkit(new TGVec3(Vec3.Zero))._);
                    continue;
                }

                // Sample at first and last frame to determine if static
                var t0 = SampleTranslation(in data, j, 0);
                var isStatic = true;

                for (uint f = 1; f < frameCount; f++)
                {
                    var t = SampleTranslation(in data, j, f * frameTime);
                    if (!EqWithEpsilon(t, t0, TranslationEpsilon))
                    {
                        isStatic = false;
                        break;
                    }
                }

                if (isStatic)
                {
                    copyJointIndices.Add(j);
                    // Store in RED4 coordinates (copy positions are NOT converted in the decoder,
                    // they're stored raw in game coords and converted to glTF only at the final
                    // assembly step via TVectorGltf)
                    copyPositions.Add(TVectorWkit(new TGVec3(t0))._);
                }
                else
                {
                    evalJointIndices.Add(j);
                }
            }
        }

        private static bool ClassifyScalesConstant(in AnimationBufferData data, ushort jointsCountActual, uint frameCount, float frameTime)
        {
            for (ushort j = 0; j < jointsCountActual; j++)
            {
                var hasLinear = data.Scales.ContainsKey(j) && data.Scales[j].Count > 0;
                var hasConst = data.ConstScales.ContainsKey(j) && data.ConstScales[j].Count > 0;

                if (!hasLinear && !hasConst)
                {
                    continue; // Default scale 1,1,1 — fine
                }

                for (uint f = 0; f < frameCount; f++)
                {
                    var s = SampleScale(in data, j, f * frameTime);
                    if (!EqWithEpsilon(s, Scale1to1, MicrometerPrecisionEpsilon))
                    {
                        return false;
                    }
                }
            }
            return true;
        }

        private static bool ClassifyTracksConstant(in AnimationBufferData data)
        {
            // Track is constant if we only have constTrackKeys and no trackKeys
            if (data.TrackKeys.Count == 0 && data.ConstTrackKeys.Count > 0)
            {
                // Additionally verify all const tracks share the same value
                var firstVal = data.ConstTrackKeys[0].Value;
                return data.ConstTrackKeys.All(k => Math.Abs(k.Value - firstVal) < TrackEpsilon);
            }

            // If there are no tracks at all, treat as constant
            if (data.TrackKeys.Count == 0 && data.ConstTrackKeys.Count == 0)
            {
                return true;
            }

            return false;
        }

        #endregion Classification

        #region Resampling

        /// <summary>
        /// Resample rotations to uniform frames in RED4 coordinate space.
        /// Output is [frame, jointSimdAligned] with SIMD padding joints set to identity.
        /// </summary>
        private static Quat[,] ResampleRotations(
            in AnimationBufferData data,
            ushort jointsCountActual, uint numJointsSimdAligned,
            uint frameCount, float frameTime)
        {
            var result = new Quat[frameCount, numJointsSimdAligned];

            // Initialize padding to identity
            for (uint f = 0; f < frameCount; f++)
            {
                for (uint j = 0; j < numJointsSimdAligned; j++)
                {
                    result[f, j] = Quat.Identity;
                }
            }

            for (ushort j = 0; j < jointsCountActual; j++)
            {
                for (uint f = 0; f < frameCount; f++)
                {
                    var time = f * frameTime;
                    var q = SampleRotation(in data, j, time);
                    // Convert from glTF Y-up RHS back to RED4 Z-up LHS
                    result[f, j] = RQuaternionWkit(new RGQuat(q))._;
                }
            }

            return result;
        }

        /// <summary>
        /// Resample animated translations into the SIMD-interleaved format.
        /// Output is flat array: [frame0: [block0: X0 X1 X2 X3, Y0 Y1 Y2 Y3, Z0 Z1 Z2 Z3], ...blockN], ...frameN]
        /// </summary>
        private static float[] ResampleEvalTranslations(
            in AnimationBufferData data,
            List<ushort> evalJointIndices, short[] evalIndicesPadded,
            ushort numTranslationsToEvalAligned,
            uint frameCount, float frameTime)
        {
            var result = new float[frameCount * numTranslationsToEvalAligned * 3];

            for (uint f = 0; f < frameCount; f++)
            {
                var time = f * frameTime;

                for (uint e = 0; e < numTranslationsToEvalAligned; e += (uint)SimdBlockWidth)
                {
                    for (uint block = 0; block < SimdBlockWidth; block++)
                    {
                        var evalIdx = (int)(e + block);
                        Vec3 pos;

                        if (evalIdx < evalJointIndices.Count)
                        {
                            var jointIdx = evalJointIndices[evalIdx];
                            var gltfPos = SampleTranslation(in data, jointIdx, time);
                            // Convert to RED4 coords
                            pos = TVectorWkit(new TGVec3(gltfPos))._;
                        }
                        else
                        {
                            // Padding — doesn't matter but use zero
                            pos = Vec3.Zero;
                        }

                        // SIMD interleaved: [X0 X1 X2 X3] [Y0 Y1 Y2 Y3] [Z0 Z1 Z2 Z3]
                        var baseOffset = f * numTranslationsToEvalAligned * 3 + e * 3;
                        result[baseOffset + block] = pos.X;             // X block
                        result[baseOffset + 4 + block] = pos.Y;         // Y block
                        result[baseOffset + 8 + block] = pos.Z;         // Z block
                    }
                }
            }

            return result;
        }

        /// <summary>
        /// Resample scales to uniform frames in RED4 coordinate space.
        /// </summary>
        private static Vec3[,] ResampleScales(
            in AnimationBufferData data,
            ushort jointsCountActual, uint numJointsSimdAligned,
            uint frameCount, float frameTime)
        {
            var result = new Vec3[frameCount, numJointsSimdAligned];

            // Initialize padding to 1,1,1
            for (uint f = 0; f < frameCount; f++)
            {
                for (uint j = 0; j < numJointsSimdAligned; j++)
                {
                    result[f, j] = Vec3.One;
                }
            }

            for (ushort j = 0; j < jointsCountActual; j++)
            {
                for (uint f = 0; f < frameCount; f++)
                {
                    var time = f * frameTime;
                    var s = SampleScale(in data, j, time);
                    // Convert from glTF to RED4 coords
                    result[f, j] = SVectorWkit(new SGVec3(s))._;
                }
            }

            return result;
        }

        private static Vec3 GetConstantScale(in AnimationBufferData data, ushort jointsCountActual)
        {
            // All scales are ~1,1,1 if we got here, so just return identity scale in RED4 coords
            return SVectorWkit(new SGVec3(Scale1to1))._;
        }

        #endregion Resampling

        #region Sampling Helpers

        /// <summary>
        /// Sample translation for a joint at a given time, interpolating between available keyframes.
        /// Merges linear and const translation dictionaries.
        /// All values are in glTF coordinate space (Y-up RHS).
        /// </summary>
        private static Vec3 SampleTranslation(in AnimationBufferData data, ushort jointIdx, float time)
        {
            // Check const first (STEP interpolation — use directly)
            if (data.ConstTranslations.TryGetValue(jointIdx, out var constT) && constT.Count > 0)
            {
                return GetNearestConstValue(constT, time);
            }

            if (data.Translations.TryGetValue(jointIdx, out var linearT) && linearT.Count > 0)
            {
                return LerpVec3AtTime(linearT, time);
            }

            return Vec3.Zero;
        }

        private static Quat SampleRotation(in AnimationBufferData data, ushort jointIdx, float time)
        {
            if (data.ConstRotations.TryGetValue(jointIdx, out var constR) && constR.Count > 0)
            {
                return GetNearestConstValue(constR, time);
            }

            if (data.Rotations.TryGetValue(jointIdx, out var linearR) && linearR.Count > 0)
            {
                return SlerpQuatAtTime(linearR, time);
            }

            return Quat.Identity;
        }

        private static Vec3 SampleScale(in AnimationBufferData data, ushort jointIdx, float time)
        {
            if (data.ConstScales.TryGetValue(jointIdx, out var constS) && constS.Count > 0)
            {
                return GetNearestConstValue(constS, time);
            }

            if (data.Scales.TryGetValue(jointIdx, out var linearS) && linearS.Count > 0)
            {
                return LerpVec3AtTime(linearS, time);
            }

            return Scale1to1;
        }

        /// <summary>
        /// Get the nearest const (STEP) value at or before the given time.
        /// </summary>
        private static T GetNearestConstValue<T>(Dictionary<float, T> dict, float time)
        {
            var keys = dict.Keys.OrderBy(k => k).ToList();
            // Find the last key <= time
            T result = dict[keys[0]];
            foreach (var k in keys)
            {
                if (k <= time + float.Epsilon)
                {
                    result = dict[k];
                }
                else
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>
        /// Linearly interpolate between keyframes at the given time.
        /// </summary>
        private static Vec3 LerpVec3AtTime(Dictionary<float, Vec3> dict, float time)
        {
            var keys = dict.Keys.OrderBy(k => k).ToList();

            if (keys.Count == 0) return Vec3.Zero;
            if (keys.Count == 1) return dict[keys[0]];

            // Clamp to range
            if (time <= keys[0]) return dict[keys[0]];
            if (time >= keys[^1]) return dict[keys[^1]];

            // Find bracketing keys
            for (int i = 0; i < keys.Count - 1; i++)
            {
                if (time >= keys[i] && time <= keys[i + 1])
                {
                    var t = (time - keys[i]) / (keys[i + 1] - keys[i]);
                    return Vec3.Lerp(dict[keys[i]], dict[keys[i + 1]], t);
                }
            }

            return dict[keys[^1]];
        }

        /// <summary>
        /// Spherically interpolate between quaternion keyframes at the given time.
        /// </summary>
        private static Quat SlerpQuatAtTime(Dictionary<float, Quat> dict, float time)
        {
            var keys = dict.Keys.OrderBy(k => k).ToList();

            if (keys.Count == 0) return Quat.Identity;
            if (keys.Count == 1) return dict[keys[0]];

            if (time <= keys[0]) return dict[keys[0]];
            if (time >= keys[^1]) return dict[keys[^1]];

            for (int i = 0; i < keys.Count - 1; i++)
            {
                if (time >= keys[i] && time <= keys[i + 1])
                {
                    var t = (time - keys[i]) / (keys[i + 1] - keys[i]);
                    return Quat.Normalize(Quat.Slerp(dict[keys[i]], dict[keys[i + 1]], t));
                }
            }

            return dict[keys[^1]];
        }

        #endregion Sampling Helpers

        #region Binary Writers

        /// <summary>
        /// Write SIMD-interleaved rotations to the binary stream.
        /// This is the exact inverse of the decode loop in <see cref="SIMD.DecodeSimdAnimationData"/>.
        /// </summary>
        private static void WriteRotations(
            BinaryWriter bw, Quat[,] rotationsForFrame,
            uint frameCount, uint numJointsSimdAligned, ushort jointsCountActual,
            bool isQuantized, ushort quantizationBits)
        {
            if (isQuantized)
            {
                // Quantized dropped-W encoding
                var totalFloatCount = ((frameCount * numJointsSimdAligned * 3) + 3U) & (~3U);
                var mask = (1U << quantizationBits) - 1U;

                // First, collect all the quantized values
                var floatsPacked = new ushort[totalFloatCount];

                for (uint f = 0; f < frameCount; f++)
                {
                    for (uint j = 0; j < numJointsSimdAligned; j += (uint)SimdBlockWidth)
                    {
                        for (uint block = 0; block < SimdBlockWidth; block++)
                        {
                            Quat q;
                            if (j + block < jointsCountActual)
                            {
                                q = rotationsForFrame[f, j + block];
                            }
                            else
                            {
                                q = Quat.Identity;
                            }

                            q = Quat.Normalize(q);

                            // Inverse of decode: encode dropped-W
                            // Decode does: dotPr = x²+y²+z²; x *= sqrt(2-dotPr); W = 1-dotPr
                            // So encode: given full XYZW, recover the pre-sqrt values
                            // W = 1 - dotPr_enc → dotPr_enc = 1 - W
                            // x_enc = X / sqrt(2 - dotPr_enc)
                            var dotPrEnc = 1f - q.W;
                            var divisor = MathF.Sqrt(2f - dotPrEnc);
                            float xEnc, yEnc, zEnc;

                            if (divisor < float.Epsilon)
                            {
                                // Near-identity quaternion, W ≈ 1
                                xEnc = 0f;
                                yEnc = 0f;
                                zEnc = 0f;
                            }
                            else
                            {
                                xEnc = q.X / divisor;
                                yEnc = q.Y / divisor;
                                zEnc = q.Z / divisor;
                            }

                            // Clamp to [-1, 1] range
                            xEnc = Math.Clamp(xEnc, -1f, 1f);
                            yEnc = Math.Clamp(yEnc, -1f, 1f);
                            zEnc = Math.Clamp(zEnc, -1f, 1f);

                            // Quantize: inverse of (1f / mask * packed * 2) - 1f
                            // packed = (enc + 1) / 2 * mask
                            var xPacked = (ushort)Math.Round((xEnc + 1f) / 2f * mask);
                            var yPacked = (ushort)Math.Round((yEnc + 1f) / 2f * mask);
                            var zPacked = (ushort)Math.Round((zEnc + 1f) / 2f * mask);

                            // SIMD interleaved layout:
                            // [frame][block: X0 X1 X2 X3, Y0 Y1 Y2 Y3, Z0 Z1 Z2 Z3]
                            var baseIdx = f * numJointsSimdAligned * 3 + j * 3;
                            floatsPacked[baseIdx + block] = xPacked;
                            floatsPacked[baseIdx + 4 + block] = yPacked;
                            floatsPacked[baseIdx + 8 + block] = zPacked;
                        }
                    }
                }

                // Bit-pack into byte stream
                // Inverse of decode: read u32 at byteOff, shift right, mask
                // Encode: for each packed value at bit offset i * quantBits, OR it in
                var rotCompressedBuffSize = totalFloatCount * (uint)quantizationBits / 8U;
                rotCompressedBuffSize = (rotCompressedBuffSize + 15U) & (~15U); // 16-byte alignment
                var rotBuffer = new byte[rotCompressedBuffSize];

                for (uint i = 0; i < totalFloatCount; i++)
                {
                    var bitOff = i * (uint)quantizationBits;
                    var byteOff = (int)(bitOff / 8);
                    var shift = (int)(bitOff % 8);
                    var val = (uint)floatsPacked[i];

                    // Write bits into the byte buffer (may span up to 4 bytes)
                    var shifted = val << shift;
                    for (int b = 0; b < 4 && byteOff + b < rotBuffer.Length; b++)
                    {
                        rotBuffer[byteOff + b] |= (byte)((shifted >> (b * 8)) & 0xFF);
                    }
                }

                bw.Write(rotBuffer);
            }
            else
            {
                // Uncompressed float32 XYZW, SIMD-interleaved
                for (uint f = 0; f < frameCount; f++)
                {
                    for (uint j = 0; j < numJointsSimdAligned; j += (uint)SimdBlockWidth)
                    {
                        // Xs
                        for (uint block = 0; block < SimdBlockWidth; block++)
                        {
                            var q = (j + block < jointsCountActual) ? rotationsForFrame[f, j + block] : Quat.Identity;
                            bw.Write(q.X);
                        }
                        // Ys
                        for (uint block = 0; block < SimdBlockWidth; block++)
                        {
                            var q = (j + block < jointsCountActual) ? rotationsForFrame[f, j + block] : Quat.Identity;
                            bw.Write(q.Y);
                        }
                        // Zs
                        for (uint block = 0; block < SimdBlockWidth; block++)
                        {
                            var q = (j + block < jointsCountActual) ? rotationsForFrame[f, j + block] : Quat.Identity;
                            bw.Write(q.Z);
                        }
                        // Ws
                        for (uint block = 0; block < SimdBlockWidth; block++)
                        {
                            var q = (j + block < jointsCountActual) ? rotationsForFrame[f, j + block] : Quat.Identity;
                            bw.Write(q.W);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Write SIMD-interleaved eval translations — pre-flattened float array.
        /// </summary>
        private static void WriteEvalTranslations(BinaryWriter bw, float[] evalPositions, uint frameCount, ushort numTranslationsToEvalAligned)
        {
            for (uint i = 0; i < frameCount * numTranslationsToEvalAligned * 3; i++)
            {
                bw.Write(evalPositions[i]);
            }
        }

        /// <summary>
        /// Write scale data — constant or per-frame SIMD-interleaved.
        /// </summary>
        private static void WriteScales(
            BinaryWriter bw, Vec3[,]? scalesForFrame, Vec3 constantScale,
            bool isScaleConstant, uint frameCount, uint numJointsSimdAligned, ushort jointsCountActual)
        {
            if (isScaleConstant)
            {
                // 4 floats: X, Y, Z, padding
                bw.Write(constantScale.X);
                bw.Write(constantScale.Y);
                bw.Write(constantScale.Z);
                bw.Write(0f); // padding to 4 floats (SIMD alignment)
            }
            else
            {
                // Per-frame, SIMD-interleaved blocks
                // Layout: [frame: [block0: X0 X1 X2 X3, Y0 Y1 Y2 Y3, Z0 Z1 Z2 Z3], ...blockN]
                for (uint f = 0; f < frameCount; f++)
                {
                    for (uint j = 0; j < numJointsSimdAligned; j += (uint)SimdBlockWidth)
                    {
                        // X block
                        for (uint block = 0; block < SimdBlockWidth; block++)
                        {
                            var s = (j + block < jointsCountActual) ? scalesForFrame![f, j + block] : Vec3.One;
                            bw.Write(s.X);
                        }
                        // Y block
                        for (uint block = 0; block < SimdBlockWidth; block++)
                        {
                            var s = (j + block < jointsCountActual) ? scalesForFrame![f, j + block] : Vec3.One;
                            bw.Write(s.Y);
                        }
                        // Z block
                        for (uint block = 0; block < SimdBlockWidth; block++)
                        {
                            var s = (j + block < jointsCountActual) ? scalesForFrame![f, j + block] : Vec3.One;
                            bw.Write(s.Z);
                        }
                    }
                }
            }
        }

        /// <summary>
        /// Write track data — constant or per-frame, 4-byte aligned.
        /// </summary>
        private static void WriteTracks(
            BinaryWriter bw, in AnimationBufferData data,
            bool isTrackConstant, uint frameCount, float frameTime, ushort numTracks)
        {
            if (numTracks == 0)
            {
                return;
            }

            if (isTrackConstant)
            {
                // Single float for all tracks
                var value = data.ConstTrackKeys.Count > 0 ? data.ConstTrackKeys[0].Value : 0f;
                bw.Write(value);
            }
            else
            {
                // Per-frame, per-track, 4-byte aligned
                var numTracks4Aligned = (uint)((numTracks + 3) & (~3));
                var paddingCount = numTracks4Aligned - numTracks;

                // Build a lookup: (frame, trackIdx) → value
                // Merge const tracks (same value every frame) and variable tracks
                var trackValues = new Dictionary<(uint frame, ushort track), float>();

                // Fill const values for all frames
                foreach (var ck in data.ConstTrackKeys)
                {
                    for (uint f = 0; f < frameCount; f++)
                    {
                        trackValues[(f, ck.TrackIndex)] = ck.Value;
                    }
                }

                // Fill/override with variable track values (find nearest frame)
                foreach (var tk in data.TrackKeys)
                {
                    var frame = (uint)Math.Round(tk.Time / frameTime);
                    frame = Math.Clamp(frame, 0, frameCount - 1);
                    trackValues[(frame, tk.TrackIndex)] = tk.Value;
                }

                // Write
                for (uint f = 0; f < frameCount; f++)
                {
                    for (ushort t = 0; t < numTracks; t++)
                    {
                        var value = trackValues.GetValueOrDefault((f, t), 0f);
                        bw.Write(value);
                    }
                    // Padding
                    for (uint p = 0; p < paddingCount; p++)
                    {
                        bw.Write(0f);
                    }
                }
            }
        }

        #endregion Binary Writers
    }
}
