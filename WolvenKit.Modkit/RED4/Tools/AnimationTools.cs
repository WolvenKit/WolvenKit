using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using NAudio.MediaFoundation;
using SharpGLTF.Schema2;
using SharpGLTF.Validation;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.RED4.Animation;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

using static WolvenKit.RED4.Types.Enums;
using static WolvenKit.Modkit.RED4.Animation.Const;
using static WolvenKit.Modkit.RED4.Animation.Fun;
using static WolvenKit.Modkit.RED4.Animation.Gltf;

using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {

#region exportanims

        public bool ExportAnim(CR2WFile animsFile, FileInfo outfile, bool isGLBinary = true, bool incRootMotion = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            if (animsFile.RootChunk is not animAnimSet anims)
            {
                return false;
            }

            if (TryFindFile(anims.Rig.DepotPath, out var result) != FindFileResult.NoError)
            {
                _loggerService.Warning("No rig found");
                return false;
            }

            var model = ModelRoot.CreateModel();
            GetAnimation(animsFile, result.File!, outfile.Name, ref model, true, incRootMotion);

            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName, new WriteSettings(vmode));
            }
            else
            {
                model.SaveGLTF(outfile.FullName, new WriteSettings(vmode));
            }

            return true;
        }

        public bool GetAnimation(CR2WFile animsFile, CR2WFile rigFile, string animsFileName, ref ModelRoot model, bool includeRig = true, bool incRootMotion = true)
        {

            if (animsFile.RootChunk is not animAnimSet anims)
            {
                return false;
            }

            // The buffers have been pre-split into chunks for us by `RED4.Archive.IO.AnimationReader`
            // so we can just assume there's logically one buffer per animation rather than mess with
            // the indexing here.
            var animDataBuffers = new List<MemoryStream>();
            foreach (var chk in anims.AnimationDataChunks)
            {
                var ms = new MemoryStream();
                ms.Write(chk.Buffer.Buffer.GetBytes());

                animDataBuffers.Add(ms);
            }

            if (includeRig)
            {
                var rig = RIG.ProcessRig(rigFile);
                if (rig is null || rig.BoneCount < 1)
                {
                    return false;
                }
                var skin = model.CreateSkin("Armature");
                skin.BindJoints(RIG.ExportNodes(ref model, rig).Values.ToArray());
            }

            var rigFileName = anims.Rig.DepotPath.GetResolvedText() ?? "<unknown rig depotpath??>";

            _loggerService.Info($"{animsFileName}: Found {anims.Animations.Count} animations to export, using rig {rigFileName}");

            var stats = new
            {
                AdditiveAnims = 0,
                SimdAnims = 0,
            };

            foreach (var anim in anims.Animations)
            {
                ArgumentNullException.ThrowIfNull(anim.Chunk);
                ArgumentNullException.ThrowIfNull(anim.Chunk.Animation.Chunk);

                var animAnimDes = anim.Chunk.Animation.Chunk;

                if (animAnimDes.MotionExtraction != null && animAnimDes.MotionExtraction.Chunk != null && !incRootMotion)
                {
                    _loggerService.Debug($"{animsFileName}: {animAnimDes.Name}: contains root motion but it's not exported!");
                }

                stats = animAnimDes.AnimationType == animAnimationType.Normal ? stats : stats with { AdditiveAnims = stats.AdditiveAnims + 1 };

                if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferSimd animBuffSimd)
                {
                    stats = stats with { SimdAnims = stats.SimdAnims + 1 };

                    MemoryStream deferredBuffer;
                    if (animBuffSimd.InplaceCompressedBuffer != null)
                    {
                        deferredBuffer = new MemoryStream(animBuffSimd.InplaceCompressedBuffer.Buffer.GetBytes());
                    }
                    else if (animBuffSimd.DataAddress != null && animBuffSimd.DataAddress.UnkIndex != uint.MaxValue)
                    {
                        var dataAddr = animBuffSimd.DataAddress;
                        var bytes = new byte[dataAddr.ZeInBytes];
                        animDataBuffers[(int)(uint)dataAddr.UnkIndex].Seek(dataAddr.FsetInBytes, SeekOrigin.Begin);
                        // bytesRead can be smaller then the bytes requested
                        var bytesRead = animDataBuffers[(int)(uint)dataAddr.UnkIndex].Read(bytes, 0, (int)(uint)dataAddr.ZeInBytes);
                        deferredBuffer = new MemoryStream(bytes);
                    }
                    else
                    {
                        deferredBuffer = new MemoryStream(animBuffSimd.DefferedBuffer.Buffer.GetBytes());
                    }
                    deferredBuffer.Seek(0, SeekOrigin.Begin);
                    _loggerService.Debug($"{animsFileName}: Exporting SIMD animation {animAnimDes.Name} with {animBuffSimd.NumFrames * animBuffSimd.NumJoints} S/R/T transforms and {animBuffSimd.NumFrames * animBuffSimd.NumTracks} tracks");
                    SIMD.AddAnimationSIMD(ref model, animBuffSimd, animAnimDes.Name!, deferredBuffer, animAnimDes, incRootMotion);
                }
                else if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferCompressed)
                {
                    CompressedBuffer.ExportAsAnimationToModel(ref model, animAnimDes, incRootMotion);
                }
            }

            if (stats.SimdAnims > 0)
            {
                _loggerService.Info($"{animsFileName}: Exported {stats.SimdAnims} SIMD animations. They can only be imported back as regular animations, so you may want to simplify them when editing, or omit them from the re-import to keep the old ones."); 
            }

            if (stats.AdditiveAnims > 0)
            {
                _loggerService.Info($"{animsFileName}: Exported {stats.AdditiveAnims} additive animations already added to the bind pose. Reimport will strip the bind pose again.");
            }

            return true;
        }

