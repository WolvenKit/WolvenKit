using System;
using System.Collections.Generic;
using System.Text.Json;
using SharpGLTF.IO;
using WolvenKit.Modkit.RED4.Animation.Deprecated;
using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;

using TranslationsAtTimes = System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>;
using RotationsAtTimes = System.Collections.Generic.Dictionary<float, System.Numerics.Quaternion>;
using ScalesAtTimes = System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>;

using JointsTranslationsAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>>;
using JointsRotationsAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Quaternion>>;
using JointsScalesAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>>;


namespace WolvenKit.Modkit.RED4.Animation
{
    internal static class Const
    {
        // Current ceil *30 doesn't get every single one of the vanilla
        // frame counts right, but neither did this.
        //
        public const double FramesPerDurationSecondArtisanallyCrafted = 30.1846575;

        public const double FramesPerDurationSecond = 30.0;
        public static Func<double, uint> FramesToAccommodateDuration = (duration) =>
             (uint)Math.Ceiling(duration * FramesPerDurationSecond);

        public const ushort RootJointIndex = 0;

        public const bool GLTF_SAMPLER_LINEAR = true;
        public const bool GLTF_SAMPLER_CONST = false;
    }

    internal static class Fun
    {
        // Type-level coordinate system and transform kind safety,
        // so that you can't accidentally mix up translation and
        // scale or glTF-format with ours (or System. stuff.)
        //
        // TODO: https://github.com/WolvenKit/WolvenKit/issues/1788 Actually Use Type-Level Coordinate and Vector Checking
        //
        // G = glTF = Y up, Righthanded
        // W = Wkit = Z up, Lefthanded

        public readonly record struct TWVec3( Vec3 _ );
        public readonly record struct TGVec3( Vec3 _ );
        public readonly record struct SWVec3( Vec3 _ );
        public readonly record struct SGVec3( Vec3 _ );
        public readonly record struct RWQuat( Quat _ );
        public readonly record struct RGQuat( Quat _ );

        public static TWVec3 TVectorWkit(TGVec3 v) => new(new(v._.X, -v._.Z, v._.Y));
        public static TGVec3 TVectorGltf(TWVec3 v) => new(new(v._.X, v._.Z, -v._.Y));
        public static TGVec3 TVectorGltf(Vec3 v) => new(new(v.X, v.Z, -v.Y));


        public static RWQuat RQuaternionWkit(RGQuat q) => new(new(q._.X, -q._.Z, q._.Y, q._.W));
        public static RGQuat RQuaternionGltf(RWQuat q) => new(new(q._.X, q._.Z, -q._.Y, q._.W));
        public static RGQuat RQuaternionGltf(Quat q) => new(new(q.X, q.Z, -q.Y, q.W));

        // NB scale is not affected by handedness, only axis
        public static SWVec3 SVectorWkit(SGVec3 v) => new(new(v._.X, v._.Z, v._.Y));
        public static SGVec3 SVectorGltf(SWVec3 v) => new(new(v._.X, v._.Z, v._.Y));
        public static SGVec3 SVectorGltf(Vec3 v) => new(new(v.X, v.Z, v.Y));

        public static Quat RQuatFromAnglesDegree(Vec3 axisDegrees) => RQuatFromAnglesDegree(axisDegrees.X, axisDegrees.Y, axisDegrees.Z);
        public static Quat RQuatFromAnglesDegree(float pitchX, float rollY, float yawZ) =>
            RQuatFromAnglesRadian(float.DegreesToRadians(pitchX), float.DegreesToRadians(rollY), float.DegreesToRadians(yawZ));

        public static Quat RQuatFromAnglesRadian(Vec3 axisRadians) => RQuatFromAnglesDegree(axisRadians.X, axisRadians.Y, axisRadians.Z);
        public static Quat RQuatFromAnglesRadian(float pitchX, float rollY, float yawZ) =>
            // C# uses yaw=Y, pitch=X, roll=Z so we want correct axis in correct position
            Quat.CreateFromYawPitchRoll(rollY, pitchX, yawZ);

#region DEPRECATE
        // OLD impl

        public static Vec3 TRVectorZupLhs(Vec3 yupV) => new(yupV.X, -yupV.Z, yupV.Y);
        public static Vec3 TRVectorYupRhs(Vec3 zupV) => new(zupV.X, zupV.Z, -zupV.Y);

