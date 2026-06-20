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
                var rigExtras = new
                {
                    rigPath = anims.Rig.DepotPath.GetResolvedText(),
                    boneNames = rig.Names,
                    boneParentIndexes = rig.Parent,
                    trackNames = rig.TrackNames 
                };

                skin.Extras = JsonSerializer.SerializeToNode(rigExtras, Gltf.SerializationOptions());

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
                        SimdQuantizationBits = bufferData.SimdQuantizationBits,
                    },
                    AnimEvents = SerializeAnimEvents(anim.Chunk),
                };

                // -.-
                //
                // TODO https://github.com/WolvenKit/WolvenKit/issues/1693 Anime JSON Format Cleanup if and when SharpGLTF Updates
                //
                // Can switch to system Json when SharpGLTF support released (maybe in .31)
                // Right now it's not possible to add an empty array to a JsonContent.
                // Can work around that elsewhere but... just don't implement your own
                // JSON parser, kids.
                gltfAnim.Extras = JsonSerializer.SerializeToNode(animExtras, Gltf.SerializationOptions());
            }

            if (stats.RootMotionConflicts > 0)
            {
                _loggerService.Warning($"{animsFileName}: {stats.RootMotionConflicts} animations had regular root joint transforms in addition to Root Motion. Only exporting Root Motion. Re-importing with Root Motion will delete the non-RM. This is probably correct, but you can additionally export without Root Motion to get the regular transforms.");
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
                    IsSimd = extras.OptimizationHints.PreferSIMD && !importArgs.ForceCompressedEncoding,
                    CompressionUsed = extras.OptimizationHints.MaxRotationCompression,
                    SimdQuantizationBits = extras.OptimizationHints.SimdQuantizationBits,
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

                animAnimDataChunk newAnimDataChunk;
                animIAnimationBuffer newAnimBuffer;

                if (incomingAnimData.IsSimd)
                {
                    SIMDEncoder.EncodeSimdAnimationData(out newAnimDataChunk, out var newSimdBuffer, in incomingAnimData, chunkDataAddress, _loggerService);
                    newAnimBuffer = newSimdBuffer;
                }
                else
                {
                    CompressedBuffer.EncodeAnimationData(out newAnimDataChunk, out var newCompressedBuffer, in incomingAnimData, chunkDataAddress, _loggerService);
                    newAnimBuffer = newCompressedBuffer;
                }

                var newAnimDesc = new animAnimation()
                {
                    Name = incomingAnim.Name,
                    AnimBuffer = new(newAnimBuffer),
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
                    Events = new(BuildEventsContainer(extras.AnimEvents, oldAnim?.Events?.Chunk)),
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
                if (importArgs.ForceCompressedEncoding)
                {
                    _loggerService.Warning($"{gltfFileName}: Encoding: Force Compressed enabled, converted {stats.SIMDs} SIMD anims to Compressed format.");
                }
                else
                {
                    _loggerService.Success($"{gltfFileName}: Encoding: {stats.SIMDs} animations encoded as SIMD buffers.");
                }
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

        #region animEventHelpers

        /// <summary>
        /// Serialize animation events from an animAnimSetEntry into glTF-friendly records.
        /// </summary>
        private static List<AnimEventSerializable>? SerializeAnimEvents(animAnimSetEntry animSetEntry)
        {
            var eventsContainer = animSetEntry.Events?.Chunk;
            if (eventsContainer == null || eventsContainer.Events.Count == 0)
            {
                return null;
            }

            var animEvents = new List<AnimEventSerializable>();
            foreach (var handle in eventsContainer.Events)
            {
                var evt = handle.Chunk;
                if (evt == null) continue;
                animEvents.Add(ConvertEventToSerializable(evt));
            }
            return animEvents.Count > 0 ? animEvents : null;
        }

        /// <summary>
        /// Convert a single animAnimEvent to its serializable representation.
        /// </summary>
        private static AnimEventSerializable ConvertEventToSerializable(animAnimEvent evt)
        {
            var type = evt switch
            {
                animAnimEvent_Sound => "Sound",
                animAnimEvent_SoundFromEmitter => "SoundFromEmitter",
                animAnimEvent_Effect => "Effect",
                animAnimEvent_EffectDuration => "EffectDuration",
                animAnimEvent_ItemEffect => "ItemEffect",
                animAnimEvent_ItemEffectDuration => "ItemEffectDuration",
                animAnimEvent_Simple => "Simple",
                _ => evt.GetType().Name.Replace("animAnimEvent_", "")
            };

            Dictionary<string, string>? switches = null;
            Dictionary<string, float>? parameters = null;
            List<AnimEventParamCurve>? paramCurves = null;
            List<string>? dynamicParams = null;
            string? metadataContext = null, onlyPlayOn = null, dontPlayOn = null;
            string? playerGenderAlt = null, emitterName = null, effectName = null;
            uint? sequenceShift = null;
            bool? breakAllLoopsOnStop = null;
            // Phase 6 fields
            float? eventValue = null;
            string? actionName = null, boneName = null, facialAnimName = null;
            string? leg = null, footPhase = null, voContext = null;
            bool? isQuest = null;
            string? side = null, customEvent = null;
            List<WorkspotActionSerializable>? workspotActions = null;

            if (evt is animAnimEvent_Sound sound)
            {
                switches = sound.Switches?.Count > 0
                    ? sound.Switches.ToDictionary(
                        s => s.Name.GetResolvedText() ?? "",
                        s => s.Value.GetResolvedText() ?? "")
                    : null;
                parameters = sound.Params?.Count > 0
                    ? sound.Params.ToDictionary(
                        p => p.Name.GetResolvedText() ?? "",
                        p => (float)p.Value)
                    : null;
                paramCurves = sound.Params?.Count > 0
                    ? sound.Params.Select(p => new AnimEventParamCurve(
                        p.Name.GetResolvedText() ?? "",
                        (float)p.Value,
                        p.EnterCurveType.ToString(),
                        (float)p.EnterCurveTime,
                        p.ExitCurveType.ToString(),
                        (float)p.ExitCurveTime
                    )).ToList()
                    : null;
                dynamicParams = sound.DynamicParams?.Count > 0
                    ? sound.DynamicParams.Select(d => d.GetResolvedText() ?? "").ToList()
                    : null;
                metadataContext = sound.MetadataContext.GetResolvedText();
                onlyPlayOn = sound.OnlyPlayOn.GetResolvedText();
                dontPlayOn = sound.DontPlayOn.GetResolvedText();
                playerGenderAlt = sound.PlayerGenderAlt.ToString();
            }
            else if (evt is animAnimEvent_SoundFromEmitter emitter)
            {
                emitterName = emitter.EmitterName.GetResolvedText();
            }
            else if (evt is animAnimEvent_EffectDuration effectDuration)
            {
                effectName = effectDuration.EffectName.GetResolvedText();
                sequenceShift = effectDuration.SequenceShift;
                breakAllLoopsOnStop = effectDuration.BreakAllLoopsOnStop;
            }
            else if (evt is animAnimEvent_ItemEffectDuration itemEffectDuration)
            {
                effectName = itemEffectDuration.EffectName.GetResolvedText();
                sequenceShift = itemEffectDuration.SequenceShift;
                breakAllLoopsOnStop = itemEffectDuration.BreakAllLoopsOnStop;
            }
            else if (evt is animAnimEvent_ItemEffect itemEffect)
            {
                effectName = itemEffect.EffectName.GetResolvedText();
            }
            else if (evt is animAnimEvent_Effect effect)
            {
                effectName = effect.EffectName.GetResolvedText();
            }
            else if (evt is animAnimEvent_Valued valued)
            {
                eventValue = (float)valued.Value;
            }
            else if (evt is animAnimEvent_FoleyAction foley)
            {
                actionName = foley.ActionName.GetResolvedText();
            }
            else if (evt is animAnimEvent_SceneItem sceneItem)
            {
                boneName = sceneItem.BoneName.GetResolvedText();
            }
            else if (evt is animAnimEvent_WorkspotPlayFacialAnim facial)
            {
                facialAnimName = facial.FacialAnimName.GetResolvedText();
            }
            else if (evt is animAnimEvent_FootIK footIk)
            {
                leg = footIk.Leg.ToString();
            }
            else if (evt is animAnimEvent_FootPhase footPhaseEvt)
            {
                footPhase = footPhaseEvt.Phase.ToString();
            }
            else if (evt is animAnimEvent_GameplayVo gameplayVo)
            {
                voContext = gameplayVo.VoContext.GetResolvedText();
                isQuest = gameplayVo.IsQuest;
            }
            else if (evt is animAnimEvent_FootPlant footPlant)
            {
                side = footPlant.Side.ToString();
                customEvent = footPlant.CustomEvent.GetResolvedText();
            }
            else if (evt is animAnimEvent_WorkspotItem workspotItem)
            {
                workspotActions = SerializeWorkspotActions(workspotItem.Actions);
            }

            return new AnimEventSerializable(
                type,
                evt.EventName.GetResolvedText() ?? "",
                evt.StartFrame,
                evt.DurationInFrames,
                switches,
                parameters,
                paramCurves,
                dynamicParams,
                metadataContext,
                onlyPlayOn,
                dontPlayOn,
                playerGenderAlt,
                emitterName,
                effectName,
                sequenceShift,
                breakAllLoopsOnStop,
                eventValue,
                actionName,
                boneName,
                facialAnimName,
                leg,
                footPhase,
                voContext,
                isQuest,
                side,
                customEvent,
                workspotActions
            );
        }

        /// <summary>
        /// Build an animEventsContainer from serialized events, merging with originals
        /// to preserve subclass-specific fields for event types we don't fully serialize.
        /// Falls back to deep-copy from original when no events in glTF.
        /// </summary>
        private static animEventsContainer? BuildEventsContainer(
            List<AnimEventSerializable>? serializedEvents,
            animEventsContainer? fallback)
        {
            // No events in glTF — fall back to deep-copy from original (backwards compat)
            if (serializedEvents == null || serializedEvents.Count == 0)
            {
                return (animEventsContainer?)fallback?.DeepCopy();
            }

            // Build a consumable list of original events for matching uncovered types
            var originals = new List<animAnimEvent>();
            if (fallback != null)
            {
                foreach (var handle in fallback.Events)
                {
                    if (handle.Chunk != null)
                        originals.Add(handle.Chunk);
                }
            }

            var container = new animEventsContainer();
            foreach (var se in serializedEvents)
            {
                animAnimEvent evt;

                if (IsFullySerializedType(se.Type))
                {
                    // Types we can reconstruct perfectly from glTF data
                    evt = ConvertSerializableToEvent(se);
                }
                else
                {
                    // Uncovered type — try to find matching original to preserve subclass fields
                    var matchIdx = originals.FindIndex(o =>
                        (o.EventName.GetResolvedText() ?? "") == se.EventName &&
                        GetEventTypeName(o) == se.Type);

                    if (matchIdx >= 0)
                    {
                        // Deep-copy original (preserves all subclass fields), update base fields
                        evt = (animAnimEvent)originals[matchIdx].DeepCopy();
                        evt.EventName = se.EventName;
                        evt.StartFrame = se.StartFrame;
                        evt.DurationInFrames = se.DurationInFrames;
                        originals.RemoveAt(matchIdx); // consume to handle duplicates
                    }
                    else
                    {
                        // New event of unknown type with no original match — best effort
                        evt = ConvertSerializableToEvent(se);
                    }
                }

                container.Events.Add(evt);
            }

            return container;
        }

        /// <summary>
        /// Returns true for event types where we serialize ALL fields to glTF,
        /// meaning we can reconstruct them perfectly without the original.
        /// </summary>
        private static bool IsFullySerializedType(string type) => type is
            "Sound" or "SoundFromEmitter" or "Effect" or "EffectDuration" or
            "ItemEffect" or "ItemEffectDuration" or
            // Base-only types (no subclass fields to lose):
            "Simple" or "SimpleDuration" or "Phase" or "KeyPose" or
            "ForceRagdoll" or "Slide" or "SafeCut" or
            "WorkspotFastExitCutoff" or "TrajectoryAdjustment" or
            // Phase 6 — fully serialized with subclass fields:
            "Valued" or "FoleyAction" or "SceneItem" or "WorkspotPlayFacialAnim" or
            "FootIK" or "FootPhase" or "GameplayVo" or "FootPlant" or "WorkspotItem";

        /// <summary>
        /// Get the serializable type name for an animAnimEvent instance.
        /// </summary>
        private static string GetEventTypeName(animAnimEvent evt) => evt switch
        {
            animAnimEvent_Sound => "Sound",
            animAnimEvent_SoundFromEmitter => "SoundFromEmitter",
            animAnimEvent_Effect => "Effect",
            animAnimEvent_EffectDuration => "EffectDuration",
            animAnimEvent_ItemEffect => "ItemEffect",
            animAnimEvent_ItemEffectDuration => "ItemEffectDuration",
            animAnimEvent_Simple => "Simple",
            _ => evt.GetType().Name.Replace("animAnimEvent_", "")
        };

        /// <summary>
        /// Convert a serialized event record back to a RED4 animAnimEvent instance.
        /// </summary>
        private static animAnimEvent ConvertSerializableToEvent(AnimEventSerializable se)
        {
            animAnimEvent evt = se.Type switch
            {
                "Sound" => BuildSoundEvent(se),
                "SoundFromEmitter" => BuildSoundFromEmitterEvent(se),
                "Effect" => BuildEffectEvent(se),
                "EffectDuration" => BuildEffectDurationEvent(se),
                "ItemEffect" => BuildItemEffectEvent(se),
                "ItemEffectDuration" => BuildItemEffectDurationEvent(se),
                // Phase 6 — types with subclass fields we now fully serialize:
                "Valued" => BuildValuedEvent(se),
                "FoleyAction" => BuildFoleyActionEvent(se),
                "SceneItem" => BuildSceneItemEvent(se),
                "WorkspotPlayFacialAnim" => BuildWorkspotPlayFacialAnimEvent(se),
                "FootIK" => BuildFootIKEvent(se),
                "FootPhase" => BuildFootPhaseEvent(se),
                "GameplayVo" => BuildGameplayVoEvent(se),
                "FootPlant" => BuildFootPlantEvent(se),
                "WorkspotItem" => BuildWorkspotItemEvent(se),
                // Base-only types (no subclass fields, just need correct C# type)
                "Phase" => new animAnimEvent_Phase(),
                "KeyPose" => new animAnimEvent_KeyPose(),
                "ForceRagdoll" => new animAnimEvent_ForceRagdoll(),
                "Slide" => new animAnimEvent_Slide(),
                "SafeCut" => new animAnimEvent_SafeCut(),
                "SimpleDuration" => new animAnimEvent_SimpleDuration(),
                "WorkspotFastExitCutoff" => new animAnimEvent_WorkspotFastExitCutoff(),
                "TrajectoryAdjustment" => new animAnimEvent_TrajectoryAdjustment(),
                // Fallback for anything truly unknown
                _ => new animAnimEvent_Simple()
            };

            evt.EventName = se.EventName;
            evt.StartFrame = se.StartFrame;
            evt.DurationInFrames = se.DurationInFrames;
            return evt;
        }

        private static animAnimEvent_Sound BuildSoundEvent(AnimEventSerializable se)
        {
            var sound = new animAnimEvent_Sound();

            if (se.ParamCurves != null)
            {
                foreach (var pc in se.ParamCurves)
                {
                    var param = new audioAudParameter
                    {
                        Name = pc.Name,
                        Value = pc.Value,
                        EnterCurveTime = pc.EnterCurveTime,
                        ExitCurveTime = pc.ExitCurveTime,
                    };
                    if (Enum.TryParse<audioESoundCurveType>(pc.EnterCurveType, out var enterCurve))
                        param.EnterCurveType = enterCurve;
                    if (Enum.TryParse<audioESoundCurveType>(pc.ExitCurveType, out var exitCurve))
                        param.ExitCurveType = exitCurve;
                    sound.Params.Add(param);
                }
            }
            else if (se.Params != null)
            {
                // Legacy path: params without curve data
                foreach (var kvp in se.Params)
                {
                    sound.Params.Add(new audioAudParameter { Name = kvp.Key, Value = kvp.Value });
                }
            }

            if (se.Switches != null)
            {
                foreach (var kvp in se.Switches)
                {
                    sound.Switches.Add(new audioAudSwitch { Name = kvp.Key, Value = kvp.Value });
                }
            }

            if (se.DynamicParams != null)
            {
                foreach (var dp in se.DynamicParams)
                {
                    sound.DynamicParams.Add(dp);
                }
            }

            if (!string.IsNullOrEmpty(se.MetadataContext)) sound.MetadataContext = se.MetadataContext;
            if (!string.IsNullOrEmpty(se.OnlyPlayOn)) sound.OnlyPlayOn = se.OnlyPlayOn;
            if (!string.IsNullOrEmpty(se.DontPlayOn)) sound.DontPlayOn = se.DontPlayOn;
            if (se.PlayerGenderAlt != null && Enum.TryParse<animAnimEventGenderAlt>(se.PlayerGenderAlt, out var genderAlt))
            {
                sound.PlayerGenderAlt = genderAlt;
            }

            return sound;
        }

        private static animAnimEvent_SoundFromEmitter BuildSoundFromEmitterEvent(AnimEventSerializable se)
        {
            var emitter = new animAnimEvent_SoundFromEmitter();
            if (!string.IsNullOrEmpty(se.EmitterName)) emitter.EmitterName = se.EmitterName;
            return emitter;
        }

        private static animAnimEvent_Effect BuildEffectEvent(AnimEventSerializable se)
        {
            var effect = new animAnimEvent_Effect();
            if (!string.IsNullOrEmpty(se.EffectName)) effect.EffectName = se.EffectName;
            return effect;
        }

        private static animAnimEvent_EffectDuration BuildEffectDurationEvent(AnimEventSerializable se)
        {
            var effect = new animAnimEvent_EffectDuration();
            if (!string.IsNullOrEmpty(se.EffectName)) effect.EffectName = se.EffectName;
            if (se.SequenceShift.HasValue) effect.SequenceShift = se.SequenceShift.Value;
            if (se.BreakAllLoopsOnStop.HasValue) effect.BreakAllLoopsOnStop = se.BreakAllLoopsOnStop.Value;
            return effect;
        }

        private static animAnimEvent_ItemEffect BuildItemEffectEvent(AnimEventSerializable se)
        {
            var effect = new animAnimEvent_ItemEffect();
            if (!string.IsNullOrEmpty(se.EffectName)) effect.EffectName = se.EffectName;
            return effect;
        }

        private static animAnimEvent_ItemEffectDuration BuildItemEffectDurationEvent(AnimEventSerializable se)
        {
            var effect = new animAnimEvent_ItemEffectDuration();
            if (!string.IsNullOrEmpty(se.EffectName)) effect.EffectName = se.EffectName;
            if (se.SequenceShift.HasValue) effect.SequenceShift = se.SequenceShift.Value;
            if (se.BreakAllLoopsOnStop.HasValue) effect.BreakAllLoopsOnStop = se.BreakAllLoopsOnStop.Value;
            return effect;
        }

        // ── Phase 6 builders ──

        private static animAnimEvent_Valued BuildValuedEvent(AnimEventSerializable se)
        {
            var valued = new animAnimEvent_Valued();
            if (se.EventValue.HasValue) valued.Value = se.EventValue.Value;
            return valued;
        }

        private static animAnimEvent_FoleyAction BuildFoleyActionEvent(AnimEventSerializable se)
        {
            var foley = new animAnimEvent_FoleyAction();
            if (!string.IsNullOrEmpty(se.ActionName)) foley.ActionName = se.ActionName;
            return foley;
        }

        private static animAnimEvent_SceneItem BuildSceneItemEvent(AnimEventSerializable se)
        {
            var sceneItem = new animAnimEvent_SceneItem();
            if (!string.IsNullOrEmpty(se.BoneName)) sceneItem.BoneName = se.BoneName;
            return sceneItem;
        }

        private static animAnimEvent_WorkspotPlayFacialAnim BuildWorkspotPlayFacialAnimEvent(AnimEventSerializable se)
        {
            var facial = new animAnimEvent_WorkspotPlayFacialAnim();
            if (!string.IsNullOrEmpty(se.FacialAnimName)) facial.FacialAnimName = se.FacialAnimName;
            return facial;
        }

        private static animAnimEvent_FootIK BuildFootIKEvent(AnimEventSerializable se)
        {
            var footIk = new animAnimEvent_FootIK();
            if (se.Leg != null && Enum.TryParse<Enums.animLeg>(se.Leg, out var leg))
                footIk.Leg = leg;
            return footIk;
        }

        private static animAnimEvent_FootPhase BuildFootPhaseEvent(AnimEventSerializable se)
        {
            var fp = new animAnimEvent_FootPhase();
            if (se.FootPhase != null && Enum.TryParse<Enums.animEFootPhase>(se.FootPhase, out var phase))
                fp.Phase = phase;
            return fp;
        }

        private static animAnimEvent_GameplayVo BuildGameplayVoEvent(AnimEventSerializable se)
        {
            var vo = new animAnimEvent_GameplayVo();
            if (!string.IsNullOrEmpty(se.VoContext)) vo.VoContext = se.VoContext;
            if (se.IsQuest.HasValue) vo.IsQuest = se.IsQuest.Value;
            return vo;
        }

        private static animAnimEvent_FootPlant BuildFootPlantEvent(AnimEventSerializable se)
        {
            var plant = new animAnimEvent_FootPlant();
            if (se.Side != null && Enum.TryParse<Enums.animEventSide>(se.Side, out var side))
                plant.Side = side;
            if (!string.IsNullOrEmpty(se.CustomEvent)) plant.CustomEvent = se.CustomEvent;
            return plant;
        }

        // ── WorkspotItem serialization ──

        private static List<WorkspotActionSerializable>? SerializeWorkspotActions(CArray<CHandle<workIWorkspotItemAction>> actions)
        {
            if (actions == null || actions.Count == 0)
                return null;

            var result = new List<WorkspotActionSerializable>();
            foreach (var handle in actions)
            {
                var action = handle.Chunk;
                if (action == null) continue;

                result.Add(action switch
                {
                    workEquipItemToSlotAction equip => new WorkspotActionSerializable(
                        "EquipItemToSlot",
                        ((ulong)equip.Item).ToString(), ((ulong)equip.ItemSlot).ToString(),
                        null, null, null, null, null, null, null, null, null, null, null, null, null),

                    workEquipPropToSlotAction prop => new WorkspotActionSerializable(
                        "EquipPropToSlot",
                        null, ((ulong)prop.ItemSlot).ToString(),
                        prop.ItemId.GetResolvedText(), prop.AttachMethod.ToString(),
                        prop.CustomOffsetPos.X, prop.CustomOffsetPos.Y, prop.CustomOffsetPos.Z,
                        prop.CustomOffsetRot.I, prop.CustomOffsetRot.J, prop.CustomOffsetRot.K, prop.CustomOffsetRot.R,
                        null, null, null, null),

                    workEquipInventoryWeaponAction weapon => new WorkspotActionSerializable(
                        "EquipInventoryWeapon",
                        null, null, null, null, null, null, null, null, null, null, null,
                        weapon.WeaponType.ToString(), weapon.KeepEquippedAfterExit,
                        ((ulong)weapon.FallbackItem).ToString(), ((ulong)weapon.FallbackSlot).ToString()),

                    workUnequipFromSlotAction unequipSlot => new WorkspotActionSerializable(
                        "UnequipFromSlot",
                        null, ((ulong)unequipSlot.ItemSlot).ToString(),
                        null, null, null, null, null, null, null, null, null, null, null, null, null),

                    workUnequipPropAction unequipProp => new WorkspotActionSerializable(
                        "UnequipProp",
                        null, null, unequipProp.ItemId.GetResolvedText(),
                        null, null, null, null, null, null, null, null, null, null, null, null),

                    workUnequipItemAction unequipItem => new WorkspotActionSerializable(
                        "UnequipItem",
                        ((ulong)unequipItem.Item).ToString(), null,
                        null, null, null, null, null, null, null, null, null, null, null, null, null),

                    _ => new WorkspotActionSerializable(
                        action.GetType().Name, null, null, null, null, null, null, null, null, null, null, null, null, null, null, null)
                });
            }
            return result.Count > 0 ? result : null;
        }

        private static animAnimEvent_WorkspotItem BuildWorkspotItemEvent(AnimEventSerializable se)
        {
            var wsItem = new animAnimEvent_WorkspotItem();
            if (se.WorkspotActions == null) return wsItem;

            foreach (var wa in se.WorkspotActions)
            {
                workIWorkspotItemAction? action = wa.ActionType switch
                {
                    "EquipItemToSlot" => BuildEquipItemToSlotAction(wa),
                    "EquipPropToSlot" => BuildEquipPropToSlotAction(wa),
                    "EquipInventoryWeapon" => BuildEquipInventoryWeaponAction(wa),
                    "UnequipFromSlot" => BuildUnequipFromSlotAction(wa),
                    "UnequipProp" => BuildUnequipPropAction(wa),
                    "UnequipItem" => BuildUnequipItemAction(wa),
                    _ => null
                };
                if (action != null)
                    wsItem.Actions.Add(action);
            }
            return wsItem;
        }

        private static workEquipItemToSlotAction BuildEquipItemToSlotAction(WorkspotActionSerializable wa)
        {
            var a = new workEquipItemToSlotAction();
            if (wa.Item != null && ulong.TryParse(wa.Item, out var item)) a.Item = item;
            if (wa.ItemSlot != null && ulong.TryParse(wa.ItemSlot, out var slot)) a.ItemSlot = slot;
            return a;
        }

        private static workEquipPropToSlotAction BuildEquipPropToSlotAction(WorkspotActionSerializable wa)
        {
            var a = new workEquipPropToSlotAction();
            if (!string.IsNullOrEmpty(wa.ItemId)) a.ItemId = wa.ItemId;
            if (wa.ItemSlot != null && ulong.TryParse(wa.ItemSlot, out var slot)) a.ItemSlot = slot;
            if (wa.AttachMethod != null && Enum.TryParse<Enums.workPropAttachMethod>(wa.AttachMethod, out var method))
                a.AttachMethod = method;
            if (wa.OffsetPosX.HasValue) a.CustomOffsetPos.X = wa.OffsetPosX.Value;
            if (wa.OffsetPosY.HasValue) a.CustomOffsetPos.Y = wa.OffsetPosY.Value;
            if (wa.OffsetPosZ.HasValue) a.CustomOffsetPos.Z = wa.OffsetPosZ.Value;
            if (wa.OffsetRotI.HasValue) a.CustomOffsetRot.I = wa.OffsetRotI.Value;
            if (wa.OffsetRotJ.HasValue) a.CustomOffsetRot.J = wa.OffsetRotJ.Value;
            if (wa.OffsetRotK.HasValue) a.CustomOffsetRot.K = wa.OffsetRotK.Value;
            if (wa.OffsetRotR.HasValue) a.CustomOffsetRot.R = wa.OffsetRotR.Value;
            return a;
        }

        private static workEquipInventoryWeaponAction BuildEquipInventoryWeaponAction(WorkspotActionSerializable wa)
        {
            var a = new workEquipInventoryWeaponAction();
            if (wa.WeaponType != null && Enum.TryParse<Enums.workWeaponType>(wa.WeaponType, out var wt))
                a.WeaponType = wt;
            if (wa.KeepEquippedAfterExit.HasValue) a.KeepEquippedAfterExit = wa.KeepEquippedAfterExit.Value;
            if (wa.FallbackItem != null && ulong.TryParse(wa.FallbackItem, out var fi)) a.FallbackItem = fi;
            if (wa.FallbackSlot != null && ulong.TryParse(wa.FallbackSlot, out var fs)) a.FallbackSlot = fs;
            return a;
        }

        private static workUnequipFromSlotAction BuildUnequipFromSlotAction(WorkspotActionSerializable wa)
        {
            var a = new workUnequipFromSlotAction();
            if (wa.ItemSlot != null && ulong.TryParse(wa.ItemSlot, out var slot)) a.ItemSlot = slot;
            return a;
        }

        private static workUnequipPropAction BuildUnequipPropAction(WorkspotActionSerializable wa)
        {
            var a = new workUnequipPropAction();
            if (!string.IsNullOrEmpty(wa.ItemId)) a.ItemId = wa.ItemId;
            return a;
        }

        private static workUnequipItemAction BuildUnequipItemAction(WorkspotActionSerializable wa)
        {
            var a = new workUnequipItemAction();
            if (wa.Item != null && ulong.TryParse(wa.Item, out var item)) a.Item = item;
            return a;
        }

        #endregion animEventHelpers

        #endregion importanims
    }
}
