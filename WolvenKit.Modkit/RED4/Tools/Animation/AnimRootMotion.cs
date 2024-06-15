using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

using static WolvenKit.RED4.Types.Enums;
using static WolvenKit.Modkit.RED4.Animation.Const;
using static WolvenKit.Modkit.RED4.Animation.Fun;
using static WolvenKit.Modkit.RED4.Animation.Gltf;

using WkVector4 = WolvenKit.RED4.Types.Vector4;

using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

using JointsTranslationsAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>>;
using JointsRotationsAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Quaternion>>;
using JointsScalesAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>>;

using TranslationsAtTimes = System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>;
using RotationsAtTimes = System.Collections.Generic.Dictionary<float, System.Numerics.Quaternion>;
using ScalesAtTimes = System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>;
using WolvenKit.Core.Extensions;
using ICSharpCode.SharpZipLib;


namespace WolvenKit.Modkit.RED4.Animation
{
    internal enum RootMotionType
    {
        Unknown,
        None,
        TransformLinearSparseFrames,
        TransformSplineSparseFrames,
        TransformLinearEveryFrame,
        TranslationPlaneWithYawAllFrames,
        TranslationWithYawAllFrames,
    }

    internal class ROOT_MOTION
    {

#region export

        public static RootMotionType DecodeRootMotion(out JointsTranslationsAtTimes translations, out JointsRotationsAtTimes rotations, ref readonly animIMotionExtraction? motionEx, ILoggerService _loggerService)
        {
            translations = [];
            rotations = [];

            if (motionEx == null)
            {
                return RootMotionType.None;
            }

            translations.Add(0, []);
            rotations.Add(0, []);

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

            if (motionEx is animLinearCompressedMotionExtraction lc)
            {
                numPositions = lc.PosFrames.Count;
                numRotations = lc.RotFrames.Count;
                posTime = lc.PosTime.Select( x => (float)x).ToArray();
                rotTime = lc.RotTime.Select(x => (float)x).ToArray();

                for (var i = 0; i < numPositions; i++)
                {
                    var v = lc.PosFrames[i];
                    translations[0].Add(posTime[i], new Vec3(v.X, v.Z, -v.Y));
                }
                for (var i = 0; i < numRotations; i++)
                {
                    var q = lc.RotFrames[i];
                    rotations[0].Add(rotTime[i], new Quat(q.I, q.K, -q.J, q.R));
                }

                return RootMotionType.TransformLinearSparseFrames;
            }
            // NB. same as non-plane, but with only XY and Z=angle
            else if (motionEx is animPlaneUncompressedMotionExtraction pc)
            {
                var duration = pc.Duration;
                numPositions = pc.Frames.Count;
                numFrames = numPositions;
                fps = (numFrames - 1f) / duration;
                ft = 1f / fps;

                for (var i = 0; i < numFrames; i++)
                {
                    var v = pc.Frames[i];

                    var planeTranslation = TVectorGltf(new Vec3(v.X, v.Y, 0f));
                    var yawRotation = RQuaternionGltf(RQuatFromAnglesDegree(0f, 0f, v.Z));

                    translations[RootJointIndex].Add(ft * i, planeTranslation._);
                    rotations[RootJointIndex].Add(ft * i, yawRotation._);
                }

                // Easier to avoid the angle recalc for now
                // return RootMotionType.TranslationPlaneWithYawAllFrames;
                return RootMotionType.TransformLinearSparseFrames;
            }
            // NB. same as Plane* but with XYZ + angle
            else if (motionEx is animUncompressedMotionExtraction uc)
            {
                var duration = uc.Duration;
                numFrames = uc.Frames.Count;
                numPositions = numFrames;
                fps = (numFrames - 1f) / duration;
                ft = 1f / fps;

                for (var i = 0; i < numFrames; i++)
                {
                    var v = uc.Frames[i];

                    var fullTranslation = TVectorGltf(new Vec3(v.X, v.Y, v.Z));
                    var yawRotation = RQuaternionGltf(RQuatFromAnglesDegree(0f, 0f, v.W));

                    translations[RootJointIndex].Add(ft * i, fullTranslation._);
                    rotations[RootJointIndex].Add(ft * i, yawRotation._);
                }

                // Easier to avoid the angle recalc for now
                // return RootMotionType.TranslationWithYawAllFrames;
                return RootMotionType.TransformLinearSparseFrames;
            }
            else if (motionEx is animSplineCompressedMotionExtraction sc)
            {
                var duration = sc.Duration;

                if (sc.PosKeysData != null)
                {
                    var b = sc.PosKeysData.Select(x => x.ToByte());
                    posBuffer = b.ToArray();
                    numPositions = posBuffer.Length / 16;

                    using (ms = new MemoryStream(posBuffer))
                    using (br = new BinaryReader(ms))
                    {
                        br.BaseStream.Seek(0, SeekOrigin.Begin);
                        for (var i = 0; i < numPositions; i++)
                        {
                            var transform = ReadTransform16byte(br);

                            if (transform.TRS.t is null)
                            {
                                throw new InvalidOperationException($"Should only have translations in translations");
                            }

                            if (transform.JointIndex != RootJointIndex)
                            {
                                throw new ValueOutOfRangeException($"Motion extraction in joint {transform.JointIndex}, unable to handle this!,");
                            }

                            var x = transform.TRS.t;

                            translations[RootJointIndex].Add(transform.TimePercent, ((TGVec3)transform.TRS.t)._);
                        }
                    }
                }

                if (sc.RotKeysData != null)
                {
                    var b = sc.RotKeysData.Select(x => x.ToByte());
                    rotBuffer = b.ToArray();
                    numRotations = rotBuffer.Length / 16;

                    using (ms = new MemoryStream(rotBuffer))
                    using (br = new BinaryReader(ms))
                    {
                        br.BaseStream.Seek(0, SeekOrigin.Begin);
                        for (var i = 0; i < numRotations; i++)
                        {
                            var transform = ReadTransform16byte(br);

                            if (transform.TRS.r is null)
                            {
                                throw new InvalidOperationException($"Should only have rotations in rotations");
                            }

                            if (transform.JointIndex != RootJointIndex)
                            {
                                throw new ValueOutOfRangeException($"Motion extraction in joint {transform.JointIndex}, unable to handle this!,");
                            }

                            rotations[RootJointIndex].Add(transform.TimePercent, ((RGQuat)transform.TRS.r)._);
                        }
                    }
                }

                return RootMotionType.TransformSplineSparseFrames;
            }
            else if (motionEx is animUncompressedAllAnglesMotionExtraction aa)
            {
                var duration = aa.Duration;
                numFrames = aa.Frames.Count;
                fps = (numFrames - 1f) / duration;
                ft = 1f / fps;

                for (var i = 0; i < numFrames; i++)
                {
                    var frame = aa.Frames[i];
                    var v = frame.Position;
                    var q = frame.Orientation;
                    translations[0].Add(ft * i, new Vec3(v.X, v.Z, -v.Y));
                    rotations[0].Add(ft * i, new Quat(q.I, q.K, -q.J, q.R));
                }

                return RootMotionType.TransformLinearEveryFrame;
            }

            throw new InvalidOperationException("Should never get here");
        }

#endregion export

#region helpers

