using System;
using System.Collections.Generic;
using System.IO;
using SharpGLTF.Schema2;
using WolvenKit.RED4.CR2W.Types;

namespace Animation
{
    using Quat = System.Numerics.Quaternion;
    using Vec3 = System.Numerics.Vector3;
    class SIMD
    {
        public static void AddAnimationSIMD(ref ModelRoot model, animAnimationBufferSimd blob,string animName,Stream defferedBuffer)
        {
            BinaryReader br = new BinaryReader(defferedBuffer);

            UInt32 jointsCountAligned = (blob.NumJoints.Value + 3U) & (~3U); // simd 4 alignment
            UInt32 totalFloatCount = (blob.NumFrames.Value * jointsCountAligned * 3 + 3U) & (~3U);  // simd 4 alignment
            UInt32 rotCompressedBuffSize = totalFloatCount * blob.QuantizationBits.Value / 8U;
            rotCompressedBuffSize = (rotCompressedBuffSize + 15U) & (~15U); // 16byte padding aligment
            UInt32 mask = (1U << blob.QuantizationBits.Value) - 1U;

            UInt16[] floatsPacked = new UInt16[totalFloatCount];
            for (UInt32 i = 0; i < totalFloatCount; i++)
            {
                UInt32 bitOff = i * blob.QuantizationBits.Value;
                UInt32 byteOff = bitOff / 8;
                UInt32 shift = (bitOff % 8);
                defferedBuffer.Position = byteOff;
                UInt32 val = br.ReadUInt32();
                val = val >> (int)shift;
                floatsPacked[i] = Convert.ToUInt16(val & mask);
            }
            float[] floatsDecompressed = new float[totalFloatCount];
            for (UInt32 i = 0; i < totalFloatCount; i++)
            {
                floatsDecompressed[i] = ((1f / mask) * floatsPacked[i] * 2) - 1f;
            }
            Quat[,] Rotations = new Quat[blob.NumFrames.Value, blob.NumJoints.Value];
            for (UInt32 i = 0; i < blob.NumFrames.Value; i++)
            {
                for (UInt32 e = 0; e < blob.NumJoints.Value; e += 4)
                {
                    for (UInt32 eye = 0; eye < 4; eye++)
                    {
                        Quat q = new Quat();
                        q.X = floatsDecompressed[i * jointsCountAligned * 3 + e * 3 + eye];
                        q.Y = floatsDecompressed[i * jointsCountAligned * 3 + e * 3 + 4 + eye];
                        q.Z = floatsDecompressed[i * jointsCountAligned * 3 + e * 3 + 8 + eye];

                        float dotPr = (q.X * q.X + q.Y * q.Y + q.Z * q.Z);
                        q.X = q.X * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                        q.Y = q.Y * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                        q.Z = q.Z * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                        q.W = 1f - dotPr;
                        q = Quat.Normalize(q);
                        if (e + eye < blob.NumJoints.Value)
                            Rotations[i, e + eye] = new Quat(q.X, q.Z, -q.Y, q.W);
                    }
                }
            }
            float[] EvalAlignedPositions = new float[blob.NumFrames.Value * blob.NumTranslationsToEvalAlignedToSimd.Value * 3];
            defferedBuffer.Position = rotCompressedBuffSize;
            for (UInt32 i = 0; i < blob.NumFrames.Value * blob.NumTranslationsToEvalAlignedToSimd.Value * 3; i++)
            {
                EvalAlignedPositions[i] = br.ReadSingle();
            }
            Vec3[,] Scales = new Vec3[blob.NumFrames.Value, blob.NumJoints.Value];
            if (blob.IsScaleConstant.Value)
            {
                float[] scalesRaw = new float[4];
                for (UInt32 i = 0; i < 4; i++)
                {
                    scalesRaw[i] = br.ReadSingle();
                }
                for (UInt32 i = 0; i < blob.NumFrames.Value; i++)
                {
                    for (UInt32 e = 0; e < blob.NumJoints.Value; e++)
                    {
                        Vec3 v = new Vec3();
                        v.X = scalesRaw[0];
                        v.Y = scalesRaw[1];
                        v.Z = scalesRaw[2];
                        Scales[i, e] = v;
                    }
                }
            }
            else
            {
                float[] scalesRaw = new float[blob.NumFrames.Value * jointsCountAligned * 3];
                for (UInt32 i = 0; i < blob.NumFrames.Value * jointsCountAligned * 3; i++)
                {
                    scalesRaw[i] = br.ReadSingle();
                }
                for (UInt32 i = 0; i < blob.NumFrames.Value; i++)
                {
                    for (UInt32 e = 0; e < blob.NumJoints.Value; e += 4)
                    {
                        for (UInt32 eye = 0; eye < 4; eye++)
                        {
                            Vec3 v = new Vec3();
                            v.X = scalesRaw[i * jointsCountAligned * 3 + e * 3 + eye];
                            v.Y = scalesRaw[i * jointsCountAligned * 3 + e * 3 + 4 + eye];
                            v.Z = scalesRaw[i * jointsCountAligned * 3 + e * 3 + 8 + eye];
                            Scales[i, e + eye] = v;
                        }
                    }
                }
            }
            if (blob.NumTracks.Value > 0)
            {
                if (!blob.IsTrackConstant.Value)
                {
                    UInt32 asas = ((blob.NumTracks.Value + 3U) & (~3U)) * blob.NumFrames.Value * 4;
                    defferedBuffer.Seek(asas, SeekOrigin.Current);
                }
                else
                {
                    defferedBuffer.Seek(4, SeekOrigin.Current);
                }
            }

            Vec3[] positionToCopy = new Vec3[blob.NumTranslationsToCopy.Value];
            for (UInt32 e = 0; e < blob.NumTranslationsToCopy.Value; e++)
            {
                positionToCopy[e].X = br.ReadSingle();
                positionToCopy[e].Y = br.ReadSingle();
                positionToCopy[e].Z = br.ReadSingle();
            }

            Int16[] evalIndices = new Int16[blob.NumTranslationsToEvalAlignedToSimd.Value];
            Int16[] copyIndices = new Int16[blob.NumTranslationsToCopy.Value];
            for (UInt32 e = 0; e < blob.NumTranslationsToCopy.Value; e++)
                copyIndices[e] = br.ReadInt16();
            for (UInt32 e = 0; e < blob.NumTranslationsToEvalAlignedToSimd.Value; e++)
                evalIndices[e] = br.ReadInt16();

            Vec3[,] Positions = new Vec3[blob.NumFrames.Value, blob.NumJoints.Value];
            for (UInt32 i = 0; i < blob.NumFrames.Value; i++)
            {
                for (UInt32 e = 0; e < blob.NumTranslationsToEvalAlignedToSimd.Value; e += 4)
                {
                    for (UInt32 eye = 0; eye < 4; eye++)
                    {
                        Vec3 v = new Vec3();
                        v.X = EvalAlignedPositions[i * blob.NumTranslationsToEvalAlignedToSimd.Value * 3 + e * 3 + eye];
                        v.Y = EvalAlignedPositions[i * blob.NumTranslationsToEvalAlignedToSimd.Value * 3 + e * 3 + 4 + eye];
                        v.Z = EvalAlignedPositions[i * blob.NumTranslationsToEvalAlignedToSimd.Value * 3 + e * 3 + 8 + eye];

                        if (evalIndices[e + eye] > -1)
                            Positions[i, evalIndices[e + eye]] = new Vec3(v.X, v.Z, -v.Y);
                    }
                }
                for (UInt32 e = 0; e < copyIndices.Length; e++)
                {
                    Vec3 v = new Vec3();
                    v.X = positionToCopy[e].X;
                    v.Y = positionToCopy[e].Y;
                    v.Z = positionToCopy[e].Z;

                    Positions[i, copyIndices[e]] = new Vec3(v.X, v.Z, -v.Y);
                }
            }
            var a = model.CreateAnimation(animName);
            for (int e = 0; e < blob.NumJoints.Value - blob.NumExtraJoints.Value; e++)
            {
                var pos = new Dictionary<float, Vec3>();
                var rot = new Dictionary<float, Quat>();
                var sca = new Dictionary<float, Vec3>();
                float diff = blob.Duration.Value / (blob.NumFrames.Value - 1);
                for (int i = 0; i < blob.NumFrames.Value; i++)
                {
                    pos.Add(i * diff, Positions[i, e]);
                    rot.Add(i * diff, Rotations[i, e]);
                    sca.Add(i * diff, Scales[i, e]);
                }
                a.CreateRotationChannel(model.LogicalNodes[e], rot);
                a.CreateTranslationChannel(model.LogicalNodes[e], pos);
                a.CreateScaleChannel(model.LogicalNodes[e], sca);
            }
        }
    }
}
