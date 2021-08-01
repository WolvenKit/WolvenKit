using System;
using System.Collections.Generic;
using System.IO;
using SharpGLTF.Schema2;
using WolvenKit.RED4.CR2W.Types;

namespace Animation
{
    using Vec3 = System.Numerics.Vector3;
    using Quat = System.Numerics.Quaternion;
    class SPLINE
    {
        const UInt16 wSignMask = 0x8000;
        const UInt16 componentTypeMask = 0x6000;
        const UInt16 boneIdxMask = 0x1FFF;
        const int wSignRightShift = 15;
        const int componentRightShift = 13;
        const int boneIdxRightShift = 0;
        public static void AddAnimationSpline(ref ModelRoot model, animAnimationBufferCompressed blob, string animName, Stream defferedBuffer)
        {
            //boneidx time value
            Dictionary<UInt16,Dictionary<float, Vec3>> positions = new Dictionary<ushort, Dictionary<float, Vec3>>();
            Dictionary<UInt16, Dictionary<float, Quat>> rotations = new Dictionary<ushort, Dictionary<float, Quat>>();
            Dictionary<UInt16, Dictionary<float, Vec3>> scales = new Dictionary<ushort, Dictionary<float, Vec3>>();

            Dictionary<UInt16, float> tracks = new Dictionary<UInt16, float>();

            BinaryReader br = new BinaryReader(defferedBuffer);
            float duration = blob.Duration.Value;
            UInt32 numFrames = blob.NumFrames.Value;
            UInt32 numJoints = blob.NumJoints.Value;
            UInt32 numTracks = blob.NumTracks.Value;
            UInt32 numExtraJoints = blob.NumExtraJoints.Value;
            UInt32 numAnimKeys = blob.NumAnimKeys.Value;
            UInt32 numAnimKeysRaw = blob.NumAnimKeysRaw.Value;
            UInt32 NumConstAnimKeys = blob.NumConstAnimKeys.Value;
            UInt32 numConstTrackKeys = blob.NumConstTrackKeys.Value;

            defferedBuffer.Seek(0, SeekOrigin.Begin);
            for (UInt32 i = 0; i < numAnimKeys; i++)
            {
                float timeNormalized = br.ReadUInt16() / (float)UInt16.MaxValue;
                UInt16 bitWiseData = br.ReadUInt16();
                UInt16 wSign = Convert.ToUInt16((bitWiseData & wSignMask) >> wSignRightShift);
                UInt16 component = Convert.ToUInt16((bitWiseData & componentTypeMask) >> componentRightShift);
                UInt16 boneIdx = Convert.ToUInt16((bitWiseData & boneIdxMask) >> boneIdxRightShift);

                float x = ((1f / 65535f) * br.ReadUInt16() * 2) - 1f;
                float y = ((1f / 65535f) * br.ReadUInt16() * 2) - 1f;
                float z = ((1f / 65535f) * br.ReadUInt16() * 2) - 1f;

                switch (component)
                {
                    case 0:
                        if(positions.ContainsKey(boneIdx))
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
                        if(wSign == 1)
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
                    case 2:
                        if (scales.ContainsKey(boneIdx))
                        {
                            scales[boneIdx].Add(timeNormalized * duration, new Vec3(x, z, -y));
                        }
                        else
                        {
                            var dic = new Dictionary<float, Vec3>();
                            dic.Add(timeNormalized * duration, new Vec3(x, z, -y));
                            scales.Add(boneIdx, dic);
                        }
                        break;
                    default:
                        break;
                }
            }
            for (UInt32 i = 0; i < numAnimKeysRaw; i++)
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
                    case 2:
                        if (scales.ContainsKey(boneIdx))
                        {
                            scales[boneIdx].Add(timeNormalized * duration, new Vec3(x, z, -y));
                        }
                        else
                        {
                            var dic = new Dictionary<float, Vec3>();
                            dic.Add(timeNormalized * duration, new Vec3(x, z, -y));
                            scales.Add(boneIdx, dic);
                        }
                        break;
                    default:
                        break;
                }
            }
            
            for (UInt32 i = 0; i < NumConstAnimKeys; i++)
            {
                UInt16 bitWiseData = br.ReadUInt16();
                float timeNormalized = br.ReadUInt16() / (float)UInt16.MaxValue; // is it some time normalized or some padding garbage data i have no idea
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
                    case 2:
                        if (scales.ContainsKey(boneIdx))
                        {
                            scales[boneIdx].Add(timeNormalized * duration, new Vec3(x, z, -y));
                        }
                        else
                        {
                            var dic = new Dictionary<float, Vec3>();
                            dic.Add(timeNormalized * duration, new Vec3(x, z, -y));
                            scales.Add(boneIdx, dic);
                        }
                        break;
                    default:
                        break;
                }
            }
            
            /*
            for (UInt32 i = 0; i < NumConstAnimKeys; i++)
            {
                UInt16 bitWiseData = br.ReadUInt16();
                br.ReadUInt16();  // is it some time normalized or some padding garbage data i have no idea
                UInt16 wSign = Convert.ToUInt16((bitWiseData & wSignMask) >> wSignRightShift);
                UInt16 component = Convert.ToUInt16((bitWiseData & componentTypeMask) >> componentRightShift);
                UInt16 boneIdx = Convert.ToUInt16((bitWiseData & boneIdxMask) >> boneIdxRightShift);
                float x = br.ReadSingle();
                float y = br.ReadSingle();
                float z = br.ReadSingle();

                for(UInt32 e = 0; e < numFrames; e++)
                {
                    float diff = duration / (numFrames - 1);
                    switch (component)
                    {
                        case 0:
                            if (positions.ContainsKey(boneIdx))
                            {
                                if (!positions[boneIdx].ContainsKey(e * diff))
                                {
                                    positions[boneIdx].Add(e * diff, new Vec3(x, z, -y));
                                }
                            }
                            else
                            {
                                var dic = new Dictionary<float, Vec3>();
                                dic.Add(e * diff, new Vec3(x, z, -y));
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
                                if (!rotations[boneIdx].ContainsKey(e * diff))
                                {
                                    rotations[boneIdx].Add(e * diff, Quat.Normalize(q));
                                }
                            }
                            else
                            {
                                var dic = new Dictionary<float, Quat>();
                                dic.Add(e * diff, Quat.Normalize(q));
                                rotations.Add(boneIdx, dic);
                            }
                            break;
                        case 2:
                            if (scales.ContainsKey(boneIdx))
                            {
                                if (!scales[boneIdx].ContainsKey(e * diff))
                                {
                                    scales[boneIdx].Add(e * diff, new Vec3(x, z, -y));
                                }
                            }
                            else
                            {
                                var dic = new Dictionary<float, Vec3>();
                                dic.Add(e * diff, new Vec3(x, z, -y));
                                scales.Add(boneIdx, dic);
                            }
                            break;
                        default:
                            break;
                    }
                }
            }
            */
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

                if(positions.ContainsKey(i))
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
