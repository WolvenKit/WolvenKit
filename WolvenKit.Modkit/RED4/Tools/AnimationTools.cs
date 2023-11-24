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
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

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

        public bool ExportAnim(Stream animStream, List<ICyberGameArchive> archives, FileInfo outfile, bool isGLBinary = true, bool incRootMotion = true)
        {
            var animsFile = _parserService.ReadRed4File(animStream);
            return animsFile is { RootChunk: animAnimSet anims } && ExportAnim(animsFile, archives, outfile, isGLBinary, incRootMotion);
        }

        public bool ExportAnim(CR2WFile animsFile, List<ICyberGameArchive> archives, FileInfo outfile, bool isGLBinary = true, bool incRootMotion = true, ValidationMode vmode = ValidationMode.TryFix)
        {
            if (animsFile.RootChunk is not animAnimSet anims)
            {
                return false;
            }

            CR2WFile? rigFile = null;
            foreach (var ar in archives)
            {
                if (ar.Files.TryGetValue(anims.Rig.DepotPath, out var gameFile))
                {
                    var ms = new MemoryStream();
                    gameFile.Extract(ms);
                    if (_parserService.TryReadRed4File(ms, out rigFile))
                    {
                        break;
                    }
                }
            }

            if (rigFile is null)
            {
                _loggerService.Warning("No rig found");
                return false;
            }

            var model = ModelRoot.CreateModel();
            GetAnimation(animsFile, rigFile, ref model, true, incRootMotion);

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

        public static bool GetAnimation(CR2WFile animsFile, CR2WFile rigFile, ref ModelRoot model, bool includeRig = true, bool incRootMotion = true)
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

            foreach (var anim in anims.Animations)
            {
                ArgumentNullException.ThrowIfNull(anim.Chunk);
                ArgumentNullException.ThrowIfNull(anim.Chunk.Animation.Chunk);

                var animAnimDes = anim.Chunk.Animation.Chunk;

                if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferSimd animBuffSimd)
                {

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
                    SIMD.AddAnimationSIMD(ref model, animBuffSimd, animAnimDes.Name!, deferredBuffer, animAnimDes, incRootMotion);
                }
                else if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferCompressed)
                {
                    CompressedBuffer.ExportAsAnimationToModel(ref model, animAnimDes, incRootMotion);
                }
            }
            return true;
        }

#endregion exportanims