        internal const ushort WsignMask = 0x8000;
        internal const ushort TransformTypeMask = 0x6000;
        internal const ushort JointIndexMask = 0x1FFF;
        internal const int WsignShift = 15;
        internal const int TransformTypeShift = 13;
        internal const int JointIndexShift = 0;

        internal const ushort TransformCompressedWidthBytes = 16; // u16 + u16 + f32 + f32 + f32

        internal enum TransformTypeId : ushort
        {
            Translation = 0,
            Rotation = 1,
            Scale = 2,
        }

        internal record struct TransformTripletRaw(
            TransformTypeId TransformType,
            float TimePercent,
            ushort JointIndex,
            Vec3 V,
            bool Wsign
        );

        internal record struct TransformParsed(
            float TimePercent,
            ushort JointIndex,
            TransformTypeId TransformType,
            (TGVec3? t, RGQuat? r, SGVec3? s) TRS
        );

        internal static Quat ReconstructQuat(Vec3 v, bool wSign)
        {
            var dotPr = (v.X * v.X) + (v.Y * v.Y) + (v.Z * v.Z);

            v.X *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
            v.Y *= Convert.ToSingle(Math.Sqrt(2f - dotPr));
            v.Z *= Convert.ToSingle(Math.Sqrt(2f - dotPr));

            float W = wSign ? -(1f - dotPr) : 1f - dotPr;

            return Quat.Normalize(new(v, W));
        }

