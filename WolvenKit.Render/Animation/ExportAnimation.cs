using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;
using Newtonsoft.Json;
using IrrlichtLime;
using IrrlichtLime.Core;
using IrrlichtLime.Scene;

namespace WolvenKit.Render
{

    class AnimExportData
    {
        public string name;
        public List<Bone> bones;
        public float duration;
        public uint numFrames;
        public float dt;
    }


    public class ExportAnimation
    {
        AnimExportData exportData = new AnimExportData();
        List<Bone> bones = new List<Bone>();
        private float animationSpeed = 0;
        private List<List<uint>> positionsKeyframes = new List<List<uint>>();
        private List<List<uint>> orientKeyframes = new List<List<uint>>();
        private List<List<uint>> scalesKeyframes = new List<List<uint>>();
        private List<List<Vector3Df>> positions = new List<List<Vector3Df>>();
        private List<List<Quaternion>> orientations = new List<List<Quaternion>>();
        private List<List<Vector3Df>> orientationsEuler = new List<List<Vector3Df>>();
        private List<List<Vector3Df>> scales = new List<List<Vector3Df>>();
        private List<SAnimationBufferBitwiseCompressedBoneTrack> currentBones = new List<SAnimationBufferBitwiseCompressedBoneTrack>();
        public string currentAnimName;

        public static List<KeyValuePair<string, int>> AnimationNames = new List<KeyValuePair<string, int>>();
        public ExportAnimation()
        {
        }
        /// <summary>
        /// Read animations and animbuffers data.
        /// </summary>
        public void LoadData(CR2WFile animFile)
        {
            AnimationNames.Clear();
            if (animFile != null)
                foreach (var chunk in animFile.chunks)
                {
                    if (chunk.REDType == "CSkeletalAnimation" && chunk.data is CSkeletalAnimation anim)
                    {
                        var name = anim.Name;
                        var chunkIdx = anim.AnimBuffer.Reference.ChunkIndex;
                        AnimationNames.Add(new KeyValuePair<string, int>(name.Value, chunkIdx));
                    }
                }
            SelectAnimation(animFile, 0);
        }

        /// <summary>
        /// Read animations and animbuffers data.
        /// </summary>
        public void SelectAnimation(CR2WFile animFile, int selectedAnimIdx)
        {
            positionsKeyframes.Clear();
            orientKeyframes.Clear();
            scalesKeyframes.Clear();
            positions.Clear();
            orientations.Clear();
            orientationsEuler.Clear();
            scales.Clear();
            currentBones.Clear();
            // *************** READ ANIMATION DATA ***************
            if (animFile != null)
                foreach (var chunk in animFile.chunks)
                {
                    if (chunk.REDType == "CAnimationBufferMultipart" && chunk.ChunkIndex == AnimationNames[selectedAnimIdx].Value 
                        && chunk.data is CAnimationBufferMultipart multipart)
                    {
                        foreach (CPtr<IAnimationBuffer> Buffer in multipart.Parts)
                        {
                            var a_buffer = Buffer.Reference;

                            throw new NotImplementedException();

                            //readBuffer(a_buffer.data as CAnimationBufferMultipart, selectedAnimIdx, animFile);
                            //break;
                        }
                        break;
                    }
                    if (chunk.REDType == "CAnimationBufferBitwiseCompressed" && chunk.ChunkIndex == AnimationNames[selectedAnimIdx].Value)
                    {
                        readBuffer(chunk.data as CAnimationBufferBitwiseCompressed, selectedAnimIdx, animFile);
                        break;
                    }
                }
        }

