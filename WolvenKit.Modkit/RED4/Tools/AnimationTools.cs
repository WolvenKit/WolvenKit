using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.Json;
using SharpGLTF.Schema2;
using SharpGLTF.Validation;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.RED4.Animation;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

using static WolvenKit.RED4.Types.Enums;
using static WolvenKit.Modkit.RED4.Animation.Const;
using static WolvenKit.Modkit.RED4.Animation.Fun;
using static WolvenKit.Modkit.RED4.Animation.Gltf;

using WolvenKit.Common.Model.Arguments;
using WolvenKit.Modkit.RED4.Tools.Common;

using JointsTranslationsAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>>;
using JointsRotationsAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Quaternion>>;
using JointsScalesAtTimes = System.Collections.Generic.Dictionary<ushort, System.Collections.Generic.Dictionary<float, System.Numerics.Vector3>>;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {

#region exportanims

        public bool ExportAnim(CR2WFile animsFile, FileInfo outfile, bool isGLBinary = true, bool additiveAddRelative = true, bool incRootMotion = true, ValidationMode vmode = ValidationMode.TryFix)
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
            GetAnimation(animsFile, result.File!, outfile.Name, ref model, true, additiveAddRelative, incRootMotion);

            model.Save(GLTFHelper.PrepareFilePath(outfile.FullName, isGLBinary), new WriteSettings(vmode));

            return true;
        }

        public bool GetAnimation(CR2WFile animsFile, CR2WFile rigFile, string animsFileName, ref ModelRoot gltfModel, bool includeRig = true, bool additiveAddRelative = true, bool incRootMotion = true)
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
                var skin = gltfModel.CreateSkin("Armature");
                skin.BindJoints(RIG.ExportNodes(ref gltfModel, rig).Values.ToArray());
            }

            var gltfSkin = gltfModel.LogicalSkins.FirstOrDefault(_ => _.Name is "Armature");
            ArgumentNullException.ThrowIfNull(gltfSkin);

            var rigFileName = anims.Rig.DepotPath.GetResolvedText() ?? "<unknown rig depotpath??>";
            _loggerService.Info($"{animsFileName}: Found {anims.Animations.Count} animations to export, using rig {rigFileName}");

            _loggerService.Info($"{animsFileName}: Root motion export: {(incRootMotion ? "enabled" : "disabled")}");

            var stats = new
            {
                AdditiveAnims = 0,
                RootMotions = 0,
                RootMotionConflicts = 0,
                SimdAnims = 0,
            };

            foreach (var anim in anims.Animations)
            {
                ArgumentNullException.ThrowIfNull(anim.Chunk);
                ArgumentNullException.ThrowIfNull(anim.Chunk.Animation.Chunk);

                var animAnimDes = anim.Chunk.Animation.Chunk;

                stats = stats with {
                    AdditiveAnims = stats.AdditiveAnims + (animAnimDes.AnimationType == animAnimationType.Normal ? 0 : 1),
                };

                // Buffer decoding

                AnimationBufferData bufferData;

                if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferSimd animBuffSimd)
                {
                    stats = stats with { SimdAnims = stats.SimdAnims + 1 };

                    SIMD.DecodeSimdAnimationData(out bufferData, ref gltfModel, ref animBuffSimd, ref animDataBuffers, animAnimDes.Name!, animAnimDes, _loggerService);
                }
                else if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferCompressed)
                {
                    CompressedBuffer.DecodeAnimationData(out bufferData, animAnimDes, _loggerService);
                }
                else
                {
                    throw new InvalidDataException("Unsupported animation buffer type, can't proceed!");
                }

                // Root motion

                JointsTranslationsAtTimes rootMotionTranslations = [];
                JointsRotationsAtTimes rootMotionRotations = [];

                var motionEx = animAnimDes.MotionExtraction?.Chunk;

                var rootMotionType = incRootMotion
                    ? ROOT_MOTION.DecodeRootMotion(out rootMotionTranslations, out rootMotionRotations, ref motionEx, _loggerService)
                    : RootMotionType.Unknown;

                if (rootMotionType is not RootMotionType.None and not RootMotionType.Unknown)
                {
                    stats = stats with { RootMotions = stats.RootMotions + 1 };

                    bufferData.ConstTranslations.TryGetValue(RootJointIndex, out var rootCTs);
                    bufferData.ConstRotations.TryGetValue(RootJointIndex, out var rootCRs);
                    bufferData.ConstScales.TryGetValue(RootJointIndex, out var rootCSs);
                    bufferData.Translations.TryGetValue(RootJointIndex, out var rootTs);
                    bufferData.Rotations.TryGetValue(RootJointIndex, out var rootRs);
                    bufferData.Scales.TryGetValue(RootJointIndex,out var rootSs);

                    rootMotionTranslations.TryGetValue(RootJointIndex, out var rmRootTranslations);
                    rootMotionRotations.TryGetValue(RootJointIndex, out var rmRootRotations);

                    if (rootMotionTranslations.Count > 1 || (rootMotionTranslations.Count == 1 && rmRootTranslations is null) ||
                        rootMotionRotations.Count > 1 || (rootMotionRotations.Count == 1 && rmRootRotations is null))
                    {
                        // One of the RM encodings leaves this possibility open
                        _loggerService.Warning($"{animsFileName}: {animAnimDes.Name}: Root Motion encoded in joints outside `root` joint {RootJointIndex}! Only `root` RM will be exported.");
                    }
                    if (rootCTs?.Count > 0 || rootCRs?.Count > 0 || rootCSs?.Count > 0 || rootTs?.Count > 0 || rootRs?.Count > 0 || rootSs?.Count > 0)
                    {
                        _loggerService.Debug($"{animsFileName}: {animAnimDes.Name}: Ignoring non-Root Motion root joint transforms.");
                        stats = stats with { RootMotionConflicts = stats.RootMotionConflicts + 1 };
                    }

                    bufferData.ConstTranslations.Remove(RootJointIndex);
                    bufferData.ConstRotations.Remove(RootJointIndex);
                    bufferData.ConstScales.Remove(RootJointIndex);

                    bufferData.Translations.Remove(RootJointIndex);
                    bufferData.Rotations.Remove(RootJointIndex);
                    bufferData.Scales.Remove(RootJointIndex);

                    // Root Motion only ever has T/R, as seen above
                    bufferData.Translations.Add(RootJointIndex, rmRootTranslations ?? []);
                    bufferData.Rotations.Add(RootJointIndex, rmRootRotations ?? []);
                }

                // All the data is gathered, time to encode it into glTF

                var gltfAnim = gltfModel.CreateAnimation(animAnimDes.Name);

                // TODO: https://github.com/WolvenKit/WolvenKit/issues/1630 Scale handling review
                var exportAdditiveToBind = additiveAddRelative && animAnimDes.AnimationType != animAnimationType.Normal;

                for (ushort jointIdx = 0; jointIdx < bufferData.JointsCountActual; jointIdx++)
                {
                    var node = gltfSkin.GetJoint(jointIdx).Joint;

                    // We *could* do some heuristics to see if we have essentially 0 translations, but for now..
                    var jointLocalTranslation = node.LocalTransform.Translation;
                    // ...just in case these two have been stored non-normalized
                    var jointLocalRotation = RQuaternionNormalize(node.LocalTransform.Rotation);
                    var jointLocalScale = SVectorNormalize(node.LocalTransform.Scale);

                    bufferData.ConstTranslations.TryGetValue(jointIdx, out var jointConstTranslations);
                    bufferData.ConstRotations.TryGetValue(jointIdx, out var jointConstRotations);
                    bufferData.ConstScales.TryGetValue(jointIdx, out var jointConstScales);
                    bufferData.Translations.TryGetValue(jointIdx, out var jointTranslations);
                    bufferData.Rotations.TryGetValue(jointIdx, out var jointRotations);
                    bufferData.Scales.TryGetValue(jointIdx, out var jointScales);
                    
                    var (hasTranslationsToExport, translationConflict, exportTranslations, translationInterpolation) = (jointTranslations ?? [], jointConstTranslations ?? []) switch {
                        ({Count: >= 1} linear, {Count: >= 1} step) => (true, true, linear, GLTF_SAMPLER_LINEAR),
                        ({Count: >= 1} linear, {Count: 0} step) => (true, false, linear, GLTF_SAMPLER_LINEAR),
                        ({Count: 0} linear, {Count: >= 1} step) => (true, false, step, GLTF_SAMPLER_CONST),
                        _ => (false, false, [], GLTF_SAMPLER_CONST),
                    };
                    
                    var (hasRotationsToExport, rotationConflict, exportRotations, rotationInterpolation) = (jointRotations ?? [], jointConstRotations ?? []) switch {
                        ({Count: >= 1} linear, {Count: >= 1} step) => (true, true, linear, GLTF_SAMPLER_LINEAR),
                        ({Count: >= 1} linear, {Count: 0} step) => (true, false, linear, GLTF_SAMPLER_LINEAR),
                        ({Count: 0} linear, {Count: >= 1} step) => (true, false, step, GLTF_SAMPLER_CONST),
                        _ => (false, false, [], GLTF_SAMPLER_CONST),
                    };
                    
                    var (hasScalesToExport, scaleConflict, exportScales, scaleInterpolation) = (jointScales ?? [], jointConstScales ?? []) switch {
                        ({Count: >= 1} linear, {Count: >= 1} step) => (true, true, linear, GLTF_SAMPLER_LINEAR),
                        ({Count: >= 1} linear, {Count: 0} step) => (true, false, linear, GLTF_SAMPLER_LINEAR),
                        ({Count: 0} linear, {Count: >= 1} step) => (true, false, step, GLTF_SAMPLER_CONST),
                        _ => (false, false, [], GLTF_SAMPLER_CONST),
                    };

                    if (translationConflict || rotationConflict || scaleConflict)
                    {
                        _loggerService.Warning($"{animsFileName}: {animAnimDes.Name}: {node.Name} ({jointIdx}): Joint has both LINEAR and STEP transforms! Only exporting LINEAR.");
                    }

                    if (hasTranslationsToExport)
                    {
                        gltfAnim.CreateTranslationChannel(
                            node,
                            exportAdditiveToBind
                                ? exportTranslations.Select((t) => (t.Key, jointLocalTranslation + t.Value)).ToDictionary()
                                : exportTranslations,
                            translationInterpolation
                        );
                    }

                    if (hasRotationsToExport)
                    {
                        gltfAnim.CreateRotationChannel(
                            node,
                            exportAdditiveToBind
                                ? exportRotations.Select((t) => (t.Key, RQuaternionNormalize(jointLocalRotation * t.Value))).ToDictionary()
                                : exportRotations,
                            rotationInterpolation
                        );
                    }

                    if (hasScalesToExport)
                    {
                        gltfAnim.CreateScaleChannel(
                            node,
                            exportAdditiveToBind
                                ? exportScales.Select((t) => (t.Key, SVectorNormalize(jointLocalScale * t.Value))).ToDictionary()
                                : exportScales,
                            scaleInterpolation
                        );
                    }
                }

                // glTF doesn't support everything we need for anims, so stuff it in extras

                var animExtras = new AnimationExtrasForGltf {
                    Schema = CurrentSchema(),
                    AnimationType = animAnimDes.AnimationType.ToString(),
                    RootMotionType = rootMotionType.ToString(),
                    FrameClamping = animAnimDes.FrameClamping,
                    FrameClampingStartFrame = animAnimDes.FrameClampingStartFrame,
                    FrameClampingEndFrame = animAnimDes.FrameClampingEndFrame,
                    NumExtraJoints = bufferData.NumExtraJoints,
                    NumExtraTracks = bufferData.NumExtraTracks,
                    ConstTrackKeys = bufferData.ConstTrackKeys,
                    TrackKeys = bufferData.TrackKeys,
                    FallbackFrameIndices = bufferData.FallbackFrameIndices,
                    OptimizationHints = new AnimationOptimizationHints {
                        PreferSIMD = bufferData.IsSimd,
                        MaxRotationCompression = bufferData.CompressionUsed,
                    },
                };

                // -.-
                //
                // TODO https://github.com/WolvenKit/WolvenKit/issues/1693 Anime JSON Format Cleanup if and when SharpGLTF Updates
                //
                // Can switch to system Json when SharpGLTF support released (maybe in .31)
                // Right now it's not possible to add an empty array to a JsonContent.
                // Can work around that elsewhere but... just don't implement your own
                // JSON parser, kids.
                gltfAnim.Extras = JsonSerializer.SerializeToNode(animExtras);
            }

            if (stats.RootMotionConflicts > 0)
            {
                _loggerService.Warning($"{animsFileName}: {stats.RootMotionConflicts} animations had regular root joint transforms in addition to Root Motion. Only exporting Root Motion. Re-importing with Root Motion will delete the non-RM. This is probably correct, but you can additionally export without Root Motion to get the regular transforms.");
            }
            if (stats.SimdAnims > 0)
            {
                _loggerService.Info($"{animsFileName}: Exported {stats.SimdAnims} SIMD animations. They can only be imported back as regular animations, so you may want to simplify them when editing, or omit them from the re-import to keep the old ones."); 
            }
            if (stats.AdditiveAnims > 0)
            {
                if (additiveAddRelative)
                {
                    _loggerService.Info($"{animsFileName}: Exported {stats.AdditiveAnims} additive animations added on top of the local transform.");
                }
                else
                {
                    _loggerService.Info($"{animsFileName}: {stats.AdditiveAnims} additive anims exported as-is, without relative local transform.");
                }
            }

            return true;
        }

