using System;
using System.Collections.Generic;
using System.Text.Json;
using SharpGLTF.IO;
using WolvenKit.Modkit.RED4.Animation.Deprecated;
using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;

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
    }

    internal static class Fun
    {
        public static Vec3 TRVectorZupLhs(Vec3 yupV) => new(yupV.X, -yupV.Z, yupV.Y);
        public static Vec3 TRVectorYupRhs(Vec3 zupV) => new(zupV.X, zupV.Z, -zupV.Y);

        // NB scale is not affected by handedness
        public static Vec3 SVectorZupLhs(Vec3 yupV) => new(yupV.X, yupV.Z, yupV.Y);
        public static Vec3 SVectorYupRhs(Vec3 zupV) => new(zupV.X, zupV.Y, zupV.Z);

        public static Quat RQuaternionZupLhs(Quat yupQ) => new(yupQ.X, -yupQ.Z, yupQ.Y, yupQ.W);
        public static Quat RQuaternionYupRhs(Quat zupQ) => new(zupQ.X, zupQ.Z, -zupQ.Y, zupQ.W);

        public static Vec3 Scale1to1 = new(1.0f, 1.0f, 1.0f);

        public static Vec3 WithEpsilon(Vec3 vec, Vec3 reference) =>
            new(
                Math.Abs(vec.X - reference.X) <= Single.Epsilon ? reference.X : vec.X,
                Math.Abs(vec.Y - reference.Y) <= Single.Epsilon ? reference.Y : vec.Y,
                Math.Abs(vec.Z - reference.Z) <= Single.Epsilon ? reference.Z : vec.Z
            );

        public static bool EqWithEpsilon(Vec3 a, Vec3 b) =>
            Math.Abs(a.X - b.X) <= Single.Epsilon &&
            Math.Abs(a.Y - b.Y) <= Single.Epsilon &&
            Math.Abs(a.Z - b.Z) <= Single.Epsilon;
    }

    internal static class Gltf
    {
        // JSON stuffs..
        public const string SchemaType = "wkit.cp2077.gltf.anims";
        public const uint SchemaVersion = 3;

        public static Func<Schema> CurrentSchema = () => new(SchemaType, SchemaVersion);
        public static Func<AnimationExtrasForGltf, bool> IsSchemaVersionCompatible = (extras) =>
            extras.Schema.Type == SchemaType && extras.Schema.Version == SchemaVersion;

        public static Func<JsonSerializerOptions> SerializationOptions = () =>
            new()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };

        private static Func<JsonContent, ValidationResult> MigrateFromV2toV3 = (maybeExtras) =>
        {
            var oldExtras = JsonSerializer.Deserialize<Deprecated.AnimationExtrasForGltfV2>(maybeExtras.ToJson(), SerializationOptions());

            return new Valid(new(
                CurrentSchema(),
                oldExtras.AnimationType,
                oldExtras.FrameClamping,
                oldExtras.FrameClampingStartFrame,
                oldExtras.FrameClampingEndFrame,
                oldExtras.NumExtraJoints,
                oldExtras.NumeExtraTracks,
                oldExtras.ConstTrackKeys,
                oldExtras.TrackKeys,
                oldExtras.FallbackFrameIndices,
                new(
                    false,
                    oldExtras.PreferLosslessLinearRotationEncoding
                        ? AnimationEncoding.Uncompressed
                        : AnimationEncoding.QuaternionAsFixed3x16bit
                )
            ));
        };

        public static Func<JsonContent, ValidationResult> TryMigrateAndValidate = (maybeExtras) =>
        {
            var extras = JsonSerializer.Deserialize<AnimationExtrasForGltf>(maybeExtras.ToJson(), SerializationOptions());

            if (IsSchemaVersionCompatible(extras))
            {
                return new Valid(extras);
            }

            if (extras.Schema.Type != SchemaType)
            {
                return new Invalid("No valid schema found in the `extras` property, please check your Blender cp2077 plugin and export.");
            }

            return extras.Schema.Version switch
            {
                2 => MigrateFromV2toV3(maybeExtras),
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

    internal enum AnimationEncoding
    {
        Uncompressed,
        QuaternionAsFixed3x16bit,
    }

    internal readonly record struct AnimationOptimizationHints(
        bool PreferSIMD,
        AnimationEncoding MaxRotationCompression
    );

    internal readonly record struct AnimationExtrasForGltf(
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

    namespace Deprecated
    {
        // TODO: maybe explicit constructor for explicit defaults?
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