        // NB scale is not affected by handedness
        public static Vec3 SVectorZupLhs(Vec3 yupV) => new(yupV.X, yupV.Z, yupV.Y);
        public static Vec3 SVectorYupRhs(Vec3 zupV) => new(zupV.X, zupV.Z, zupV.Y);


        public static Quat RQuaternionZupLhs(Quat yupQ) => new(yupQ.X, -yupQ.Z, yupQ.Y, yupQ.W);
        public static Quat RQuaternionYupRhs(Quat zupQ) => new(zupQ.X, zupQ.Z, -zupQ.Y, zupQ.W);
#endregion DEPRECATE


        public static Vec3 Scale1to1 = new(1f, 1f, 1f);
        public static float MicrometerPrecisionEpsilon = 0.0000001f;

        public static Vec3 WithEpsilon(Vec3 vec, Vec3 reference, float epsilon = Single.Epsilon) =>
            new(
                Math.Abs(vec.X - reference.X) <= epsilon ? reference.X : vec.X,
                Math.Abs(vec.Y - reference.Y) <= epsilon ? reference.Y : vec.Y,
                Math.Abs(vec.Z - reference.Z) <= epsilon ? reference.Z : vec.Z
            );

        public static bool EqWithEpsilon(Vec3 a, Vec3 b, float epsilon = Single.Epsilon) =>
            Math.Abs(a.X - b.X) <= epsilon &&
            Math.Abs(a.Y - b.Y) <= epsilon &&
            Math.Abs(a.Z - b.Z) <= epsilon;

        public static Quat RQuaternionNormalize(Quat q) => q.W == 1 ? Quat.Identity : Quat.Normalize(q);
        public static Vec3 SVectorNormalize(Vec3 v) => WithEpsilon(v, Scale1to1, MicrometerPrecisionEpsilon);
    }

    internal static class Gltf
    {
        // JSON stuffs..
        public const string SchemaType = "wkit.cp2077.gltf.anims";
        public const uint SchemaVersion = 4;

        public static Func<Schema> CurrentSchema = () => new(SchemaType, SchemaVersion);
        public static Func<AnimationExtrasForGltf, bool> IsCurrentSchema = (extras) =>
            extras.Schema.Type == SchemaType && extras.Schema.Version == SchemaVersion;

        public static Func<JsonSerializerOptions> SerializationOptions = () =>
            new()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

        private static Func<AnimationExtrasForGltfV3, AnimationExtrasForGltf> MigrateFromV3toV4 = (v3Extras) => {
            return new(
                new(SchemaType, 4),
                v3Extras.AnimationType,
                RootMotionType.Unknown.ToString(),
                v3Extras.FrameClamping,
                v3Extras.FrameClampingStartFrame,
                v3Extras.FrameClampingEndFrame,
                v3Extras.NumExtraJoints,
                v3Extras.NumExtraTracks,
                v3Extras.ConstTrackKeys,
                v3Extras.TrackKeys,
                v3Extras.FallbackFrameIndices,
                v3Extras.OptimizationHints
            );
        };
        private static Func<System.Text.Json.Nodes.JsonNode, AnimationExtrasForGltf> MigrateJsonFromV3toV4 = (maybeExtras) =>
            MigrateFromV3toV4(JsonSerializer.Deserialize<Deprecated.AnimationExtrasForGltfV3>(maybeExtras, SerializationOptions()));

        private static Func<System.Text.Json.Nodes.JsonNode, Deprecated.AnimationExtrasForGltfV3> MigrateJsonFromV2toV3 = (maybeExtras) =>
        {
            var v2Extras = JsonSerializer.Deserialize<Deprecated.AnimationExtrasForGltfV2>(maybeExtras, SerializationOptions());

            return new(
                new(SchemaType, 3),
                v2Extras.AnimationType,
                v2Extras.FrameClamping,
                v2Extras.FrameClampingStartFrame,
                v2Extras.FrameClampingEndFrame,
                v2Extras.NumExtraJoints,
                v2Extras.NumeExtraTracks,
                v2Extras.ConstTrackKeys,
                v2Extras.TrackKeys,
                v2Extras.FallbackFrameIndices,
                new(
                    false,
                    v2Extras.PreferLosslessLinearRotationEncoding
                        ? AnimationCompression.Uncompressed
                        : AnimationCompression.QuaternionAsFixed3x16bit
                )
            );
        };

