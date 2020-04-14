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
        private List<CVector> currentBones = new List<CVector>();
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
                    if (chunk.Type == "CSkeletalAnimation")
                    {
                        var name = chunk.GetVariableByName("name");
                        var chunkIdx = (chunk.GetVariableByName("animBuffer") as CPtr).ChunkIndex;
                        AnimationNames.Add(new KeyValuePair<string, int>((name as CName).Value, chunkIdx));
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
                    if (chunk.Type == "CAnimationBufferMultipart" && chunk.ChunkIndex == AnimationNames[selectedAnimIdx].Value)
                    {
                        foreach (CPtr Buffer in (chunk.GetVariableByName("parts") as CArray).array)
                        {
                            var a_buffer = Buffer.PtrTarget;
                            readBuffer(a_buffer, selectedAnimIdx, animFile);
                            break;
                        }
                        break;
                    }
                    if (chunk.Type == "CAnimationBufferBitwiseCompressed" && chunk.ChunkIndex == AnimationNames[selectedAnimIdx].Value)
                    {
                        readBuffer(chunk, selectedAnimIdx, animFile);
                        break;
                    }
                }
        }


        public void readBuffer(CR2WExportWrapper chunk, int selectedAnimIdx, CR2WFile animFile)
        {
            string dataAddrVar = "dataAddr";
            uint numFrames = (chunk.GetVariableByName("numFrames") as CUInt32).val;
            float animDuration = (chunk.GetVariableByName("duration") as CFloat)?.val ?? 1.0f;
            animationSpeed = numFrames / animDuration;
            uint keyFrame = 0;
            byte[] data;
            //data = (chunk.GetVariableByName("fallbackData") as CByteArray).Bytes;
            currentAnimName = AnimationNames[selectedAnimIdx].Key;
            exportData.name = AnimationNames[selectedAnimIdx].Key;
            exportData.duration = animDuration;
            exportData.numFrames = numFrames;
            exportData.dt = (chunk.GetVariableByName("dt") as CFloat)?.val ?? 0.03333333f;
            var deferredData = chunk.GetVariableByName("deferredData") as CInt16;
            var streamingOption = (chunk.GetVariableByName("streamingOption") as CVariable);

            if (deferredData != null && deferredData.val != 0)
                if (streamingOption != null && streamingOption.ToString() == "ABSO_PartiallyStreamable")
                    data = ConvertAnimation.Combine((chunk.GetVariableByName("data") as CByteArray).Bytes,
                    File.ReadAllBytes(animFile.FileName + "." + deferredData.val + ".buffer"));
                else
                    data = File.ReadAllBytes(animFile.FileName + "." + deferredData.val + ".buffer");
            else
                data = (chunk.GetVariableByName("data") as CByteArray).Bytes;
            using (MemoryStream ms = new MemoryStream(data))
            using (BinaryReader br = new BinaryReader(ms))
            {
                foreach (CVector bone in (chunk.GetVariableByName("bones") as CArray).array)
                {
                    List<uint> currkeyframe = new List<uint>();
                    List<Quaternion> currorient = new List<Quaternion>();
                    List<Vector3Df> currorientEuler = new List<Vector3Df>();
                    currentBones.Add(bone);

                    br.BaseStream.Position = ((bone.GetVariableByName("orientation") as CVector).GetVariableByName(dataAddrVar) as CUInt32).val;
                    int orientNumFrames = ((bone.GetVariableByName("orientation") as CVector).GetVariableByName("numFrames") as CUInt16).val;

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
                    var compr = (bone.GetVariableByName("position") as CVector).GetVariableByName("compression") as CInt8;
                    if (compr != null)
                        compression = compr.val;
                    var addr = (bone.GetVariableByName("position") as CVector).GetVariableByName(dataAddrVar) as CUInt32;
                    if (addr != null)
                        br.BaseStream.Position = addr.val;
                    else
                        br.BaseStream.Position = 0;
                    var posNumFrames = ((bone.GetVariableByName("position") as CVector).GetVariableByName("numFrames") as CUInt16).val;
                    for (uint idx = 0; idx < posNumFrames; idx++)
                    {
                        keyFrame = idx;
                        //keyFrame += numFrames;
                        currkeyframe.Add(keyFrame);
                        var vec = new CVector3D();
                        vec.Read(br, compression);
                        Vector3Df pos = new Vector3Df(vec.x.val, vec.y.val, vec.z.val);
                        currposition.Add(pos);
                    }
                    positionsKeyframes.Add(currkeyframe);
                    positions.Add(currposition);

                    List<Vector3Df> currscale = new List<Vector3Df>();
                    currkeyframe = new List<uint>();
                    compression = 0;
                    compr = (bone.GetVariableByName("scale") as CVector).GetVariableByName("compression") as CInt8;
                    if (compr != null)
                        compression = compr.val;
                    addr = (bone.GetVariableByName("scale") as CVector).GetVariableByName(dataAddrVar) as CUInt32;
                    if (addr != null)
                        br.BaseStream.Position = addr.val;
                    else
                        br.BaseStream.Position = 0;
                    var scaleNumFrames = ((bone.GetVariableByName("scale") as CVector).GetVariableByName("numFrames") as CUInt16).val;
                    for (uint idx = 0; idx < scaleNumFrames; idx++)
                    {
                        keyFrame = idx;
                        //keyFrame += numFrames;
                        currkeyframe.Add(keyFrame);
                        var vec = new CVector3D();
                        vec.Read(br, compression);
                        Vector3Df scale = new Vector3Df(vec.x.val, vec.y.val, vec.z.val);
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

                CVector animBone = currentBones[i];

                CVector positionVar = animBone.GetVariableByName("position") as CVector;
                CFloat dtPos = positionVar.GetVariableByName("dt") as CFloat;
                CUInt32 dataAddrPos = positionVar.GetVariableByName("dataAddr") as CUInt32;
                CUInt32 dataAddrFallbackPos = positionVar.GetVariableByName("dataAddrFallback") as CUInt32;
                CUInt16 numframesPos = positionVar.GetVariableByName("numFrames") as CUInt16;
                if (dtPos != null)
                    bone.position_dt = dtPos.val;
                if (dataAddrPos != null)
                    bone.position_dataAddr = dataAddrPos.val;
                if (dataAddrFallbackPos != null)
                    bone.position_dataAddrFallback = dataAddrFallbackPos.val;
                if (numframesPos != null)
                    bone.position_numFrames = numframesPos.val;

                CVector orientationVar = animBone.GetVariableByName("orientation") as CVector;
                CFloat dtRot = orientationVar.GetVariableByName("dt") as CFloat;
                CUInt32 dataAddrRot = orientationVar.GetVariableByName("dataAddr") as CUInt32;
                CUInt32 dataAddrFallbackRot = orientationVar.GetVariableByName("dataAddrFallback") as CUInt32;
                CUInt16 numframesRot = orientationVar.GetVariableByName("numFrames") as CUInt16;
                if (dtRot != null)
                    bone.rotation_dt = dtRot.val;
                if (dataAddrRot != null)
                    bone.rotation_dataAddr = dataAddrRot.val;
                if (dataAddrFallbackRot != null)
                    bone.rotation_dataAddrFallback = dataAddrFallbackRot.val;
                if (numframesRot != null)
                    bone.rotation_numFrames = numframesRot.val;

                CVector scaleVar = animBone.GetVariableByName("scale") as CVector;
                CFloat dtScale = scaleVar.GetVariableByName("dt") as CFloat;
                CUInt32 dataAddrScale = scaleVar.GetVariableByName("dataAddr") as CUInt32;
                CUInt32 dataAddrFallbackScale = scaleVar.GetVariableByName("dataAddrFallback") as CUInt32;
                CUInt16 numframesScale = scaleVar.GetVariableByName("numFrames") as CUInt16;
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
