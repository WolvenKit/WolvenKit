using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpGLTF.Schema2;
using WolvenKit.RED4.Types;
using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;

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

            // Not entirely sure if this should be used everywhere instead of blob.NumJoints
            var jointsCountAligned = (blob.NumJoints + 3U) & (~3U); // simd 4 alignment

            var rotationsYup = new Quat[blob.NumFrames, blob.NumJoints];
            var isQuantizedRotations = blob.QuantizationBits != 0;  // Apparently 0 means no quantization, logical.

            if (isQuantizedRotations)
            {
                var totalFloatCount = ((blob.NumFrames * jointsCountAligned * 3) + 3U) & (~3U);  // simd 4 alignment
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
                    for (uint e = 0; e < blob.NumJoints; e += 4)
                    {
                        for (uint eye = 0; eye < 4; eye++)
                        {
                            var q = new Quat
                            {
                                X = floatsDecompressed[(i * jointsCountAligned * 3) + (e * 3) + eye],
                                Y = floatsDecompressed[(i * jointsCountAligned * 3) + (e * 3) + 4 + eye],
                                Z = floatsDecompressed[(i * jointsCountAligned * 3) + (e * 3) + 8 + eye]
                            };

                            var dotPr = (q.X * q.X) + (q.Y * q.Y) + (q.Z * q.Z);
                            q.X *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                            q.Y *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                            q.Z *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                            q.W = 1f - dotPr;
                            q = Quat.Normalize(q);
                            if (e + eye < blob.NumJoints)
                            {
                                rotationsYup[i, e + eye] = new Quat(q.X, q.Z, -q.Y, q.W);
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
                    for (uint j = 0; j < blob.NumJoints; j++)
                    {
                        var q = new Quat
                        {
                            X = br.ReadSingle(),
                            Y = br.ReadSingle(),
                            Z = br.ReadSingle(),
                            W = br.ReadSingle()
                        };
                        rotationsYup[f, j] = new Quat(q.X, q.Z, -q.Y, q.W);
                    }
                }
            }

            var evalAlignedPositions = new float[blob.NumFrames * blob.NumTranslationsToEvalAlignedToSimd * 3];
            for (uint i = 0; i < blob.NumFrames * blob.NumTranslationsToEvalAlignedToSimd * 3; i++)
            {
                evalAlignedPositions[i] = br.ReadSingle();
            }
            // TODO I think we need yup here

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
                            Z = scalesRaw[2],
                            Y = scalesRaw[1], // just magnitude for scale, no flip
                        };
                        scalesYup[i, e] = v;
                    }
                }
            }
            else
            {
                var scalesRaw = new float[blob.NumFrames * jointsCountAligned * 3];
                for (uint i = 0; i < blob.NumFrames * jointsCountAligned * 3; i++)
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
                                X = scalesRaw[(i * jointsCountAligned * 3) + (e * 3) + eye],
                                Z = scalesRaw[(i * jointsCountAligned * 3) + (e * 3) + 8 + eye],
                                Y = scalesRaw[(i * jointsCountAligned * 3) + (e * 3) + 4 + eye], // just magnitude for scale, no flip
                            };
                            scalesYup[i, e + eye] = v;
                        }
                    }
                }
            }
            if (blob.NumTracks > 0)
            {
            // TODO all of this lol
                if (!blob.IsTrackConstant)
                {
                    uint asas = ((blob.NumTracks + 3U) & (~3U)) * blob.NumFrames * 4;
                    defferedBuffer.Seek(asas, SeekOrigin.Current);
                }
                else
                {
                    defferedBuffer.Seek(4, SeekOrigin.Current);
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

            var a = model.CreateAnimation(animName);
            var skin = model.LogicalSkins.FirstOrDefault(_ => _.Name is "Armature");
            if (skin is null)
            {
                ArgumentNullException.ThrowIfNull(nameof(skin));
                return;
            }

            for (var e = 0; e < blob.NumJoints - blob.NumExtraJoints; e++)
            {
                var node = skin.GetJoint(e).Joint;
                var pos = new Dictionary<float, Vec3>();
                var rot = new Dictionary<float, Quat>();
                var sca = new Dictionary<float, Vec3>();
                var diff = blob.Duration / (blob.NumFrames - 1);
                for (var i = 0; i < blob.NumFrames; i++)
                {
                    pos.Add(i * diff, positions[i, e]); // Also yup but TODO to fix naming along the way
                    rot.Add(i * diff, rotationsYup[i, e]);
                    sca.Add(i * diff, scalesYup[i, e]);
                }
                a.CreateRotationChannel(node, rot);
                a.CreateTranslationChannel(node, pos);
                a.CreateScaleChannel(node, sca);
            }

        }
    }
}
