using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.RED4.Types;
using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;

namespace WolvenKit.Modkit.RED4.Animation
{
    internal class ROOT_MOTION
    {
        private const ushort wSignMask = 0x8000;
        private const ushort componentTypeMask = 0x6000;
        private const ushort boneIdxMask = 0x1FFF;
        private const int wSignRightShift = 15;
        private const int componentRightShift = 13;
        private const int boneIdxRightShift = 0;
        public static void AddRootMotion(ref Dictionary<ushort, Dictionary<float, Vec3>> positions, ref Dictionary<ushort, Dictionary<float, Quat>> rotations, animAnimation animAnimDes)
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
                for (var i = 0; i < numPositions; i++)
                {
                    var v = lc.PosFrames[i];
                    positions[0].Add(posTime[i], new Vec3(v.X, v.Z, -v.Y));
                }
                for (var i = 0; i < numRotations; i++)
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
                for (var i = 0; i < numFrames; i++)
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
                if (sc.RotKeysData != null)
                {
                    var b = sc.RotKeysData.Select(x => x.ToByte());
                    rotBuffer = b.ToArray();
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
                        for (var i = 0; i < numRotations; i++)
                        {
                            var timeNormalized = br.ReadUInt16() / (float)ushort.MaxValue;
                            var bitWiseData = br.ReadUInt16();
                            var wSign = Convert.ToUInt16((bitWiseData & wSignMask) >> wSignRightShift);
                            var component = Convert.ToUInt16((bitWiseData & componentTypeMask) >> componentRightShift);
                            var boneIdx = Convert.ToUInt16((bitWiseData & boneIdxMask) >> boneIdxRightShift);

                            var x = br.ReadSingle();
                            var y = br.ReadSingle();
                            var z = br.ReadSingle();

                            switch (component)
                            {
                                case 0:
                                    if (positions.ContainsKey(boneIdx))
                                    {
                                        positions[boneIdx].Add(timeNormalized * duration, new Vec3(x, z, -y));
                                    }
                                    else
                                    {
                                        var dic = new Dictionary<float, Vec3>
                                        {
                                            { timeNormalized * duration, new Vec3(x, z, -y) }
                                        };
                                        positions.Add(boneIdx, dic);
                                    }
                                    break;
                                case 1:
                                    var dotPr = (x * x) + (y * y) + (z * z);
                                    x *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                                    y *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                                    z *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                                    var w = 1f - dotPr;
                                    if (wSign == 1)
                                    {
                                        w = -w;
                                    }

                                    var q = new Quat(x, z, -y, w);
                                    if (rotations.ContainsKey(boneIdx))
                                    {
                                        rotations[boneIdx].Add(timeNormalized * duration, Quat.Normalize(q));
                                    }
                                    else
                                    {
                                        var dic = new Dictionary<float, Quat>
                                        {
                                            { timeNormalized * duration, Quat.Normalize(q) }
                                        };
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
                    var b = sc.PosKeysData.Select(x => x.ToByte());
                    posBuffer = b.ToArray();
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
                        for (var i = 0; i < numPositions; i++)
                        {
                            var timeNormalized = br.ReadUInt16() / (float)ushort.MaxValue;
                            var bitWiseData = br.ReadUInt16();
                            var wSign = Convert.ToUInt16((bitWiseData & wSignMask) >> wSignRightShift);
                            var component = Convert.ToUInt16((bitWiseData & componentTypeMask) >> componentRightShift);
                            var boneIdx = Convert.ToUInt16((bitWiseData & boneIdxMask) >> boneIdxRightShift);

                            var x = br.ReadSingle();
                            var y = br.ReadSingle();
                            var z = br.ReadSingle();

                            switch (component)
                            {
                                case 0:
                                    if (positions.ContainsKey(boneIdx))
                                    {
                                        positions[boneIdx].Add(timeNormalized * duration, new Vec3(x, z, -y));
                                    }
                                    else
                                    {
                                        var dic = new Dictionary<float, Vec3>
                                        {
                                            { timeNormalized * duration, new Vec3(x, z, -y) }
                                        };
                                        positions.Add(boneIdx, dic);
                                    }
                                    break;
                                case 1:
                                    var dotPr = (x * x) + (y * y) + (z * z);
                                    x *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                                    y *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                                    z *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                                    var w = 1f - dotPr;
                                    if (wSign == 1)
                                    {
                                        w = -w;
                                    }

                                    var q = new Quat(x, z, -y, w);
                                    if (rotations.ContainsKey(boneIdx))
                                    {
                                        rotations[boneIdx].Add(timeNormalized * duration, Quat.Normalize(q));
                                    }
                                    else
                                    {
                                        var dic = new Dictionary<float, Quat>
                                        {
                                            { timeNormalized * duration, Quat.Normalize(q) }
                                        };
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
                for (var i = 0; i < numFrames; i++)
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
                for (var i = 0; i < numFrames; i++)
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
