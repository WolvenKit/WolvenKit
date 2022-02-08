using System;
using System.Collections.Generic;
using System.IO;
using SharpGLTF.Schema2;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4.Animation
{
    using Quat = System.Numerics.Quaternion;
    using Vec3 = System.Numerics.Vector3;

    internal class SPLINE
    {
        private const ushort wSignMask = 0x8000;
        private const ushort componentTypeMask = 0x6000;
        private const ushort boneIdxMask = 0x1FFF;
        private const int wSignRightShift = 15;
        private const int componentRightShift = 13;
        private const int boneIdxRightShift = 0;
        public static void AddAnimationSpline(ref ModelRoot model, animAnimationBufferCompressed blob, string animName, Stream defferedBuffer, animAnimation animAnimDes)
        {
            //boneidx time value
            var positions = new Dictionary<ushort, Dictionary<float, Vec3>>();
            var rotations = new Dictionary<ushort, Dictionary<float, Quat>>();
            var scales = new Dictionary<ushort, Dictionary<float, Vec3>>();

            var tracks = new Dictionary<ushort, float>();

            if (animAnimDes.MotionExtraction.Chunk != null)
            {
                ROOT_MOTION.AddRootMotion(ref positions, ref rotations, animAnimDes);
            }

            var br = new BinaryReader(defferedBuffer);
            float duration = blob.Duration;
            uint numFrames = blob.NumFrames;
            uint numJoints = blob.NumJoints;
            uint numTracks = blob.NumTracks;
            uint numExtraJoints = blob.NumExtraJoints;
            uint numAnimKeys = blob.NumAnimKeys;
            uint numAnimKeysRaw = blob.NumAnimKeysRaw;
            uint NumConstAnimKeys = blob.NumConstAnimKeys;
            uint numConstTrackKeys = blob.NumConstTrackKeys;

            defferedBuffer.Seek(0, SeekOrigin.Begin);
            for (uint i = 0; i < numAnimKeys; i++)
            {
                var timeNormalized = br.ReadUInt16() / (float)ushort.MaxValue;
                var bitWiseData = br.ReadUInt16();
                var wSign = Convert.ToUInt16((bitWiseData & wSignMask) >> wSignRightShift);
                var component = Convert.ToUInt16((bitWiseData & componentTypeMask) >> componentRightShift);
                var boneIdx = Convert.ToUInt16((bitWiseData & boneIdxMask) >> boneIdxRightShift);

                var x = ((1f / 65535f) * br.ReadUInt16() * 2) - 1f;
                var y = ((1f / 65535f) * br.ReadUInt16() * 2) - 1f;
                var z = ((1f / 65535f) * br.ReadUInt16() * 2) - 1f;

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
                        var dotPr = (x * x + y * y + z * z);
                        x = x * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                        y = y * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                        z = z * Convert.ToSingle(Math.Sqrt(2f - dotPr));
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
                    case 2:
                        if (scales.ContainsKey(boneIdx))
                        {
                            scales[boneIdx].Add(timeNormalized * duration, new Vec3(x, z, -y));
                        }
                        else
                        {
                            var dic = new Dictionary<float, Vec3>
                            {
                                { timeNormalized * duration, new Vec3(x, z, -y) }
                            };
                            scales.Add(boneIdx, dic);
                        }
                        break;
                    default:
                        break;
                }
            }
            for (uint i = 0; i < numAnimKeysRaw; i++)
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
                        var dotPr = (x * x + y * y + z * z);
                        x = x * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                        y = y * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                        z = z * Convert.ToSingle(Math.Sqrt(2f - dotPr));
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
                    case 2:
                        if (scales.ContainsKey(boneIdx))
                        {
                            scales[boneIdx].Add(timeNormalized * duration, new Vec3(x, z, -y));
                        }
                        else
                        {
                            var dic = new Dictionary<float, Vec3>
                            {
                                { timeNormalized * duration, new Vec3(x, z, -y) }
                            };
                            scales.Add(boneIdx, dic);
                        }
                        break;
                    default:
                        break;
                }
            }

            for (uint i = 0; i < NumConstAnimKeys; i++)
            {
                var bitWiseData = br.ReadUInt16();
                var timeNormalized = br.ReadUInt16() / (float)ushort.MaxValue; // is it some time normalized or some padding garbage data i have no idea
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
                            positions[boneIdx].Add(0f, new Vec3(x, z, -y));
                        }
                        else
                        {
                            var dic = new Dictionary<float, Vec3>
                            {
                                { 0f, new Vec3(x, z, -y) }
                            };
                            positions.Add(boneIdx, dic);
                        }
                        break;
                    case 1:
                        var dotPr = (x * x + y * y + z * z);
                        x = x * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                        y = y * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                        z = z * Convert.ToSingle(Math.Sqrt(2f - dotPr));
                        var w = 1f - dotPr;
                        if (wSign == 1)
                        {
                            w = -w;
                        }

                        var q = new Quat(x, z, -y, w);
                        if (rotations.ContainsKey(boneIdx))
                        {
                            rotations[boneIdx].Add(0f, Quat.Normalize(q));
                        }
                        else
                        {
                            var dic = new Dictionary<float, Quat>
                            {
                                { 0f, Quat.Normalize(q) }
                            };
                            rotations.Add(boneIdx, dic);
                        }
                        break;
                    case 2:
                        if (scales.ContainsKey(boneIdx))
                        {
                            scales[boneIdx].Add(0f, new Vec3(x, z, -y));
                        }
                        else
                        {
                            var dic = new Dictionary<float, Vec3>
                            {
                                { 0f, new Vec3(x, z, -y) }
                            };
                            scales.Add(boneIdx, dic);
                        }
                        break;
                    default:
                        break;
                }
            }
            /*
            for (UInt32 i = 0; i < numConstTrackKeys; i++)
            {
                UInt16 idx = br.ReadUInt16();
                br.ReadUInt16(); //is it time or some garbage idk
                float value = br.ReadSingle();
            }
            */
            var anim = model.CreateAnimation(animName);

            for (ushort i = 0; i < numJoints - numExtraJoints; i++)
            {

                if (positions.ContainsKey(i))
                {
                    anim.CreateTranslationChannel(model.LogicalNodes[i], positions[i]);
                }
                if (rotations.ContainsKey(i))
                {
                    anim.CreateRotationChannel(model.LogicalNodes[i], rotations[i]);
                }
                if (scales.ContainsKey(i))
                {
                    anim.CreateScaleChannel(model.LogicalNodes[i], scales[i]);
                }
            }
        }
    }
}
