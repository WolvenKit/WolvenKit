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

            if (cr2w == null || cr2w.RootChunk is not animAnimSet blob)
            {
                return false;
            }

            List<MemoryStream> animDataBuffers = new List<MemoryStream>();
            foreach (var chk in blob.AnimationDataChunks)
            {
                var ms = new MemoryStream();
                ms.Write(chk.Buffer.Buffer.GetBytes());

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
                {
                    continue;
                }

                if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferSimd)
                {
                    var animBuff = (animAnimDes.AnimBuffer.Chunk as animAnimationBufferSimd);
                    MemoryStream defferedBuffer;
                    if (animBuff.InplaceCompressedBuffer != null)
                    {
                        defferedBuffer = new MemoryStream(animBuff.InplaceCompressedBuffer.Buffer.GetBytes());
                    }
                    else
                    {
                        defferedBuffer = new MemoryStream(animBuff.DefferedBuffer.Buffer.GetBytes());
                    }
                    defferedBuffer.Seek(0, SeekOrigin.Begin);
                    SIMD.AddAnimationSIMD(ref model, animBuff, animAnimDes.Name, defferedBuffer, animAnimDes);
                }
                else if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferCompressed)
                {
                    var animBuff = (animAnimDes.AnimBuffer.Chunk as animAnimationBufferCompressed);
                    var defferedBuffer = new MemoryStream();
                    if (animBuff.InplaceCompressedBuffer != null )
                    {
                        defferedBuffer = new MemoryStream(animBuff.InplaceCompressedBuffer.Buffer.GetBytes());
                    }
                    else if (animBuff.DataAddress != null)
                    {
                        var dataAddr = animBuff.DataAddress;
                        Byte[] bytes = new Byte[dataAddr.ZeInBytes];
                        animDataBuffers[(int)((uint)dataAddr.UnkIndex)].Seek(dataAddr.FsetInBytes, SeekOrigin.Begin);
                        animDataBuffers[(int)((uint)dataAddr.UnkIndex)].Read(bytes, 0, (int)((uint)dataAddr.ZeInBytes));
                        defferedBuffer = new MemoryStream(bytes);
                    }
                    else if (animBuff.DefferedBuffer.Buffer.MemSize > 0)
                    {
                        defferedBuffer.Write(animBuff.DefferedBuffer.Buffer.GetBytes());
                    }
                    defferedBuffer.Seek(0, SeekOrigin.Begin);
                    SPLINE.AddAnimationSpline(ref model, animBuff, animAnimDes.Name, defferedBuffer, animAnimDes);
                }
            }
            if (isGLBinary)
            {
                model.SaveGLB(outfile.FullName);
            }
            else
            {
                model.SaveGLTF(outfile.FullName);
            }

            return true;
        }
    }
}