        internal static (Vec3 v, bool wSign) CompressQuat(Quat q)
        {
            bool wSign = q.W < 0f;

            float dotWeight = Convert.ToSingle(Math.Sqrt(2f - (1f - Math.Abs(q.W))));

            float x = q.X / dotWeight;
            float y = q.Y / dotWeight;
            float z = q.Z / dotWeight; 

            return (new Vec3(x, y, z), wSign);
        }

        internal static TransformTripletRaw ReadTransformTripletRaw(BinaryReader br)
        {
            // NB time first here, const keys is opposite
            ushort timePercentU16Ratio = br.ReadUInt16();
            ushort bitWiseData = br.ReadUInt16();
            float x = br.ReadSingle();
            float y = br.ReadSingle();
            float z = br.ReadSingle();

            return new TransformTripletRaw {
                    TransformType = (TransformTypeId)Convert.ToUInt16((bitWiseData & TransformTypeMask) >> TransformTypeShift),
                    TimePercent = timePercentU16Ratio / (float)ushort.MaxValue,
                    JointIndex = Convert.ToUInt16((bitWiseData & JointIndexMask) >> JointIndexShift),
                    V = new(x, y, z),
                    Wsign = 0f > Convert.ToUInt16((bitWiseData & WsignMask) >> WsignMask),
                };
        }

        internal static bool WriteTransformTripletRaw(BinaryWriter bw, TransformTypeId transformTypeId, float timePercent, ushort jointIndex, Vec3 transform, bool wSign)
        {
            ushort timePercentAsU16Ratio = (ushort)(timePercent * ushort.MaxValue);

            ushort bitWiseData = Convert.ToUInt16(
                0
                | ((wSign ? 1 : 0) << WsignMask)
                | ((ushort)transformTypeId << TransformTypeShift)
                | jointIndex
            );

            // NB time first here, const keys is opposite
            bw.Write((ushort)timePercentAsU16Ratio);
            bw.Write((ushort)bitWiseData);
            bw.Write((float)transform.X);
            bw.Write((float)transform.Y);
            bw.Write((float)transform.Z);

            return true;
        }

        internal static TransformParsed ReadTransform16byte(BinaryReader br)
        {
            var t = ReadTransformTripletRaw(br);

            return (ushort)t.TransformType switch {
                    0 => new(t.TimePercent, t.JointIndex, TransformTypeId.Translation, (TVectorGltf(t.V), null, null)),
                    1 => new(t.TimePercent, t.JointIndex, TransformTypeId.Rotation, (null, RQuaternionGltf(ReconstructQuat(t.V, t.Wsign)), null)),
                    2 => new(t.TimePercent, t.JointIndex, TransformTypeId.Scale, (null, null, SVectorGltf(t.V))),
                    _ => throw new ArgumentOutOfRangeException(nameof(t), "No valid transform type, shouldn't get here"),
                };
        }

        internal static bool WriteTransform16byte(BinaryWriter bw, TransformParsed trs)
        {
            (Vec3 transform, bool wSign) = trs.TRS switch {
                    (TGVec3 t, null, null) => (TVectorWkit(t)._, false),
                    (null, RGQuat r, null) => CompressQuat(RQuaternionWkit(r)._),
                    (null, null, SGVec3 s) => (SVectorWkit(s)._, false),
                    _ => throw new ArgumentNullException(nameof(trs), "No transform type or multiple, shouldn't get here!"),
                };

            return WriteTransformTripletRaw(bw, trs.TransformType, trs.TimePercent, trs.JointIndex, transform, wSign);
        }

#endregion helpers

    }
}