#endregion exportanims

#region importanims

        public bool ImportAnims(FileInfo gltfFile, Stream animStream)
        {
            var animsArchive = _parserService.ReadRed4File(animStream);
            if (animsArchive is not { RootChunk: animAnimSet anims })
            {
                return false;
            }

            var gltfFileName = gltfFile.Name;
            var rigFileName = anims.Rig.DepotPath.GetResolvedText() ?? "<unknown rig depotpath??>";

            // find first rig in archives
            if (TryFindFile(anims.Rig.DepotPath, out var result) != FindFileResult.NoError)
            {
                _loggerService.Error($"{gltfFileName}: No rig found for {rigFileName}, can't import animations!");
                return false;
            }

            var rig = RIG.ProcessRig(result.File!);
            if (rig is null || rig.BoneCount < 1)
            {
                _loggerService.Error($"{gltfFileName}: couldn't process rig from {rigFileName}, can't import anims!");
                return false;
            }

            var model = ModelRoot.Load(gltfFile.FullName, new ReadSettings(ValidationMode.TryFix));

            if (model.LogicalAnimations.Count < 1)
            {
                _loggerService.Error($"No animations found in {gltfFileName}!");
                return false;
            }

            PutAnimations(ref anims, ref rig, ref model, gltfFileName, rigFileName);

            var outMs = new MemoryStream();
            using var writer = new CR2WWriter(outMs, Encoding.UTF8, true) { LoggerService = _loggerService };
            writer.WriteFile(animsArchive);

            outMs.Seek(0, SeekOrigin.Begin);
            animStream.SetLength(0);
            outMs.CopyTo(animStream);

            return true;

        }


        private bool PutAnimations(ref animAnimSet anims, ref RawArmature rig, ref ModelRoot model, string gltfFileName, string rigFileName)
        {
            _loggerService.Info($"{gltfFileName}: found {model.LogicalAnimations.Count} animations to import");

            var (simdCount, additiveCount) = (0, 0);

            var newAnimSetEntries = new CArray<CHandle<animAnimSetEntry>>();
            var newAnimChunks = new CArray<animAnimDataChunk>();

            var originalAnimNames = new HashSet<string>(anims.Animations.Select(_ => _?.Chunk?.Animation.Chunk?.Name.GetResolvedText())!);
            var importedAnimNames = new HashSet<string>();

            foreach (var incomingAnim in model.LogicalAnimations)
            {
                if (importedAnimNames.Contains(incomingAnim.Name))
                {
                    throw new InvalidOperationException($"{gltfFileName}: animation `{incomingAnim.Name}` appears more than once, can't import!");
                }

                // Can switch to system Json when SharpGLTF support released (maybe in .31)
                if (incomingAnim.Extras.Content is null)
                {
                    throw new InvalidOperationException($"{gltfFileName}: animation `{incomingAnim.Name}` has no extra data, can't import!");
                }

                var result = TryMigrateAndValidate(incomingAnim.Extras);

                if (result is Invalid invalid)
                {
                    _loggerService.Error($"{gltfFileName}: can't import `{incomingAnim.Name}`: {invalid.Reason}!");
                    continue;
                }

                var extras = ((Valid)result).Extras;

                var oldAnim = anims.Animations.FirstOrDefault(_ => _?.Chunk?.Animation.Chunk?.Name.GetResolvedText() == incomingAnim.Name)?.Chunk;
                if (oldAnim == null)
                {
                    _loggerService.Debug($"{gltfFileName}: new: `{incomingAnim.Name}` not found in animset, treating as new animation!");
                }

                var keyframeTranslations = new Dictionary<AnimationInterpolationMode, Dictionary<ushort, List<(float, Vec3)>>> {
                    [AnimationInterpolationMode.STEP] = new (),
                    [AnimationInterpolationMode.LINEAR] = new (),
                };

                var keyframeRotations = new Dictionary<AnimationInterpolationMode, Dictionary<ushort, List<(float, Quat)>>> {
                    [AnimationInterpolationMode.STEP] = new (),
                    [AnimationInterpolationMode.LINEAR] = new (),
                };

                var keyframeScales = new Dictionary<AnimationInterpolationMode, Dictionary<ushort, List<(float, Vec3)>>> {
                    [AnimationInterpolationMode.STEP] = new (),
                    [AnimationInterpolationMode.LINEAR] = new (),
                };

                var incomingAnimationType = (animAnimationType)Enum.Parse(typeof(animAnimationType), extras.AnimationType);
                var stripLocalFromAdditives = incomingAnimationType != animAnimationType.Normal;

                additiveCount += stripLocalFromAdditives ? 1 : 0;
                simdCount += extras.OptimizationHints.PreferSIMD ? 1 : 0;

                foreach (var chan in incomingAnim.Channels)
                {
                    var idx = Array.IndexOf(rig.Names.NotNull(), chan.TargetNode.Name);
                    if (idx < 0)
                    {
                        throw new Exception($"{gltfFileName} ${incomingAnim.Name}: Invalid Joint Transform, joint {chan.TargetNode.Name} not present in the associated rig {rigFileName}");
                    }

                    switch (chan.TargetNodePath)
                    {
                        case PropertyPath.translation:
                            var translationSampler = chan.GetTranslationSampler();
                            var typedTranslations = keyframeTranslations[translationSampler.InterpolationMode] ?? throw new Exception($"{gltfFileName} ${incomingAnim.Name}: Unsupported interpolation mode {translationSampler.InterpolationMode}!");

                            var translations = stripLocalFromAdditives
                                ?  translationSampler.GetLinearKeys().Select(_ => (_.Key, _.Value - chan.TargetNode.LocalTransform.Translation)).ToList()
                                : translationSampler.GetLinearKeys().Select(_ => (_.Key, _.Value)).ToList();

                            typedTranslations.Add((ushort)idx, translations);
                            break;

                        case PropertyPath.rotation:
                            var rotationSampler = chan.GetRotationSampler();
                            var typedRotations = keyframeRotations[rotationSampler.InterpolationMode] ?? throw new Exception($"{gltfFileName} ${incomingAnim.Name}: Unsupported interpolation mode {rotationSampler.InterpolationMode}!");

                            var rotations = stripLocalFromAdditives
                                ? rotationSampler.GetLinearKeys().Select(_ => (_.Key, _.Value / chan.TargetNode.LocalTransform.Rotation)).ToList()
                                : rotationSampler.GetLinearKeys().Select(_ => (_.Key, _.Value)).ToList();

                            typedRotations.Add((ushort)idx, rotations);
                            break;

                        case PropertyPath.scale:
                            var scaleSampler = chan.GetScaleSampler();
                            var typedScales = keyframeScales[scaleSampler.InterpolationMode] ?? throw new Exception($"{gltfFileName} ${incomingAnim.Name}: Unsupported interpolation mode {scaleSampler.InterpolationMode}!");

                            var scales = stripLocalFromAdditives
                                ? scaleSampler.GetLinearKeys().Select(_ => (_.Key, _.Value - chan.TargetNode.LocalTransform.Scale)).ToList()
                                : scaleSampler.GetLinearKeys().Select(_ => (_.Key, _.Value)).ToList();

                            typedScales.Add((ushort)idx, scales);
                            break;

                        case PropertyPath.weights:
                            // Fallthrough, no morph anims yet
                        default:
                            throw new Exception($"{gltfFileName} ${incomingAnim.Name}: Unsupported channel target {chan.TargetNodePath}!");
                    }
                }
  
                // We could validate there's only one of each const but not 100% that's a requirement
                var constKeyTranslations = keyframeTranslations[AnimationInterpolationMode.STEP];
                var constKeyRotations = keyframeRotations[AnimationInterpolationMode.STEP];
                var constKeyScales = keyframeScales[AnimationInterpolationMode.STEP];

                var keyTranslations = keyframeTranslations[AnimationInterpolationMode.LINEAR];
                var keyRotations = keyframeRotations[AnimationInterpolationMode.LINEAR];
                var keyScales = keyframeScales[AnimationInterpolationMode.LINEAR];

                // TODO umm do we need to remove root motion if it was present in the original anim?

                var constAnimKeys = new List<animKey?>();
                var animKeys = new List<animKey?>();
                var animKeysRaw = new List<animKey?>();

                var rotationCompressionAllowed = extras.OptimizationHints.MaxRotationCompression != AnimationEncoding.Uncompressed;

                for (ushort jointIdx = 0; jointIdx < (ushort)rig.BoneCount; ++jointIdx) {

                    // Const keyframes are all similarly encoded, S, R and T

                    // Order of SRT doesn't seem to matter
                    foreach (var (time, value) in constKeyRotations.GetValueOrDefault(jointIdx, new ()))
                    {
                        constAnimKeys.Add(new animKeyRotation() { Idx = jointIdx, Time = time, Rotation = RQuaternionZupLhs(value), });
                    }
                    foreach (var (time, value) in constKeyTranslations.GetValueOrDefault(jointIdx, new ()))
                    {
                        constAnimKeys.Add(new animKeyPosition() { Idx = jointIdx, Time = time, Position = TRVectorZupLhs(value), });
                    }
                    foreach (var (time, value) in constKeyScales.GetValueOrDefault(jointIdx, new ()))
                    {
                        constAnimKeys.Add(new animKeyScale() { Idx = jointIdx, Time = time, Scale = SVectorZupLhs( value ), });
                    }

                    // For linear keyframes, T and S are always 'raw' but R can optionally be compressed

                    foreach (var (time, value) in keyTranslations.GetValueOrDefault(jointIdx, new ()))
                    {
                        animKeysRaw.Add(new animKeyPosition() { Idx = jointIdx, Time = time, Position = TRVectorZupLhs( value ), });
                    }
                    foreach (var (time, value) in keyScales.GetValueOrDefault(jointIdx, new ()))
                    {
                        animKeysRaw.Add(new animKeyScale() { Idx = jointIdx, Time = time, Scale = SVectorZupLhs(value), });
                    }

                    var preferredStorage = rotationCompressionAllowed ? animKeys : animKeysRaw;

                    foreach (var (time, value) in keyRotations.GetValueOrDefault(jointIdx, new ()))
                    {
                        preferredStorage.Add(new animKeyRotation() { Idx = jointIdx, Time = time, Rotation = RQuaternionZupLhs(value), });
                    }
                }

                // -.-
                var fallbackIndices = extras.FallbackFrameIndices?.Select(_ =>
                    (CUInt16)_
                ).ToList() ?? new List<CUInt16>();

                var constTrackKeys = extras.ConstTrackKeys?.Select<AnimConstTrackKeySerializable, animKeyTrack?>(_ =>
                    new animKeyTrack() {
                        TrackIndex = _.TrackIndex,
                        Time = _.Time,
                        Value = _.Value,
                    }
                ).ToList() ?? new List<animKeyTrack?>();

                var trackKeys = extras.TrackKeys?.Select<AnimTrackKeySerializable, animKeyTrack?>(_ =>
                    new animKeyTrack() {
                        TrackIndex = _.TrackIndex,
                        Time = _.Time,
                        Value = _.Value,
                    }
                ).ToList() ?? new List<animKeyTrack?>();

                // Have all the raw data in hand now, let's mangle it into CR2W


                var compressed = new animAnimationBufferCompressed()
                {
                    Duration = incomingAnim.Duration,
                    NumFrames = FramesToAccommodateDuration(incomingAnim.Duration),
                    NumExtraJoints = extras.NumExtraJoints,
                    NumExtraTracks = extras.NumExtraTracks,
                    NumJoints = Convert.ToUInt16(rig.BoneCount),
                    NumTracks = Convert.ToUInt16(rig.ReferenceTracks?.Length ?? 0),
                    NumConstAnimKeys = Convert.ToUInt32(constAnimKeys.Count),
                    NumAnimKeysRaw = Convert.ToUInt32(animKeysRaw.Count),
                    NumAnimKeys = Convert.ToUInt32(animKeys.Count),
                    NumConstTrackKeys = Convert.ToUInt32(constTrackKeys.Count),
                    NumTrackKeys = Convert.ToUInt32(trackKeys.Count),
                    IsScaleConstant = keyScales.Count + constKeyScales.Count < 1,
                    HasRawRotations = !rotationCompressionAllowed,

                    FallbackFrameIndices = new CArray<CUInt16>(fallbackIndices),

                    // These are internal only, they'll be packed into a buffer...
                    ConstAnimKeys = new (constAnimKeys),
                    AnimKeysRaw = new (animKeysRaw),
                    AnimKeys = new (animKeys),

                    ConstTrackKeys = new (constTrackKeys),
                    TrackKeys = new (trackKeys),

                    TempBuffer = new (),
                };

                // ...specifically TempBuffer, here.
                compressed.WriteBuffer();

                // These could also be written to a single chunk (or fewer chunks)
                // but for now we'll do a chunk per animation.
                //
                // Might have some kind of streaming optimization potential chunk count vs. size?
                compressed.DataAddress.UnkIndex = (uint)newAnimChunks.Count;
                compressed.DataAddress.FsetInBytes = 0;
                compressed.DataAddress.ZeInBytes = compressed.TempBuffer.Buffer.MemSize;

                // For now just dump the data always into `AnimationDataChunk`s,
                // may need to handle `InplaceCompressedBuffer` and `DefferedBuffer` (sic)
                // separately if this doesn't work for those reliably...
                var newAnimDataChunk = new animAnimDataChunk()
                {
                    Buffer = new SerializationDeferredDataBuffer(compressed.TempBuffer.Buffer.GetBytes())
                };

                // Backfill from original where possible, for now
                var oldAnimDesc = oldAnim?.Animation?.Chunk;

                var newAnimDesc = new animAnimation()
                {
                    Name = incomingAnim.Name,
                    AnimBuffer = new(compressed),
                    Duration = incomingAnim.Duration,
                    AnimationType = incomingAnimationType,
                    FrameClamping = extras.FrameClamping,
                    FrameClampingStartFrame = Convert.ToSByte(extras.FrameClampingStartFrame),
                    FrameClampingEndFrame = Convert.ToSByte(extras.FrameClampingEndFrame),
                    MotionExtraction = new((animIMotionExtraction?)(oldAnimDesc?.MotionExtraction?.Chunk?.DeepCopy())),
                };

                // I hate C#
                if (oldAnimDesc != null)
                {
                    newAnimDesc.AdditionalTracks = (animAdditionalFloatTrackContainer)oldAnimDesc.AdditionalTracks.DeepCopy();
                    newAnimDesc.AdditionalTransforms = (animAdditionalTransformContainer)oldAnimDesc.AdditionalTransforms.DeepCopy();
                    newAnimDesc.Tags = (redTagList)oldAnimDesc.Tags.DeepCopy();
                }

                var newAnim = new animAnimSetEntry()
                {
                    Animation = new(newAnimDesc),
                    Events = new((animEventsContainer?)(oldAnim?.Events?.Chunk?.DeepCopy())),
                };

                newAnimChunks.Add(newAnimDataChunk);
                newAnimSetEntries.Add(newAnim);

                importedAnimNames.Add(incomingAnim.Name);
            }

            // Check if there's any animations from the original set that were not in the import
            var originalAnimsNotInImport = originalAnimNames.Except(importedAnimNames).ToList();
            var newAnimsImported = importedAnimNames.Except(originalAnimNames).ToList();
            var updatedAnims = originalAnimNames.Intersect(importedAnimNames).ToList();

            if (originalAnimsNotInImport.Count > 0)
            {
                var originalAnimsToCopy = anims.Animations
                    .Where(_ => originalAnimsNotInImport.Contains(_?.Chunk?.Animation.Chunk?.Name.GetResolvedText()!))
                    .Select(_ => _.Chunk!);

                foreach (var original in originalAnimsToCopy)
                {
                    CopyOldAnim(ref anims, original, ref newAnimSetEntries, ref newAnimChunks);
                    _loggerService.Debug($"{gltfFileName}: keep: `{original.Animation!.Chunk!.Name.GetResolvedText()}`, copied to new animset");
                }
            }

            // If we get this far, can replace the old with the new
            //
            // TODO https://github.com/WolvenKit/WolvenKit/issues/1425
            //      - Actually replace the *entire* old with the new, not just the anims
            anims.AnimationDataChunks = newAnimChunks;
            anims.Animations = newAnimSetEntries;

            if (simdCount > 0)
            {
                _loggerService.Warning($"{gltfFileName}: EXPERIMENTAL: SIMD anims are not fully supported, converted {simdCount} to normal anims. These mostly work ok, but if you have trouble, you can omit them from the animset to keep the existing SIMD versions.");
            }
            if (additiveCount > 0)
            {
                _loggerService.Info($"{gltfFileName}: stripped bind pose transform from all {additiveCount} additive animations");
            }

            _loggerService.Success($"{gltfFileName}: total: {newAnimSetEntries.Count} animations ({updatedAnims.Count} updated, {newAnimsImported.Count} new, {originalAnimsNotInImport.Count} originals kept)");
            return true;
        }

        private static void CopyOldAnim(ref animAnimSet anims, animAnimSetEntry oldAnim, ref CArray<CHandle<animAnimSetEntry>> newAnimSetEntries, ref CArray<animAnimDataChunk> newAnimChunks)
        {
            var copiedAnim = (animAnimSetEntry)oldAnim.DeepCopy();

            // Manually polyed morphs
            var copiedDataAddress = copiedAnim.Animation!.Chunk!.AnimBuffer!.Chunk! switch
                {
                    animAnimationBufferCompressed compressed => compressed.DataAddress,
                    animAnimationBufferSimd simd => simd.DataAddress,
                    _ => throw new Exception("Unexpected animation buffer type"),
                };

            // Need to extract just the part of the old buffer we need
            var oldChunk = anims.AnimationDataChunks[(int)(uint)copiedDataAddress.UnkIndex].Buffer.Buffer;
            var span = oldChunk.GetBytes()[(int)(uint)copiedDataAddress.FsetInBytes..(int)(uint)(copiedDataAddress.FsetInBytes + copiedDataAddress.ZeInBytes)];

            // Individual chonker for every animation
            var newBuffer = new SerializationDeferredDataBuffer(span);
            var newChunk = new animAnimDataChunk() { Buffer = newBuffer, };

            copiedDataAddress.UnkIndex = (uint)newAnimChunks.Count;
            copiedDataAddress.FsetInBytes = 0;
            copiedDataAddress.ZeInBytes = (uint)span.Length;

            // ...Do we need to polE3 morph to set TempBuffer also?

            // Otherwise should be peachy keen now, nobody gonna mess with our buffer...
            newAnimChunks.Add(newChunk);
            newAnimSetEntries.Add(copiedAnim);
        }

        #endregion importanims
    }
}
