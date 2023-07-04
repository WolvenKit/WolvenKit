using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SharpGLTF.Schema2;
using SharpGLTF.Validation;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.RED4.Animation;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
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

            var animDataBuffers = new List<MemoryStream>();
            foreach (var chk in anims.AnimationDataChunks)
            {
                var ms = new MemoryStream();
                ms.Write(chk.Buffer.Buffer.GetBytes());

                animDataBuffers.Add(ms);
            }

            CR2WFile? rigFile = null;
            // find first rig in archives
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
        public bool ImportAnims(FileInfo gltfFile, Stream animStream, List<ICyberGameArchive> archives)
        {
            var animsFile = _parserService.ReadRed4File(animStream);
            if (animsFile is not { RootChunk: animAnimSet anims })
            {
                return false;
            }

            CR2WFile? rigFile = null;
            // find first rig in archives
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

            var rig = RIG.ProcessRig(rigFile);
            if (rig is null || rig.BoneCount < 1)
            {
                return false;
            }

            var model = ModelRoot.Load(gltfFile.FullName, new ReadSettings(ValidationMode.TryFix));

            foreach (var srcAnim in model.LogicalAnimations)
            {
                var tmpAnim = anims.Animations.FirstOrDefault(_ => _?.Chunk?.Animation.Chunk?.Name.GetResolvedText() == srcAnim.Name);
                if (tmpAnim == null)
                {
                    continue;
                }

                ArgumentNullException.ThrowIfNull(tmpAnim.Chunk);
                ArgumentNullException.ThrowIfNull(tmpAnim.Chunk.Animation.Chunk);

                var animAnimDes = tmpAnim.Chunk.Animation.Chunk;

                var positions = new Dictionary<ushort, Dictionary<float, System.Numerics.Vector3>>();
                var rotations = new Dictionary<ushort, Dictionary<float, System.Numerics.Quaternion>>();
                var scales = new Dictionary<ushort, Dictionary<float, System.Numerics.Vector3>>();


                foreach (var chan in srcAnim.Channels)
                {
                    var idx = Array.IndexOf(rig.Names.NotNull(), chan.TargetNode.Name);
                    if (idx < 0)
                    {
                        throw new Exception($"Invalid Joint Transform, Joint: {chan.TargetNode.Name} not present in the src/original Rig");
                    }

                    switch (chan.TargetNodePath)
                    {
                        case PropertyPath.translation:
                            positions.Add((ushort)idx, chan.GetTranslationSampler().GetLinearKeys().ToDictionary(_ => _.Key, _ => _.Value));
                            break;
                        case PropertyPath.rotation:
                            rotations.Add((ushort)idx, chan.GetRotationSampler().GetLinearKeys().ToDictionary(_ => _.Key, _ => _.Value));
                            break;
                        case PropertyPath.scale:
                            scales.Add((ushort)idx, chan.GetScaleSampler().GetLinearKeys().ToDictionary(_ => _.Key, _ => _.Value));
                            break;
                        case PropertyPath.weights:
                            throw new System.Exception("Morph weights channel import not supported!");
                        default:
                            break;
                    }
                }

                List<ushort>? fallbackIndices = null;
                if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferCompressed animAnimationBufferCompressed)
                {
                    fallbackIndices = animAnimationBufferCompressed.FallbackFrameIndices.Select(_ => (ushort)_).ToList();
                }
                if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferSimd animAnimationBufferSimd)
                {
                    fallbackIndices = animAnimationBufferSimd.FallbackFrameIndices.Select(_ => (ushort)_).ToList();
                }

                var compressed = new animAnimationBufferCompressed()
                {
                    Duration = srcAnim.Duration,
                    NumFrames = Convert.ToUInt32(srcAnim.Duration * 30.1846575),
                    NumExtraJoints = 0,
                    NumExtraTracks = 0,
                    NumJoints = Convert.ToUInt16(rig.BoneCount),
                    NumTracks = 0,
                    NumAnimKeys = 0,
                    NumAnimKeysRaw = 0,
                    NumConstAnimKeys = 0,
                    NumTrackKeys = 0,
                    NumConstTrackKeys = 0,
                    IsScaleConstant = scales.Count < 1,
                    HasRawRotations = true
                };
                if (fallbackIndices != null)
                {
                    foreach (var idx in fallbackIndices)
                    {
                        compressed.FallbackFrameIndices.Add(idx);

                    }
                }

                var buffer = new MemoryStream();
                var bw = new BinaryWriter(buffer);

                foreach (var bone in positions.Keys)
                {
                    var dict = positions[bone];
                    foreach (var time in dict.Keys)
                    {
                        var timeNormalized = NormalizeTime(time, srcAnim.Duration);
                        var t = Convert.ToUInt16(Math.Clamp(timeNormalized, 0, 1.0f) * ushort.MaxValue);
                        bw.Write(t);
                        bw.Write(bone);
                        var posn = new System.Numerics.Vector3(dict[time].X, -dict[time].Z, dict[time].Y);
                        bw.Write(posn.X);
                        bw.Write(posn.Y);
                        bw.Write(posn.Z);
                        compressed.NumAnimKeysRaw++;
                    }
                }
                foreach (var bone in rotations.Keys)
                {
                    var dict = rotations[bone];
                    foreach (var time in dict.Keys)
                    {
                        var timeNormalized = NormalizeTime(time, srcAnim.Duration);
                        var t = Convert.ToUInt16(Math.Clamp(timeNormalized, 0, 1.0f) * ushort.MaxValue);
                        bw.Write(t);


                        var rotn = new System.Numerics.Quaternion(dict[time].X, -dict[time].Z, dict[time].Y, dict[time].W);

                        var bitwise = bone;
                        bitwise |= 1 << 13;

                        if (rotn.W < 0)
                        {
                            rotn.W = -rotn.W;
                            bitwise |= 1 << 15;
                        }
                        bw.Write(bitwise);

                        var dotPr = 1f - rotn.W;


                        rotn.X /= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                        rotn.Y /= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                        rotn.Z /= Convert.ToSingle(Math.Sqrt(2f - dotPr));

                        var zzczxc = (rotn.X * rotn.X) + (rotn.Y * rotn.Y) + (rotn.Z * rotn.Z);

                        bw.Write(rotn.X);
                        bw.Write(rotn.Y);
                        bw.Write(rotn.Z);

                        compressed.NumAnimKeysRaw++;
                    }
                }

                foreach (var bone in scales.Keys)
                {
                    var dict = scales[bone];
                    foreach (var time in dict.Keys)
                    {
                        var timeNormalized = NormalizeTime(time, srcAnim.Duration);
                        var t = Convert.ToUInt16(Math.Clamp(timeNormalized, 0, 1.0f) * ushort.MaxValue);
                        bw.Write(t);

                        var bitwise = bone;
                        bitwise |= 2 << 13;
                        bw.Write(bitwise);

                        var scal = new System.Numerics.Vector3(dict[time].X, dict[time].Y, dict[time].Z);

                        bw.Write(scal.X);
                        bw.Write(scal.Y);
                        bw.Write(scal.Z);

                        compressed.NumAnimKeysRaw++;
                    }
                }
                var dataChk = new animAnimDataChunk()
                {
                    Buffer = new SerializationDeferredDataBuffer(buffer.ToArray())
                };
                compressed.DataAddress.UnkIndex = (uint)anims.AnimationDataChunks.Count;
                compressed.DataAddress.FsetInBytes = 0;
                compressed.DataAddress.ZeInBytes = (uint)buffer.Length;

                anims.AnimationDataChunks.Add(dataChk);
                animAnimDes.AnimBuffer.Chunk = compressed;
            }

            var outMs = new MemoryStream();
            using var writer = new CR2WWriter(outMs, Encoding.UTF8, true) { LoggerService = _loggerService };
            writer.WriteFile(animsFile);

            outMs.Seek(0, SeekOrigin.Begin);
            animStream.SetLength(0);
            outMs.CopyTo(animStream);

            return true;

            static float NormalizeTime(float time, float sceneLength) => (0 == time * sceneLength) ? 0 : time / sceneLength;
        }
        public static bool GetAnimation(CR2WFile animsFile, CR2WFile rigFile, ref ModelRoot model, bool includeRig = true, bool incRootMotion = true)
        {

            if (animsFile.RootChunk is not animAnimSet anims)
            {
                return false;
            }

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
                    CompressedBuffer.AddAnimation(ref model, animAnimDes, incRootMotion);
                }
            }
            return true;
        }
    }
}
