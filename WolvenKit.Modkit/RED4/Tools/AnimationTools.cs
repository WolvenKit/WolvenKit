using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpGLTF.Schema2;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Oodle;
using WolvenKit.Modkit.RED4.Animation;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        public bool ExportAnim(Stream animStream, List<Archive> archives, FileInfo outfile, bool isGLBinary = true)
        {
            var cr2w = _wolvenkitFileService.TryReadRed4File(animStream);

            if (!cr2w.Chunks.OfType<animAnimSet>().Any())
            {
                return false;
            }
            var blob = cr2w.Chunks.OfType<animAnimSet>().First();

            List<MemoryStream> animDataBuffers = new List<MemoryStream>();
            foreach (var chk in blob.AnimationDataChunks)
            {
                UInt16 bufferIdx = chk.Buffer.Pointer;
                var buffer = cr2w.Buffers[bufferIdx - 1];

                var unpacked = new byte[buffer.MemSize];
                _ = OodleHelper.Decompress(buffer.Data, unpacked);
                var ms = new MemoryStream();
                ms.Write(unpacked);

                animDataBuffers.Add(ms);
            }

            var Rig = new RawArmature();
            var hash = FNV1A64HashAlgorithm.HashString(blob.Rig.DepotPath);
            foreach (var ar in archives)
            {
                if (ar.Files.ContainsKey(hash))
                {
                    var ms = new MemoryStream();
                    ModTools.ExtractSingleToStream(ar, hash, ms);
                    Rig = RIG.ProcessRig(_wolvenkitFileService.TryReadRed4File(ms));
                    break;
                }
            }

            if (Rig is null)
            {
                return false;
            }

            if (Rig.BoneCount < 1)
            {
                return false;
            }

            var model = ModelRoot.CreateModel();
            var skin = model.CreateSkin();
            skin.BindJoints(RIG.ExportNodes(ref model, Rig).Values.ToArray());

            for (int i = 0; i < blob.Animations.Count; i++)
            {
                var setEntry = (blob.Animations[i].Chunk as animAnimSetEntry);
                var animAnimDes = (setEntry.Animation.Chunk as animAnimation);
                if (animAnimDes.AnimationType.Value != Enums.animAnimationType.Normal)
                    continue;

                if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferSimd)
                {
                    var animBuff = (animAnimDes.AnimBuffer.Chunk as animAnimationBufferSimd);
                    var defferedBuffer = new MemoryStream();
                    if (animBuff.InplaceCompressedBuffer.Data.Length > 0)
                    {
                        animBuff.InplaceCompressedBuffer.Decompress();
                        animStream.Write(animBuff.InplaceCompressedBuffer.Data);

                        var br = new BinaryReader(defferedBuffer);
                        br.BaseStream.Seek(0, SeekOrigin.Begin);
                        if (br.ReadUInt32() == OodleHelper.KARK)
                        {
                            uint size = br.ReadUInt32();
                            var input = br.ReadBytes((int)(br.BaseStream.Length - 8));
                            var output = new Byte[size];
                            OodleHelper.Decompress(input, output);
                            defferedBuffer = new MemoryStream(output);
                        }
                    }
                    else
                    {
                        animBuff.DefferedBuffer.Decompress();
                        animStream.Write(animBuff.DefferedBuffer.Data);
                    }
                    defferedBuffer.Seek(0, SeekOrigin.Begin);
                    SIMD.AddAnimationSIMD(ref model, animBuff, animAnimDes.Name, defferedBuffer, animAnimDes);
                }
                else if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferCompressed)
                {
                    var animBuff = (animAnimDes.AnimBuffer.Chunk as animAnimationBufferCompressed);
                    var defferedBuffer = new MemoryStream();
                    if (animBuff.InplaceCompressedBuffer.Data.Length > 0)
                    {
                        animBuff.InplaceCompressedBuffer.Decompress();
                        animStream.Write(animBuff.InplaceCompressedBuffer.Data);

                        var br = new BinaryReader(defferedBuffer);
                        br.BaseStream.Seek(0, SeekOrigin.Begin);
                        if (br.ReadUInt32() == OodleHelper.KARK)
                        {
                            uint size = br.ReadUInt32();
                            var input = br.ReadBytes((int)(br.BaseStream.Length - 8));
                            var output = new Byte[size];
                            OodleHelper.Decompress(input, output);
                            defferedBuffer = new MemoryStream(output);
                        }
                    }
                    else if (animBuff.DataAddress != null)
                    {
                        var dataAddr = animBuff.DataAddress;
                        Byte[] bytes = new Byte[dataAddr.ZeInBytes];
                        animDataBuffers[(int)((uint)dataAddr.UnkIndex)].Seek(dataAddr.FsetInBytes, SeekOrigin.Begin);
                        animDataBuffers[(int)((uint)dataAddr.UnkIndex)].Read(bytes, 0, (int)((uint)dataAddr.ZeInBytes));
                        defferedBuffer = new MemoryStream(bytes);
                    }
                    else if (animBuff.DefferedBuffer.Data.Length > 0)
                    {
                        animBuff.DefferedBuffer.Decompress();
                        defferedBuffer.Write(animBuff.DefferedBuffer.Data);
                    }
                    defferedBuffer.Seek(0, SeekOrigin.Begin);
                    SPLINE.AddAnimationSpline(ref model, animBuff, animAnimDes.Name, defferedBuffer, animAnimDes);
                }
            }
            if (isGLBinary)
                model.SaveGLB(outfile.FullName);
            else
                model.SaveGLTF(outfile.FullName);

            return true;
        }
    }
}