        public static Func<System.Text.Json.Nodes.JsonNode, ValidationResult> TryMigrateAndValidate = (maybeExtras) =>
        {
            var extras = maybeExtras.Deserialize<AnimationExtrasForGltf>(SerializationOptions());

            if (IsCurrentSchema(extras))
            {
                return new Valid(extras);
            }

            if (extras.Schema.Type != SchemaType)
            {
                return new Invalid("No valid schema found in the `extras` property, please check your Blender cp2077 plugin and export.");
            }

            return extras.Schema.Version switch
            {
                3 => new Valid(MigrateJsonFromV3toV4(maybeExtras)),
                2 => new Valid(MigrateFromV3toV4(MigrateJsonFromV2toV3(maybeExtras))),
                _ => new Invalid($"No migration path for schema version {extras.Schema.Version} found.")
            };
        };
    }

    internal record class ValidationResult();
    internal record class Invalid(
        string Reason
    ) : ValidationResult();
    internal record class Valid(
        AnimationExtrasForGltf Extras
    ) : ValidationResult();

    internal readonly record struct Schema(
        string Type,
        uint Version
    );

    internal readonly record struct AnimTrackKeySerializable(
        ushort TrackIndex,
        float Time,
        float Value
    );

    internal readonly record struct AnimConstTrackKeySerializable(
        ushort TrackIndex,
        float Time,
        float Value
    );

    internal enum AnimationCompression
    {
        Uncompressed,
        QuaternionAsFixed3x16bit,
    }

    internal readonly record struct AnimationOptimizationHints(
        bool PreferSIMD,
        AnimationCompression MaxRotationCompression
    );

    internal record struct AnimationBufferData(
        float Duration,
        uint FrameCount,
        JointsTranslationsAtTimes Translations,
        JointsTranslationsAtTimes ConstTranslations,
        JointsRotationsAtTimes Rotations,
        JointsRotationsAtTimes ConstRotations,
        JointsScalesAtTimes Scales,
        JointsScalesAtTimes ConstScales,
        List<AnimTrackKeySerializable> TrackKeys,
        List<AnimConstTrackKeySerializable> ConstTrackKeys,
        List<ushort> FallbackFrameIndices,
        ushort NumJoints,
        byte NumExtraJoints,
        ushort JointsCountActual,
        ushort NumTracks,
        byte NumExtraTracks,
        ushort TracksCountActual,
        bool IsSimd,
        AnimationCompression CompressionUsed
    );

    internal readonly record struct AnimationExtrasForGltf(
        Schema Schema,
        string AnimationType,
        string RootMotionType,
        bool FrameClamping,
        short FrameClampingStartFrame,
        short FrameClampingEndFrame,
        byte NumExtraJoints,
        byte NumExtraTracks,
        List<AnimConstTrackKeySerializable> ConstTrackKeys,
        List<AnimTrackKeySerializable> TrackKeys,
        List<ushort> FallbackFrameIndices,
        AnimationOptimizationHints OptimizationHints
    );

    namespace Deprecated
    {
        // TODO: maybe explicit constructor for explicit defaults?
        internal readonly record struct AnimationExtrasForGltfV3(
            Schema Schema,
            string AnimationType,
            bool FrameClamping,
            short FrameClampingStartFrame,
            short FrameClampingEndFrame,
            byte NumExtraJoints,
            byte NumExtraTracks,
            List<AnimConstTrackKeySerializable> ConstTrackKeys,
            List<AnimTrackKeySerializable> TrackKeys,
            List<ushort> FallbackFrameIndices,
            AnimationOptimizationHints OptimizationHints
        );
        internal readonly record struct AnimationExtrasForGltfV2(
            Schema Schema,
            string AnimationType,
            bool FrameClamping,
            short FrameClampingStartFrame,
            short FrameClampingEndFrame,
            bool PreferLosslessLinearRotationEncoding,
            byte NumExtraJoints,
            byte NumeExtraTracks,
            List<AnimConstTrackKeySerializable> ConstTrackKeys,
            List<AnimTrackKeySerializable> TrackKeys,
            List<ushort> FallbackFrameIndices
        );
    }
}