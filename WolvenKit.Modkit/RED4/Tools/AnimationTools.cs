using System.Collections.Generic;
using System.IO;
using System.Linq;
using SharpGLTF.Schema2;
using WolvenKit.Common.FNV1A;
using WolvenKit.Modkit.RED4.Animation;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        public bool ExportAnim(Stream animStream, List<Archive> archives, FileInfo outfile, bool isGLBinary = true)
        {
            var animsFile = _wolvenkitFileService.ReadRed4File(animStream);
            if (animsFile == null || animsFile.RootChunk is not animAnimSet anims)
            {
                return false;
            }
            return ExportAnim(animsFile, archives, outfile, isGLBinary);
        }

        public bool ExportAnim(CR2WFile animsFile, List<Archive> archives, FileInfo outfile, bool isGLBinary = true)
        {
            if (animsFile == null || animsFile.RootChunk is not animAnimSet anims)
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

            CR2WFile rigFile = null;
            var hash = FNV1A64HashAlgorithm.HashString(anims.Rig.DepotPath);
            foreach (var ar in archives)
            {
                if (ar.Files.ContainsKey(hash))
                {
                    var ms = new MemoryStream();
                    ModTools.ExtractSingleToStream(ar, hash, ms);
                    rigFile = _wolvenkitFileService.ReadRed4File(ms);
                    break;
                }
            }

            var model = ModelRoot.CreateModel();
            GetAnimation(animsFile, rigFile, ref model);

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

        public static bool GetAnimation(CR2WFile animsFile, CR2WFile rigFile, ref ModelRoot model, bool includeRig = true)
        {

            if (animsFile == null || animsFile.RootChunk is not animAnimSet anims)
            {
                return false;
            }

            if (includeRig)
            {
                var rig = RIG.ProcessRig(rigFile);
                if (rig is null || rig.BoneCount < 1)
                {
                    return false;
                }
                var skin = model.CreateSkin();
                skin.BindJoints(RIG.ExportNodes(ref model, rig).Values.ToArray());
            }

            for (var i = 0; i < anims.Animations.Count; i++)
            {
                var setEntry = anims.Animations[i].Chunk;
                var animAnimDes = setEntry.Animation.Chunk;

                if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferSimd animBuffSimd)
                {
                    MemoryStream defferedBuffer;
                    if (animBuffSimd.InplaceCompressedBuffer != null)
                    {
                        defferedBuffer = new MemoryStream(animBuffSimd.InplaceCompressedBuffer.Buffer.GetBytes());
                    }
                    else
                    {
                        defferedBuffer = new MemoryStream(animBuffSimd.DefferedBuffer.Buffer.GetBytes());
                    }
                    defferedBuffer.Seek(0, SeekOrigin.Begin);
                    SIMD.AddAnimationSIMD(ref model, animBuffSimd, animAnimDes.Name, defferedBuffer, animAnimDes);
                }
                else if (animAnimDes.AnimBuffer.Chunk is animAnimationBufferCompressed)
                {
                    CompressedBuffer.AddAnimation(ref model, animAnimDes);
                }
            }
            return true;
        }
    }
}