        public void readBuffer(CAnimationBufferBitwiseCompressed buffer, int selectedAnimIdx, CR2WFile animFile)
        {
            uint numFrames = buffer.NumFrames.val;
            float animDuration = buffer.Duration?.val ?? 1.0f;
            animationSpeed = numFrames / animDuration;
            uint keyFrame = 0;
            byte[] data;
            //data = (chunk.GetVariableByName("fallbackData") as CByteArray).Bytes;
            currentAnimName = AnimationNames[selectedAnimIdx].Key;
            exportData.name = AnimationNames[selectedAnimIdx].Key;
            exportData.duration = animDuration;
            exportData.numFrames = numFrames;
            exportData.dt = buffer.Dt?.val ?? 0.03333333f;
            DeferredDataBuffer deferredData = buffer.DeferredData;
            var streamingOption = buffer.StreamingOption;

            if (deferredData != null && deferredData.Bufferdata.val != 0)
                if (streamingOption.WrappedEnum == Enums.SAnimationBufferStreamingOption.ABSO_PartiallyStreamable)
                    data = ConvertAnimation.Combine(buffer.Data.Bytes,
                    File.ReadAllBytes(animFile.FileName + "." + deferredData.Bufferdata.val + ".buffer"));
                else
                    data = File.ReadAllBytes(animFile.FileName + "." + deferredData.Bufferdata.val + ".buffer");
            else
                data = buffer.Data.Bytes;
            using (MemoryStream ms = new MemoryStream(data))
            using (BinaryReader br = new BinaryReader(ms))
            {
                foreach (SAnimationBufferBitwiseCompressedBoneTrack bone in buffer.Bones)
                {
                    List<uint> currkeyframe = new List<uint>();
                    List<Quaternion> currorient = new List<Quaternion>();
                    List<Vector3Df> currorientEuler = new List<Vector3Df>();
                    currentBones.Add(bone);

                    br.BaseStream.Position = bone.Orientation.DataAddr.val;
                    int orientNumFrames = bone.Orientation.NumFrames.val;

                    for (uint idx = 0; idx < orientNumFrames; idx++)
                    {
                        keyFrame = idx;
                        //keyFrame += numFrames;
                        currkeyframe.Add(keyFrame);
                        //bone.GetVariableByName("position");
                        byte[] odata = br.ReadBytes(6);
                        ulong bits = (ulong)odata[0] << 40 | (ulong)odata[1] << 32 | (ulong)odata[2] << 24 | (ulong)odata[3] << 16 | (ulong)odata[4] << 8 | odata[5];

                        ushort[] orients = new ushort[4];
                        float[] quart = new float[4];
                        orients[0] = (ushort)((bits & 0x0000FFF000000000) >> 36);
                        orients[1] = (ushort)((bits & 0x0000000FFF000000) >> 24);
                        orients[2] = (ushort)((bits & 0x0000000000FFF000) >> 12);
                        orients[3] = (ushort)((bits & 0x0000000000000FFF));

                        for (int i = 0; i < orients.Length; i++)
                        {
                            float fVal = (2047.0f - orients[i]) * (1 / 2048.0f);
                            quart[i] = fVal;
                        }
                        quart[3] = -quart[3];

                        Quaternion orientation = new Quaternion(quart[0], quart[1], quart[2], quart[3]);
                        currorient.Add(orientation);
                        Vector3Df euler = orientation.ToEuler();
                        currorientEuler.Add(euler);
                        //Console.WriteLine("Euler : x=%f, y=%f, z=%f", euler.X, euler.Y, euler.Z);
                    }

                    orientKeyframes.Add(currkeyframe);
                    orientations.Add(currorient);
                    orientationsEuler.Add(currorientEuler);

                    // TODO: Refactor
                    List<Vector3Df> currposition = new List<Vector3Df>();
                    currkeyframe = new List<uint>();
                    int compression = 0;
                    var compr = bone.Position.Compression;
                    if (compr != null)
                        compression = compr.val;
                    var addr = bone.Position.DataAddr;
                    if (addr != null)
                        br.BaseStream.Position = addr.val;
                    else
                        br.BaseStream.Position = 0;
                    var posNumFrames = bone.Position.NumFrames.val;
                    for (uint idx = 0; idx < posNumFrames; idx++)
                    {
                        keyFrame = idx;
                        //keyFrame += numFrames;
                        currkeyframe.Add(keyFrame);
                        var vec = new SVector3D(null, null, "");
                        vec.Read(br, compression);
                        Vector3Df pos = new Vector3Df(vec.X.val, vec.Y.val, vec.Z.val);
                        currposition.Add(pos);
                    }
                    positionsKeyframes.Add(currkeyframe);
                    positions.Add(currposition);

                    List<Vector3Df> currscale = new List<Vector3Df>();
                    currkeyframe = new List<uint>();
                    compression = 0;
                    compr = bone.Scale.Compression;
                    if (compr != null)
                        compression = compr.val;
                    addr = bone.Scale.DataAddr;
                    if (addr != null)
                        br.BaseStream.Position = addr.val;
                    else
                        br.BaseStream.Position = 0;
                    var scaleNumFrames = bone.Scale.NumFrames.val;
                    for (uint idx = 0; idx < scaleNumFrames; idx++)
                    {
                        keyFrame = idx;
                        //keyFrame += numFrames;
                        currkeyframe.Add(keyFrame);
                        var vec = new SVector3D(null, null, "");
                        vec.Read(br, compression);
                        Vector3Df scale = new Vector3Df(vec.X.val, vec.Y.val, vec.Z.val);
                        currscale.Add(scale);
                    }
                    scalesKeyframes.Add(currkeyframe);
                    scales.Add(currscale);
                }
            }
        }


