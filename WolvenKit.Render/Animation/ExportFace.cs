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

    public class ExportFace
    {
        class AnimExportData
        {
            public string name;
            public List<Bone> bones;
            public uint numFrames;
#pragma warning disable CS0649
            public float duration;
            public float dt;
#pragma warning restore CS0649
        }
        AnimExportData exportData = new AnimExportData();
        
        List<AnimExportData> exportPoses = new List<AnimExportData>();
        private CR2WFile w3FaceFile;
        public CR2WFile W3FaceFile
        {
            get { return w3FaceFile; }
            set { w3FaceFile = value; }
        }

        public ExportFace()
        {
        }

        
        Dictionary<string, uint> dict = new Dictionary<string, uint>();
        public void LoadData(CR2WFile facFile)
        {
            byte[] data;
            data = File.ReadAllBytes(@"D:\w3.modding\FACE_ANIMATION\h_01_wa__ciri.w3fac");
            using (MemoryStream ms = new MemoryStream(data))
            using (BinaryReader br = new BinaryReader(ms))
            {
                W3FaceFile = new CR2WFile();
                w3FaceFile.Read(br);
                //int count = Read(br, 0);
                CMimicFace chunkMimicFace = W3FaceFile.chunks[0].data as CMimicFace;
                CSkeleton mimicSkeleton = W3FaceFile.chunks[1].data as CSkeleton;
                CSkeleton floatTrackSkeleton = W3FaceFile.chunks[2].data as CSkeleton;

                CArray<SSkeletonBone> mimicSkeletonBones = mimicSkeleton.Bones;
                uint nbBones = (uint)mimicSkeletonBones.Count;
                foreach (SSkeletonBone bone in mimicSkeletonBones)
                {
                    CName boneName = bone.NameAsCName;
                    //meshSkeleton.names.Add(boneName.Value);
                }

                //convert mapping into bone array
                CArray<CInt32> mimicMapping = chunkMimicFace.Mapping;
                //ie. mimicMapping[0] = "uv_center_slide2"

                //give each mapping a name
                CArray<SSkeletonTrack> tracks = floatTrackSkeleton.Tracks;

                CArray<CArray<EngineQsTransform>> mimicPoses = chunkMimicFace.MimicPoses;
                //save poses into

                for (int i = 0; i < mimicPoses.Count(); i++)
                {
                    AnimExportData pose = new AnimExportData();
                    string trackanme = tracks[i].NameAsCName.Value;
                    pose.name = trackanme;
                    pose.numFrames = 1;
                    CArray<EngineQsTransform> mimicbones = mimicPoses[i];
                    List<Bone> exportBones = new List<Bone>();
                    for (int j = 0; j < mimicbones.Count(); j++)
                    {
                        Bone myBone = new Bone();
                        //finde the bone name using mapping
                        int map = (mimicMapping[j] as CInt32).val;
                        var BoneName = mimicSkeletonBones[map].NameAsCName;

                        myBone.BoneName = BoneName.Value; // find the mapping
                        float x =  mimicbones[j].X.val;
                        float y = mimicbones[j].Y.val;
                        float z = mimicbones[j].Z.val;
                        float pitch = mimicbones[j].Pitch.val;
                        float yaw = mimicbones[j].Yaw.val;
                        float roll = mimicbones[j].Roll.val;
                        float w = mimicbones[j].W.val;
                        float scale_x = mimicbones[j].Scale_x.val;
                        float scale_y = mimicbones[j].Scale_y.val;
                        float scale_z = mimicbones[j].Scale_z.val;
                        myBone.positionFrames.Add(new Vector(x, y, z));
                        myBone.rotationFrames.Add(new Quaternion(pitch, yaw, roll, w));
                        myBone.scaleFrames.Add(new Vector(scale_x, scale_y, scale_z));
                        exportBones.Add(myBone);

                    }
                    pose.bones = exportBones;
                    exportPoses.Add(pose);
                }
            }
            //SaveJson(@"D:\w3.modding\FACE_ANIMATION\face_anims_test_01.json");
        }

        public void SaveJson(string filename)
        {
            //open file stream
            using (StreamWriter file = File.CreateText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Formatting = Formatting.Indented;
                //serialize object directly into file stream

                foreach (AnimExportData pose in exportPoses)
                {
                    if(pose.name == "jaw_open_a")
                        serializer.Serialize(file, pose);
                }
            }
        }
        
    }

}