using System;
using System.Collections.Generic;
using System.Linq;
using SharpGLTF.Schema2;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Modkit.RED4.RigFile
{
    using Quat = System.Numerics.Quaternion;
    using Vec3 = System.Numerics.Vector3;

    public class RIG
    {
        public static RawArmature ProcessRig(CR2WFile cr2w)
        {
            if (cr2w == null || cr2w.RootChunk is not animRig animrig)
            {
                return null;
            }

            var Rig = new RawArmature
            {
                BoneCount = animrig.BoneNames.Count
            };

            Rig.Names = new string[Rig.BoneCount];
            for (var i = 0; i < animrig.BoneNames.Count; i++)
            {
                Rig.Names[i] = animrig.BoneNames[i];
            }

            Rig.Parent = new short[Rig.BoneCount];
            for (var i = 0; i < animrig.Unk1.Count; i++)
            {
                Rig.Parent[i] = animrig.Unk1[i];
            }

            Rig.LocalPosn = new Vec3[Rig.BoneCount];
            for (var i = 0; i < Rig.BoneCount; i++)
            {
                var v = new Vec3(animrig.Unk2[i][0].X, animrig.Unk2[i][0].Y, animrig.Unk2[i][0].Z);
                Rig.LocalPosn[i] = new Vec3(v.X, v.Z, -v.Y);
            }

            Rig.LocalRot = new Quat[Rig.BoneCount];

            for (var i = 0; i < Rig.BoneCount; i++)
            {
                var q = new Quat(animrig.Unk2[i][1].X, animrig.Unk2[i][1].Y, animrig.Unk2[i][1].Z, animrig.Unk2[i][1].W);
                Rig.LocalRot[i] = new Quat(q.X, q.Z, -q.Y, q.W);
            }

            Rig.LocalScale = new Vec3[Rig.BoneCount];
            for (var i = 0; i < Rig.BoneCount; i++)
            {
                var v = new Vec3(animrig.Unk2[i][2].X, animrig.Unk2[i][2].Y, animrig.Unk2[i][2].Z);
                Rig.LocalScale[i] = new Vec3(v.X, v.Y, v.Z);
            }

            // if AposeWorld/AposeMS Exists then..... this can be done better i guess...
            if (cr2w.RootChunk is animRig aRig)
            {
                if (aRig.APoseMS.Count != 0)
                {
                    Rig.AposeMSExits = true;
                    Rig.AposeMSTrans = new Vec3[Rig.BoneCount];
                    Rig.AposeMSRot = new Quat[Rig.BoneCount];
                    Rig.AposeMSScale = new Vec3[Rig.BoneCount];

                    for (var i = 0; i < Rig.BoneCount; i++)
                    {
                        float x = aRig.APoseMS[i].Translation.X;
                        float y = aRig.APoseMS[i].Translation.Y;
                        float z = aRig.APoseMS[i].Translation.Z;
                        Rig.AposeMSTrans[i] = new Vec3(x, z, -y);
                        float I = aRig.APoseMS[i].Rotation.I;
                        float J = aRig.APoseMS[i].Rotation.J;
                        float K = aRig.APoseMS[i].Rotation.K;
                        float R = aRig.APoseMS[i].Rotation.R;
                        Rig.AposeMSRot[i] = new Quat(I, K, -J, R);
                        float t = aRig.APoseMS[i].Scale.X;
                        float u = aRig.APoseMS[i].Scale.Y;
                        float v = aRig.APoseMS[i].Scale.Z;
                        Rig.AposeMSScale[i] = new Vec3(t, v, u);
                    }
                }

                // not sure how APose works or how the matrix multiplication will be, maybe its a recursive mul
                if (aRig.APoseLS.Count != 0)
                {
                    Rig.AposeLSExits = true;
                    Rig.AposeLSTrans = new Vec3[Rig.BoneCount];
                    Rig.AposeLSRot = new Quat[Rig.BoneCount];
                    Rig.AposeLSScale = new Vec3[Rig.BoneCount];

                    for (var i = 0; i < Rig.BoneCount; i++)
                    {
                        float x = aRig.APoseLS[i].Translation.X;
                        float y = aRig.APoseLS[i].Translation.Y;
                        float z = aRig.APoseLS[i].Translation.Z;
                        Rig.AposeLSTrans[i] = new Vec3(x, z, -y);
                        float I = aRig.APoseLS[i].Rotation.I;
                        float J = aRig.APoseLS[i].Rotation.J;
                        float K = aRig.APoseLS[i].Rotation.K;
                        float R = aRig.APoseLS[i].Rotation.R;
                        Rig.AposeLSRot[i] = new Quat(I, K, -J, R);
                        float t = aRig.APoseLS[i].Scale.X;
                        float u = aRig.APoseLS[i].Scale.Y;
                        float v = aRig.APoseLS[i].Scale.Z;
                        Rig.AposeLSScale[i] = new Vec3(t, v, u);
                    }
                }
            }

            var baseTendencyBoneNames = new string[] { "Root", "Hips", "Spine", "LeftUpLeg", "RightUpLeg", "Spine1", "LeftLeg", "RightLeg", "Spine2", "LeftFoot", "RightFoot", "Spine3",
                "LeftShoulder", "RightShoulder", "Neck", "LeftArm", "RightArm", "Neck1", "LeftForeArm", "RightForeArm", "Head" };
            Rig.baseTendencyCount = 0;
            for (var i = 0; i < baseTendencyBoneNames.Length; i++)
            {
                if (Rig.Names.Contains(baseTendencyBoneNames[i]))
                {
                    Rig.baseTendencyCount++;
                }
            }
            return Rig;
        }
        public static RawArmature CombineRigs(List<RawArmature> rigs)
        {
            rigs = rigs.OrderByDescending(_ => _.BoneCount).ToList();
            rigs = rigs.OrderByDescending(_ => _.baseTendencyCount).ToList();

            var Names = new List<string>();

            var Parent = new List<short>();
            var BoneCount = 0;
            var LocalPosn = new List<Vec3>();
            var LocalRot = new List<Quat>();
            var LocalScale = new List<Vec3>();

            for (var i = 0; i < rigs.Count; i++)
            {
                for (var e = 0; e < rigs[i].BoneCount; e++)
                {
                    var found = false;
                    for (var eye = 0; eye < BoneCount; eye++)
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
            for (var i = 1; i < BoneCount; i++)  // i = 1, assuming at i = 0 is always "Root" bone
            {
                var found = false;
                var parentName = string.Empty;

                for (var e = 0; e < rigs.Count; e++)
                {
                    for (var eye = 0; eye < rigs[e].BoneCount; eye++)
                    {
                        if (Names[i] == rigs[e].Names[eye])
                        {
                            found = true;
                            parentName = rigs[e].Names[rigs[e].Parent[eye]];
                            break;
                        }
                    }
                    if (found)
                    {
                        break;
                    }
                }
                for (short r = 0; r < BoneCount; r++)
                {
                    if (parentName == Names[r])
                    {
                        Parent.Add(r);
                        break;
                    }
                }
            }

            var CombinedRig = new RawArmature
            {
                BoneCount = BoneCount,
                Names = Names.ToArray(),
                Parent = Parent.ToArray(),
                LocalPosn = LocalPosn.ToArray(),
                LocalScale = LocalScale.ToArray(),
                LocalRot = LocalRot.ToArray(),
                AposeLSExits = false,
                AposeMSExits = false
            };

            return CombinedRig;
        }
        public static Dictionary<int, Node> ExportNodes(ref ModelRoot model, RawArmature srcBones)
        {
            var bonesMapping = new Dictionary<int, Node>();
            var armature = model.UseScene(0).CreateNode("Armature");
            for (var i = 0; i < srcBones.BoneCount; i++)
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
                    var root = armature.CreateNode(srcBones.Names[i]);
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
