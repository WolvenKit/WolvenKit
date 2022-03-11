using System.Collections.Generic;
using System;
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
using WolvenKit.RED4.Archive.IO;
using System.Text;

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

            /*
            ImportAnim(ref animsFile, model);

            var mms = new MemoryStream();
            using var writer = new CR2WWriter(mms, Encoding.UTF8, true);
            writer.WriteFile(animsFile);

            File.WriteAllBytes(@"C:\Users\abhin\OneDrive\Desktop\untitled.gltf", mms.ToArray());
            */

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
        public bool ImportAnim(ref CR2WFile animsFile, ModelRoot model)
        {

            if (animsFile == null || animsFile.RootChunk is not animAnimSet anims)
            {
                return false;
            }

            var setEntry = anims.Animations[0].Chunk;
            var animAnimDes = setEntry.Animation.Chunk;

            var compressed = animAnimDes.AnimBuffer.Chunk as animAnimationBufferCompressed;
            compressed.HasRawRotations = true;
            compressed.Duration = model.LogicalAnimations[1].Duration;
            compressed.NumAnimKeys = 0;
            compressed.NumConstAnimKeys = 0;
            compressed.NumAnimKeysRaw = 0;
            compressed.NumConstTrackKeys = 0;
            compressed.NumFrames = Convert.ToUInt32(compressed.Duration * 30.2245898);
            compressed.NumTrackKeys = 0;
            compressed.NumTracks = 0;

            var positions = new Dictionary<ushort, Dictionary<float, System.Numerics.Vector3>>();
            var rotations = new Dictionary<ushort, Dictionary<float, System.Numerics.Quaternion>>();
            var scales = new Dictionary<ushort, Dictionary<float, System.Numerics.Vector3>>();

            foreach(var chan in model.LogicalAnimations[1].Channels)
            {
                switch (chan.TargetNodePath)
                {
                    case PropertyPath.translation:
                        positions.Add((ushort)(chan.TargetNode.LogicalIndex - 1), chan.GetTranslationSampler().GetLinearKeys().ToDictionary(_=>_.Key,_=>_.Value));
                        break;
                    case PropertyPath.rotation:
                        rotations.Add((ushort)(chan.TargetNode.LogicalIndex - 1), chan.GetRotationSampler().GetLinearKeys().ToDictionary(_ => _.Key, _ => _.Value));
                        break;
                    case PropertyPath.scale:
                        scales.Add((ushort)(chan.TargetNode.LogicalIndex - 1), chan.GetScaleSampler().GetLinearKeys().ToDictionary(_ => _.Key, _ => _.Value));
                        break;
                    case PropertyPath.weights:
                        throw new System.Exception("Morph weights channel import not supported!");
                    default:
                        break;
                }
            }

            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);

            foreach(var bone in positions.Keys)
            {
                var dict = positions[bone];
                foreach (var time in dict.Keys)
                {
                    var timeNormalized = time / model.LogicalAnimations[1].Duration;
                    UInt16 t = Convert.ToUInt16(Math.Clamp(timeNormalized, 0, 1.0f) * UInt16.MaxValue);
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
                    var timeNormalized = time / model.LogicalAnimations[1].Duration;
                    UInt16 t = Convert.ToUInt16(Math.Clamp(timeNormalized, 0, 1.0f) * UInt16.MaxValue);
                    bw.Write(t);


                    var rotn = new System.Numerics.Quaternion(dict[time].X, -dict[time].Z, dict[time].Y, dict[time].W);

                    UInt16 bitwise = bone;
                    bitwise |= (UInt16)1 << 13;

                    if (rotn.W < 0)
                    {
                        rotn.W = -rotn.W;
                        bitwise |= (UInt16)1 << 15;
                    }
                    bw.Write(bitwise);

                    float dotPr = 1f - rotn.W;


                    rotn.X /= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                    rotn.Y /= Convert.ToSingle(Math.Sqrt(2f - dotPr));
                    rotn.Z /= Convert.ToSingle(Math.Sqrt(2f - dotPr));

                    var zzczxc = (rotn.X * rotn.X + rotn.Y * rotn.Y + rotn.Z * rotn.Z);

                    bw.Write(rotn.X);
                    bw.Write(rotn.Y);
                    bw.Write(rotn.Z);

                    compressed.NumAnimKeysRaw++;
                }
            }
            compressed.DataAddress.ZeInBytes =(UInt32)ms.Length;
            
            foreach (var bone in scales.Keys)
            {
                var dict = scales[bone];
                foreach (var time in dict.Keys)
                {
                    var timeNormalized = time / model.LogicalAnimations[1].Duration;
                    UInt16 t = Convert.ToUInt16(Math.Clamp(timeNormalized, 0, 1.0f) * UInt16.MaxValue);
                    bw.Write(t);

                    UInt16 bitwise = bone;
                    bitwise |= (UInt16)2 << 13;
                    bw.Write(bitwise);

                    var scal = new System.Numerics.Vector3(dict[time].X, dict[time].Y, dict[time].Z);

                    bw.Write(scal.X);
                    bw.Write(scal.Y);
                    bw.Write(scal.Z);

                    compressed.NumAnimKeysRaw++;
                }
            }
            
            anims.AnimationDataChunks[0].Buffer = new SerializationDeferredDataBuffer(ms.ToArray());

            compressed.DefferedBuffer = null;
            return true;
        }
        public static bool GetAnimation(CR2WFile animsFile, CR2WFile rigFile, ref ModelRoot model, bool includeRig = true)
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
                    else if (animBuffSimd.DataAddress != null)
                    {
                        var dataAddr = animBuffSimd.DataAddress;
                        var bytes = new byte[dataAddr.ZeInBytes];
                        animDataBuffers[(int)((uint)dataAddr.UnkIndex)].Seek(dataAddr.FsetInBytes, SeekOrigin.Begin);
                        animDataBuffers[(int)((uint)dataAddr.UnkIndex)].Read(bytes, 0, (int)((uint)dataAddr.ZeInBytes));
                        defferedBuffer = new MemoryStream(bytes);
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
