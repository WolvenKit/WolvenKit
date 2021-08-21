using System;
using System.IO;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Types;
using WolvenKit.Modkit.RED4.GeneralStructs;
using SharpGLTF.Schema2;
using System.Collections.Generic;
using System.Linq;

namespace WolvenKit.Modkit.RED4.RigFile
{
    using Vec3 = System.Numerics.Vector3;
    using Quat = System.Numerics.Quaternion;

    public class RIG
    {
        private readonly Red4ParserService _modTools;

        public RIG(Red4ParserService modTools)
        {
            _modTools = modTools;
        }

        public RawArmature ProcessRig(Stream fs)
        {
            BinaryReader br = new BinaryReader(fs);

            var cr2w = _modTools.TryReadRED4File(fs);
            if (cr2w == null || !cr2w.Chunks.Select(_ => _.Data).OfType<animRig>().Any())
            {
                return new RawArmature();
            }
            RawArmature Rig = new RawArmature();
            Rig.Names = GetboneNames(cr2w);
            Rig.BoneCount = Rig.Names.Length;

            var animrig = cr2w.Chunks.Select(_ => _.Data).OfType<animRig>().First();
            Rig.Parent = GetboneParents(animrig);

            Rig.LocalPosn = new Vec3[Rig.BoneCount];

            for (int i = 0; i < Rig.BoneCount; i++)
            {
                Vec3 v = new Vec3(animrig.Unk2[i][0].X.Value, animrig.Unk2[i][0].Y.Value, animrig.Unk2[i][0].Z.Value);
                Rig.LocalPosn[i] = new Vec3(v.X, v.Z, -v.Y);
            }

            Rig.LocalRot = new Quat[Rig.BoneCount];

            for (int i = 0; i < Rig.BoneCount; i++)
            {
                Quat q = new Quat(animrig.Unk2[i][1].X.Value, animrig.Unk2[i][1].Y.Value, animrig.Unk2[i][1].Z.Value, animrig.Unk2[i][1].W.Value);
                Rig.LocalRot[i] = new Quat(q.X, q.Z, -q.Y, q.W);
            }

            Rig.LocalScale = new Vec3[Rig.BoneCount];
            for (int i = 0; i < Rig.BoneCount; i++)
            {
                Vec3 v = new Vec3(animrig.Unk2[i][2].X.Value, animrig.Unk2[i][2].Y.Value, animrig.Unk2[i][2].Z.Value);
                Rig.LocalScale[i] = new Vec3(v.X, v.Y, v.Z);
            }

            // if AposeWorld/AposeMS Exists then..... this can be done better i guess...
            if ((cr2w.Chunks[0].Data as animRig).APoseMS.Count != 0)
            {
                Rig.AposeMSExits = true;
                Rig.AposeMSTrans = new Vec3[Rig.BoneCount];
                Rig.AposeMSRot = new Quat[Rig.BoneCount];
                Rig.AposeMSScale = new Vec3[Rig.BoneCount];

                for (int i = 0; i < Rig.BoneCount; i++)
                {
                    float x = (cr2w.Chunks[0].Data as animRig).APoseMS[i].Translation.X.Value;
                    float y = (cr2w.Chunks[0].Data as animRig).APoseMS[i].Translation.Y.Value;
                    float z = (cr2w.Chunks[0].Data as animRig).APoseMS[i].Translation.Z.Value;
                    Rig.AposeMSTrans[i] = new Vec3(x, z, -y);
                    float I = (cr2w.Chunks[0].Data as animRig).APoseMS[i].Rotation.I.Value;
                    float J = (cr2w.Chunks[0].Data as animRig).APoseMS[i].Rotation.J.Value;
                    float K = (cr2w.Chunks[0].Data as animRig).APoseMS[i].Rotation.K.Value;
                    float R = (cr2w.Chunks[0].Data as animRig).APoseMS[i].Rotation.R.Value;
                    Rig.AposeMSRot[i] = new Quat(I, K, -J, R);
                    float t = (cr2w.Chunks[0].Data as animRig).APoseMS[i].Scale.X.Value;
                    float u = (cr2w.Chunks[0].Data as animRig).APoseMS[i].Scale.Y.Value;
                    float v = (cr2w.Chunks[0].Data as animRig).APoseMS[i].Scale.Z.Value;
                    Rig.AposeMSScale[i] = new Vec3(t, v, u);
                }
            }

            // not sure how APose works or how the matrix multiplication will be, maybe its a recursive mul
            if ((cr2w.Chunks[0].Data as animRig).APoseLS.Count != 0)
            {
                Rig.AposeLSExits = true;
                Rig.AposeLSTrans = new Vec3[Rig.BoneCount];
                Rig.AposeLSRot = new Quat[Rig.BoneCount];
                Rig.AposeLSScale = new Vec3[Rig.BoneCount];

                for (int i = 0; i < Rig.BoneCount; i++)
                {
                    float x = (cr2w.Chunks[0].Data as animRig).APoseLS[i].Translation.X.Value;
                    float y = (cr2w.Chunks[0].Data as animRig).APoseLS[i].Translation.Y.Value;
                    float z = (cr2w.Chunks[0].Data as animRig).APoseLS[i].Translation.Z.Value;
                    Rig.AposeLSTrans[i] = new Vec3(x, z, -y);
                    float I = (cr2w.Chunks[0].Data as animRig).APoseLS[i].Rotation.I.Value;
                    float J = (cr2w.Chunks[0].Data as animRig).APoseLS[i].Rotation.J.Value;
                    float K = (cr2w.Chunks[0].Data as animRig).APoseLS[i].Rotation.K.Value;
                    float R = (cr2w.Chunks[0].Data as animRig).APoseLS[i].Rotation.R.Value;
                    Rig.AposeLSRot[i] = new Quat(I, K, -J, R);
                    float t = (cr2w.Chunks[0].Data as animRig).APoseLS[i].Scale.X.Value;
                    float u = (cr2w.Chunks[0].Data as animRig).APoseLS[i].Scale.Y.Value;
                    float v = (cr2w.Chunks[0].Data as animRig).APoseLS[i].Scale.Z.Value;
                    Rig.AposeLSScale[i] = new Vec3(t, v, u);

                }
            }
            string[] baseTendencyBoneNames = new string[] { "Root", "Hips", "Spine", "LeftUpLeg", "RightUpLeg", "Spine1", "LeftLeg", "RightLeg", "Spine2", "LeftFoot", "RightFoot", "Spine3",
                "LeftShoulder", "RightShoulder", "Neck", "LeftArm", "RightArm", "Neck1", "LeftForeArm", "RightForeArm", "Head" };
            Rig.baseTendencyCount = 0;
            for(int i = 0; i < baseTendencyBoneNames.Length; i++)
            {
                if(Rig.Names.Contains(baseTendencyBoneNames[i]))
                {
                    Rig.baseTendencyCount++;
                }
            }
            return Rig;
        }
        static Int16[] GetboneParents(animRig animrig)
        {
            Int16[] boneParents = new Int16[animrig.Unk1.Count];
            for (int i = 0; i < animrig.Unk1.Count; i++)
            {
                boneParents[i] = animrig.Unk1[i].Value;
            }
            return boneParents;
        }
        public static string[] GetboneNames(CR2WFile cr2w)
        {
            string[] bonenames = new string[0];
            if (cr2w.Chunks.Select(_ => _.Data).OfType<animRig>().Any())
            {
                var animrig = cr2w.Chunks.Select(_ => _.Data).OfType<animRig>().First();
                bonenames = new string[animrig.BoneNames.Count];
                for (int i = 0; i < animrig.BoneNames.Count; i++)
                {
                    bonenames[i] = animrig.BoneNames[i].Value;
                }
            }
            if(cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().Any())
            {
                var meshrig = cr2w.Chunks.Select(_ => _.Data).OfType<CMesh>().First();
                bonenames = new string[meshrig.BoneNames.Count];
                for (int i = 0; i < meshrig.BoneNames.Count; i++)
                {
                    bonenames[i] = meshrig.BoneNames[i].Value;
                }
            }
            return bonenames;
        }
        public static RawArmature CombineRigs(List<RawArmature> rigs)
        {
            rigs = rigs.OrderByDescending(_ => _.BoneCount).ToList();
            rigs = rigs.OrderByDescending(_ => _.baseTendencyCount).ToList();

            List<string> Names = new List<string>();

            List<Int16> Parent = new List<Int16>();
            int BoneCount = 0;
            List<Vec3> LocalPosn = new List<Vec3>();
            List<Quat> LocalRot = new List<Quat>();
            List<Vec3> LocalScale = new List<Vec3>();

            for (int i = 0; i < rigs.Count; i++)
            {
                for (int e = 0; e < rigs[i].BoneCount; e++)
                {
                    bool found = false;
                    for (int eye = 0; eye < BoneCount; eye++)
                    {
                        if (Names[eye] == rigs[i].Names[e])
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Names.Add(rigs[i].Names[e]);
                        if (rigs[i].AposeLSExits)
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

                for (int e = 0; e < rigs.Count; e++)
                {
                    for (int eye = 0; eye < rigs[e].BoneCount; eye++)
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
            CombinedRig.BoneCount = BoneCount;
            CombinedRig.Names = Names.ToArray();
            CombinedRig.Parent = Parent.ToArray();
            CombinedRig.LocalPosn = LocalPosn.ToArray();
            CombinedRig.LocalScale = LocalScale.ToArray();
            CombinedRig.LocalRot = LocalRot.ToArray();
            CombinedRig.AposeLSExits = false;
            CombinedRig.AposeMSExits = false;

            return CombinedRig;
        }
        public static Dictionary<int, Node> ExportNodes(ref ModelRoot model, RawArmature srcBones)
        {
            var bonesMapping = new Dictionary<int, Node>();

            for (int i = 0; i < srcBones.BoneCount; i++)
            {
                if (srcBones.Parent[i] > -1)
                {
                    var bone = bonesMapping[srcBones.Parent[i]].CreateNode(srcBones.Names[i]);
                    if (srcBones.AposeLSExits)
                    {
                        var s = new Vec3(srcBones.AposeLSScale[i].X, srcBones.AposeLSScale[i].Y, srcBones.AposeLSScale[i].Z);
                        var r = new Quat(srcBones.AposeLSRot[i].X, srcBones.AposeLSRot[i].Y, srcBones.AposeLSRot[i].Z, srcBones.AposeLSRot[i].W);
                        var t = new Vec3(srcBones.AposeLSTrans[i].X, srcBones.AposeLSTrans[i].Y, srcBones.AposeLSTrans[i].Z);

                        bone.WithLocalTranslation(t).WithLocalRotation(r).WithLocalScale(s);
                    }
                    else
                    {
                        var s = new Vec3(srcBones.LocalScale[i].X, srcBones.LocalScale[i].Y, srcBones.LocalScale[i].Z);
                        var r = new Quat(srcBones.LocalRot[i].X, srcBones.LocalRot[i].Y, srcBones.LocalRot[i].Z, srcBones.LocalRot[i].W);
                        var t = new Vec3(srcBones.LocalPosn[i].X, srcBones.LocalPosn[i].Y, srcBones.LocalPosn[i].Z);

                        bone.WithLocalTranslation(t).WithLocalRotation(r).WithLocalScale(s);
                    }
                    bonesMapping[i] = bone;
                }
                else
                {
                    var root = model.UseScene(0).CreateNode(srcBones.Names[i]);
                    if (srcBones.AposeLSExits)
                    {
                        var s = new Vec3(srcBones.AposeLSScale[i].X, srcBones.AposeLSScale[i].Y, srcBones.AposeLSScale[i].Z);
                        var r = new Quat(srcBones.AposeLSRot[i].X, srcBones.AposeLSRot[i].Y, srcBones.AposeLSRot[i].Z, srcBones.AposeLSRot[i].W);
                        var t = new Vec3(srcBones.AposeLSTrans[i].X, srcBones.AposeLSTrans[i].Y, srcBones.AposeLSTrans[i].Z);
                        root.WithLocalTranslation(t).WithLocalRotation(r).WithLocalScale(s);
                    }
                    else
                    {
                        var s = new Vec3(srcBones.LocalScale[i].X, srcBones.LocalScale[i].Y, srcBones.LocalScale[i].Z);
                        var r = new Quat(srcBones.LocalRot[i].X, srcBones.LocalRot[i].Y, srcBones.LocalRot[i].Z, srcBones.LocalRot[i].W);
                        var t = new Vec3(srcBones.LocalPosn[i].X, srcBones.LocalPosn[i].Y, srcBones.LocalPosn[i].Z);

                        root.WithLocalTranslation(t).WithLocalRotation(r).WithLocalScale(s);
                    }
                    bonesMapping[i] = root;
                }
            }

            return bonesMapping;
        }
    }
}
