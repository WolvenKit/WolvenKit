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
            public float duration;
            public uint numFrames;
            public float dt;
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
                W3FaceFile = new CR2WFile(br);
                //int count = Read(br, 0);
                var chunkMimicFace = W3FaceFile.chunks[0];
                var mimicSkeleton = W3FaceFile.chunks[1];
                var floatTrackSkeleton = W3FaceFile.chunks[2];

                var mimicSkeletonBones = mimicSkeleton.GetVariableByName("bones") as CArray;
                uint nbBones = (uint)mimicSkeletonBones.array.Count;
                foreach (CVector bone in mimicSkeletonBones)
                {
                    var boneName = bone.variables.GetVariableByName("nameAsCName") as CName;
                    //meshSkeleton.names.Add(boneName.Value);
                }

                //convert mapping into bone array
                var mimicMapping = (chunkMimicFace.GetVariableByName("mapping") as CArray).array;
                //ie. mimicMapping[0] = "uv_center_slide2"

                //give each mapping a name
                var tracks = (floatTrackSkeleton.GetVariableByName("tracks") as CArray).array;


                var mimicPoses = (chunkMimicFace.GetVariableByName("mimicPoses") as CArray).array;
                //save poses into

                for (int i = 0; i < mimicPoses.Count(); i++)
                {
                    AnimExportData pose = new AnimExportData();
                    string trackanme = ((tracks[i] as CVector).GetVariableByName("nameAsCName") as CName).Value;
                    pose.name = trackanme;
                    pose.numFrames = 1;
                    var mimicbones = (mimicPoses[i] as CArray).array;
                    List<Bone> exportBones = new List<Bone>();
                    for (int j = 0; j < mimicbones.Count(); j++)
                    {
                        Bone myBone = new Bone();
                        //finde the bone name using mapping
                        int map = (mimicMapping[j] as CInt32).val;
                        var BoneName = (mimicSkeletonBones.array[map] as CVector).GetVariableByName("nameAsCName") as CName;

                        myBone.BoneName = BoneName.Value; // find the mapping
                        float x =  ((mimicbones[j] as CEngineQsTransform).x as CFloat).val;
                        float y = ((mimicbones[j] as CEngineQsTransform).y as CFloat).val;
                        float z = ((mimicbones[j] as CEngineQsTransform).z as CFloat).val;
                        float pitch = ((mimicbones[j] as CEngineQsTransform).pitch as CFloat).val;
                        float yaw = ((mimicbones[j] as CEngineQsTransform).yaw as CFloat).val;
                        float roll = ((mimicbones[j] as CEngineQsTransform).roll as CFloat).val;
                        float w = ((mimicbones[j] as CEngineQsTransform).w as CFloat).val;
                        float scale_x = ((mimicbones[j] as CEngineQsTransform).scale_x as CFloat).val;
                        float scale_y = ((mimicbones[j] as CEngineQsTransform).scale_y as CFloat).val;
                        float scale_z = ((mimicbones[j] as CEngineQsTransform).scale_z as CFloat).val;
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