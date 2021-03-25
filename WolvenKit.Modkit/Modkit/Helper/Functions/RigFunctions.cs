using System;
using System.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.RED4.GeneralStructs;
using SharpGLTF.Scenes;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.RED4.RigFile
{
    using Vec3 = System.Numerics.Vector3;
    using Quat = System.Numerics.Quaternion;
    using Mat = System.Numerics.Matrix4x4;

    public class RIG
    {
        public static RawArmature ProcessRig(Stream fs)
        {
            BinaryReader br = new BinaryReader(fs);

            var cr2w = CP77.CR2W.ModTools.TryReadCr2WFile(fs);

            RawArmature Rig = new RawArmature();
            Rig.Names = GetboneNames(cr2w, "animRig");
            Rig.BoneCount = Rig.Names.Length;
            Rig.Rig = true;
            long offset = 0;
            offset = fs.Length - 48 * Rig.BoneCount - 2 * Rig.BoneCount;
            Rig.Parent = GetboneParents(fs, Rig.BoneCount, offset);

            offset = fs.Length - 48 * Rig.BoneCount;

            Rig.LocalPosn = new Vec3[Rig.BoneCount];

            for (int i = 0; i < Rig.BoneCount; i++)
            {
                fs.Position = offset + i * 48;
                Rig.LocalPosn[i] = new Vec3(br.ReadSingle(), br.ReadSingle(), br.ReadSingle());
            }

            Rig.LocalRot = new Quat[Rig.BoneCount];

            for (int i = 0; i < Rig.BoneCount; i++)
            {
                fs.Position = offset + i * 48 + 16;
                Rig.LocalRot[i] = new Quat(br.ReadSingle(), br.ReadSingle(), br.ReadSingle(), br.ReadSingle());
            }

            Rig.LocalScale = new Vec3[Rig.BoneCount];
            for (int i = 0; i < Rig.BoneCount; i++)
            {
                fs.Position = offset + i * 48 + 32;
                Rig.LocalScale[i] = new Vec3(br.ReadSingle(), br.ReadSingle(), br.ReadSingle());
            }
            
            // T R S to 4x4 matrix
            Mat[] matrix4Xes = new Mat[Rig.BoneCount];
            for (int i = 0; i < Rig.BoneCount; i++)
            {
                Mat T = Mat.CreateTranslation(Rig.LocalPosn[i]);
                Mat R = Mat.CreateFromQuaternion(Rig.LocalRot[i]);
                Mat S = Mat.CreateScale(Rig.LocalScale[i]);
                matrix4Xes[i] = (R * T)*S ; //  bereal careful with this scaling multiplication, since scale is always one, can't be trusted, R*T is okay
            }

            // creating worldspace matrix by parent multiplication
            for (int i = 0; i < Rig.BoneCount; i++)
            {
                int j = 0;
                j = Rig.Parent[i];
                if (j != -1)
                matrix4Xes[i] = matrix4Xes[i] * matrix4Xes[j];
            }

            Rig.WorldMat = new Mat[Rig.BoneCount];
            for (int i = 0; i < Rig.BoneCount; i++)
            {
                Rig.WorldMat[i] = matrix4Xes[i];
            }
            Rig.IBWorldMat = new Mat[Rig.BoneCount];
            for (int i = 0; i < Rig.BoneCount; i++)
            {
                 Mat.Invert(matrix4Xes[i],out Rig.IBWorldMat[i]);
            }
            // if AposeWorld/AposeMS Exists then..... this can be done better i guess...
            if ((cr2w.Chunks[0].data as animRig).APoseMS.Count != 0)
            {
                Rig.AposeMSExits = true;
                Rig.AposeMSTrans = new Vec3[Rig.BoneCount];
                Rig.AposeMSRot = new Quat[Rig.BoneCount];
                Rig.AposeMSScale = new Vec3[Rig.BoneCount];
                Rig.AposeMSMat = new Mat[Rig.BoneCount];
                Rig.IBAposeMat = new Mat[Rig.BoneCount];
                for (int i = 0; i < Rig.BoneCount; i++)
                {
                    float x = (cr2w.Chunks[0].data as animRig).APoseMS[i].Translation.X.Value;
                    float y = (cr2w.Chunks[0].data as animRig).APoseMS[i].Translation.Y.Value;
                    float z = (cr2w.Chunks[0].data as animRig).APoseMS[i].Translation.Z.Value;
                    Rig.AposeMSTrans[i] = new Vec3(x, y, z);
                    Mat Tra = Mat.CreateTranslation(Rig.AposeMSTrans[i]);
                    float I = (cr2w.Chunks[0].data as animRig).APoseMS[i].Rotation.I.Value;
                    float J = (cr2w.Chunks[0].data as animRig).APoseMS[i].Rotation.J.Value;
                    float K = (cr2w.Chunks[0].data as animRig).APoseMS[i].Rotation.K.Value;
                    float R = (cr2w.Chunks[0].data as animRig).APoseMS[i].Rotation.R.Value;
                    Rig.AposeMSRot[i] = new Quat(I, J, K, R);
                    Mat Rot = Mat.CreateFromQuaternion(Rig.AposeMSRot[i]);
                    float t = (cr2w.Chunks[0].data as animRig).APoseMS[i].Scale.X.Value;
                    float u = (cr2w.Chunks[0].data as animRig).APoseMS[i].Scale.Y.Value;
                    float v = (cr2w.Chunks[0].data as animRig).APoseMS[i].Scale.Z.Value;
                    Rig.AposeMSScale[i] = new Vec3(t, u, v);
                    Mat Sca = Mat.CreateScale(Rig.AposeMSScale[i]);
                    Rig.AposeMSMat[i] = (Rot * Tra) * Sca;
                }
                for (int i = 0; i < Rig.BoneCount; i++)
                {
                    Mat.Invert(Rig.AposeMSMat[i], out Rig.IBAposeMat[i]);
                }
            }

            // not sure how APose works or how the matrix multiplication will be, maybe its a recursive mul 
            if ((cr2w.Chunks[0].data as animRig).APoseLS.Count != 0)
            {
                Rig.AposeLSExits = true;
                Rig.AposeLSTrans = new Vec3[Rig.BoneCount];
                Rig.AposeLSRot = new Quat[Rig.BoneCount];
                Rig.AposeLSScale = new Vec3[Rig.BoneCount];
                Rig.AposeLSMat = new Mat[Rig.BoneCount];

                Mat[] matrix4X4s = new Mat[Rig.BoneCount];
                for (int i = 0; i < Rig.BoneCount; i++)
                {
                    float x = (cr2w.Chunks[0].data as animRig).APoseLS[i].Translation.X.Value;
                    float y = (cr2w.Chunks[0].data as animRig).APoseLS[i].Translation.Y.Value;
                    float z = (cr2w.Chunks[0].data as animRig).APoseLS[i].Translation.Z.Value;
                    Rig.AposeLSTrans[i] = new Vec3(x, y, z);
                    Mat Tra = Mat.CreateTranslation(Rig.AposeLSTrans[i]);
                    float I = (cr2w.Chunks[0].data as animRig).APoseLS[i].Rotation.I.Value;
                    float J = (cr2w.Chunks[0].data as animRig).APoseLS[i].Rotation.J.Value;
                    float K = (cr2w.Chunks[0].data as animRig).APoseLS[i].Rotation.K.Value;
                    float R = (cr2w.Chunks[0].data as animRig).APoseLS[i].Rotation.R.Value;
                    Rig.AposeLSRot[i] = new Quat(I, J, K, R);
                    Mat Rot = Mat.CreateFromQuaternion(Rig.AposeLSRot[i]);
                    float t = (cr2w.Chunks[0].data as animRig).APoseLS[i].Scale.X.Value;
                    float u = (cr2w.Chunks[0].data as animRig).APoseLS[i].Scale.Y.Value;
                    float v = (cr2w.Chunks[0].data as animRig).APoseLS[i].Scale.Z.Value;
                    Rig.AposeLSScale[i] = new Vec3(t, u, v);
                    Mat Sca = Mat.CreateScale(Rig.AposeLSScale[i]);

                    matrix4X4s[i] = (Rot * Tra) * Sca;
                }
                // recursive mul of AposeLS gives correct worlspace
                for (int i = 0; i < Rig.BoneCount; i++)
                {
                    int j = 0;
                    j = Rig.Parent[i];
                    if (j != -1)
                        matrix4X4s[i] = matrix4X4s[i] * matrix4X4s[j];
                }
                for (int i = 0; i < Rig.BoneCount; i++)
                {
                    Rig.AposeLSMat[i] = matrix4X4s[i];
                }
            }
            return Rig;
        }
        static Int16[] GetboneParents(Stream fs, int bonesCount, long offset)
        {
            BinaryReader br = new BinaryReader(fs);
            fs.Position = offset;

            Int16[] boneParents = new Int16[bonesCount];
            for (int i = 0; i < bonesCount; i++)
            {
                boneParents[i] = br.ReadInt16();
            }
            return boneParents;
        }
        public static string[] GetboneNames(CR2WFile cr2w, string Type)
        {
            int last = 0;
            for (int i = 0; i < cr2w.Chunks.Count; i++)
            {
                if (cr2w.Chunks[i].REDType == Type)
                {
                    last = i;
                }
            }
            int boneCount = 0;
            if (Type == "animRig")
                boneCount = (cr2w.Chunks[last].data as animRig).BoneNames.Count;
            else
                boneCount = (cr2w.Chunks[last].data as CMesh).BoneNames.Count;


            string[] bonenames = new string[boneCount];
            for (int i = 0; i < boneCount; i++)
            {
                if (Type == "animRig")
                    bonenames[i] = (cr2w.Chunks[last].data as animRig).BoneNames[i].Value;
                else
                    bonenames[i] = (cr2w.Chunks[last].data as CMesh).BoneNames[i].Value;
            }

            return bonenames;
        }

        public static RawArmature CombineRigs(List<RawArmature> rigs)
        {
            List<string> Names = new List<string>();

            List<Int16> Parent = new List<Int16>();
            int BoneCount = 0;
            List<Vec3> LocalPosn = new List<Vec3>();
            List<Quat> LocalRot = new List<Quat>();
            List<Vec3> LocalScale = new List<Vec3>();

            for(int i = 0; i < rigs.Count; i++)
            {
                for(int e = 0; e < rigs[i].BoneCount; e++)
                {
                    bool found = false;
                    for(int eye = 0; eye < BoneCount; eye++)
                    {
                        if (Names[eye] == rigs[i].Names[e])
                        {
                            found = true;
                            break;
                        }
                    }
                    if(!found)
                    {
                        Names.Add(rigs[i].Names[e]);
                        if(rigs[i].AposeLSExits)
                        {
                            LocalPosn.Add(rigs[i].AposeLSTrans[e]);
                            LocalScale.Add(rigs[i].AposeLSScale[e]);
                            LocalRot.Add(rigs[i].AposeLSRot[e]);
                        }
                        else
                        {
                            LocalPosn.Add(rigs[i].LocalPosn[e]);
                            LocalScale.Add(rigs[i].LocalScale[e]);
                            LocalRot.Add(rigs[i].LocalRot[e]);
                        }
                        BoneCount++;
                    }
                }
            }
            // this rig merging is gonna break if someone tries to merge rigs not having a "Root" bone, generally seen with weapons etc.
            Parent.Add(-1); // assuming at i = 0 is always "Root" bone
            for (int i = 1; i < BoneCount; i++)  // i = 1, assuming at i = 0 is always "Root" bone
            {
                bool found = false;
                string parentName = string.Empty;

                for(int e = 0; e < rigs.Count; e++)
                {
                    for(int eye = 0; eye < rigs[e].BoneCount; eye++)
                    {
                        if (Names[i] == rigs[e].Names[eye])
                        {
                            found = true;
                            parentName = rigs[e].Names[rigs[e].Parent[eye]];
                            break;
                        }
                    }
                    if (found)
                        break;
                }
                for (Int16 r = 0; r < BoneCount; r++)
                {
                    if (parentName == Names[r])
                    {
                        Parent.Add(r);
                        break;
                    }
                }
            }

            RawArmature CombinedRig = new RawArmature();
            CombinedRig.Rig = true;
            CombinedRig.BoneCount = BoneCount;
            CombinedRig.Names = Names.ToArray();
            CombinedRig.Parent = Parent.ToArray();
            CombinedRig.LocalPosn = LocalPosn.ToArray();
            CombinedRig.LocalScale = LocalScale.ToArray();
            CombinedRig.LocalRot = LocalRot.ToArray();
            CombinedRig.AposeLSExits = false;
            CombinedRig.AposeMSExits = false;

            Mat[] matrix4Xes = new Mat[CombinedRig.BoneCount];
            for (int i = 0; i < CombinedRig.BoneCount; i++)
            {
                Mat T = Mat.CreateTranslation(CombinedRig.LocalPosn[i]);
                Mat R = Mat.CreateFromQuaternion(CombinedRig.LocalRot[i]);
                Mat S = Mat.CreateScale(CombinedRig.LocalScale[i]);
                matrix4Xes[i] = (R * T) * S; //  bereal careful with this scaling multiplication, since scale is always one, can't be trusted, R*T is okay
            }

            // creating worldspace matrix by parent multiplication
            for (int i = 0; i < CombinedRig.BoneCount; i++)
            {
                int j = 0;
                j = CombinedRig.Parent[i];
                if (j != -1)
                    matrix4Xes[i] = matrix4Xes[i] * matrix4Xes[j];
            }

            CombinedRig.WorldMat = new Mat[CombinedRig.BoneCount];
            for (int i = 0; i < CombinedRig.BoneCount; i++)
            {
                CombinedRig.WorldMat[i] = matrix4Xes[i];
            }
            /*
            for (int i = 0; i < CombinedRig.BoneCount; i++)
            {
                Console.WriteLine(CombinedRig.Names[i] + " " + CombinedRig.Parent[i]);
            }
            */
            return CombinedRig;
        }
        public static Dictionary<int, NodeBuilder> ExportNodes(RawArmature rig)
        {
            var bonesMapping = new Dictionary<int, NodeBuilder>();

            // process bones
            for (int i = 0; i < rig.BoneCount; i++)
            {
                bonesMapping[i] = CreateBoneHierarchy(rig, i, bonesMapping);
            }

            // find root nodes by looking at the bones that don't have any parent.
            var bonesRoots = bonesMapping.Values.Where(n => n.Parent == null).FirstOrDefault();

            return bonesMapping;
        }
        // recursive helper class
        static NodeBuilder CreateBoneHierarchy(RawArmature srcBones, int srcIndex, IReadOnlyDictionary<int, NodeBuilder> bonesMap)
        {
            var dstNode = new NodeBuilder(srcBones.Names[srcIndex]);

            var srcParentIdx = srcBones.Parent[srcIndex]; // I guess a negative parent index means it's a root bone.

            if (srcParentIdx >= 0) // if this bone has a parent, get the parent NodeBuilder from the bonesMap. 
            {
                var dstParent = bonesMap[srcParentIdx];
                dstParent.AddNode(dstNode);
            }

            // fill transform or any other property...

            if(srcBones.AposeLSExits)
            {
                var s = new Vec3(srcBones.AposeLSScale[srcIndex].X, srcBones.AposeLSScale[srcIndex].Y, srcBones.AposeLSScale[srcIndex].Z);
                var r = new Quat(srcBones.AposeLSRot[srcIndex].X, srcBones.AposeLSRot[srcIndex].Y, srcBones.AposeLSRot[srcIndex].Z, srcBones.AposeLSRot[srcIndex].W);
                var t = new Vec3(srcBones.AposeLSTrans[srcIndex].X, srcBones.AposeLSTrans[srcIndex].Y, srcBones.AposeLSTrans[srcIndex].Z);

                if (srcBones.Names[srcIndex] == "Root")
                    r = new Quat((float)-0.707107, 0, 0, (float)0.707107); // to rotate rig +Z up

                dstNode.WithLocalTranslation(t).WithLocalRotation(r).WithLocalScale(s);
            }
            else
            {
                var s = new Vec3(srcBones.LocalScale[srcIndex].X, srcBones.LocalScale[srcIndex].Y, srcBones.LocalScale[srcIndex].Z);
                var r = new Quat(srcBones.LocalRot[srcIndex].X, srcBones.LocalRot[srcIndex].Y, srcBones.LocalRot[srcIndex].Z, srcBones.LocalRot[srcIndex].W);
                var t = new Vec3(srcBones.LocalPosn[srcIndex].X, srcBones.LocalPosn[srcIndex].Y, srcBones.LocalPosn[srcIndex].Z);

                if (srcBones.Names[srcIndex] == "Root")
                    r = new Quat((float)-0.707107, 0, 0, (float)0.707107);   // to rotate rig +Z up
                dstNode.WithLocalTranslation(t).WithLocalRotation(r).WithLocalScale(s);
            }
            return dstNode;
        }
    }
}
