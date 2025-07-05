using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json;
using SharpGLTF.Schema2;

using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Types;

using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;

using static WolvenKit.RED4.Types.Enums;
using static WolvenKit.Modkit.RED4.Animation.Fun;
using static WolvenKit.Modkit.RED4.Animation.Gltf;

using JointsTranslationsAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>>;
using JointsRotationsAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Quaternion>>;
using JointsScalesAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>>;


namespace WolvenKit.Modkit.RED4.Animation
{
    internal class CompressedBuffer
    {
#region export
        internal static void DecodeAnimationData(out AnimationBufferData result, animAnimation animAnimDes, ILoggerService _loggerService)
        {
            if (animAnimDes.AnimBuffer.GetValue() is not animAnimationBufferCompressed animBuf)
            {
                throw new ArgumentNullException();
            }
            animBuf.ReadBuffer();

            var translations = new JointsTranslationsAtTimes();
            var rotations = new JointsRotationsAtTimes();
            var scales = new JointsScalesAtTimes();

            var constTranslations = new JointsTranslationsAtTimes();
            var constRotations = new JointsRotationsAtTimes();
            var constScales = new JointsScalesAtTimes();


            foreach (var key in animBuf.AnimKeys)
            {
                if (key is animKeyPosition p)
                {
                    if (!translations.ContainsKey(p.Idx))
                    {
                        translations[p.Idx] = new Dictionary<float, Vec3>();
                    }
                    translations[p.Idx][p.Time] = TRVectorYupRhs(p.Position);
                }
                else if (key is animKeyRotation r)
                {
                    if (!rotations.ContainsKey(r.Idx))
                    {
                        rotations[r.Idx] = new Dictionary<float, Quat>();
                    }
                    rotations[r.Idx][r.Time] = RQuaternionNormalize(RQuaternionYupRhs(r.Rotation));
                }
                else if (key is animKeyScale s)
                {
                    if (!scales.ContainsKey(s.Idx))
                    {
                        scales[s.Idx] = new Dictionary<float, Vec3>();
                    }
                    scales[s.Idx][s.Time] = SVectorNormalize(SVectorYupRhs(s.Scale));
                }
            }

            foreach (var key in animBuf.AnimKeysRaw)
            {
                if (key is animKeyPosition p)
                {
                    if (!translations.ContainsKey(p.Idx))
                    {
                        translations[p.Idx] = new Dictionary<float, Vec3>();
                    }
                    translations[p.Idx][p.Time] = TRVectorYupRhs(p.Position);
                }
                else if (key is animKeyRotation r)
                {
                    if (!rotations.ContainsKey(r.Idx))
                    {
                        rotations[r.Idx] = new Dictionary<float, Quat>();
                    }
                    rotations[r.Idx][r.Time] = RQuaternionNormalize(RQuaternionYupRhs(r.Rotation));
                }
                else if (key is animKeyScale s)
                {
                    if (!scales.ContainsKey(s.Idx))
                    {
                        scales[s.Idx] = new Dictionary<float, Vec3>();
                    }
                    scales[s.Idx][s.Time] = SVectorNormalize(SVectorYupRhs(s.Scale));
                }
            }

            foreach (var key in animBuf.ConstAnimKeys)
            {
                if (key is animKeyPosition p)
                {
                    if (!constTranslations.ContainsKey(p.Idx))
                    {
                        constTranslations[p.Idx] = [];
                    }
                    constTranslations[p.Idx][p.Time] = TRVectorYupRhs(p.Position);
                }
                else if (key is animKeyRotation r)
                {
                    if (!constRotations.ContainsKey(r.Idx))
                    {
                        constRotations[r.Idx] = [];
                    }
                    constRotations[r.Idx][r.Time] = RQuaternionNormalize(RQuaternionYupRhs(r.Rotation));
                }
                else if (key is animKeyScale s)
                {
                    if (!constScales.ContainsKey(s.Idx))
                    {
                        constScales[s.Idx] = [];
                    }
                    constScales[s.Idx][s.Time] = SVectorNormalize(SVectorYupRhs(s.Scale));
                }
            }

            result = new AnimationBufferData {
                Duration = animBuf.Duration,
                FrameCount = animBuf.NumFrames,
                Translations = translations,
                ConstTranslations = constTranslations,
                Rotations = rotations,
                ConstRotations = constRotations,
                Scales = scales,
                ConstScales = constScales,
                TrackKeys = animBuf.TrackKeys.Select(_ => new AnimTrackKeySerializable(_.TrackIndex, _.Time, _.Value)).ToList(),
                ConstTrackKeys = animBuf.ConstTrackKeys.Select(_ => new AnimConstTrackKeySerializable(_.TrackIndex, _.Time, _.Value)).ToList(),
                FallbackFrameIndices = animBuf.FallbackFrameIndices.Select(_ => (ushort)_).ToList(),
                NumJoints = animBuf.NumJoints,
                NumExtraJoints = animBuf.NumExtraJoints,
                JointsCountActual = Convert.ToUInt16(animBuf.NumJoints - animBuf.NumExtraJoints),
                NumTracks = animBuf.NumTracks,
                NumExtraTracks = animBuf.NumExtraTracks,
                TracksCountActual = Convert.ToUInt16(animBuf.NumTracks - animBuf.NumExtraTracks),
                IsSimd = false,
                CompressionUsed =
                    animBuf.HasRawRotations
                    ? AnimationCompression.Uncompressed
                    : AnimationCompression.QuaternionAsFixed3x16bit
            };
        }

#endregion export
#region import
        internal static void EncodeAnimationData(out animAnimDataChunk newAnimDataChunk, out animAnimationBufferCompressed newCompressedBuffer, ref readonly AnimationBufferData incomingAnimBufferData, animAnimDataAddress chunkDataAddress, ILoggerService _loggerService)
        {
            var constAnimKeys = new List<animKey?>();
            var animKeys = new List<animKey?>();
            var animKeysRaw = new List<animKey?>();

            var rotationCompressionAllowed = incomingAnimBufferData.CompressionUsed != AnimationCompression.Uncompressed;

            for (ushort jointIdx = 0; jointIdx < incomingAnimBufferData.JointsCountActual; ++jointIdx)
            {
                // Const (non-interpolated) keyframes are all similarly encoded, S, R and T
                
                // TODO https://github.com/WolvenKit/WolvenKit/issues/1661
                //      Warn on failing sanity checks like no 0 timestamp for const keyframes.
                //      There's probably a bunch of possible additional warnings we can raise.

                foreach (var (time, translation) in incomingAnimBufferData.ConstTranslations.GetValueOrDefault(jointIdx, []))
                {
                    constAnimKeys.Add(new animKeyPosition() { Idx = jointIdx, Time = time, Position = TRVectorZupLhs(translation), });
                }

                foreach (var (time, rotation) in incomingAnimBufferData.ConstRotations.GetValueOrDefault(jointIdx, []))
                {
                    constAnimKeys.Add(new animKeyRotation() { Idx = jointIdx, Time = time, Rotation = RQuaternionZupLhs(rotation), });
                }

                foreach (var (time, scale) in incomingAnimBufferData.ConstScales.GetValueOrDefault(jointIdx, []))
                {
                    constAnimKeys.Add(new animKeyScale() { Idx = jointIdx, Time = time, Scale = SVectorZupLhs(scale), });
                }

                // For linear keyframes, T and S are essentially always* 'raw', i.e. uncompressed...
                // * Not strictly true

                foreach (var (time, translation) in incomingAnimBufferData.Translations.GetValueOrDefault(jointIdx, []))
                {
                    animKeysRaw.Add(new animKeyPosition() { Idx = jointIdx, Time = time, Position = TRVectorZupLhs( translation ), });
                }

                foreach (var (time, scale) in incomingAnimBufferData.Scales.GetValueOrDefault(jointIdx, []))
                {
                    animKeysRaw.Add(new animKeyScale() { Idx = jointIdx, Time = time, Scale = SVectorZupLhs(scale), });
                }

                // ...but R can optionally be compressed
                var preferredStorage = rotationCompressionAllowed ? animKeys : animKeysRaw;

                foreach (var (time, rotation) in incomingAnimBufferData.Rotations.GetValueOrDefault(jointIdx, []))
                {
                    preferredStorage.Add(new animKeyRotation() { Idx = jointIdx, Time = time, Rotation = RQuaternionZupLhs(rotation), });
                }
            }

            var fallbackIndices = incomingAnimBufferData.FallbackFrameIndices.Select(_ =>
                (CUInt16)_).ToList();

            // These must be nullable for carray init -.-
            var constTrackKeys = incomingAnimBufferData.ConstTrackKeys.Select<AnimConstTrackKeySerializable, animKeyTrack?>(_ =>
                new animKeyTrack() { TrackIndex = _.TrackIndex, Time = _.Time, Value = _.Value, }).ToList();

            var trackKeys = incomingAnimBufferData.TrackKeys.Select<AnimTrackKeySerializable, animKeyTrack?>(_ =>
                new animKeyTrack() { TrackIndex = _.TrackIndex, Time = _.Time, Value = _.Value, }).ToList();

            // There's three ways 'constant scale' could be understood:
            //
            // 1. Every joint maintains uniform scale, i.e. 1:1
            // 2. Every joint maintains same scale S throughout anim
            // 3. Each joint  maintains separate scale S' throughout anim
            //
            // Using the first definition here.
            //
            var allScalesUniform1to1 =
                ((List<JointsScalesAtTimes>)[incomingAnimBufferData.Scales, incomingAnimBufferData.ConstScales]).All(_ =>
                    _.All(_ => _.Value.All(_ => EqWithEpsilon(_.Value, Scale1to1))));

            newCompressedBuffer = new animAnimationBufferCompressed()
            {
                Duration = incomingAnimBufferData.Duration,
                NumFrames = incomingAnimBufferData.FrameCount,
                NumExtraJoints = incomingAnimBufferData.NumExtraJoints,
                NumExtraTracks = incomingAnimBufferData.NumExtraTracks,
                NumJoints = incomingAnimBufferData.NumJoints,
                NumTracks = incomingAnimBufferData.NumTracks,
                NumConstAnimKeys = Convert.ToUInt32(constAnimKeys.Count),
                NumAnimKeysRaw = Convert.ToUInt32(animKeysRaw.Count),
                NumAnimKeys = Convert.ToUInt32(animKeys.Count),
                NumConstTrackKeys = Convert.ToUInt32(constTrackKeys.Count),
                NumTrackKeys = Convert.ToUInt32(trackKeys.Count),
                IsScaleConstant = allScalesUniform1to1,
                HasRawRotations = !rotationCompressionAllowed,

                FallbackFrameIndices = new CArray<CUInt16>(fallbackIndices),

                DataAddress = chunkDataAddress,

                // These are internal only, they'll be packed into a buffer...
                ConstAnimKeys = new(constAnimKeys),
                AnimKeysRaw = new(animKeysRaw),
                AnimKeys = new(animKeys),

                ConstTrackKeys = new(constTrackKeys),
                TrackKeys = new(trackKeys),

                TempBuffer = new(),
            };

            // ...specifically TempBuffer, here.
            newCompressedBuffer.WriteBuffer();

            // And bookkeeping
            newCompressedBuffer.DataAddress.ZeInBytes = newCompressedBuffer.TempBuffer.Buffer.MemSize;

            newAnimDataChunk = new() { Buffer = new SerializationDeferredDataBuffer(newCompressedBuffer.TempBuffer.Buffer.GetBytes()) };
        }
#endregion import

    }
}
