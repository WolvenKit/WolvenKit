using System;
using System.Collections.Generic;
using System.Linq;
using DynamicData;
using Microsoft.ClearScript.JavaScript;
using SharpGLTF.Schema2;
using SharpGLTF.Transforms;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Types;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using Quat = System.Numerics.Quaternion;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;
using Mat44 = System.Numerics.Matrix4x4;

namespace WolvenKit.Modkit.RED4.RigFile
{
    public class RIG
    {
        private static void Swap<T>(IList<T> list, int indexA, int indexB)
        {
            T tmp = list[indexA];
            list[indexA] = list[indexB];
            list[indexB] = tmp;
        }
        public static bool ImportRig(ref CR2WFile cr2w, ModelRoot model)
        {
            if(cr2w.RootChunk is not animRig rig)
            {
                return false;
            }

            var armature = model.LogicalSkins.First();
            var joints = Enumerable.Range(0, armature.JointsCount).Select(_ => armature.GetJoint(_).Joint).ToList();

            Dictionary<string,short> jointNames = new Dictionary<string,short>();
            jointNames[joints.First().VisualParent.Name] = -1;
            
            foreach(var x in Enumerable.Range(0, joints.Count))
            {
                jointNames[joints[x].Name] = (short)x;
            }


            var newRig = new RawArmature
            {
                BoneCount = joints.Count,
                Names = joints.Select(_ => _.Name).ToArray(),
                Parent = joints.Select(_ => jointNames[_.VisualParent.Name]).ToArray(),
                LocalPosn = joints.Select(p => new Vec3(p.LocalTransform.Translation.X, -p.LocalTransform.Translation.Z, p.LocalTransform.Translation.Y)).ToArray(),
                LocalRot = joints.Select(p => new Quat(p.LocalTransform.Rotation.X, -p.LocalTransform.Rotation.Z, p.LocalTransform.Rotation.Y, p.LocalTransform.Rotation.W)).ToArray(),
                LocalScale = joints.Select(p => new Vec3(p.LocalTransform.Scale.X, p.LocalTransform.Scale.Y, p.LocalTransform.Scale.Z)).ToArray()
            };


            for (int i = 0; i < rig.BoneNames.Count; i++)
            {
                if (rig.BoneNames[i] != newRig.Names[i])
                {
                    int j = newRig.Names.IndexOf(rig.BoneNames[i].ToString());

                    Swap(newRig.Names, i, j);
                    Swap(newRig.Parent, i, j);
                    Swap(newRig.LocalPosn, i, j);
                    Swap(newRig.LocalRot, i, j);
                    Swap(newRig.LocalScale, i, j);
                }
            }

            var jointNames1 = jointNames.ToDictionary(x => x.Value, x => x.Key);

            for (int i = 0; i < newRig.BoneCount; i++)
            {
                var tmp = jointNames1[newRig.Parent[i]];
                newRig.Parent[i] = (short)newRig.Names.IndexOf(tmp);
            }

            rig.BoneNames.Clear();
            rig.BoneParentIndexes.Clear();
            rig.BoneTransforms.Clear();

            foreach (var x in Enumerable.Range(0, newRig.BoneCount))
            {
                rig.BoneNames.Add((CName)newRig.Names[x]);
                rig.BoneParentIndexes.Add((CInt16)newRig.Parent[x]);
                
                var qsT = new QsTransform();
                
                qsT.Translation = new Vec4(newRig.LocalPosn[x],1);
                qsT.Scale = new Vec4(newRig.LocalScale[x], 1);
                qsT.Rotation = newRig.LocalRot[x];
                rig.BoneTransforms.Add(qsT);
            }

            return true;
        }
        public static RawArmature? ProcessRig(CR2WFile? cr2w)
        {
            if (cr2w is not { RootChunk: animRig animRig })
            {
                return null;
            }

            var rig = new RawArmature
            {
                BoneCount = animRig.BoneNames.Count,
                Names = animRig.BoneNames.Select(_ => _.GetResolvedText().NotNull()).ToArray(),
                Parent = animRig.BoneParentIndexes.Select(_ => (short)_).ToArray(),
                LocalPosn = animRig.BoneTransforms.Select(p => new Vec3(p.Translation.X, p.Translation.Z, -p.Translation.Y)).ToArray(),
                LocalRot = animRig.BoneTransforms.Select(p => new Quat(p.Rotation.I, p.Rotation.K, -p.Rotation.J, p.Rotation.R)).ToArray(),
                LocalScale = animRig.BoneTransforms.Select(p => new Vec3(p.Scale.X, p.Scale.Y, p.Scale.Z)).ToArray(),

                ReferenceTracks = animRig.ReferenceTracks.Select(_ => (float)_).ToArray(),
            };

            // if AposeWorld/AposeMS Exists then..... this can be done better i guess...
            if (cr2w.RootChunk is animRig aRig)
            {
                if (aRig.APoseMS is not null && aRig.APoseMS.Count > 0)
                {
                    rig.AposeMSExits = true;

                    rig.AposeMSTrans = aRig.APoseMS.Select(p => new Vec3(p.Translation.X, p.Translation.Z, -p.Translation.Y)).ToArray();
                    rig.AposeMSRot = aRig.APoseMS.Select(p => new Quat(p.Rotation.I, p.Rotation.K, -p.Rotation.J, p.Rotation.R)).ToArray();
                    rig.AposeMSScale = aRig.APoseMS.Select(p => new Vec3(p.Scale.X, p.Scale.Y, p.Scale.Z)).ToArray();
                }

                // not sure how APose works or how the matrix multiplication will be, maybe its a recursive mul
                if (aRig.APoseLS is not null && aRig.APoseLS.Count > 0)
                {
                    rig.AposeLSExits = true;

                    rig.AposeLSTrans = aRig.APoseLS.Select(p => new Vec3(p.Translation.X, p.Translation.Z, -p.Translation.Y)).ToArray();
                    rig.AposeLSRot = aRig.APoseLS.Select(p => new Quat(p.Rotation.I, p.Rotation.K, -p.Rotation.J, p.Rotation.R)).ToArray();
                    rig.AposeLSScale = aRig.APoseLS.Select(p => new Vec3(p.Scale.X, p.Scale.Y, p.Scale.Z)).ToArray();
                    
                    rig.MeshInverseBinding = new Mat44[rig.BoneCount];

                    var temp = ModelRoot.CreateModel();
                    Skin temp1 = temp.CreateSkin();
                    var nodesRig = RIG.ExportNodes(ref temp, rig, true).Values.ToArray();

                    for (int i = 0; i < rig.BoneCount; i++)
                    {
                        var mat = nodesRig[i].WorldMatrix;
                        rig.MeshInverseBinding[i] = (Mat44)SkinnedTransform.CalculateInverseBinding(new Matrix4x4Double(Mat44.Identity), new Matrix4x4Double(mat));
                    }
                }
            }

            if(!rig.AposeLSExits)
            {
                rig.MeshInverseBinding = new Mat44[rig.BoneCount];

                var temp = ModelRoot.CreateModel();
                Skin temp1 = temp.CreateSkin();
                var nodesRig = RIG.ExportNodes(ref temp, rig, true).Values.ToArray();

                for (int i = 0; i < rig.BoneCount; i++)
                {
                    var mat = nodesRig[i].WorldMatrix;
                    rig.MeshInverseBinding[i] = (Mat44)SkinnedTransform.CalculateInverseBinding(new Matrix4x4Double(Mat44.Identity), new Matrix4x4Double(mat));
                }
            }
            var baseTendencyBoneNames = new string[] { "Root", "Hips", "Spine", "LeftUpLeg", "RightUpLeg", "Spine1", "LeftLeg", "RightLeg", "Spine2", "LeftFoot", "RightFoot", "Spine3",
                "LeftShoulder", "RightShoulder", "Neck", "LeftArm", "RightArm", "Neck1", "LeftForeArm", "RightForeArm", "Head" };
            rig.baseTendencyCount = 0;
            foreach (var name in baseTendencyBoneNames)
            {
                if (rig.Names.Contains(name))
                {
                    rig.baseTendencyCount++;
                }
            }
            return rig;
        }
        public static RawArmature CombineRigs(List<RawArmature> rigs)
        {
            rigs = rigs.OrderByDescending(_ => _.BoneCount).ToList();
            rigs = rigs.OrderByDescending(_ => _.baseTendencyCount).ToList();

            var names = new List<string>();

            var parent = new List<short>();
            var boneCount = 0;
            var localPosN = new List<Vec3>();
            var localRot = new List<Quat>();
            var localScale = new List<Vec3>();

            foreach (var rig in rigs)
            {
                ArgumentNullException.ThrowIfNull(rig.LocalPosn);
                ArgumentNullException.ThrowIfNull(rig.LocalScale);
                ArgumentNullException.ThrowIfNull(rig.LocalRot);
                ArgumentNullException.ThrowIfNull(rig.Names);

                if (rig.AposeLSExits)
                {
                    ArgumentNullException.ThrowIfNull(rig.AposeLSTrans);
                    ArgumentNullException.ThrowIfNull(rig.AposeLSScale);
                    ArgumentNullException.ThrowIfNull(rig.AposeLSRot);
                }

                for (var e = 0; e < rig.BoneCount; e++)
                {
                    var found = false;
                    for (var eye = 0; eye < boneCount; eye++)
                    {
                        if (names[eye] == rig.Names[e])
                        {
                            found = true;
                            break;
                        }
                    }
                    if (!found)
                    {
                        names.Add(rig.Names[e]);
                        if (rig.AposeLSExits)
                        {
                            localPosN.Add(rig.AposeLSTrans![e]);
                            localScale.Add(rig.AposeLSScale![e]);
                            localRot.Add(rig.AposeLSRot![e]);
                        }
                        else
                        {
                            localPosN.Add(rig.LocalPosn[e]);
                            localScale.Add(rig.LocalScale[e]);
                            localRot.Add(rig.LocalRot[e]);
                        }
                        boneCount++;
                    }
                }
            }
            // this rig merging is gonna break if someone tries to merge rigs not having a "Root" bone, generally seen with weapons etc.
            parent.Add(-1); // assuming at i = 0 is always "Root" bone
            for (var i = 1; i < boneCount; i++)  // i = 1, assuming at i = 0 is always "Root" bone
            {
                var found = false;
                var parentName = string.Empty;

                foreach (var rig in rigs)
                {
                    ArgumentNullException.ThrowIfNull(rig.Names);
                    ArgumentNullException.ThrowIfNull(rig.Parent);

                    for (var eye = 0; eye < rig.BoneCount; eye++)
                    {
                        if (names[i] == rig.Names[eye])
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
                for (short r = 0; r < boneCount; r++)
                {
                    if (parentName == names[r])
                    {
                        parent.Add(r);
                        break;
                    }
                }
            }

            var combinedRig = new RawArmature
            {
                BoneCount = boneCount,
                Names = names.ToArray(),
                Parent = parent.ToArray(),
                LocalPosn = localPosN.ToArray(),
                LocalScale = localScale.ToArray(),
                LocalRot = localRot.ToArray(),
                AposeLSExits = false,
                AposeMSExits = false,
                ReferenceTracks = Array.Empty<float>(),
            };

            return combinedRig;
        }
        public static Dictionary<int, Node> ExportNodes(ref ModelRoot model, RawArmature srcBones, bool useApose = true)
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
                    if (srcBones.AposeLSExits && useApose)
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
                    if (srcBones.AposeLSExits && useApose)
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
