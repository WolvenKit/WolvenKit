using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpGLTF.Schema2;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4.Animation
{
    using Vec4 = System.Numerics.Vector4;
    using Vec3 = System.Numerics.Vector3;
    using Quat = System.Numerics.Quaternion;
    class ROOT_MOTION
    {
        const UInt16 wSignMask = 0x8000;
        const UInt16 componentTypeMask = 0x6000;
        const UInt16 boneIdxMask = 0x1FFF;
        const int wSignRightShift = 15;
        const int componentRightShift = 13;
        const int boneIdxRightShift = 0;
        public static void AddRootMotion(ref Dictionary<UInt16, Dictionary<float, Vec3>> positions, ref Dictionary<UInt16, Dictionary<float, Quat>> rotations, animAnimation animAnimDes)
        {
            var motionEx = animAnimDes.MotionExtraction.Chunk;
            var duration = animAnimDes.Duration;
            var numFrames = 0;
            var numPositions = 0;
            var numRotations = 0;
            var posTime = new float[0];
            var rotTime = new float[0];
            var rotBuffer = new byte[0];
            var posBuffer = new byte[0];
            var fps = 0f;
            var ft = 0f;
            BinaryReader br;
            MemoryStream ms;

            if (motionEx is animLinearCompressedMotionExtraction)
            {
                var lc = motionEx as animLinearCompressedMotionExtraction;
                numPositions = lc.PosFrames.Count;
                numRotations = lc.RotFrames.Count;
                posTime = lc.PosTime.Cast<float>().ToArray();
                rotTime = lc.RotTime.Cast<float>().ToArray();

                if (numPositions > 0)
                {
                    if (!positions.ContainsKey(0))
                    {
                        positions.Add(0, new Dictionary<float, Vec3>());
                    }
                }
                if (numRotations > 0)
                {
                    if (!rotations.ContainsKey(0))
                    {
                        rotations.Add(0, new Dictionary<float, Quat>());
                    }
                }
                for (int i = 0; i < numPositions; i++)
                {
                    var v = lc.PosFrames[i];
                    positions[0].Add(posTime[i], new Vec3(v.X, v.Z, -v.Y));
                }
                for (int i = 0; i < numRotations; i++)
                {
                    var q = lc.RotFrames[i];
                    rotations[0].Add(rotTime[i], new Quat(q.I, q.K, -q.J, q.R));
                }
            }
            else if (motionEx is animPlaneUncompressedMotionExtraction)
            {
                var pc = motionEx as animPlaneUncompressedMotionExtraction;
                duration = pc.Duration;
                numPositions = pc.Frames.Count;
                numFrames = numPositions;
                fps = (numFrames - 1f) / duration;
                ft = 1f / fps;
                if (numPositions > 0)
                {
                    if (!positions.ContainsKey(0))
                    {
                        positions.Add(0, new Dictionary<float, Vec3>());
                    }
                }
                for (int i = 0; i < numFrames; i++)
                {
                    var v = pc.Frames[i];
                    positions[0].Add(ft * i, new Vec3(v.X, v.Z, -v.Y));
                }
            }
            else if (motionEx is animSplineCompressedMotionExtraction)
            {
                var sc = motionEx as animSplineCompressedMotionExtraction;
                duration = sc.Duration;

                #region rotations
                if (sc.RotKeysData!= null)
                {
                    rotBuffer = sc.RotKeysData.Cast<byte>().ToArray();
                    numRotations = rotBuffer.Length / 16;
                    if (numRotations > 0)
                    {
                        if (!rotations.ContainsKey(0))
                        {
                            rotations.Add(0, new Dictionary<float, Quat>());
                        }
                    }
                    using (ms = new MemoryStream(rotBuffer))
                    using (br = new BinaryReader(ms))
                    {
                        br.BaseStream.Seek(0, SeekOrigin.Begin);
                        for (int i = 0; i < numRotations; i++)
                        {
                            float timeNormalized = br.ReadUInt16() / (float)UInt16.MaxValue;
                            UInt16 bitWiseData = br.ReadUInt16();
                            UInt16 wSign = Convert.ToUInt16((bitWiseData & wSignMask) >> wSignRightShift);
                            UInt16 component = Convert.ToUInt16((bitWiseData & componentTypeMask) >> componentRightShift);
                            UInt16 boneIdx = Convert.ToUInt16((bitWiseData & boneIdxMask) >> boneIdxRightShift);

                            float x = br.ReadSingle();
                            float y = br.ReadSingle();
                            float z = br.ReadSingle();

                            switch (component)
                            {
                                case 0:
                                    if (positions.ContainsKey(boneIdx))
                                    {
                                        positions[boneIdx].Add(timeNormalized * duration, new Vec3(x, z, -y));
                                    }
                                    else
                                    {
                                        var dic = new Dictionary<float, Vec3>();
                                        dic.Add(timeNormalized * duration, new Vec3(x, z, -y));
                                        positions.Add(boneIdx, dic);
                                    }
                                    break;
                                case 1:
                                    float dotPr = (x * x + y * y + z * z);
                                    x = x * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                                    y = y * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                                    z = z * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                                    float w = 1f - dotPr;
                                    if (wSign == 1)
                                        w = -w;
                                    Quat q = new Quat(x, z, -y, w);
                                    if (rotations.ContainsKey(boneIdx))
                                    {
                                        rotations[boneIdx].Add(timeNormalized * duration, Quat.Normalize(q));
                                    }
                                    else
                                    {
                                        var dic = new Dictionary<float, Quat>();
                                        dic.Add(timeNormalized * duration, Quat.Normalize(q));
                                        rotations.Add(boneIdx, dic);
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
                #endregion
                if (sc.PosKeysData != null)
                {
                    posBuffer = sc.PosKeysData.Cast<byte>().ToArray();
                    numPositions = posBuffer.Length / 16;
                    if (numPositions > 0)
                    {
                        if (!positions.ContainsKey(0))
                        {
                            positions.Add(0, new Dictionary<float, Vec3>());
                        }
                    }
                    using (ms = new MemoryStream(posBuffer))
                    using (br = new BinaryReader(ms))
                    {
                        br.BaseStream.Seek(0, SeekOrigin.Begin);
                        for (int i = 0; i < numPositions; i++)
                        {
                            float timeNormalized = br.ReadUInt16() / (float)UInt16.MaxValue;
                            UInt16 bitWiseData = br.ReadUInt16();
                            UInt16 wSign = Convert.ToUInt16((bitWiseData & wSignMask) >> wSignRightShift);
                            UInt16 component = Convert.ToUInt16((bitWiseData & componentTypeMask) >> componentRightShift);
                            UInt16 boneIdx = Convert.ToUInt16((bitWiseData & boneIdxMask) >> boneIdxRightShift);

                            float x = br.ReadSingle();
                            float y = br.ReadSingle();
                            float z = br.ReadSingle();

                            switch (component)
                            {
                                case 0:
                                    if (positions.ContainsKey(boneIdx))
                                    {
                                        positions[boneIdx].Add(timeNormalized * duration, new Vec3(x, z, -y));
                                    }
                                    else
                                    {
                                        var dic = new Dictionary<float, Vec3>();
                                        dic.Add(timeNormalized * duration, new Vec3(x, z, -y));
                                        positions.Add(boneIdx, dic);
                                    }
                                    break;
                                case 1:
                                    float dotPr = (x * x + y * y + z * z);
                                    x = x * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                                    y = y * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                                    z = z * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                                    float w = 1f - dotPr;
                                    if (wSign == 1)
                                        w = -w;
                                    Quat q = new Quat(x, z, -y, w);
                                    if (rotations.ContainsKey(boneIdx))
                                    {
                                        rotations[boneIdx].Add(timeNormalized * duration, Quat.Normalize(q));
                                    }
                                    else
                                    {
                                        var dic = new Dictionary<float, Quat>();
                                        dic.Add(timeNormalized * duration, Quat.Normalize(q));
                                        rotations.Add(boneIdx, dic);
                                    }
                                    break;
                                default:
                                    break;
                            }
                        }
                    }
                }
            }
            else if (motionEx is animUncompressedAllAnglesMotionExtraction)
            {
                var aa = motionEx as animUncompressedAllAnglesMotionExtraction;
                duration = aa.Duration;
                numFrames = aa.Frames.Count;
                fps = (numFrames - 1f) / duration;
                ft = 1f / fps;
                if (numFrames > 0)
                {
                    if (!positions.ContainsKey(0))
                    {
                        positions.Add(0, new Dictionary<float, Vec3>());
                    }
                    if (!rotations.ContainsKey(0))
                    {
                        rotations.Add(0, new Dictionary<float, Quat>());
                    }
                }
                for (int i = 0; i < numFrames; i++)
                {
                    var v = aa.Frames[i].Position;
                    var q = aa.Frames[i].Orientation;
                    positions[0].Add(ft * i, new Vec3(v.X, v.Z, -v.Y));
                    rotations[0].Add(ft * i, new Quat(q.I, q.K, -q.J, q.R));
                }
            }
            else if (motionEx is animUncompressedMotionExtraction)
            {
                var uc = motionEx as animUncompressedMotionExtraction;
                duration = uc.Duration;
                numFrames = uc.Frames.Count;
                numPositions = numFrames;
                fps = (numFrames - 1f) / duration;
                ft = 1f / fps;
                if (numPositions > 0)
                {
                    if (!positions.ContainsKey(0))
                    {
                        positions.Add(0, new Dictionary<float, Vec3>());
                    }
                }
                for (int i = 0; i < numFrames; i++)
                {
                    var v = uc.Frames[i];
                    if (v.W != 0f || v.W != 1f)
                    {
                        throw new Exception("vec4 W unexpected value ???");
                    }
                    positions[0].Add(ft * i, new Vec3(v.X, v.Z, -v.Y));
                }
            }
        }
    }
}
