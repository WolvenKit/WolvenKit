using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text.Json;
using SharpGLTF.Schema2;
using WolvenKit.RED4.Types;

using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;

using static WolvenKit.RED4.Types.Enums;
using static WolvenKit.Modkit.RED4.Animation.Const;
using static WolvenKit.Modkit.RED4.Animation.Fun;
using static WolvenKit.Modkit.RED4.Animation.Gltf;

using WolvenKit.Core.Interfaces;

using TranslationsAtTimes = System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>;
using RotationsAtTimes = System.Collections.Generic.Dictionary<float, System.Numerics.Quaternion>;
using ScalesAtTimes = System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>;

using JointsTranslationsAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>>;
using JointsRotationsAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Quaternion>>;
using JointsScalesAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>>;

namespace WolvenKit.Modkit.RED4.Animation
{

    internal class SIMD
    {
        internal static void DecodeSimdAnimationData(out AnimationBufferData result, ref ModelRoot model, ref animAnimationBufferSimd animBufSimd, ref List<MemoryStream> animDataBuffers, string animName, animAnimation animAnimDes, ILoggerService _loggerService)
        {
            MemoryStream deferredBuffer;
            if (animBufSimd.InplaceCompressedBuffer != null)
            {
                deferredBuffer = new MemoryStream(animBufSimd.InplaceCompressedBuffer.Buffer.GetBytes());
            }
            else if (animBufSimd.DataAddress != null && animBufSimd.DataAddress.UnkIndex != uint.MaxValue)
            {
                var dataAddr = animBufSimd.DataAddress;
                var bytes = new byte[dataAddr.ZeInBytes];
                animDataBuffers[(int)(uint)dataAddr.UnkIndex].Seek(dataAddr.FsetInBytes, SeekOrigin.Begin);
                // bytesRead can be smaller then the bytes requested
                var bytesRead = animDataBuffers[(int)(uint)dataAddr.UnkIndex].Read(bytes, 0, (int)(uint)dataAddr.ZeInBytes);
                deferredBuffer = new MemoryStream(bytes);
            }
            else
            {
                deferredBuffer = new MemoryStream(animBufSimd.DefferedBuffer.Buffer.GetBytes());
            }
            deferredBuffer.Seek(0, SeekOrigin.Begin);

            _loggerService.Debug($"Exporting SIMD animation {animAnimDes.Name} with {animBufSimd.NumFrames * animBufSimd.NumJoints} S/R/T transforms and {animBufSimd.NumFrames * animBufSimd.NumTracks} tracks");

            var br = new BinaryReader(deferredBuffer);

            var simdBlockWidth = 4; // 128 bits
            var simdBlockPadding = (uint)simdBlockWidth - 1U;
            var numJointsSimdAligned = (animBufSimd.NumJoints - animBufSimd.NumExtraJoints + simdBlockPadding) & (~simdBlockPadding);

            uint frameCount = animBufSimd.NumFrames;
            float frameTime = animBufSimd.Duration / (frameCount - 1);

            var rotationsForFrame = new Quat[animBufSimd.NumFrames, animBufSimd.NumJoints];
            var isQuantizedRotations = animBufSimd.QuantizationBits != 0;  // Apparently 0 means no quantization, logical.

            if (isQuantizedRotations)
            {
                var totalFloatCount = ((animBufSimd.NumFrames * numJointsSimdAligned * 3) + 3U) & (~3U);  // simd 4 alignment
                var rotCompressedBuffSize = totalFloatCount * animBufSimd.QuantizationBits / 8U;
                rotCompressedBuffSize = (rotCompressedBuffSize + 15U) & (~15U); // 16byte padding aligment
                var mask = (1U << animBufSimd.QuantizationBits) - 1U;

                var floatsPacked = new ushort[totalFloatCount];
                for (uint i = 0; i < totalFloatCount; i++)
                {
                    var bitOff = i * animBufSimd.QuantizationBits;
                    var byteOff = bitOff / 8;
                    var shift = bitOff % 8;
                    deferredBuffer.Position = byteOff;
                    var val = br.ReadUInt32();
                    val >>= (int)shift;
                    floatsPacked[i] = Convert.ToUInt16(val & mask);
                }
                var floatsDecompressed = new float[totalFloatCount];
                for (uint i = 0; i < totalFloatCount; i++)
                {
                    floatsDecompressed[i] = (1f / mask * floatsPacked[i] * 2) - 1f;
                }

                for (uint i = 0; i < animBufSimd.NumFrames; i++)
                {
                    for (uint j = 0; j < numJointsSimdAligned; j += (uint)simdBlockWidth)
                    {
                        for (uint block = 0; block < simdBlockWidth; block++)
                        {
                            var q = new Quat
                            {
                                X = floatsDecompressed[(i * numJointsSimdAligned * 3) + (j * 3) + block],
                                Y = floatsDecompressed[(i * numJointsSimdAligned * 3) + (j * 3) + 4 + block],
                                Z = floatsDecompressed[(i * numJointsSimdAligned * 3) + (j * 3) + 8 + block]
                            };

                            var dotPr = (q.X * q.X) + (q.Y * q.Y) + (q.Z * q.Z);
                            q.X *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                            q.Y *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                            q.Z *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                            q.W = 1f - dotPr;
                            q = Quat.Normalize(q);
                            if (j + block < animBufSimd.NumJoints)
                            {

                                rotationsForFrame[i, j + block] = RQuaternionGltf(q)._;
                            }
                        }
                    }
                }
                deferredBuffer.Position = rotCompressedBuffSize;
            }
            else // non-compressed rotations
            {
                for (uint f = 0; f < animBufSimd.NumFrames; f++)
                {
                    for (uint j = 0; j < numJointsSimdAligned; j += (uint)simdBlockWidth)
                    {
                        var xs = Enumerable.Range(0, simdBlockWidth).Select(_ => br.ReadSingle()).ToArray();
                        var ys = Enumerable.Range(0, simdBlockWidth).Select(_ => br.ReadSingle()).ToArray();
                        var zs = Enumerable.Range(0, simdBlockWidth).Select(_ => br.ReadSingle()).ToArray();
                        var ws = Enumerable.Range(0, simdBlockWidth).Select(_ => br.ReadSingle()).ToArray();

                        // We can safely *read* the padding but can't write it
                        var bandWidth = Math.Min(simdBlockWidth, animBufSimd.NumJoints - j);

                        for (uint band = 0; band < bandWidth; band++)
                        {
                            var rot = new Quat
                            {
                                X = xs[band],
                                Y = ys[band],
                                Z = zs[band],
                                W = ws[band]
                            };

                            rotationsForFrame[f, j + band] = RQuaternionGltf(rot)._;
                        }
                    }
                }
            }

            var evalAlignedPositions = new float[animBufSimd.NumFrames * animBufSimd.NumTranslationsToEvalAlignedToSimd * 3];
            for (uint i = 0; i < animBufSimd.NumFrames * animBufSimd.NumTranslationsToEvalAlignedToSimd * 3; i++)
            {
                evalAlignedPositions[i] = br.ReadSingle();
            }

            var scalesForFrame = new Vec3[animBufSimd.NumFrames, numJointsSimdAligned];
            if (animBufSimd.IsScaleConstant)
            {
                // I guess these are aligned too?
                var scalesRaw = new float[4];
                for (uint i = 0; i < 4; i++)
                {
                    scalesRaw[i] = br.ReadSingle();
                }
                for (uint i = 0; i < animBufSimd.NumFrames; i++)
                {
                    for (uint e = 0; e < animBufSimd.NumJoints; e++)
                    {
                        var v = new Vec3
                        {
                            X = scalesRaw[0],
                            Y = scalesRaw[1],
                            Z = scalesRaw[2],
                        };
                        scalesForFrame[i, e] = SVectorGltf(v)._;
                    }
                }
            }
            else
            {
                var scalesRaw = new float[animBufSimd.NumFrames * numJointsSimdAligned * 3];
                for (uint i = 0; i < animBufSimd.NumFrames * numJointsSimdAligned * 3; i++)
                {
                    scalesRaw[i] = br.ReadSingle();
                }
                for (uint i = 0; i < animBufSimd.NumFrames; i++)
                {
                    for (uint e = 0; e < animBufSimd.NumJoints; e += 4)
                    {
                        for (uint eye = 0; eye < 4; eye++)
                        {
                            var v = new Vec3
                            {
                                X = scalesRaw[(i * numJointsSimdAligned * 3) + (e * 3) + eye],
                                Y = scalesRaw[(i * numJointsSimdAligned * 3) + (e * 3) + 4 + eye], // just magnitude for scale, no flip
                                Z = scalesRaw[(i * numJointsSimdAligned * 3) + (e * 3) + 8 + eye],
                            };
                            scalesForFrame[i, e + eye] = SVectorGltf(v)._;
                        }
                    }
                }
            }

            // Track data - need to review how to best map this more optimally
            List<AnimConstTrackKeySerializable> constTrackKeys = new();
            List<AnimTrackKeySerializable> trackKeys = new();

            if (animBufSimd.NumTracks > 0)
            {
                // Uniform track for *every* frame and joint
                if (animBufSimd.IsTrackConstant)
                {
                    var uniformValue = br.ReadSingle();

                    for (uint i = 0; i < animBufSimd.NumTracks; i++)
                    {
                        constTrackKeys.Add(new AnimConstTrackKeySerializable
                        {
                            TrackIndex = Convert.ToUInt16(i),
                            Time = 0,
                            Value = uniformValue,
                        });
                    }
                }
                // This is possibly just not UNIFORM across tracks rather than non-const per track,
                // so it's very likely at least some could be flattened to constTrackKeys
                else
                {
                    uint numTracks4byteAligned = (animBufSimd.NumTracks + 3U) & (~3U);
                    uint paddingBytes = (numTracks4byteAligned - animBufSimd.NumTracks) * sizeof(float);

                    // [frame0 = [track0, ...trackM, padding], ...frameN]
                    for (uint f = 0; f < animBufSimd.NumFrames; f++)
                    {
                        for (uint i = 0; i < animBufSimd.NumTracks; i++)
                        {
                            trackKeys.Add(new AnimTrackKeySerializable
                            {
                                TrackIndex = Convert.ToUInt16(i),
                                Time = frameTime * f,
                                Value = br.ReadSingle()
                            });
                        }
                        deferredBuffer.Seek(paddingBytes, SeekOrigin.Current);
                    }
                }
            }

            var positionToCopy = new Vec3[animBufSimd.NumTranslationsToCopy];
            for (uint e = 0; e < animBufSimd.NumTranslationsToCopy; e++)
            {
                positionToCopy[e].X = br.ReadSingle();
                positionToCopy[e].Y = br.ReadSingle();
                positionToCopy[e].Z = br.ReadSingle();
            }

            var evalIndices = new short[animBufSimd.NumTranslationsToEvalAlignedToSimd];
            var copyIndices = new short[animBufSimd.NumTranslationsToCopy];
            for (uint e = 0; e < animBufSimd.NumTranslationsToCopy; e++)
            {
                copyIndices[e] = br.ReadInt16();
            }

            // NB this also reads possible padding at the end of the buffer
            for (uint e = 0; e < animBufSimd.NumTranslationsToEvalAlignedToSimd; e++)
            {
                evalIndices[e] = br.ReadInt16();
            }

            var positionsForFrame = new Vec3[animBufSimd.NumFrames, animBufSimd.NumJoints];
            for (uint i = 0; i < animBufSimd.NumFrames; i++)
            {
                for (uint e = 0; e < animBufSimd.NumTranslationsToEvalAlignedToSimd; e += 4)
                {
                    for (uint eye = 0; eye < 4; eye++)
                    {
                        var v = new Vec3
                        {
                            X = evalAlignedPositions[(i * animBufSimd.NumTranslationsToEvalAlignedToSimd * 3) + (e * 3) + eye],
                            Y = evalAlignedPositions[(i * animBufSimd.NumTranslationsToEvalAlignedToSimd * 3) + (e * 3) + 4 + eye],
                            Z = evalAlignedPositions[(i * animBufSimd.NumTranslationsToEvalAlignedToSimd * 3) + (e * 3) + 8 + eye]
                        };

                        // Skip padding, store real indices
                        if (evalIndices[e + eye] > -1)
                        {
                            positionsForFrame[i, evalIndices[e + eye]] = TVectorGltf(v)._;
                        }
                    }
                }
                for (uint e = 0; e < copyIndices.Length; e++)
                {
                    var v = new Vec3
                    {
                        X = positionToCopy[e].X,
                        Y = positionToCopy[e].Y,
                        Z = positionToCopy[e].Z
                    };

                    positionsForFrame[i, copyIndices[e]] = TVectorGltf(v)._;
                }
            }

            // Got everything, roll it into a better shape for downstream
            // NB: can optimize by doing this from the start

            var jointsCountActual = Convert.ToUInt16(animBufSimd.NumJoints - animBufSimd.NumExtraJoints);

            // There are no consts, only variables (even if they may be constant..)
            var jointWiseTranslations = new JointsTranslationsAtTimes();
            var jointWiseRotations = new JointsRotationsAtTimes();
            var jointWiseScales = new JointsScalesAtTimes();

            for (ushort jointIdx = 0; jointIdx < jointsCountActual; jointIdx++)
            {
                var translations = new TranslationsAtTimes();
                var rotations = new RotationsAtTimes();
                var scales = new ScalesAtTimes();

                for (var frameIdx = 0; frameIdx < frameCount; frameIdx++)
                {
                    if (positionsForFrame[frameIdx, jointIdx] is Vec3 translation) {
                        translations.Add(frameIdx * frameTime, translation);
                    }
                    if (rotationsForFrame[frameIdx, jointIdx] is Quat rotation) {
                        rotations.Add(frameIdx * frameTime, rotation);
                    }
                    if (scalesForFrame[frameIdx, jointIdx] is Vec3 scale) {
                        scales.Add(frameIdx * frameTime, scale);
                    }
                }

                jointWiseTranslations.Add(jointIdx, translations);
                jointWiseRotations.Add(jointIdx, rotations);
                jointWiseScales.Add(jointIdx, scales);
            }

            result = new AnimationBufferData {
                Duration = animBufSimd.Duration,
                FrameCount = animBufSimd.NumFrames,
                Translations = jointWiseTranslations,
                ConstTranslations = [],
                Rotations = jointWiseRotations,
                ConstRotations = [],
                Scales = jointWiseScales,
                ConstScales = [],
                TrackKeys = trackKeys,
                ConstTrackKeys = constTrackKeys,
                FallbackFrameIndices = animBufSimd.FallbackFrameIndices.Select(_ => (ushort)_).ToList(),
                NumJoints = animBufSimd.NumJoints,
                NumExtraJoints = animBufSimd.NumExtraJoints,
                JointsCountActual = jointsCountActual,
                NumTracks = animBufSimd.NumTracks,
                NumExtraTracks = animBufSimd.NumExtraTracks,
                TracksCountActual = Convert.ToUInt16(animBufSimd.NumTracks - animBufSimd.NumExtraTracks),
                IsSimd = true,
                CompressionUsed =
                    isQuantizedRotations
                    ? AnimationCompression.QuaternionAsFixed3x16bit
                    : AnimationCompression.Uncompressed,
            };
        }
    }
}
