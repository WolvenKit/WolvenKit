using System;
using System.Collections.Generic;
using System.Text.Json;

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
        public static Vec3 TRVectorZup(Vec3 v) => new(v.X, -v.Z, v.Y);
        public static Vec3 TRVectorYup(Vec3 v) => new(v.X, v.Z, -v.Y);

        // NB scale is not affected by handedness
        public static Vec3 SVectorZup(Vec3 v) => new(v.X, v.Z, v.Y);
        public static Vec3 SVectorYup(Vec3 v) => new(v.X, v.Y, v.Z);

        public static Quat RQuaternionZup(Quat q) => new(q.X, -q.Z, q.Y, q.W);
        public static Quat RQuatYup(Quat q) => new(q.X, q.Z, -q.Y, q.W);
    }

    internal static class Gltf
    {
        // JSON stuffs..
        public const string SchemaType = "wkit.cp2077.gltf.anims";
        public const uint SchemaVersion = 2;

        public static Func<Schema> CurrentSchema = () => new(SchemaType, SchemaVersion);
        public static Func<AnimationExtrasForGltf, bool> IsSchemaVersionCompatible = (extras) =>
            extras.Schema.Type == SchemaType && extras.Schema.Version == SchemaVersion;

        public static Func<JsonSerializerOptions> SerializationOptions = () =>
            new()
            {
                PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
                WriteIndented = true
            };
    }

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

    // TODO: maybe explicit constructor for explicit defaults?
    internal readonly record struct AnimationExtrasForGltf(
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