        /// <summary>
        /// Try to apply animation to rig.
        /// </summary>
        public void Apply(Rig rig)
        {
            bones.Clear();
            Vector3Df current;
            for (int i = 0; i < orientations.Count; i++)
            {
                Bone bone = new Bone();
                bones.Add(bone);

                var animBone = currentBones[i];

                var positionVar = animBone.Position;
                CFloat dtPos = positionVar.Dt;
                CUInt32 dataAddrPos = positionVar.DataAddr;
                CUInt32 dataAddrFallbackPos = positionVar.DataAddrFallback;
                CUInt16 numframesPos = positionVar.NumFrames;
                if (dtPos != null)
                    bone.position_dt = dtPos.val;
                if (dataAddrPos != null)
                    bone.position_dataAddr = dataAddrPos.val;
                if (dataAddrFallbackPos != null)
                    bone.position_dataAddrFallback = dataAddrFallbackPos.val;
                if (numframesPos != null)
                    bone.position_numFrames = numframesPos.val;

                var orientationVar = animBone.Orientation;
                CFloat dtRot = orientationVar.Dt;
                CUInt32 dataAddrRot = orientationVar.DataAddr;
                CUInt32 dataAddrFallbackRot = orientationVar.DataAddrFallback;
                CUInt16 numframesRot = orientationVar.NumFrames;
                if (dtRot != null)
                    bone.rotation_dt = dtRot.val;
                if (dataAddrRot != null)
                    bone.rotation_dataAddr = dataAddrRot.val;
                if (dataAddrFallbackRot != null)
                    bone.rotation_dataAddrFallback = dataAddrFallbackRot.val;
                if (numframesRot != null)
                    bone.rotation_numFrames = numframesRot.val;

                var scaleVar = animBone.Scale;
                CFloat dtScale = scaleVar.Dt;
                CUInt32 dataAddrScale = scaleVar.DataAddr;
                CUInt32 dataAddrFallbackScale = scaleVar.DataAddrFallback;
                CUInt16 numframesScale = scaleVar.NumFrames;
                if (dtScale != null)
                    bone.scale_dt = dtScale.val;
                if (dataAddrScale != null)
                    bone.scale_dataAddr = dataAddrScale.val;
                if (dataAddrFallbackScale != null)
                    bone.scale_dataAddrFallback = dataAddrFallbackScale.val;
                if (numframesScale != null)
                    bone.scale_numFrames = numframesScale.val;

                bone.BoneName = rig.meshSkeleton.names[i];
                for (int j = 0; j < positions[i].Count; j++)
                {
                    bone.positionFrames.Add(new Vector(positions[i][j].X, positions[i][j].Y, positions[i][j].Z));
                }

                for (int j = 0; j < orientations[i].Count; j++)
                {
                    current = orientationsEuler[i][j];
                    bone.rotationFrames.Add(orientations[i][j]);
                }

                for (int j = 0; j < scales[i].Count; j++)
                {
                    bone.scaleFrames.Add(new Vector(scales[i][j].X, scales[i][j].Y, scales[i][j].Z));
                }
            }
            exportData.bones = bones;
        }

        public void SaveJson(string filename)
        {
            //open file stream
            using (StreamWriter file = File.CreateText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                //serialize object directly into file stream
                serializer.Serialize(file, exportData);
            }
        }
    }
}
