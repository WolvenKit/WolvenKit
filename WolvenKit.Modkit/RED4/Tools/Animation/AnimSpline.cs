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
    public class CompressedBuffer
    {
        public static Vec3 TRVector(float x, float y, float z) => new(x, z, -y);

        public static Quat RQuat(float x, float y, float z, float w) => new(x, z, -y, w);

        public static Vec3 SVector(float x, float y, float z) => new(x, z, y);

        public static void AddAnimation(ref ModelRoot model, animAnimation animAnimDes, bool incRootMotion = true)
        {
            if (animAnimDes.AnimBuffer.GetValue() is not animAnimationBufferCompressed blob)
            {
                throw new ArgumentNullException();
            }
            blob.ReadBuffer();

            // boneidx time value
            var positions = new Dictionary<ushort, Dictionary<float, Vec3>>();
            var rotations = new Dictionary<ushort, Dictionary<float, Quat>>();
            var scales = new Dictionary<ushort, Dictionary<float, Vec3>>();

            var tracks = new Dictionary<ushort, float>();

            if (animAnimDes.MotionExtraction != null && animAnimDes.MotionExtraction.Chunk != null && incRootMotion)
            {
                ROOT_MOTION.AddRootMotion(ref positions, ref rotations, animAnimDes);
            }

            foreach (var key in blob.AnimKeys)
            {
                if (key is animKeyPosition p)
                {
                    if (!positions.ContainsKey(p.Idx))
                    {
                        positions[p.Idx] = new Dictionary<float, Vec3>();
                    }
                    positions[p.Idx][p.Time] = TRVector(p.Position.X, p.Position.Y, p.Position.Z);
                }
                else if (key is animKeyRotation r)
                {
                    if (!rotations.ContainsKey(r.Idx))
                    {
                        rotations[r.Idx] = new Dictionary<float, Quat>();
                    }
                    rotations[r.Idx][r.Time] = RQuat(r.Rotation.I, r.Rotation.J, r.Rotation.K, r.Rotation.R);
                }
                else if (key is animKeyScale s)
                {
                    if (!scales.ContainsKey(s.Idx))
                    {
                        scales[s.Idx] = new Dictionary<float, Vec3>();
                    }
                    scales[s.Idx][s.Time] = SVector(s.Scale.X, s.Scale.Y, s.Scale.Z);
                }
            }

            foreach (var key in blob.AnimKeysRaw)
            {
                if (key is animKeyPosition p)
                {
                    if (!positions.ContainsKey(p.Idx))
                    {
                        positions[p.Idx] = new Dictionary<float, Vec3>();
                    }
                    positions[p.Idx][p.Time] = TRVector(p.Position.X, p.Position.Y, p.Position.Z);
                }
                else if (key is animKeyRotation r)
                {
                    if (!rotations.ContainsKey(r.Idx))
                    {
                        rotations[r.Idx] = new Dictionary<float, Quat>();
                    }
                    rotations[r.Idx][r.Time] = RQuat(r.Rotation.I, r.Rotation.J, r.Rotation.K, r.Rotation.R);
                }
                else if (key is animKeyScale s)
                {
                    if (!scales.ContainsKey(s.Idx))
                    {
                        scales[s.Idx] = new Dictionary<float, Vec3>();
                    }
                    scales[s.Idx][s.Time] = SVector(s.Scale.X, s.Scale.Y, s.Scale.Z);
                }
            }

            foreach (var key in blob.ConstAnimKeys)
            {
                // using x.Time here causes some problems - not sure what data it actually is. maybe a hold time?
                if (key is animKeyPosition p)
                {
                    if (!positions.ContainsKey(p.Idx))
                    {
                        positions[p.Idx] = new Dictionary<float, Vec3>();
                    }
                    positions[p.Idx][0] = TRVector(p.Position.X, p.Position.Y, p.Position.Z);
                }
                else if (key is animKeyRotation r)
                {
                    if (!rotations.ContainsKey(r.Idx))
                    {
                        rotations[r.Idx] = new Dictionary<float, Quat>();
                    }
                    rotations[r.Idx][0] = RQuat(r.Rotation.I, r.Rotation.J, r.Rotation.K, r.Rotation.R);
                }
                else if (key is animKeyScale s)
                {
                    if (!scales.ContainsKey(s.Idx))
                    {
                        scales[s.Idx] = new Dictionary<float, Vec3>();
                    }
                    scales[s.Idx][0] = SVector(s.Scale.X, s.Scale.Y, s.Scale.Z);
                }
            }

            var anim = model.CreateAnimation(animAnimDes.Name);
            var skin = model.LogicalSkins.FirstOrDefault(_ => _.Name is "Armature");
            if (skin is null)
            {
                ArgumentNullException.ThrowIfNull(nameof(skin));
                return;
            }
            if (animAnimDes.AnimationType == Enums.animAnimationType.Additive)
            {

                for (ushort i = 0; i < blob.NumJoints - blob.NumExtraJoints; i++)
                {
                    var node = skin.GetJoint(i).Joint;
                    if (positions.ContainsKey(i))
                    {
                        foreach (var (t, position) in positions[i])
                        {
                            positions[i][t] = node.LocalTransform.Translation + position;
                        }
                        anim.CreateTranslationChannel(node, positions[i]);
                    }
                    if (rotations.ContainsKey(i))
                    {
                        foreach (var (t, rotation) in rotations[i])
                        {
                            rotations[i][t] = node.LocalTransform.Rotation * rotation;
                        }
                        anim.CreateRotationChannel(node, rotations[i]);
                    }
                    if (scales.ContainsKey(i))
                    {
                        foreach (var (t, scale) in scales[i])
                        {
                            scales[i][t] = node.LocalTransform.Scale + scale;
                        }
                        anim.CreateScaleChannel(node, scales[i]);
                    }
                }
            }
            else
            {
                for (ushort i = 0; i < blob.NumJoints - blob.NumExtraJoints; i++)
                {
                    var node = skin.GetJoint(i).Joint;
                    if (positions.ContainsKey(i))
                    {
                        anim.CreateTranslationChannel(node, positions[i]);
                    }
                    if (rotations.ContainsKey(i))
                    {
                        anim.CreateRotationChannel(node, rotations[i]);
                    }
                    if (scales.ContainsKey(i))
                    {
                        anim.CreateScaleChannel(node, scales[i]);
                    }
                }
            }
        }
    }
}
