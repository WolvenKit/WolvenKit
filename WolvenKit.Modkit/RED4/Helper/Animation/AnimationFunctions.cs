using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.CR2W.Types;
using RigFile;
using GeneralStructs;
using WolvenKit.Common.FNV1A;
using SharpGLTF.Schema2;
using WolvenKit.Common.Oodle;
using WolvenKit.Modkit.RED4;

namespace Animation
{
    public class ANIMATION
    {
        private readonly Red4ParserService _wolvenkitFileService;
        public ANIMATION(Red4ParserService fileservice)
        {
            _wolvenkitFileService = fileservice;
        }
        public bool ExportAnim(Stream animStream, List<Archive> archives, FileInfo outfile, bool isGLBinary = true)
        {
            var cr2w = _wolvenkitFileService.TryReadRED4File(animStream);

            if (!cr2w.Chunks.Select(_ => _.Data).OfType<animAnimSet>().Any())
            {
                return false;
            }
            var blob = cr2w.Chunks.Select(_ => _.Data).OfType<animAnimSet>().First();

            List<MemoryStream> animDataBuffers = new List<MemoryStream>();
            foreach(var chk in blob.AnimationDataChunks)
            {
                UInt16 bufferIdx = chk.Buffer.Buffer.Value;
                var b = cr2w.Buffers[bufferIdx - 1];
                animStream.Seek(b.Offset, SeekOrigin.Begin);
                var ms = new MemoryStream();
                animStream.DecompressAndCopySegment(ms, b.DiskSize, b.MemSize);
                animDataBuffers.Add(ms);
            }
            RawArmature Rig = null;
            {
                ulong hash = FNV1A64HashAlgorithm.HashString(blob.Rig.DepotPath);
                foreach (Archive ar in archives)
                {
                    if (ar.Files.ContainsKey(hash))
                    {
                        var ms = new MemoryStream();
                        ModTools.ExtractSingleToStream(ar, hash, ms);
                        Rig = new RIG(_wolvenkitFileService).ProcessRig(ms);
                        break;
                    }
                }
            }
            if (Rig.BoneCount < 1)
                return false;
            var model = ModelRoot.CreateModel();
            var skin = model.CreateSkin();
            skin.BindJoints(RIG.ExportNodes(ref model, Rig).Values.ToArray());

            for (int i = 0; i < blob.Animations.Count;i++)
            {
                var setEntry = (blob.Animations[i].GetReference().Data as animAnimSetEntry);
                var animAnimDes = (setEntry.Animation.GetReference().Data as animAnimation);
                if (animAnimDes.AnimationType.Value != Enums.animAnimationType.Normal)
                    continue;
                switch (animAnimDes.AnimBuffer.GetReference().REDType)
                {
                    case "animAnimationBufferSimd":
                    {
                        var animBuff = (animAnimDes.AnimBuffer.GetReference().Data as animAnimationBufferSimd);
                        var bufferIdx = animBuff.DefferedBuffer.Buffer.Value;
                        var b = cr2w.Buffers[bufferIdx - 1];
                        animStream.Seek(b.Offset, SeekOrigin.Begin);
                        var defferedBuffer = new MemoryStream();
                        animStream.DecompressAndCopySegment(defferedBuffer, b.DiskSize, b.MemSize);
                        SIMD.AddAnimationSIMD(ref model, animBuff, animAnimDes.Name.Value, defferedBuffer);
                    }
                    break;
                    case "animAnimationBufferCompressed":
                    {
                        var animBuff = (animAnimDes.AnimBuffer.GetReference().Data as animAnimationBufferCompressed);
                        var dataAddr = animBuff.DataAddress;
                        Byte[] bytes = new Byte[dataAddr.ZeInBytes.Value];
                        animDataBuffers[(int)dataAddr.UnkIndex.Value].Seek(dataAddr.FsetInBytes.Value, SeekOrigin.Begin);
                        animDataBuffers[(int)dataAddr.UnkIndex.Value].Read(bytes, 0,(int) dataAddr.ZeInBytes.Value);
                        var defferedBuffer = new MemoryStream(bytes);
                        SPLINE.AddAnimationSpline(ref model, animBuff, animAnimDes.Name.Value, defferedBuffer);
                    }
                    break;
                    default:
                    break;
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