#endregion exportanims

#region importanims

        public bool ImportAnims(FileInfo gltfFile, Stream animStream, GltfImportArgs importArgs)
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

            var maybeRig = RIG.ProcessRig(result.File!);
            if (maybeRig is null || maybeRig.BoneCount < 1)
            {
                _loggerService.Error($"{gltfFileName}: couldn't process rig from {rigFileName}, can't import anims!");
                return false;
            }
            RawArmature rig = maybeRig;

            var model = ModelRoot.Load(gltfFile.FullName, new ReadSettings(ValidationMode.TryFix));

            if (model.LogicalAnimations.Count < 1)
            {
                _loggerService.Error($"No animations found in {gltfFileName}!");
                return false;
            }

            PutAnimations(ref anims, ref rig, ref model, gltfFileName, rigFileName, importArgs);

            var outMs = new MemoryStream();
            using var writer = new CR2WWriter(outMs, Encoding.UTF8, true) { LoggerService = _loggerService };
            writer.WriteFile(animsArchive);

            outMs.Seek(0, SeekOrigin.Begin);
            animStream.SetLength(0);
            outMs.CopyTo(animStream);

            return true;

        }


        private bool PutAnimations(ref animAnimSet anims, ref RawArmature rig, ref ModelRoot model, string gltfFileName, string rigFileName, GltfImportArgs importArgs)
        {
            _loggerService.Info($"{gltfFileName}: found {model.LogicalAnimations.Count} animations to import");

            var stats = new {
                Additives = 0,
                AdditivesStripped = 0,
                RootMotions = 0,
                RootTransformsStripped = 0,
                SIMDs = 0,
            };

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

                // Prep and metadata

                if (incomingAnim.Extras is null)
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

                var incomingAnimationType = (animAnimationType)Enum.Parse(typeof(animAnimationType), extras.AnimationType);

                var stripLocalFromAdditives = incomingAnimationType != animAnimationType.Normal &&
                                              importArgs.AdditiveStripLocalTransform;

                stats = stats with {
                    Additives = incomingAnimationType != animAnimationType.Normal ? stats.Additives + 1 : stats.Additives,
                    AdditivesStripped = stripLocalFromAdditives ? stats.AdditivesStripped + 1 : stats.AdditivesStripped,
                    SIMDs = extras.OptimizationHints.PreferSIMD ? stats.SIMDs + 1 : stats.SIMDs,
                };

                // Ok, process incoming data

                var keyframeTranslations = new Dictionary<AnimationInterpolationMode, JointsTranslationsAtTimes> {
                    [AnimationInterpolationMode.STEP] = [],
                    [AnimationInterpolationMode.LINEAR] = []
                };

                var keyframeRotations = new Dictionary<AnimationInterpolationMode, JointsRotationsAtTimes> {
                    [AnimationInterpolationMode.STEP] = [],
                    [AnimationInterpolationMode.LINEAR] = [],
                };

                var keyframeScales = new Dictionary<AnimationInterpolationMode, JointsScalesAtTimes> {
                    [AnimationInterpolationMode.STEP] = [],
                    [AnimationInterpolationMode.LINEAR] = [],
                };

                foreach (var chan in incomingAnim.Channels)
                {
                    var jointIdx = Array.IndexOf(rig.Names.NotNull(), chan.TargetNode.Name);
                    if (jointIdx < 0)
                    {
                        throw new Exception($"{gltfFileName} ${incomingAnim.Name}: Invalid Joint Transform, glTF joint {chan.TargetNode.Name} not present in the associated rig {rigFileName}");
                    }

                    switch (chan.TargetNodePath)
                    {
                        case PropertyPath.translation:
                            var translationSampler = chan.GetTranslationSampler();
                            var typedTranslations = keyframeTranslations[translationSampler.InterpolationMode] ?? throw new Exception($"{gltfFileName} ${incomingAnim.Name}: Unsupported interpolation mode {translationSampler.InterpolationMode}!");

                            var localTranslation = chan.TargetNode.LocalTransform.Translation;

                            var translations = stripLocalFromAdditives
                                ?  translationSampler.GetLinearKeys().Select(_ => (_.Key, _.Value - localTranslation)).ToDictionary()
                                : translationSampler.GetLinearKeys().ToDictionary();

                            typedTranslations.Add((ushort)jointIdx, translations);
                            break;

                        case PropertyPath.rotation:
                            var rotationSampler = chan.GetRotationSampler();
                            var typedRotations = keyframeRotations[rotationSampler.InterpolationMode] ?? throw new Exception($"{gltfFileName} ${incomingAnim.Name}: Unsupported interpolation mode {rotationSampler.InterpolationMode}!");

                            var localRotation = RQuaternionNormalize(chan.TargetNode.LocalTransform.Rotation);

                            var rotations = stripLocalFromAdditives
                                ? rotationSampler.GetLinearKeys().Select(_ => (_.Key, RQuaternionNormalize(RQuaternionNormalize(_.Value) / localRotation))).ToDictionary()
                                : rotationSampler.GetLinearKeys().Select(_ => (_.Key, RQuaternionNormalize(_.Value))).ToDictionary();

                            typedRotations.Add((ushort)jointIdx, rotations);
                            break;

                        case PropertyPath.scale:
                            var scaleSampler = chan.GetScaleSampler();
                            var typedScales = keyframeScales[scaleSampler.InterpolationMode] ?? throw new Exception($"{gltfFileName} ${incomingAnim.Name}: Unsupported interpolation mode {scaleSampler.InterpolationMode}!");

                            var localScale = SVectorNormalize(chan.TargetNode.LocalTransform.Scale);

                            var scales = stripLocalFromAdditives
                                ? scaleSampler.GetLinearKeys().Select(_ =>
                                    (_.Key, Value: SVectorNormalize(SVectorNormalize(_.Value) / localScale))).ToDictionary()
                                : scaleSampler.GetLinearKeys().Select(_ => (_.Key, Value: SVectorNormalize(_.Value))).ToDictionary();

                            typedScales.Add((ushort)jointIdx, scales);
                            break;

                        case PropertyPath.weights:
                            // Fallthrough, no morph anims yet
                        default:
                            throw new Exception($"{gltfFileName} ${incomingAnim.Name}: Unsupported channel target {chan.TargetNodePath}!");
                    }
                }
  
                // ROOT MOTION

                // TODO https://github.com/WolvenKit/WolvenKit/issues/1752 Full Entity Update Support (Model, Rig, Anims, Ent...)
                //      For now we just use the rig data, but this should be updated properly.
                var numJoints = Convert.ToUInt16(rig.BoneCount);
                var numExtraJoints = extras.NumExtraJoints;
                var jointsCountActual = Convert.ToUInt16(numJoints - numExtraJoints);
                var numTracks = Convert.ToUInt16(rig.ReferenceTracks?.Length ?? 0);
                var numExtraTracks = extras.NumExtraTracks;
                var tracksCountActual = Convert.ToUInt16(numTracks - numExtraTracks);

                // Have all the raw data in hand now, let's mangle it into CR2W

                // For now just dump the data always into `AnimationDataChunk`s, it seems
                // to work okay regardless of the original buffer type — but presumably those
                // exist for a reason, so it may be necessary to add support.

                // Currently SIMD not supported

                var incomingAnimData = new AnimationBufferData {
                    Duration = incomingAnim.Duration,
                    FrameCount = FramesToAccommodateDuration(incomingAnim.Duration),
                    Translations = keyframeTranslations[AnimationInterpolationMode.LINEAR],
                    ConstTranslations = keyframeTranslations[AnimationInterpolationMode.STEP],
                    Rotations = keyframeRotations[AnimationInterpolationMode.LINEAR],
                    ConstRotations = keyframeRotations[AnimationInterpolationMode.STEP],
                    Scales = keyframeScales[AnimationInterpolationMode.LINEAR],
                    ConstScales = keyframeScales[AnimationInterpolationMode.STEP],
                    TrackKeys = extras.TrackKeys ?? [],
                    ConstTrackKeys = extras.ConstTrackKeys ?? [],
                    FallbackFrameIndices = extras.FallbackFrameIndices ?? [],
                    NumJoints = numJoints,
                    NumExtraJoints = numExtraJoints,
                    JointsCountActual = jointsCountActual,
                    NumTracks = numTracks,
                    NumExtraTracks = numExtraTracks,
                    TracksCountActual = tracksCountActual,
                    IsSimd = false,
                    CompressionUsed = extras.OptimizationHints.MaxRotationCompression,
                };

                // Backfill from original where we must, for now
                var oldAnimDesc = oldAnim?.Animation?.Chunk;

                // Sneak out Root Motion
                var incomingRootMotionType = (RootMotionType)Enum.Parse(typeof(RootMotionType), extras.RootMotionType);
                var (rootMotionType, rootTransformsStripped) = ROOT_MOTION.ExtractRootMotion(out var rootMotion, ref incomingAnimData, ref oldAnimDesc, incomingRootMotionType, incomingAnim.Name, _loggerService);

                stats = stats with {
                        RootMotions = (rootMotionType is RootMotionType.None or RootMotionType.Unknown) ? stats.RootMotions : stats.RootMotions + 1,
                        RootTransformsStripped = rootTransformsStripped ? stats.RootTransformsStripped + 1 : stats.RootTransformsStripped
                    };

                // These could also be written to a single chunk (or fewer chunks)
                // but for now we'll do a chunk per animation.
                //
                // Might have some kind of streaming optimization potential chunk count vs. size?
                var chunkDataAddress = new animAnimDataAddress {
                    UnkIndex = (uint)newAnimChunks.Count,
                    FsetInBytes = 0,
                    ZeInBytes = 0,
                };

                CompressedBuffer.EncodeAnimationData(out var newAnimDataChunk, out var newCompressedBuffer, ref incomingAnimData, chunkDataAddress, _loggerService);

                var newAnimDesc = new animAnimation()
                {
                    Name = incomingAnim.Name,
                    AnimBuffer = new(newCompressedBuffer),
                    Duration = incomingAnimData.Duration,
                    AnimationType = incomingAnimationType,
                    FrameClamping = extras.FrameClamping,
                    FrameClampingStartFrame = Convert.ToSByte(extras.FrameClampingStartFrame),
                    FrameClampingEndFrame = Convert.ToSByte(extras.FrameClampingEndFrame),
                    MotionExtraction = new(rootMotion),
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

            if (stats.SIMDs > 0)
            {
                _loggerService.Warning($"{gltfFileName}: Encoding: SIMD anims are not fully supported, converted {stats.SIMDs} to normal anims. These mostly work ok, but if you have trouble, you can omit them from the animset to keep the existing SIMD versions.");
            }
            if (stats.AdditivesStripped > 0)
            {
                _loggerService.Info($"{gltfFileName}: Additive: stripped local transform from all {stats.AdditivesStripped} additive animations");
            }
            if (stats.Additives != stats.AdditivesStripped)
            {
                _loggerService.Warning($"{gltfFileName}: Additive: additive animations present but were not stripped of local transform, make sure this is what you want");
            }
            if (stats.RootMotions > 0)
            {
                _loggerService.Info($"{gltfFileName}: Root Motion: {stats.RootMotions} animations with Root Motion extracted.");
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
                    // TODO https://github.com/WolvenKit/WolvenKit/issues/1660
                    //      Implement Copying for Anime InplaceBuffers and Direct SerializedBuffers.
                    //      Can steal code from export, but better to refactor it properly.
                    _ => throw new Exception("Unexpected animation buffer type"),
                };
            var inplaceBuffer = copiedAnim.Animation!.Chunk!.AnimBuffer!.Chunk! switch
                {
                    animAnimationBufferCompressed compressed => compressed.InplaceCompressedBuffer,
                    animAnimationBufferSimd simd => simd.InplaceCompressedBuffer,
                    _ => throw new Exception("Unexpected animation buffer type"),
                };
            // Need to extract just the part of the old buffer we need
            var oldChunk = inplaceBuffer == null ? anims.AnimationDataChunks[(int)(uint)copiedDataAddress.UnkIndex].Buffer.Buffer : inplaceBuffer.Buffer;
            var span =  inplaceBuffer == null ? oldChunk.GetBytes()[(int)(uint)copiedDataAddress.FsetInBytes..(int)(uint)(copiedDataAddress.FsetInBytes + copiedDataAddress.ZeInBytes)] : oldChunk.GetBytes();
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