#region importanims

        public bool ImportAnims(FileInfo gltfFile, Stream animStream, List<ICyberGameArchive> archives)
        {
            var animsArchive = _parserService.ReadRed4File(animStream);
            if (animsArchive is not { RootChunk: animAnimSet anims })
            {
                return false;
            }

            CR2WFile? rigArchive = null;
            // find first rig in archives
            foreach (var ar in archives)
            {
                if (ar.Files.TryGetValue(anims.Rig.DepotPath, out var gameFile))
                {
                    var ms = new MemoryStream();
                    gameFile.Extract(ms);
                    if (_parserService.TryReadRed4File(ms, out rigArchive))
                    {
                        break;
                    }
                }
            }

            var gltfFileName = gltfFile.Name;
            var rigFileName = anims.Rig.DepotPath.GetResolvedText() ?? "<unknown rig depotpath??>";

            if (rigArchive is null)
            {
                _loggerService.Error($"{gltfFileName}: No rig found for {rigFileName}, can't import animations!");
                return false;
            }

            var rig = RIG.ProcessRig(rigArchive);
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


        private bool PutAnimations(ref animAnimSet anims, ref RawArmature rig, ref ModelRoot model, string gltfFileName, string rigFileName) {

            // Clear out the old animdata if it looks like we have something to import
            _loggerService.Info($"{gltfFileName}: found {model.LogicalAnimations.Count} animations to import");
            anims.AnimationDataChunks.Clear();

            foreach (var srcAnim in model.LogicalAnimations)
            {
                // Can switch to system Json when SharpGLTF support released (maybe in .31)
                var extras = JsonSerializer.Deserialize<AnimationExtrasForGltf>(srcAnim.Extras.ToJson(), SerializationOptions());

                // TODO can we migrate?
                if (!IsSchemaVersionCompatible(extras))
                {
                    throw new InvalidOperationException($"{gltfFileName}: Unsupported schema type or version for extra data on animation {srcAnim.Name}: {extras.Schema.Type} {extras.Schema.Version}!");
                }

                // TODO should be able to insert new anims too, need to set it up though
                var tmpAnim = anims.Animations.FirstOrDefault(_ => _?.Chunk?.Animation.Chunk?.Name.GetResolvedText() == srcAnim.Name);
                if (tmpAnim == null)
                {
                    _loggerService.Warning($"{gltfFileName}: animation {srcAnim.Name} not found in animset, skipping! (New animations are not supported currently!)");
                    continue;
                }

                ArgumentNullException.ThrowIfNull(tmpAnim.Chunk);
                ArgumentNullException.ThrowIfNull(tmpAnim.Chunk.Animation.Chunk);

                var animAnimDes = tmpAnim.Chunk.Animation.Chunk;

                if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferSimd) {
                    _loggerService.Warning($"{gltfFileName}: original animation {srcAnim.Name} is a SIMD animation, will try to import data as a CompressedBuffer instead but full support is not implemented yet so this may not work correctly!");
                }

                var keyframeTranslations = new Dictionary<AnimationInterpolationMode, Dictionary<ushort, Dictionary<float, Vec3>>> {
                    [AnimationInterpolationMode.STEP] = new (),
                    [AnimationInterpolationMode.LINEAR] = new (),
                };

                var keyframeRotations = new Dictionary<AnimationInterpolationMode, Dictionary<ushort, Dictionary<float, Quat>>> {
                    [AnimationInterpolationMode.STEP] = new (),
                    [AnimationInterpolationMode.LINEAR] = new (),
                };

                var keyframeScales = new Dictionary<AnimationInterpolationMode, Dictionary<ushort, Dictionary<float, Vec3>>> {
                    [AnimationInterpolationMode.STEP] = new (),
                    [AnimationInterpolationMode.LINEAR] = new (),
                };

                foreach (var chan in srcAnim.Channels)
                {
                    var idx = Array.IndexOf(rig.Names.NotNull(), chan.TargetNode.Name);
                    if (idx < 0)
                    {
                        throw new Exception($"{gltfFileName} ${srcAnim.Name}: Invalid Joint Transform, joint {chan.TargetNode.Name} not present in the associated rig {rigFileName}");
                    }

                    switch (chan.TargetNodePath)
                    {
                        case PropertyPath.translation:
                            var translationSampler = chan.GetTranslationSampler();
                            var typedTranslations = keyframeTranslations[translationSampler.InterpolationMode] ?? throw new Exception($"{gltfFileName} ${srcAnim.Name}: Unsupported interpolation mode {translationSampler.InterpolationMode}!");

                            typedTranslations.Add((ushort)idx, translationSampler.GetLinearKeys().ToDictionary(_ => _.Key, _ => _.Value));
                            break;

                        case PropertyPath.rotation:
                            var rotationSampler = chan.GetRotationSampler();
                            var typedRotations = keyframeRotations[rotationSampler.InterpolationMode] ?? throw new Exception($"{gltfFileName} ${srcAnim.Name}: Unsupported interpolation mode {rotationSampler.InterpolationMode}!");

                            typedRotations.Add((ushort)idx, rotationSampler.GetLinearKeys().ToDictionary(_ => _.Key, _ => _.Value));
                            break;

                        case PropertyPath.scale:
                            var scaleSampler = chan.GetScaleSampler();
                            var typedScales = keyframeScales[scaleSampler.InterpolationMode] ?? throw new Exception($"{gltfFileName} ${srcAnim.Name}: Unsupported interpolation mode {scaleSampler.InterpolationMode}!");

                            typedScales.Add((ushort)idx, scaleSampler.GetLinearKeys().ToDictionary(_ => _.Key, _ => _.Value));
                            break;

                        case PropertyPath.weights:
                            // Fallthrough, no morph anims yet
                        default:
                            throw new System.Exception($"{gltfFileName} ${srcAnim.Name}: Unsupported channel target {chan.TargetNodePath}!");
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

                for (ushort jointIdx = 0; jointIdx < (ushort)rig.BoneCount; ++jointIdx) {

                    // Const keyframes are all similarly encoded, S, R and T

                    // Order of SRT doesn't seem to matter
                    foreach (var (time, value) in constKeyRotations.GetValueOrDefault(jointIdx, new ()))
                    {
                        constAnimKeys.Add(new animKeyRotation() { Idx = jointIdx, Time = time, Rotation = RQuaternionZup(value), });
                    }
                    foreach (var (time, value) in constKeyTranslations.GetValueOrDefault(jointIdx, new ()))
                    {
                        constAnimKeys.Add(new animKeyPosition() { Idx = jointIdx, Time = time, Position = TRVectorZup(value), });
                    }
                    foreach (var (time, value) in constKeyScales.GetValueOrDefault(jointIdx, new ()))
                    {
                        constAnimKeys.Add(new animKeyScale() { Idx = jointIdx, Time = time, Scale = SVectorZup( value ), });
                    }

                    // For linear keyframes, T and S are always 'raw' but R can optionally be compressed

                    foreach (var (time, value) in keyTranslations.GetValueOrDefault(jointIdx, new ()))
                    {
                        animKeysRaw.Add(new animKeyPosition() { Idx = jointIdx, Time = time, Position = TRVectorZup( value ), });
                    }
                    foreach (var (time, value) in keyScales.GetValueOrDefault(jointIdx, new ()))
                    {
                        animKeysRaw.Add(new animKeyScale() { Idx = jointIdx, Time = time, Scale = SVectorZup(value), });
                    }

                    var preferredStorage = extras.PreferLosslessLinearRotationEncoding ? animKeysRaw : animKeys;

                    foreach (var (time, value) in keyRotations.GetValueOrDefault(jointIdx, new ()))
                    {
                        preferredStorage.Add(new animKeyRotation() { Idx = jointIdx, Time = time, Rotation = RQuaternionZup(value), });
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

                animAnimDes.AnimationType = (Enums.animAnimationType)Enum.Parse(typeof(Enums.animAnimationType), extras.AnimationType);
                animAnimDes.FrameClamping = extras.FrameClamping;
                animAnimDes.FrameClampingStartFrame = Convert.ToSByte(extras.FrameClampingStartFrame);
                animAnimDes.FrameClampingEndFrame = Convert.ToSByte(extras.FrameClampingEndFrame);

                var compressed = new animAnimationBufferCompressed()
                {
                    Duration = srcAnim.Duration,
                    NumFrames = FramesToAccommodateDuration(srcAnim.Duration),
                    NumExtraJoints = extras.NumExtraJoints,
                    NumExtraTracks = extras.NumeExtraTracks,
                    NumJoints = Convert.ToUInt16(rig.BoneCount),
                    NumTracks = Convert.ToUInt16(rig.ReferenceTracks?.Length ?? 0),
                    NumConstAnimKeys = Convert.ToUInt32(constAnimKeys.Count),
                    NumAnimKeysRaw = Convert.ToUInt32(animKeysRaw.Count),
                    NumAnimKeys = Convert.ToUInt32(animKeys.Count),
                    NumConstTrackKeys = Convert.ToUInt32(constTrackKeys.Count),
                    NumTrackKeys = Convert.ToUInt32(trackKeys.Count),
                    IsScaleConstant = keyScales.Count + constKeyScales.Count < 1,
                    HasRawRotations = extras.PreferLosslessLinearRotationEncoding,

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

                // For now just dump the data always into `AnimationDataChunk`s,
                // may need to handle `InplaceCompressedBuffer` and `DefferedBuffer` (sic)
                // separately if this doesn't work for those reliably...
                var dataChk = new animAnimDataChunk()
                {
                    Buffer = new SerializationDeferredDataBuffer(compressed.TempBuffer.Buffer.GetBytes())
                };

                // These could also be written to a single chunk (or fewer chunks)
                // but for now we'll do a chunk per animation.
                //
                // Might have some kind of streaming optimization potential chunk count vs. size?
                compressed.DataAddress.UnkIndex = (uint)anims.AnimationDataChunks.Count;
                compressed.DataAddress.FsetInBytes = 0;
                compressed.DataAddress.ZeInBytes = compressed.TempBuffer.Buffer.MemSize;

                anims.AnimationDataChunks.Add(dataChk);
                animAnimDes.AnimBuffer.Chunk = compressed;
            }

            return true;
        }


        #endregion importanims
    }
}
