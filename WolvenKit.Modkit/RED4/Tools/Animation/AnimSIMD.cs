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
using static WolvenKit.Modkit.RED4.Animation.Fun;
using static WolvenKit.Modkit.RED4.Animation.Gltf;

namespace WolvenKit.Modkit.RED4.Animation
{

    internal class SIMD
    {
        public static void AddAnimationSIMD(ref ModelRoot model, animAnimationBufferSimd blob, string animName, Stream defferedBuffer, animAnimation animAnimDes, bool incRootMotion = true)
        {
            var rootPositions = new Dictionary<ushort, Dictionary<float, Vec3>>();
            var rootRotations = new Dictionary<ushort, Dictionary<float, Quat>>();
            var hasRootMotion = animAnimDes.MotionExtraction?.Chunk is not null;
            if (hasRootMotion && incRootMotion)
            {
                ROOT_MOTION.AddRootMotion(ref rootPositions, ref rootRotations, animAnimDes);
            }
            var br = new BinaryReader(defferedBuffer);

            var simdBlockWidth = 4; // 128 bits
            var simdBlockPadding = (uint)simdBlockWidth - 1U;
            var numJointsSimdAligned = (blob.NumJoints - blob.NumExtraJoints + simdBlockPadding) & (~simdBlockPadding);

            float frameTime = blob.Duration / (blob.NumFrames - 1);

            var rotationsYup = new Quat[blob.NumFrames, blob.NumJoints];
            var isQuantizedRotations = blob.QuantizationBits != 0;  // Apparently 0 means no quantization, logical.

            if (isQuantizedRotations)
            {
                var totalFloatCount = ((blob.NumFrames * numJointsSimdAligned * 3) + 3U) & (~3U);  // simd 4 alignment
                var rotCompressedBuffSize = totalFloatCount * blob.QuantizationBits / 8U;
                rotCompressedBuffSize = (rotCompressedBuffSize + 15U) & (~15U); // 16byte padding aligment
                var mask = (1U << blob.QuantizationBits) - 1U;

                var floatsPacked = new ushort[totalFloatCount];
                for (uint i = 0; i < totalFloatCount; i++)
                {
                    var bitOff = i * blob.QuantizationBits;
                    var byteOff = bitOff / 8;
                    var shift = bitOff % 8;
                    defferedBuffer.Position = byteOff;
                    var val = br.ReadUInt32();
                    val >>= (int)shift;
                    floatsPacked[i] = Convert.ToUInt16(val & mask);
                }
                var floatsDecompressed = new float[totalFloatCount];
                for (uint i = 0; i < totalFloatCount; i++)
                {
                    floatsDecompressed[i] = (1f / mask * floatsPacked[i] * 2) - 1f;
                }

                for (uint i = 0; i < blob.NumFrames; i++)
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
                            if (j + block < blob.NumJoints)
                            {

                                rotationsYup[i, j + block] = new Quat(q.X, q.Z, -q.Y, q.W);
                            }
                        }
                    }
                }
                defferedBuffer.Position = rotCompressedBuffSize;
            }
            else // non-compressed rotations
            {
                for (uint f = 0; f < blob.NumFrames; f++)
                {
                    for (uint j = 0; j < numJointsSimdAligned; j += (uint)simdBlockWidth)
                    {
                        var xs = Enumerable.Range(0, simdBlockWidth).Select(_ => br.ReadSingle()).ToArray();
                        var ys = Enumerable.Range(0, simdBlockWidth).Select(_ => br.ReadSingle()).ToArray();
                        var zs = Enumerable.Range(0, simdBlockWidth).Select(_ => br.ReadSingle()).ToArray();
                        var ws = Enumerable.Range(0, simdBlockWidth).Select(_ => br.ReadSingle()).ToArray();

                        // We can safely *read* the padding but can't write it
                        var bandWidth = Math.Min(simdBlockWidth, blob.NumJoints - j);

                        for (uint band = 0; band < bandWidth; band++)
                        {
                            var rot = new Quat
                            {
                                X = xs[band],
                                Y = ys[band],
                                Z = zs[band],
                                W = ws[band]
                            };

                            rotationsYup[f, j + band] = RQuaternionYupRhs(rot);
                        }
                    }
                }
            }

            var evalAlignedPositions = new float[blob.NumFrames * blob.NumTranslationsToEvalAlignedToSimd * 3];
            for (uint i = 0; i < blob.NumFrames * blob.NumTranslationsToEvalAlignedToSimd * 3; i++)
            {
                evalAlignedPositions[i] = br.ReadSingle();
            }

            var scalesYup = new Vec3[blob.NumFrames, blob.NumJoints];
            if (blob.IsScaleConstant)
            {
                // I guess these are aligned too?
                var scalesRaw = new float[4];
                for (uint i = 0; i < 4; i++)
                {
                    scalesRaw[i] = br.ReadSingle();
                }
                for (uint i = 0; i < blob.NumFrames; i++)
                {
                    for (uint e = 0; e < blob.NumJoints; e++)
                    {
                        var v = new Vec3
                        {
                            X = scalesRaw[0],
                            Y = scalesRaw[1],
                            Z = scalesRaw[2],
                        };
                        scalesYup[i, e] = SVectorYupRhs(v);
                    }
                }
            }
            else
            {
                var scalesRaw = new float[blob.NumFrames * numJointsSimdAligned * 3];
                for (uint i = 0; i < blob.NumFrames * numJointsSimdAligned * 3; i++)
                {
                    scalesRaw[i] = br.ReadSingle();
                }
                for (uint i = 0; i < blob.NumFrames; i++)
                {
                    for (uint e = 0; e < blob.NumJoints; e += 4)
                    {
                        for (uint eye = 0; eye < 4; eye++)
                        {
                            var v = new Vec3
                            {
                                X = scalesRaw[(i * numJointsSimdAligned * 3) + (e * 3) + eye],
                                Y = scalesRaw[(i * numJointsSimdAligned * 3) + (e * 3) + 4 + eye], // just magnitude for scale, no flip
                                Z = scalesRaw[(i * numJointsSimdAligned * 3) + (e * 3) + 8 + eye],
                            };
                            scalesYup[i, e + eye] = SVectorYupRhs(v);
                        }
                    }
                }
            }

            // Track data - need to review how to best map this more optimally
            List<AnimConstTrackKeySerializable> constTrackKeys = new();
            List<AnimTrackKeySerializable> trackKeys = new();

            if (blob.NumTracks > 0)
            {
                // Uniform track for *every* frame and joint
                if (blob.IsTrackConstant)
                {
                    var uniformValue = br.ReadSingle();

                    for (uint i = 0; i < blob.NumTracks; i++)
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
                    uint numTracks4byteAligned = (blob.NumTracks + 3U) & (~3U);
                    uint paddingBytes = (numTracks4byteAligned - blob.NumTracks) * sizeof(float);

                    // [frame0 = [track0, ...trackM, padding], ...frameN]
                    for (uint f = 0; f < blob.NumFrames; f++)
                    {
                        for (uint i = 0; i < blob.NumTracks; i++)
                        {
                            trackKeys.Add(new AnimTrackKeySerializable
                            {
                                TrackIndex = Convert.ToUInt16(i),
                                Time = frameTime * f,
                                Value = br.ReadSingle()
                            });
                        }
                        defferedBuffer.Seek(paddingBytes, SeekOrigin.Current);
                    }
                }
            }

            var positionToCopy = new Vec3[blob.NumTranslationsToCopy];
            for (uint e = 0; e < blob.NumTranslationsToCopy; e++)
            {
                positionToCopy[e].X = br.ReadSingle();
                positionToCopy[e].Y = br.ReadSingle();
                positionToCopy[e].Z = br.ReadSingle();
            }

            var evalIndices = new short[blob.NumTranslationsToEvalAlignedToSimd];
            var copyIndices = new short[blob.NumTranslationsToCopy];
            for (uint e = 0; e < blob.NumTranslationsToCopy; e++)
            {
                copyIndices[e] = br.ReadInt16();
            }

            // NB this also reads possible padding at the end of the buffer
            for (uint e = 0; e < blob.NumTranslationsToEvalAlignedToSimd; e++)
            {
                evalIndices[e] = br.ReadInt16();
            }

            var positions = new Vec3[blob.NumFrames, blob.NumJoints];
            for (uint i = 0; i < blob.NumFrames; i++)
            {
                for (uint e = 0; e < blob.NumTranslationsToEvalAlignedToSimd; e += 4)
                {
                    for (uint eye = 0; eye < 4; eye++)
                    {
                        var v = new Vec3
                        {
                            X = evalAlignedPositions[(i * blob.NumTranslationsToEvalAlignedToSimd * 3) + (e * 3) + eye],
                            Y = evalAlignedPositions[(i * blob.NumTranslationsToEvalAlignedToSimd * 3) + (e * 3) + 4 + eye],
                            Z = evalAlignedPositions[(i * blob.NumTranslationsToEvalAlignedToSimd * 3) + (e * 3) + 8 + eye]
                        };

                        // Skip padding, store real indices
                        if (evalIndices[e + eye] > -1)
                        {
                            positions[i, evalIndices[e + eye]] = new Vec3(v.X, v.Z, -v.Y);
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

                    positions[i, copyIndices[e]] = new Vec3(v.X, v.Z, -v.Y);
                }
            }

            // Can switch to system Json when SharpGLTF support released (maybe in .31)
            // Right now it's not possible to add an empty array to a JsonContent.
            // Can work around that elsewhere but... just don't implement your own
            // JSON parser, kids.
            var animExtras = new AnimationExtrasForGltf(
                CurrentSchema(),
                animAnimDes.AnimationType.ToString(),
                animAnimDes.FrameClamping,
                animAnimDes.FrameClampingStartFrame,
                animAnimDes.FrameClampingEndFrame,
                blob.NumExtraJoints,
                blob.NumExtraTracks,
                constTrackKeys,
                trackKeys,
                blob.FallbackFrameIndices.Select(_ => (ushort)_).ToList(),
                new AnimationOptimizationHints(
                    true,
                    blob.QuantizationBits == 0 ? AnimationEncoding.Uncompressed : AnimationEncoding.QuaternionAsFixed3x16bit
                )
            );

            // All the data is gathered, stitch it together
            //
            // TODO: this duplicates `AnimSpline` logic, need
            // to see about refactoring the commonalities.

            var anim = model.CreateAnimation(animAnimDes.Name);
            var skin = model.LogicalSkins.FirstOrDefault(_ => _.Name is "Armature");
            if (skin is null)
            {
                ArgumentNullException.ThrowIfNull(nameof(skin));
                return;
            }

            // -.-
            anim.Extras = SharpGLTF.IO.JsonContent.Parse(JsonSerializer.Serialize(animExtras, SerializationOptions()));

            var exportAdditiveToBind = animAnimDes.AnimationType != animAnimationType.Normal;

            for (var j = 0; j < blob.NumJoints - blob.NumExtraJoints; j++)
            {
                var node = skin.GetJoint(j).Joint;
                var localTransform = node.LocalTransform;

                var pos = new Dictionary<float, Vec3>();
                var rot = new Dictionary<float, Quat>();
                var sca = new Dictionary<float, Vec3>();

                for (var f = 0; f < blob.NumFrames; f++)
                {
                    if (exportAdditiveToBind)
                    {
                        pos.Add(f * frameTime, localTransform.Translation + positions[f, j]); // Also yup but TODO to fix naming along the way
                        rot.Add(f * frameTime, localTransform.Rotation * rotationsYup[f, j]);
                        sca.Add(f * frameTime, localTransform.Scale * scalesYup[f, j]);
                    }
                    else
                    {
                        pos.Add(f * frameTime, positions[f, j]);
                        rot.Add(f * frameTime, rotationsYup[f, j]);
                        sca.Add(f * frameTime, scalesYup[f, j]);
                    }
                }

                anim.CreateRotationChannel(node, rot);
                anim.CreateTranslationChannel(node, pos);
                anim.CreateScaleChannel(node, sca);
            }
        }
    }
}
