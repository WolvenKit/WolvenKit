using System;
using System.Collections.Generic;
using System.Linq;
using SharpGLTF.Schema2;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;

namespace WolvenKit.Modkit.RED4.RigFile
{
    public class RIG
    {
        public static RawArmature? ProcessRig(CR2WFile? cr2w)
        {
            if (cr2w == null || cr2w.RootChunk is not animRig animrig)
            {
                return null;
            }

            var Rig = new RawArmature
            {
                BoneCount = animrig.BoneNames.Count,
                Names = animrig.BoneNames.Select(_ => _.GetResolvedText().NotNull()).ToArray(),
                Parent = animrig.BoneParentIndexes.Select(_ => (short)_).ToArray(),
                LocalPosn = animrig.BoneTransforms.Select(p => new Vec3(p.Translation.X, p.Translation.Z, -p.Translation.Y)).ToArray(),
                LocalRot = animrig.BoneTransforms.Select(p => new Quat(p.Rotation.I, p.Rotation.K, -p.Rotation.J, p.Rotation.R)).ToArray(),
                LocalScale = animrig.BoneTransforms.Select(p => new Vec3(p.Scale.X, p.Scale.Y, p.Scale.Z)).ToArray(),
            };

            // if AposeWorld/AposeMS Exists then..... this can be done better i guess...
            if (cr2w.RootChunk is animRig aRig)
            {
                if (aRig.APoseMS is not null && aRig.APoseMS.Count > 0)
                {
                    Rig.AposeMSExits = true;

                    Rig.AposeMSTrans = aRig.APoseMS.Select(p => new Vec3(p.Translation.X, p.Translation.Z, -p.Translation.Y)).ToArray();
                    Rig.AposeMSRot = aRig.APoseMS.Select(p => new Quat(p.Rotation.I, p.Rotation.K, -p.Rotation.J, p.Rotation.R)).ToArray();
                    Rig.AposeMSScale = aRig.APoseMS.Select(p => new Vec3(p.Scale.X, p.Scale.Y, p.Scale.Z)).ToArray();
                }

                // not sure how APose works or how the matrix multiplication will be, maybe its a recursive mul
                if (aRig.APoseLS is not null && aRig.APoseLS.Count > 0)
                {
                    Rig.AposeLSExits = true;

                    Rig.AposeLSTrans = aRig.APoseLS.Select(p => new Vec3(p.Translation.X, p.Translation.Z, -p.Translation.Y)).ToArray();
                    Rig.AposeLSRot = aRig.APoseLS.Select(p => new Quat(p.Rotation.I, p.Rotation.K, -p.Rotation.J, p.Rotation.R)).ToArray();
                    Rig.AposeLSScale = aRig.APoseLS.Select(p => new Vec3(p.Scale.X, p.Scale.Y, p.Scale.Z)).ToArray();
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
                var rig = rigs[i];

                ArgumentNullException.ThrowIfNull(rig.AposeLSTrans);
                ArgumentNullException.ThrowIfNull(rig.AposeLSScale);
                ArgumentNullException.ThrowIfNull(rig.AposeLSRot);
                ArgumentNullException.ThrowIfNull(rig.LocalPosn);
                ArgumentNullException.ThrowIfNull(rig.LocalScale);
                ArgumentNullException.ThrowIfNull(rig.LocalRot);
                ArgumentNullException.ThrowIfNull(rig.Names);

                for (var e = 0; e < rigs[i].BoneCount; e++)
                {
                    var found = false;
                    for (var eye = 0; eye < BoneCount; eye++)
                    {
                        if (Names[eye] == rig.Names[e])
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        Names.Add(rig.Names[e]);
                        if (rigs[i].AposeLSExits)
                        {
                            LocalPosn.Add(rig.AposeLSTrans[e]);
                            LocalScale.Add(rig.AposeLSScale[e]);
                            LocalRot.Add(rig.AposeLSRot[e]);
                        }
                        else
                        {
                            LocalPosn.Add(rig.LocalPosn[e]);
                            LocalScale.Add(rig.LocalScale[e]);
                            LocalRot.Add(rig.LocalRot[e]);
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
                    var rig = rigs[e];

                    ArgumentNullException.ThrowIfNull(rig.Names);
                    ArgumentNullException.ThrowIfNull(rig.Parent);

                    for (var eye = 0; eye < rig.BoneCount; eye++)
                    {
                        if (Names[i] == rig.Names[eye])
                        {
                            found = true;
                            parentName = rig.Names[rig.Parent[eye]];
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
            ArgumentNullException.ThrowIfNull(srcBones.Parent);
            ArgumentNullException.ThrowIfNull(srcBones.Names);
            ArgumentNullException.ThrowIfNull(srcBones.LocalScale);
            ArgumentNullException.ThrowIfNull(srcBones.LocalRot);
            ArgumentNullException.ThrowIfNull(srcBones.LocalPosn);

            if (srcBones.AposeLSExits)
            {
                ArgumentNullException.ThrowIfNull(srcBones.AposeLSScale);
                ArgumentNullException.ThrowIfNull(srcBones.AposeLSRot);
                ArgumentNullException.ThrowIfNull(srcBones.AposeLSTrans);
            }

            var bonesMapping = new Dictionary<int, Node>();
            var armature = model.UseScene(0).CreateNode("Armature");
            for (var i = 0; i < srcBones.BoneCount; i++)
            {
                if (srcBones.Parent[i] > -1)
                {
                    var bone = bonesMapping[srcBones.Parent[i]].CreateNode(srcBones.Names[i]);
                    if (srcBones.AposeLSExits)
                    {
                        var s = new Vec3(srcBones.AposeLSScale![i].X, srcBones.AposeLSScale[i].Y, srcBones.AposeLSScale[i].Z);
                        var r = new Quat(srcBones.AposeLSRot![i].X, srcBones.AposeLSRot[i].Y, srcBones.AposeLSRot[i].Z, srcBones.AposeLSRot[i].W);
                        var t = new Vec3(srcBones.AposeLSTrans![i].X, srcBones.AposeLSTrans[i].Y, srcBones.AposeLSTrans[i].Z);

                        bone.WithLocalScale(s).WithLocalRotation(r).WithLocalTranslation(t);
                    }
                    else
                    {
                        var s = new Vec3(srcBones.LocalScale[i].X, srcBones.LocalScale[i].Y, srcBones.LocalScale[i].Z);
                        var r = new Quat(srcBones.LocalRot[i].X, srcBones.LocalRot[i].Y, srcBones.LocalRot[i].Z, srcBones.LocalRot[i].W);
                        var t = new Vec3(srcBones.LocalPosn[i].X, srcBones.LocalPosn[i].Y, srcBones.LocalPosn[i].Z);

                        bone.WithLocalScale(s).WithLocalRotation(r).WithLocalTranslation(t);
                    }
                    bonesMapping[i] = bone;
                }
                else
                {
                    var root = armature.CreateNode(srcBones.Names[i]);
                    if (srcBones.AposeLSExits)
                    {
                        var s = new Vec3(srcBones.AposeLSScale![i].X, srcBones.AposeLSScale[i].Y, srcBones.AposeLSScale[i].Z);
                        var r = new Quat(srcBones.AposeLSRot![i].X, srcBones.AposeLSRot[i].Y, srcBones.AposeLSRot[i].Z, srcBones.AposeLSRot[i].W);
                        var t = new Vec3(srcBones.AposeLSTrans![i].X, srcBones.AposeLSTrans[i].Y, srcBones.AposeLSTrans[i].Z);
                        root.WithLocalScale(s).WithLocalRotation(r).WithLocalTranslation(t);
                    }
                    else
                    {
                        var s = new Vec3(srcBones.LocalScale[i].X, srcBones.LocalScale[i].Y, srcBones.LocalScale[i].Z);
                        var r = new Quat(srcBones.LocalRot[i].X, srcBones.LocalRot[i].Y, srcBones.LocalRot[i].Z, srcBones.LocalRot[i].W);
                        var t = new Vec3(srcBones.LocalPosn[i].X, srcBones.LocalPosn[i].Y, srcBones.LocalPosn[i].Z);

                        root.WithLocalScale(s).WithLocalRotation(r).WithLocalTranslation(t);
                    }
                    bonesMapping[i] = root;
                }
            }

            return bonesMapping;
        }
    }
}
