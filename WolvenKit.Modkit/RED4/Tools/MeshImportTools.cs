using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using SharpGLTF.Schema2;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.Modkit.RED4.Tools;
using WolvenKit.RED4.Archive;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.Archive.IO;
using WolvenKit.RED4.Types;
using Mat4 = System.Numerics.Matrix4x4;
using Quat = System.Numerics.Quaternion;
using Vec2 = System.Numerics.Vector2;
using Vec3 = System.Numerics.Vector3;
using Vec4 = System.Numerics.Vector4;

namespace WolvenKit.Modkit.RED4
{
    public partial class ModTools
    {
        //WIP does not do the thing yet
        public bool ImportRig(FileInfo inGltfFile, Stream rigStream, GltfImportArgs args)
        {
            var cr2w = _wolvenkitFileService.ReadRed4File(rigStream);

            if (cr2w == null || cr2w.RootChunk is not animRig rig)
            {
                return false;
            }

            var model = ModelRoot.Load(inGltfFile.FullName, new ReadSettings(args.validationMode));

            //VerifyGLTF(model);

            var armature = new List<LogicalChildOfRoot>();

            var joints = new List<(Node Joint, Mat4 InverseBindMatrix)>();
            var jointlist = new List<Node>();
            var jointnames = new List<string>();
            var jointparentnames = new List<string>();
            var ibm = new List<Mat4>();
            var wm = new List<Mat4>();


            if (model.LogicalSkins.Count > 0)
            {
                armature = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => (LogicalChildOfRoot)model.LogicalSkins[0]).ToList();
                joints = Enumerable.Range(0, armature.Count).Select(_ => ((Skin)armature[_]).GetJoint(_)).ToList();
                jointlist = Enumerable.Range(0, armature.Count).Select(_ => ((Skin)armature[_]).GetJoint(_).Joint).ToList();
                jointnames = Enumerable.Range(0, armature.Count).Select(_ => ((Skin)armature[_]).GetJoint(_).Joint.Name).ToList();
                jointparentnames = Enumerable.Range(0, armature.Count).Select(_ => ((Skin)armature[_]).GetJoint(_).Joint.VisualParent.Name).ToList();
                ibm = Enumerable.Range(0, armature.Count).Select(_ => ((Skin)armature[_]).GetJoint(_).InverseBindMatrix).ToList();
                wm = Enumerable.Range(0, armature.Count).Select(_ => ((Skin)armature[_]).GetJoint(_).Joint.WorldMatrix).ToList();
            }
            else
            {
                if (model.LogicalNodes.Count > 0)
                {
                    armature = Enumerable.Range(0, model.LogicalNodes.Count).Select(_ => (LogicalChildOfRoot)model.LogicalNodes[_]).ToList();
                    jointlist = Enumerable.Range(0, armature.Count).Select(_ => (Node)armature[_]).ToList();
                    jointnames = Enumerable.Range(0, armature.Count).Select(_ => ((Node)armature[_]).Name).ToList();
                    jointparentnames = Enumerable.Range(0, armature.Count).Select(_ => ((Node)armature[_]).VisualParent is null
                                                                        ? "firstbone" : ((Node)armature[_]).VisualParent.Name).ToList();
                    wm = Enumerable.Range(0, armature.Count).Select(_ => ((Node)armature[_]).WorldMatrix).ToList();

                    for (var i = 0; i < wm.Count; i++)
                    {
                        var temp = new Mat4();
                        Mat4.Invert(wm[i], out temp);
                        ibm.Add(temp);
                    }
                    //ibm = Enumerable.Range(0, wm.Count).Select(_ => Mat4.Invert( wm[_], out ibm[_] )).ToList();
                    joints = Enumerable.Range(0, armature.Count).Select(_ => (jointlist[_], ibm[_])).ToList();
                }
            }

            int[] GetLevels(string root = "Root")
            {
                var rootindex = jointnames.IndexOf("Root");
                var treelevel = new int[jointnames.Count];

                if (jointparentnames[rootindex].Contains("Armature"))
                {
                    void rec(string parent, int level)
                    {
                        var tindex = Enumerable.Range(0, jointnames.Count).Where(i => jointparentnames[i] == parent).ToList();
                        if (tindex is not null)
                        {
                            foreach (var ind in tindex)
                            {
                                treelevel[ind] = level;
                                rec(jointnames[ind], level + 1);
                            }
                        }
                    }
                    rec(root, 0);
                    return treelevel;
                }
                return null;
            }

            Mat4.Invert(joints[1].Joint.WorldMatrix, out var inversedWorldMatrix);
            Mat4.Invert(joints[1].Joint.LocalMatrix, out var inversedLocalMatrix);

            var oriRotM = Mat4.CreateFromQuaternion(joints[1].Joint.LocalTransform.Rotation);
            var oriScaM = Mat4.CreateScale(joints[1].Joint.LocalTransform.Scale);
            var oriTraM = Mat4.CreateTranslation(joints[1].Joint.LocalTransform.Translation);

            var RotM = oriScaM * joints[1].InverseBindMatrix * oriTraM;
            Mat4.Invert(RotM, out RotM);

            var manualTRS = oriTraM * oriRotM * oriScaM;
            Mat4.Invert(manualTRS, out var inversedManualTRS);

            var manualRotM = oriScaM * inversedManualTRS * oriTraM;
            Mat4.Invert(manualRotM, out manualRotM);

            var inv2 = oriTraM * RotM * oriScaM;

            var localinvRotM = oriScaM * inversedLocalMatrix * oriTraM;
            Mat4.Invert(localinvRotM, out localinvRotM);

            var rotationVector = Quat.CreateFromRotationMatrix(RotM);
            var manualrotationVector = Quat.CreateFromRotationMatrix(manualRotM);
            var localrotationVector = Quat.CreateFromRotationMatrix(localinvRotM);

            var levels = GetLevels("Root");
            if (levels is not null)
            {
                for (var i = 0; i < rig.BoneNames.Count; i++)
                {
                    var currentbone = rig.BoneNames[i];
                    var index = jointnames.IndexOf(currentbone);
                    var parindex = jointnames.IndexOf(jointlist[index].VisualParent.Name);

                    {
                        /*
                                            rig.BoneTransforms[i].Rotation.I = jointlist[index].LocalTransform.Rotation.X;
                                            rig.BoneTransforms[i].Rotation.J = -jointlist[index].LocalTransform.Rotation.Z;
                                            rig.BoneTransforms[i].Rotation.K = jointlist[index].LocalTransform.Rotation.Y;
                                            rig.BoneTransforms[i].Rotation.R = jointlist[index].LocalTransform.Rotation.W;

                                            rig.BoneTransforms[i].Scale.W = 1;
                                            rig.BoneTransforms[i].Scale.X = jointlist[index].LocalTransform.Scale.X;
                                            rig.BoneTransforms[i].Scale.Y = jointlist[index].LocalTransform.Scale.Y;
                                            rig.BoneTransforms[i].Scale.Z = jointlist[index].LocalTransform.Scale.Z;

                                            rig.BoneTransforms[i].Translation.W = i == 0 ? 1 : 0;
                                            rig.BoneTransforms[i].Translation.X = jointlist[index].LocalTransform.Translation.X;
                                            rig.BoneTransforms[i].Translation.Y = -jointlist[index].LocalTransform.Translation.Z;
                                            rig.BoneTransforms[i].Translation.Z = jointlist[index].LocalTransform.Translation.Y;
                        */
                    } //gotta figure out those rotations

                    var oriR = rig.BoneTransforms[i].Rotation;
                    var oriRquat = new Quat(oriR.I, oriR.J, oriR.K, oriR.R);
                    var newR = jointlist[index].LocalTransform.Rotation;
                    var parR = jointlist[index].VisualParent.LocalTransform.Rotation;

                    var oriT = rig.BoneTransforms[i].Translation;
                    var oriTvec = new Vec4(oriT.X, oriT.Y, oriT.Z, oriT.W);
                    var newT = jointlist[index].LocalTransform.Translation;
                    var parT = jointlist[index].VisualParent.LocalTransform.Translation;

                    var herewegoagane = parR * newR;


                    var quatM = Mat4.CreateFromQuaternion(oriRquat);

                    var d = newR - oriRquat + new Quat(0, 0, 0, 1);
                    var p = newR * oriRquat;
                    var e = d == p;
                    var esmall = (d - p).Length() < 0.001;

                    var level = levels[index];

                    {/*
                        var nya = System.Numerics.Vector3.Transform(tr, parR);

                        //var rr = jointlist[index].VisualParent.VisualParent.LocalTransform.Rotation;
                        var nye = System.Numerics.Vector3.Transform(tr, parR * rr);
                        var rrr = jointlist[index].VisualParent.VisualParent.VisualParent.LocalTransform.Rotation;
                        var ya = System.Numerics.Vector3.Transform(tr, parR * rr * rrr);

                        var (r, s, t) = (new Quat(), new Vec3(), new Vec3());
                        var tinverse = new Mat4();
                        Mat4.Invert(jointlist[index].VisualParent.WorldMatrix, out tinverse);
                        Mat4.Decompose(tinverse, out s, out r, out t);

                        var yaya = System.Numerics.Vector3.Transform(tr, r * parR);*/
                    }

                    /*Mat4 TRSFromRig(QsTransform parTr)
                    {
                        var (r, s, t) = (parTr.Rotation, parTr.Scale, parTr.Translation);

                        var R = Mat4.CreateFromQuaternion(new Quat(r.R, r.I, r.J, r.K));
                        var S = Mat4.CreateScale(new Vec3(s.X, s.Y, s.Z));
                        var T = Mat4.CreateTranslation(new Vec3(t.X, t.Y, t.Z));
                        var M = T * R * S;
                        return M;
                    }

                    if (index > -1 && parindex > -1)
                    {
                        var parM = TRSFromRig(rig.BoneTransforms[parindex]);
                        Mat4.Invert(parM, out var parMinv);
                        var M = TRSFromRig(rig.BoneTransforms[index]);
                        Mat4.Invert(jointlist[index].VisualParent.WorldMatrix, out var tinverse);
                        Mat4.Decompose(parMinv * M, out var s, out var r, out var t);
                    }*/

                    Quat AllOriginalRotations(int i)
                    {
                        var wquat = rig.BoneTransforms[i].Rotation;
                        var quat = new Quat(wquat.I, wquat.J, wquat.K, wquat.R);
                        return (rig.BoneNames[i] == "Root") ? quat : AllOriginalRotations(rig.BoneParentIndexes[i]) * quat;
                    }

                    var oriAllR = AllOriginalRotations(i);
                    var oriParAllR = oriAllR * Quat.Inverse(oriRquat);
                    var yetatr = Vec4.Transform(newT, oriAllR);

                    Quat AllRotations(Node node)
                    {
                        var quat = node.LocalTransform.Rotation;
                        return (node.Name == "Root") ? quat : AllRotations(node.VisualParent) * quat;
                    }

                    var infinya = AllRotations(jointlist[index]);
                    var finit = Vec4.Transform(newT, infinya);
                    var aynifni = Vec4.Transform(newT, Quat.Inverse(infinya));


                    var before = rig.BoneTransforms[i].Translation.DeepCopy();

                    //level = 0;

                    var x90 = Quat.CreateFromAxisAngle(Vec3.UnitX, (float)Math.PI / 2);
                    var y90 = Quat.CreateFromAxisAngle(Vec3.UnitY, (float)Math.PI / 2);
                    var z90 = Quat.CreateFromAxisAngle(Vec3.UnitZ, (float)Math.PI / 2);


                    //works only for the rig of the kusanagi bike
                    rig.BoneTransforms[i].Translation = level == 1 ? Vec4.Transform(newT, x90) :
                                                        level is 3 or
                                                        4 ? Vec4.Transform(newT, new Quat(0, 1, 0, 0) * x90) :
                                                        level == 5 ? Vec4.Transform(newT, x90) :
                                                        level == 6 ? Vec4.Transform(newT, z90) :
                                                        level == 8 ? Vec4.Transform(newT, y90 * new Quat(0, 0, 0, 1)) : // Quat(0, 0, 0, 1) is z90 * z90
                                                        new Vec4(newT.X, newT.Y, newT.Z, 0);

                    rig.BoneTransforms[i].Translation.W = i == 0 ? 1 : 0;

                    /*
                                            rig.BoneTransforms[i].Translation.X = level == 6 ? -newT.Y :
                                                                                  level == 8 ? newT.Z :
                                                                                  newT.X;
                                            rig.BoneTransforms[i].Translation.Y = level == 1 ? newT.Z :
                                                                                  level == 3 ? -newT.Z :
                                                                                  level == 4 ? -newT.Z :
                                                                                  level == 5 ? -newT.Z :
                                                                                  level == 6 ? newT.X :
                                                                                  level == 8 ? -newT.Y :
                                                                                  newT.Y;
                                            rig.BoneTransforms[i].Translation.Z = level == 1 ? newT.Y :
                                                                                  level == 3 ? -newT.Y :
                                                                                  level == 4 ? -newT.Y :
                                                                                  level == 5 ? newT.Y :
                                                                                  level == 8 ? newT.X :
                                                                                  newT.Z;
                    */

                    var after = rig.BoneTransforms[i].Translation;
                }
            }
            var ms = new MemoryStream();
            using var writer = new CR2WWriter(ms, Encoding.UTF8, true);
            writer.WriteFile(cr2w);
            ms.Seek(0, SeekOrigin.Begin);

            rigStream.SetLength(0);
            ms.CopyTo(rigStream);

            return true;
        }


        public bool ImportMesh(FileInfo inGltfFile, Stream inmeshStream, GltfImportArgs args, Stream outStream = null)
        {
            var cr2w = _wolvenkitFileService.ReadRed4File(inmeshStream);

            if (cr2w == null || cr2w.RootChunk is not CMesh meshBlob || meshBlob.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendblob)
            {
                return false;
            }

            var originalRig = args.Rig?.FirstOrDefault();

            if (File.Exists(Path.ChangeExtension(inGltfFile.FullName, ".Material.json")))
            {
                if (args.Archives != null)
                {
                    WriteMatToMesh(ref cr2w, File.ReadAllText(Path.ChangeExtension(inGltfFile.FullName, ".Material.json")), args.Archives);
                }
                if (args.importMaterialOnly)
                {
                    var matOnlyStream = new MemoryStream();

                    //cr2w.Write(new BinaryWriter(matOnlyStream));
                    using var writer = new CR2WWriter(matOnlyStream);
                    writer.WriteFile(cr2w);


                    matOnlyStream.Seek(0, SeekOrigin.Begin);
                    if (outStream != null)
                    {
                        matOnlyStream.CopyTo(outStream);
                    }
                    else
                    {
                        inmeshStream.SetLength(0);
                        matOnlyStream.CopyTo(inmeshStream);
                    }
                    return true;
                }

            }

            var model = ModelRoot.Load(inGltfFile.FullName, new ReadSettings(args.validationMode));

            if (model.LogicalSkins.Count > 0)
            {

                var joints = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_)).ToArray();

                var jointarray = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint).ToArray();
                var jointnames = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.Name).ToArray();

                var ibm = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).InverseBindMatrix).ToArray();
                var wm = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.WorldMatrix).ToArray();

                if (cr2w.RootChunk is CMesh root)
                {
                    for (var i = 0; i < root.BoneNames.Count; i++)
                    {
                        var foundbone = jointarray.FirstOrDefault(x => root.BoneNames[i] == x.Name);
                        if (foundbone is not null)
                        {
                            var inversedWorldMatrix = new System.Numerics.Matrix4x4();
                            System.Numerics.Matrix4x4.Invert(foundbone.WorldMatrix, out inversedWorldMatrix);


                            root.BoneRigMatrices[i] = inversedWorldMatrix;
                            root.BoneRigMatrices[i].W.Y = -inversedWorldMatrix.M43;
                            root.BoneRigMatrices[i].W.Z = inversedWorldMatrix.M42;
                            //component Y and -Z are being swapped in vector W
                            //should probably figure out why
                        }
                    }
                }
            }

            var tt = model.LogicalSkins.Count >= 2 ?
                Enumerable.Range(0, model.LogicalSkins[1].JointsCount).Select(_ => model.LogicalSkins[1].GetJoint(_).Joint.WorldMatrix).ToArray()
                : null;

            var tjointnames = model.LogicalSkins.Count >= 2 ?
                Enumerable.Range(0, model.LogicalSkins[1].JointsCount).Select(_ => model.LogicalSkins[1].GetJoint(_).Joint.Name).ToArray()
                : null;


            /*
                        var somerig = MeshTools.GetOrphanRig(model);
                        var newmodel = ModelRoot.CreateModel();
                        var tempdict = RIG.ExportNodes(ref newmodel, somerig);
            */

            if (model.LogicalSkins.Count > 0)
            {

                var joints = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_)).ToArray();

                var jointarray = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint).ToArray();
                var jointnames = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.Name).ToArray();

                var ibm = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).InverseBindMatrix).ToArray();
                var wm = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.WorldMatrix).ToArray();

                if (cr2w.RootChunk is CMesh root)
                {
                    for (var i = 0; i < root.BoneNames.Count; i++)
                    {
                        var foundbone = jointarray.FirstOrDefault(x => root.BoneNames[i] == x.Name);
                        if (foundbone is not null)
                        {
                            var inversedWorldMatrix = new Mat4();
                            Mat4.Invert(foundbone.WorldMatrix, out inversedWorldMatrix);


                            root.BoneRigMatrices[i] = inversedWorldMatrix;
                            root.BoneRigMatrices[i].W.Y = -inversedWorldMatrix.M43;
                            root.BoneRigMatrices[i].W.Z = inversedWorldMatrix.M42;
                            //component Y and -Z are being swapped in vector W
                            //should probably figure out why
                        }
                    }
                }
            }

            VerifyGLTF(model);

            var Meshes = new List<RawMeshContainer>();
            foreach (var node in model.LogicalNodes)
            {
                if (node.Mesh != null)
                {
                    Meshes.Add(GltfMeshToRawContainer(node));
                }
                else if (args.FillEmpty)
                {
                    Meshes.Add(CreateEmptyMesh(node.Name));
                }
            }
            Meshes = Meshes.OrderBy(o => o.name).ToList();

            var max = new Vec3(float.MinValue, float.MinValue, float.MinValue);
            var min = new Vec3(float.MaxValue, float.MaxValue, float.MaxValue);

            Meshes.ForEach(p => p.positions.ToList().ForEach(q => { max.X = Math.Max(q.X, max.X); max.Y = Math.Max(q.Y, max.Y); max.Z = Math.Max(q.Z, max.Z); }));
            Meshes.ForEach(p => p.positions.ToList().ForEach(q => { min.X = Math.Min(q.X, min.X); min.Y = Math.Min(q.Y, min.Y); min.Z = Math.Min(q.Z, min.Z); }));

            meshBlob.BoundingBox.Min = new Vector4 { X = min.X, Y = min.Y, Z = min.Z, W = 1f };
            meshBlob.BoundingBox.Max = new Vector4 { X = max.X, Y = max.Y, Z = max.Z, W = 1f };

            var QuantScale = new Vec4((max.X - min.X) / 2, (max.Y - min.Y) / 2, (max.Z - min.Z) / 2, 0);
            var QuantTrans = new Vec4((max.X + min.X) / 2, (max.Y + min.Y) / 2, (max.Z + min.Z) / 2, 1);



            RawArmature oldRig = null;
            RawArmature newRig = null;
            if (originalRig != null)
            {

                using var msss = new MemoryStream(rendblob.RenderBuffer.Buffer.GetBytes());

                var meshesinfo = MeshTools.GetMeshesinfo(rendblob, cr2w.RootChunk as CMesh);

                var expMeshesss = MeshTools.ContainRawMesh(msss, meshesinfo, true);

                for (var i = 0; i < Meshes.Count; i++)
                {
                    Array.Clear(Meshes[i].boneindices, 0, Meshes[i].boneindices.Length);
                }

                oldRig = MeshTools.GetOrphanRig(meshBlob);


                var ar = originalRig.Archive as Archive;
                using var msr = new MemoryStream();
                ar?.CopyFileToStream(msr, originalRig.NameHash64, false);
                newRig = RIG.ProcessRig(_wolvenkitFileService.ReadRed4File(msr));
            }
            else
            {
                newRig = MeshTools.GetOrphanRig(meshBlob);
                if (model.LogicalSkins.Count > 0 && model.LogicalSkins[0].JointsCount > 0)
                {
                    oldRig = new RawArmature
                    {
                        BoneCount = model.LogicalSkins[0].JointsCount,
                        Names = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.Name).ToArray()
                    };
                }
            }


            MeshTools.UpdateMeshJoints(ref Meshes, newRig, oldRig);

            UpdateSkinningParamCloth(ref Meshes, ref cr2w);

            var expMeshes = Meshes.Select(_ => RawMeshToRE4Mesh(_, QuantScale, QuantTrans)).ToList();

            var meshBuffer = new MemoryStream();
            var meshesInfo = BufferWriter(expMeshes, ref meshBuffer);

            meshesInfo.quantScale = QuantScale;
            meshesInfo.quantTrans = QuantTrans;

            var ms = (originalRig != null) ? GetEditedCr2wFile(cr2w, meshesInfo, meshBuffer, tt, tjointnames) :
                                             GetEditedCr2wFile(cr2w, meshesInfo, meshBuffer);


            /*
             var ms = new MemoryStream();
            if (originalRig != null)
            {
                ms = GetEditedCr2wFile(cr2w, meshesInfo, meshBuffer, tt, tjointnames);
            }
            else
            {
                ms = GetEditedCr2wFile(cr2w, meshesInfo, meshBuffer);

            }
             */

            ms.Seek(0, SeekOrigin.Begin);
            if (outStream != null)
            {
                ms.CopyTo(outStream);
            }
            else
            {
                inmeshStream.SetLength(0);
                ms.CopyTo(inmeshStream);
            }
            return true;
        }

        private static RawMeshContainer CreateEmptyMesh(string name)
        {
            var meshContainer = new RawMeshContainer
            {
                boneindices = new ushort[3, 0],
                colors0 = new Vec4[3],
                colors1 = Array.Empty<Vec4>(),
                garmentMorph = Array.Empty<Vec3>(),
                indices = new uint[3],
                materialNames = null,
                name = name,
                normals = new Vec3[3],
                positions = new Vec3[3],
                tangents = new Vec4[3],
                texCoords0 = new Vec2[3],
                texCoords1 = new Vec2[3],
                weightCount = 0,
                weights = new float[3, 0]
            };

            meshContainer.indices[0] = 2;
            meshContainer.indices[1] = 0;
            meshContainer.indices[2] = 1;

            meshContainer.texCoords0[0] = new Vec2(1, 1);
            meshContainer.texCoords0[1] = new Vec2(0, 0);
            meshContainer.texCoords0[2] = new Vec2(1, 0);

            for (var i = 0; i < 3; i++)
            {
                meshContainer.colors0[i] = new Vec4(1, 1, 1, 1);
                meshContainer.normals[i] = new Vec3(0, 0, 1);
                meshContainer.positions[i] = new Vec3(0, 0, 0);
                meshContainer.tangents[i] = new Vec4(1, 0, 0, -1);
                meshContainer.texCoords1[i] = new Vec2(0, 1);
            }

            return meshContainer;
        }

        private static RawMeshContainer GltfMeshToRawContainer(Node node)
        {
            if (node.Mesh == null)
            {
                return CreateEmptyMesh(node.Name);
            }

            var mesh = node.Mesh;
            var accessors = mesh.Primitives[0].VertexAccessors.Keys.ToList();

            var meshContainer = new RawMeshContainer
            {
                name = mesh.Name,

                // Copying PNT w/ RHS to LHS Y+ to Z+
                positions = mesh.Primitives[0].GetVertices("POSITION").AsVector3Array().ToList().AsParallel().Select(p => new Vec3(p.X, -p.Z, p.Y)).ToArray(),
                normals = mesh.Primitives[0].GetVertices("NORMAL").AsVector3Array().ToList().AsParallel().Select(p => new Vec3(p.X, -p.Z, p.Y)).ToArray(),
                tangents = mesh.Primitives[0].GetVertices("TANGENT").AsVector4Array().ToList().AsParallel().Select(p => new Vec4(p.X, -p.Z, p.Y, p.W)).ToArray(),

                colors0 = accessors.Contains("COLOR_0") ? mesh.Primitives[0].GetVertices("COLOR_0").AsVector4Array().ToArray() : Array.Empty<Vec4>(),
                colors1 = accessors.Contains("COLOR_1") ? mesh.Primitives[0].GetVertices("COLOR_1").AsVector4Array().ToArray() : Array.Empty<Vec4>(),
                texCoords0 = accessors.Contains("TEXCOORD_0") ? mesh.Primitives[0].GetVertices("TEXCOORD_0").AsVector2Array().ToArray() : Array.Empty<Vec2>(),
                texCoords1 = accessors.Contains("TEXCOORD_1") ? mesh.Primitives[0].GetVertices("TEXCOORD_1").AsVector2Array().ToArray() : Array.Empty<Vec2>()
            };

            var indicesList = mesh.Primitives[0].GetIndices().ToList();

            if (mesh.Name.ToLower().Contains("double"))
            {
                meshContainer.indices = new uint[indicesList.Count * 2];
                for (var i = 0; i < indicesList.Count; i += 3)
                {
                    // RHS to LHS face orientations
                    meshContainer.indices[i] = indicesList[i + 1];
                    meshContainer.indices[i + 1] = indicesList[i];
                    meshContainer.indices[i + 2] = indicesList[i + 2];

                    meshContainer.indices[indicesList.Count + i] = indicesList[i];
                    meshContainer.indices[indicesList.Count + i + 1] = indicesList[i + 1];
                    meshContainer.indices[indicesList.Count + i + 2] = indicesList[i + 2];
                }
            }
            else
            {
                meshContainer.indices = new uint[indicesList.Count];
                for (var i = 0; i < indicesList.Count; i += 3)
                {
                    // RHS to LHS face orientations
                    meshContainer.indices[i] = indicesList[i + 1];
                    meshContainer.indices[i + 1] = indicesList[i];
                    meshContainer.indices[i + 2] = indicesList[i + 2];
                }
            }

            var joints0 = accessors.Contains("JOINTS_0") ? mesh.Primitives[0].GetVertices("JOINTS_0").AsVector4Array().ToList() : null;

            var joints1 = accessors.Contains("JOINTS_1") ? mesh.Primitives[0].GetVertices("JOINTS_1").AsVector4Array().ToList() : null;

            var weights0 = accessors.Contains("WEIGHTS_0") ? mesh.Primitives[0].GetVertices("WEIGHTS_0").AsVector4Array().ToList() : null;

            var weights1 = accessors.Contains("WEIGHTS_1") ? mesh.Primitives[0].GetVertices("WEIGHTS_1").AsVector4Array().ToList() : null;

            meshContainer.weightCount = 0;

            if (joints0 != null)
            {
                meshContainer.weightCount += 4;
            }

            if (joints1 != null)
            {
                meshContainer.weightCount += 4;
            }

            var vertCount = meshContainer.positions.Length;
            meshContainer.boneindices = new ushort[vertCount, meshContainer.weightCount];
            meshContainer.weights = new float[vertCount, meshContainer.weightCount];

            for (var i = 0; i < vertCount; i++)
            {
                if (joints0 != null && i < joints0.Count)
                {
                    meshContainer.boneindices[i, 0] = (ushort)joints0[i].X;
                    meshContainer.boneindices[i, 1] = (ushort)joints0[i].Y;
                    meshContainer.boneindices[i, 2] = (ushort)joints0[i].Z;
                    meshContainer.boneindices[i, 3] = (ushort)joints0[i].W;

                    meshContainer.weights[i, 0] = weights0[i].X;
                    meshContainer.weights[i, 1] = weights0[i].Y;
                    meshContainer.weights[i, 2] = weights0[i].Z;
                    meshContainer.weights[i, 3] = weights0[i].W;
                }
                if (joints1 != null && i < joints1.Count)
                {
                    meshContainer.boneindices[i, 4] = (ushort)joints1[i].X;
                    meshContainer.boneindices[i, 5] = (ushort)joints1[i].Y;
                    meshContainer.boneindices[i, 6] = (ushort)joints1[i].Z;
                    meshContainer.boneindices[i, 7] = (ushort)joints1[i].W;

                    meshContainer.weights[i, 4] = weights1[i].X;
                    meshContainer.weights[i, 5] = weights1[i].Y;
                    meshContainer.weights[i, 6] = weights1[i].Z;
                    meshContainer.weights[i, 7] = weights1[i].W;
                }
            }

            meshContainer.garmentMorph = Array.Empty<Vec3>();
            if (mesh.Primitives[0].MorphTargetsCount > 0)
            {
                var idx = mesh.Primitives[0].GetMorphTargetAccessors(0).Keys.ToList().IndexOf("POSITION");
                var extraDataList = mesh.Primitives[0].GetMorphTargetAccessors(0).Values.ToList()[idx].AsVector3Array().ToList();

                meshContainer.garmentMorph = extraDataList.Select(p => new Vec3(p.X, -p.Z, p.Y)).ToArray();
            }

            return meshContainer;
        }

        private static Re4MeshContainer RawMeshToRE4Mesh(RawMeshContainer mesh, Vec4 qScale, Vec4 qTrans)
        {
            var Re4Mesh = new Re4MeshContainer
            {
                name = mesh.name
            };

            var vertCount = mesh.positions.Length;
            Re4Mesh.ExpVerts = new short[vertCount, 3];

            for (var i = 0; i < vertCount; i++)
            {
                var x = (mesh.positions[i].X - qTrans.X) / qScale.X;
                var y = (mesh.positions[i].Y - qTrans.Y) / qScale.Y;
                var z = (mesh.positions[i].Z - qTrans.Z) / qScale.Z;
                Re4Mesh.ExpVerts[i, 0] = Convert.ToInt16(x * 32767);
                Re4Mesh.ExpVerts[i, 1] = Convert.ToInt16(y * 32767);
                Re4Mesh.ExpVerts[i, 2] = Convert.ToInt16(z * 32767);
            }

            // converting normals struct
            Re4Mesh.Nor32s = new uint[vertCount];
            for (var i = 0; i < vertCount; i++)
            {
                var v = new Vec4(mesh.normals[i], 0); // for normal w == 0
                Re4Mesh.Nor32s[i] = Converters.Vec4ToU32(v);
            }

            // converting tangents struct
            Re4Mesh.Tan32s = new uint[vertCount];
            for (var i = 0; i < vertCount; i++)
            {
                var v = mesh.tangents[i]; // for tangents w == 1 or -1
                Re4Mesh.Tan32s[i] = Converters.Vec4ToU32(v);
            }

            Re4Mesh.uv0s = new ushort[vertCount, 2];
            for (var i = 0; i < mesh.texCoords0.Length; i++)
            {
                Re4Mesh.uv0s[i, 0] = Converters.converthf(mesh.texCoords0[i].X);
                Re4Mesh.uv0s[i, 1] = Converters.converthf(mesh.texCoords0[i].Y);
            }

            Re4Mesh.uv1s = new ushort[vertCount, 2];
            for (var i = 0; i < mesh.texCoords1.Length; i++)
            {
                Re4Mesh.uv1s[i, 0] = Converters.converthf(mesh.texCoords1[i].X);
                Re4Mesh.uv1s[i, 1] = Converters.converthf(mesh.texCoords1[i].Y);
            }

            Re4Mesh.colors = new byte[vertCount, 4];
            for (var i = 0; i < mesh.colors0.Length; i++)
            {
                Re4Mesh.colors[i, 0] = Convert.ToByte(mesh.colors0[i].X * 255);
                Re4Mesh.colors[i, 1] = Convert.ToByte(mesh.colors0[i].Y * 255);
                Re4Mesh.colors[i, 2] = Convert.ToByte(mesh.colors0[i].Z * 255);
                Re4Mesh.colors[i, 3] = Convert.ToByte(mesh.colors0[i].W * 255);
            }

            Re4Mesh.weightcount = mesh.weightCount;

            Re4Mesh.boneindices = new byte[vertCount, Re4Mesh.weightcount];
            for (var i = 0; i < vertCount; i++)
            {
                for (var e = 0; e < Re4Mesh.weightcount; e++)
                {
                    Re4Mesh.boneindices[i, e] = Convert.ToByte(mesh.boneindices[i, e]); // mesh.boneindices are supposed to be processed
                }
            }
            // (updated according to the mesh bones rather than rig bones) before putting here

            Re4Mesh.weights = new byte[vertCount, Re4Mesh.weightcount];
            for (var i = 0; i < vertCount; i++)
            {
                for (var e = 0; e < Re4Mesh.weightcount; e++)
                {
                    Re4Mesh.weights[i, e] = Convert.ToByte(mesh.weights[i, e] * 255);
                }
                // weight summing can cause problems here, sometimes sum >= 256, idk how to fix them yet
            }

            // extradata/ morphoffsetbs
            Re4Mesh.garmentMorph = new ushort[0, 0];
            if (mesh.garmentMorph.Length > 0)
            {
                Re4Mesh.garmentMorph = new ushort[vertCount, 3];
                for (var i = 0; i < vertCount; i++)
                {
                    Re4Mesh.garmentMorph[i, 0] = Converters.converthf(mesh.garmentMorph[i].X);
                    Re4Mesh.garmentMorph[i, 1] = Converters.converthf(mesh.garmentMorph[i].Y);
                    Re4Mesh.garmentMorph[i, 2] = Converters.converthf(mesh.garmentMorph[i].Z);
                }
            }

            Re4Mesh.indices = new ushort[mesh.indices.Length];
            for (var i = 0; i < mesh.indices.Length; i++)
            {
                Re4Mesh.indices[i] = Convert.ToUInt16(mesh.indices[i]);
            }

            return Re4Mesh;
        }

        private static MeshesInfo BufferWriter(List<Re4MeshContainer> expMeshes, ref MemoryStream ms)
        {
            var meshesInfo = new MeshesInfo(expMeshes.Count);

            var bw = new BinaryWriter(ms);
            for (var i = 0; i < expMeshes.Count; i++)
            {
                var vertCount = expMeshes[i].ExpVerts.Length / 3;

                meshesInfo.vertCounts[i] = (uint)vertCount;
                meshesInfo.posnOffsets[i] = (uint)ms.Position;

                meshesInfo.vpStrides[i] = (expMeshes[i].weightcount * 2) + 8;
                meshesInfo.weightCounts[i] = expMeshes[i].weightcount;

                if (expMeshes[i].garmentMorph.Length > 0)
                {
                    meshesInfo.garmentSupportExists[i] = true;
                    meshesInfo.vpStrides[i] += 8;
                }

                for (var e = 0; e < vertCount; e++)
                {
                    bw.Write(expMeshes[i].ExpVerts[e, 0]);
                    bw.Write(expMeshes[i].ExpVerts[e, 1]);
                    bw.Write(expMeshes[i].ExpVerts[e, 2]);
                    bw.Write((short)32767);
                    for (var eye = 0; eye < expMeshes[i].weightcount; eye++)
                    {
                        bw.Write(expMeshes[i].boneindices[e, eye]);
                    }

                    for (var eye = 0; eye < expMeshes[i].weightcount; eye++)
                    {
                        bw.Write(expMeshes[i].weights[e, eye]);
                    }

                    if (meshesInfo.garmentSupportExists[i])
                    {
                        bw.Write(expMeshes[i].garmentMorph[e, 0]);
                        bw.Write(expMeshes[i].garmentMorph[e, 1]);
                        bw.Write(expMeshes[i].garmentMorph[e, 2]);
                        bw.Write((ushort)0);
                    }
                }

                long paddingLen = 0;

                // 16 bytes Padding between vertexBlock and uv0, if required
                paddingLen = ((ms.Length + 15U) & (~15)) - ms.Length;
                bw.Write(new byte[paddingLen]);

                // writing tx0s
                meshesInfo.tex0Offsets[i] = (uint)ms.Position;
                for (var e = 0; e < vertCount; e++)
                {
                    bw.Write(expMeshes[i].uv0s[e, 0]);
                    bw.Write(expMeshes[i].uv0s[e, 1]);
                }

                // 16 bytes Padding between uv0 and normals, if required
                paddingLen = ((ms.Length + 15U) & (~15)) - ms.Length;
                bw.Write(new byte[paddingLen]);

                // writing normals and tangents
                meshesInfo.normalOffsets[i] = (uint)ms.Position;
                for (var e = 0; e < vertCount; e++)
                {
                    bw.Write(expMeshes[i].Nor32s[e]);
                    bw.Write(expMeshes[i].Tan32s[e]);
                }

                // 16 bytes Padding between nors/tans and colors/uv1s, if required
                paddingLen = ((ms.Length + 15U) & (~15)) - ms.Length;
                bw.Write(new byte[paddingLen]);

                // writing colors and tx1s
                meshesInfo.colorOffsets[i] = (uint)ms.Position;
                for (var e = 0; e < vertCount; e++)
                {

                    bw.Write(expMeshes[i].colors[e, 0]);
                    bw.Write(expMeshes[i].colors[e, 1]);
                    bw.Write(expMeshes[i].colors[e, 2]);
                    bw.Write(expMeshes[i].colors[e, 3]);


                    // Temp fix for improved lighting geomertry
                    /*
                    bw.Write((byte)0);
                    bw.Write((byte)0);
                    bw.Write((byte)0);
                    bw.Write((byte)0);
                    */
                    bw.Write(expMeshes[i].uv1s[e, 0]);
                    bw.Write(expMeshes[i].uv1s[e, 1]);
                }

                // 16 bytes Padding if necessary
                paddingLen = ((ms.Length + 15U) & (~15)) - ms.Length;
                bw.Write(new byte[paddingLen]);

                // for the unusual lightblocker data
                /*
                unknownOffsets[i] = (UInt32)ms.Position;

                for (int e = 0; e < vertCount; e++)
                {
                    bw.Write((float)0f);
                }
                */
                meshesInfo.vertBufferSize = (uint)ms.Length;

                // this padding writer if that unusual lightblocker data is written
                /*
                // padding writer if necessary
                if (((UInt64)ms.Length % 16) != 0)
                {
                    int zeroesCount = (int)((((UInt64)ms.Length / 16) + 1) * 16 - (UInt64)ms.Length);
                    Byte[] bytes = new Byte[zeroesCount];
                    bw.Write(bytes);
                }
                */
            }

            meshesInfo.indexBufferOffset = (uint)ms.Position;
            for (var i = 0; i < expMeshes.Count; i++)
            {
                var indCount = expMeshes[i].indices.Length;
                meshesInfo.indCounts[i] = (uint)indCount;

                meshesInfo.indicesOffsets[i] = (uint)ms.Position;
                for (var e = 0; e < indCount; e++)
                {
                    bw.Write(expMeshes[i].indices[e]);
                }
            }
            meshesInfo.indexBufferSize = (uint)ms.Length - meshesInfo.indexBufferOffset;


            for (var i = 0; i < meshesInfo.meshCount; i++)
            {
                if (expMeshes[i].name.Contains("LOD"))
                {
                    var idx = expMeshes[i].name.IndexOf("LOD_");
                    if (idx < expMeshes[i].name.Length - 1)
                    {
                        meshesInfo.LODLvl[i] = Convert.ToUInt32(expMeshes[i].name.Substring(idx + 4, 1));
                    }
                }
                else
                {
                    meshesInfo.LODLvl[i] = 1;
                }
            }

            return meshesInfo;
        }

        private static MemoryStream GetEditedCr2wFile(CR2WFile cr2w, MeshesInfo info, MemoryStream buffer, Mat4[] inverseBindMatrices = null, string[] boneNames = null)
        //private static MemoryStream GetEditedCr2wFile(CR2WFile cr2w, MeshesInfo info, MemoryStream buffer)
        {
            rendRenderMeshBlob blob = null;
            if (cr2w.RootChunk is CMesh obj1 && obj1.RenderResourceBlob.Chunk is rendRenderMeshBlob obj2)
            {
                blob = obj2;
            }

            if (cr2w.RootChunk is MorphTargetMesh obj3 && obj3.Blob.Chunk is rendRenderMorphTargetMeshBlob obj4 && obj4.BaseBlob.Chunk is rendRenderMeshBlob obj5)
            {
                blob = obj5;
            }

            // removing BS topology data which causes a lot of issues with improved facial lighting geomerty, vertex colors uroborus and what not
            if (blob.Header.Topology is not null)
            {
                blob.Header.Topology.Clear();
                for (var i = 0; i < info.meshCount; i++)
                {
                    blob.Header.Topology.Add(new rendTopologyData());
                }
            }

            //dependent RenderLOD's removal and addition
            if (blob.Header.RenderLODs is not null)
            {
                blob.Header.RenderLODs.Clear();

                blob.Header.RenderLODs.Add(0f);
                if (info.LODLvl.ToList().Contains(2))
                {
                    blob.Header.RenderLODs.Add(3f);
                }
                if (info.LODLvl.ToList().Contains(4))
                {
                    blob.Header.RenderLODs.Add(6f);
                }
                if (info.LODLvl.ToList().Contains(8))
                {
                    blob.Header.RenderLODs.Add(9f);
                }
            }
            if (cr2w.RootChunk is CMesh cmeshblob)
            {
                if (cmeshblob.LodLevelInfo is not null)
                {
                    cmeshblob.LodLevelInfo.Clear();

                    cmeshblob.LodLevelInfo.Add(0f);
                    if (info.LODLvl.ToList().Contains(2))
                    {
                        cmeshblob.LodLevelInfo.Add(3f);
                    }
                    if (info.LODLvl.ToList().Contains(4))
                    {
                        cmeshblob.LodLevelInfo.Add(6f);
                    }
                    if (info.LODLvl.ToList().Contains(8))
                    {
                        cmeshblob.LodLevelInfo.Add(9f);
                    }
                }
            }
            // removing existing rendChunks
            blob.Header.RenderChunkInfos.Clear();

            // adding new rendChunks
            for (var i = 0; i < info.meshCount; i++)
            {
                var chunk = new rendChunk
                {
                    LodMask = (byte)info.LODLvl[i],
                    RenderMask = Enums.EMeshChunkFlags.MCF_RenderInScene | Enums.EMeshChunkFlags.MCF_RenderInShadows,
                    // based upon VertexBlock, subject to change, incremental will be good, for weightcount ++ etc
                    // VertexFactory is really important to be taken care of properly
                    VertexFactory = 2,
                    NumIndices = info.indCounts[i],
                    NumVertices = (ushort)info.vertCounts[i],
                    ChunkIndices = new rendIndexBufferChunk
                    {
                        Pe = Enums.GpuWrapApieIndexBufferChunkType.IBCT_IndexUShort,
                        TeOffset = info.indicesOffsets[i] - info.indexBufferOffset
                    },
                    ChunkVertices = new rendVertexBufferChunk()
                };

                chunk.ChunkVertices.ByteOffsets.Add(info.posnOffsets[i]);
                chunk.ChunkVertices.ByteOffsets.Add(info.tex0Offsets[i]);
                chunk.ChunkVertices.ByteOffsets.Add(info.normalOffsets[i]);
                chunk.ChunkVertices.ByteOffsets.Add(info.colorOffsets[i]);
                chunk.ChunkVertices.ByteOffsets.Add(info.unknownOffsets[i]);

                chunk.ChunkVertices.VertexLayout = new GpuWrapApiVertexLayoutDesc
                {
                    //hash and slotmask are not understood/no-interest, subject to change
                    Hash = 0,
                    SlotMask = 0
                };

                chunk.ChunkVertices.VertexLayout.SlotStrides.Add((byte)info.vpStrides[i]);
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(4);
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(8);
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(8);

                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(info.unknownOffsets[i] == 0 ? (byte)0 : (byte)4);

                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(0);
                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(0);

                chunk.ChunkVertices.VertexLayout.SlotStrides.Add(info.weightCounts[i] == 0 ? (byte)48 : (byte)64);

                // Position
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                {
                    StreamIndex = 0,
                    UsageIndex = 0,
                    Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Position,
                    Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Short4N
                    //StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                });

                // Joint0
                if (info.weightCounts[i] > 0)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                    {
                        StreamIndex = 0,
                        UsageIndex = 0,
                        Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices,
                        Type = Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4
                        //StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                    });

                    // subject to change, maybe, VertexFactory is weird
                    chunk.VertexFactory++;
                }

                // joint1
                if (info.weightCounts[i] > 4)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                    {
                        StreamIndex = 0,
                        UsageIndex = 1,
                        Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_SkinIndices,
                        Type = Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4
                        //StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                    });

                    // subject to change, maybe, VertexFactory is weird
                    chunk.VertexFactory++;
                }

                // weight0
                if (info.weightCounts[i] > 0)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                    {
                        StreamIndex = 0,
                        UsageIndex = 0,
                        Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_SkinWeights,
                        Type = Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4N
                        //StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                    });
                }
                // weight1
                if (info.weightCounts[i] > 4)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                    {
                        StreamIndex = 0,
                        UsageIndex = 1,
                        Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_SkinWeights,
                        Type = Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4N
                        //StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                    });
                }

                // tx0coords
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                {
                    StreamIndex = 1,
                    UsageIndex = 0,
                    Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_TexCoord,
                    Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Float16_2
                    //StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                });

                // normals
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                {
                    StreamIndex = 2,
                    UsageIndex = 0,
                    Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Normal,
                    Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Dec4
                    //StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                });

                // tangents
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                {
                    StreamIndex = 2,
                    UsageIndex = 0,
                    Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Tangent,
                    Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Dec4
                    //StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                });

                // color
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                {
                    StreamIndex = 3,
                    UsageIndex = 0,
                    Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Color,
                    Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Color
                    //StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                });

                // tx1coords
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                {
                    StreamIndex = 3,
                    UsageIndex = 1,
                    Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_TexCoord,
                    Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Float16_2
                    //StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                });

                // extra data/ morphoffsets
                if (info.garmentSupportExists[i])
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                    {
                        // fishy
                        StreamIndex = 0,
                        UsageIndex = 0,
                        Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_ExtraData,
                        Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Float16_4
                        //StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                    });

                    // subject to change, maybe, VertexFactory is weird, extra data ads 2 to this
                    chunk.VertexFactory += 2;
                }

                // instanceTransforms
                for (byte e = 0; e < 3; e++)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                    {
                        StreamIndex = 7,
                        UsageIndex = e,
                        Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_InstanceTransform,
                        Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Float4,
                        StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerInstance
                    });
                }

                // instanceSkinningDatas
                if (info.weightCounts[i] > 0)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                    {
                        StreamIndex = 7,
                        UsageIndex = 0,
                        Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_InstanceSkinningData,
                        Type = Enums.GpuWrapApiVertexPackingePackingType.PT_UInt4,
                        StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerInstance
                    });
                }

                // LightBlockerIntensity
                if (info.unknownOffsets[i] != 0)
                {
                    chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                    {
                        StreamIndex = 4,
                        UsageIndex = 0,
                        Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_LightBlockerIntensity,
                        Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Float1,
                        // StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_PerVertex
                    });

                    // for lightblocker its 24, after testing some files, somtimes unknownoffsets[4] is used for destruction indices and some paint instead of lightblocker, so this needs to be taken care of
                    chunk.VertexFactory += 24;
                }


                // Invalid, Required
                chunk.ChunkVertices.VertexLayout.Elements.Add(new GpuWrapApiVertexPackingPackingElement
                {
                    StreamIndex = 0,
                    UsageIndex = 0,
                    Usage = Enums.GpuWrapApiVertexPackingePackingUsage.PS_Invalid,
                    Type = Enums.GpuWrapApiVertexPackingePackingType.PT_Invalid,
                    StreamType = Enums.GpuWrapApiVertexPackingEStreamType.ST_Invalid
                });

                // Adding Chunk
                blob.Header.RenderChunkInfos.Add(chunk);
            }

            blob.Header.QuantizationScale.X = info.quantScale.X;
            blob.Header.QuantizationScale.Y = info.quantScale.Y;
            blob.Header.QuantizationScale.Z = info.quantScale.Z;
            blob.Header.QuantizationOffset.X = info.quantTrans.X;
            blob.Header.QuantizationOffset.Y = info.quantTrans.Y;
            blob.Header.QuantizationOffset.Z = info.quantTrans.Z;

            blob.Header.VertexBufferSize = info.vertBufferSize;
            blob.Header.IndexBufferSize = info.indexBufferSize;
            blob.Header.IndexBufferOffset = info.indexBufferOffset;

            blob.RenderBuffer.Buffer.SetBytes(buffer.ToArray());

            if (cr2w.RootChunk is CMesh root && inverseBindMatrices != null)
            {
                for (var i = 0; i < blob.Header.BonePositions.Count; i++)
                {
                    var index = Array.FindIndex(boneNames, x => x.Contains(root.BoneNames[i]) && x.Length == root.BoneNames[i].Length);

                    blob.Header.BonePositions[i].X = inverseBindMatrices[index].M41;
                    blob.Header.BonePositions[i].Y = -inverseBindMatrices[index].M43;
                    blob.Header.BonePositions[i].Z = inverseBindMatrices[index].M42;
                    blob.Header.BonePositions[i].W = inverseBindMatrices[index].M44;
                    //blob.Header.BonePositions[i] = root.BoneRigMatrices[i].W;
                }
            }

            var ms = new MemoryStream();
            using var writer = new CR2WWriter(ms, Encoding.UTF8, true);
            writer.WriteFile(cr2w);

            return ms;
        }

        private static void VerifyGLTF(ModelRoot model)
        {
            if (model.LogicalMeshes.Count < 1)
            {
                throw new Exception("Provided glTF doesn't contain any 3D Meshes");
            }
            /*if (model.LogicalSkins.Count > 1)
            {
                throw new Exception($"Armature Count: {model.LogicalSkins.Count}, Only 1 Armature is allowed");
            }*/

            var LODs = new List<uint>();
            for (var i = 0; i < model.LogicalMeshes.Count; i++)
            {
                var accessors = model.LogicalMeshes[i].Primitives[0].VertexAccessors.Keys.ToList();

                if (!accessors.Contains("POSITION"))
                {
                    throw new Exception("One or more Geometry in provided GLTF doesn't contain Vertices");
                }
                if (!accessors.Contains("NORMAL"))
                {
                    throw new Exception("One or more Geometry in provided GLTF doesn't contain Normals data. Normals must be included within glTF files.");
                }
                if (!accessors.Contains("TANGENT"))
                {
                    throw new Exception("One or more Geometry in provided GLTF doesn't contain Tangents data. Tangents must be included within glTF files.");
                }
                if (model.LogicalMeshes[i].Primitives[0].GetIndices().ToList().Count < 3)
                {
                    throw new Exception("One or more Geometry in provided GLTF doesn't contain any Triangle primitives");
                }
                var name = model.LogicalMeshes[i].Name;
                uint LOD = 0;

                if (name.Contains("LOD"))
                {
                    try
                    {
                        var idx = name.IndexOf("LOD_");
                        if (idx < name.Length - 1)
                        {
                            LOD = Convert.ToUInt32(name.Substring(idx + 4, 1));
                            LODs.Add(LOD);
                        }
                    }
                    catch
                    {
                        throw new Exception("Invalid Geometry/sub mesh name: " + name + " , Character after \"LOD_\" should be 1 or 2 or 4 or 8, Representing the Level of Detail (LOD) of the submesh.");
                    }
                    if (LOD is not 1 and not 2 and not 4 and not 8)
                    {
                        throw new Exception("Invalid Geometry/sub mesh name: " + name + " , Character after \"LOD_\"  should be 1 or 2 or 4 or 8, Representing the Level of Detail (LOD) of the submesh.");
                    }
                }
                else
                {
                    LODs.Add(1);
                }
            }
            if (!LODs.Contains(1))
            {
                throw new Exception("None of the Geometry/submeshes are of 1 Level of Detail or (LOD 1) in provided GLTF");
            }
        }
        private static void UpdateSkinningParamCloth(ref List<RawMeshContainer> meshes, ref CR2WFile cr2w)
        {
            var cmesh = (CMesh)cr2w.RootChunk;

            var LODLvl = new uint[meshes.Count];
            for (var i = 0; i < meshes.Count; i++)
            {
                if (meshes[i].name.Contains("LOD"))
                {
                    var idx = meshes[i].name.IndexOf("LOD_");
                    if (idx < meshes[i].name.Length - 1)
                    {
                        LODLvl[i] = Convert.ToUInt32(meshes[i].name.Substring(idx + 4, 1));
                    }
                }
                else
                {
                    LODLvl[i] = 1;
                }

            }

            // TODO: What should happen here?
            /*int meshBufferIdx = cr2w.Chunks.OfType<rendRenderMeshBlob>().First().RenderBuffer.Pointer - 1;
            int materialBufferIdx = cr2w.Chunks.OfType<CMesh>().First().LocalMaterialBuffer.RawData.Pointer - 1;
            if (cr2w.Chunks.OfType<CMesh>().First().LocalMaterialBuffer.RawData.Buffer.MemSize == 0)
                materialBufferIdx = int.MaxValue;

            int buffCount = cr2w.Buffers.Count;

            for (int i = 0, idx = 0; i < buffCount; i++, idx++)
            {
                if (idx != meshBufferIdx && idx != materialBufferIdx)
                {
                    cr2w.Buffers.Remove(cr2w.Buffers[idx]);
                    if (idx < meshBufferIdx)
                        meshBufferIdx--;
                    if (idx < materialBufferIdx)
                        materialBufferIdx--;
                    idx--;
                }
            }
            if (cr2w.Chunks.OfType<CMesh>().First().LocalMaterialBuffer.RawData.Buffer.MemSize == 0)
                materialBufferIdx = 0;

            cr2w.Chunks.OfType<rendRenderMeshBlob>().First().RenderBuffer.Pointer = meshBufferIdx + 1;
            cr2w.Chunks.OfType<CMesh>().First().LocalMaterialBuffer.RawData.Pointer = materialBufferIdx + 1;*/

            var clothBlob = cmesh.Parameters.FirstOrDefault(x => x.Chunk is meshMeshParamCloth);
            var clothGraphicalBlob = cmesh.Parameters.FirstOrDefault(x => x.Chunk is meshMeshParamCloth_Graphical);

            if (clothBlob != null)
            {
                var blob = (meshMeshParamCloth)clothBlob.Chunk;
                blob.Chunks = new CArray<meshPhxClothChunkData>();
                for (var i = 0; i < meshes.Count; i++)
                {
                    var chunk = new meshPhxClothChunkData();
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(meshes[i].positions[e].X);
                            bw.Write(meshes[i].positions[e].Y);
                            bw.Write(meshes[i].positions[e].Z);
                        }

                        chunk.Positions = new DataBuffer(buffer.ToArray());
                    }
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].indices.Length; e++)
                        {
                            bw.Write(Convert.ToUInt16(meshes[i].indices[e]));
                        }

                        chunk.Indices = new DataBuffer(buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(meshes[i].weights[e, 0]);
                            bw.Write(meshes[i].weights[e, 1]);
                            bw.Write(meshes[i].weights[e, 2]);
                            bw.Write(meshes[i].weights[e, 3]);
                        }

                        chunk.SkinWeights = new DataBuffer(buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 0]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 1]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 2]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 3]));
                        }

                        chunk.SkinIndices = new DataBuffer(buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(meshes[i].weights[e, 4]);
                            bw.Write(meshes[i].weights[e, 5]);
                            bw.Write(meshes[i].weights[e, 6]);
                            bw.Write(meshes[i].weights[e, 7]);
                        }

                        chunk.SkinWeightsExt = new DataBuffer(buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 4]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 5]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 6]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 7]));
                        }

                        chunk.SkinIndicesExt = new DataBuffer(buffer.ToArray());
                    }
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].normals.Length; e++)
                        {
                            bw.Write(meshes[i].normals[e].X);
                            bw.Write(meshes[i].normals[e].Y);
                            bw.Write(meshes[i].normals[e].Z);
                        }

                        chunk.Normals = new DataBuffer(buffer.ToArray());
                    }
                    blob.Chunks.Add(chunk);
                    meshes[i].weightCount = 0;
                }
                blob.LodChunkIndices = new CArray<CArray<CUInt16>>
                {
                    new()
                };
                if (LODLvl.Contains(2U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                if (LODLvl.Contains(4U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                if (LODLvl.Contains(8U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                for (ushort i = 0; i < LODLvl.Length; i++)
                {
                    if (LODLvl[i] == 1)
                    {
                        blob.LodChunkIndices[0].Add(i);
                    }
                    if (LODLvl[i] == 2)
                    {
                        blob.LodChunkIndices[1].Add(i);
                    }
                    if (LODLvl[i] == 4)
                    {
                        blob.LodChunkIndices[2].Add(i);
                    }
                    if (LODLvl[i] == 8)
                    {
                        blob.LodChunkIndices[3].Add(i);
                    }
                }
            }
            if (clothGraphicalBlob != null)
            {
                var blob = (meshMeshParamCloth_Graphical)clothGraphicalBlob.Chunk;
                blob.Chunks = new CArray<meshGfxClothChunkData>();
                for (var i = 0; i < meshes.Count; i++)
                {
                    var chunk = new meshGfxClothChunkData();
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(meshes[i].positions[e].X);
                            bw.Write(meshes[i].positions[e].Y);
                            bw.Write(meshes[i].positions[e].Z);
                        }

                        chunk.Positions = new DataBuffer(buffer.ToArray());
                    }
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].indices.Length; e++)
                        {
                            bw.Write(Convert.ToUInt16(meshes[i].indices[e]));
                        }

                        chunk.Indices = new DataBuffer(buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(meshes[i].weights[e, 0]);
                            bw.Write(meshes[i].weights[e, 1]);
                            bw.Write(meshes[i].weights[e, 2]);
                            bw.Write(meshes[i].weights[e, 3]);
                        }

                        chunk.SkinWeights = new DataBuffer(buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 0]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 1]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 2]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 3]));
                        }

                        chunk.SkinIndices = new DataBuffer(buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(meshes[i].weights[e, 4]);
                            bw.Write(meshes[i].weights[e, 5]);
                            bw.Write(meshes[i].weights[e, 6]);
                            bw.Write(meshes[i].weights[e, 7]);
                        }

                        chunk.SkinWeightsExt = new DataBuffer(buffer.ToArray());
                    }
                    if (meshes[i].weightCount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < meshes[i].positions.Length; e++)
                        {
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 4]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 5]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 6]));
                            bw.Write(Convert.ToByte(meshes[i].boneindices[e, 7]));
                        }

                        chunk.SkinIndicesExt = new DataBuffer(buffer.ToArray());
                    }
                    {
                        chunk.Simulation = new CArray<CUInt16>();
                        var z = 0;
                        for (ushort e = 0; e < meshes[i].colors1.Length; e++)
                        {
                            if (meshes[i].colors1[e].X > 0.01f)
                            {
                                var val = e;
                                chunk.Simulation.Add(val);
                                z++;
                            }
                        }
                    }
                    blob.Chunks.Add(chunk);
                    meshes[i].weightCount = 0;
                }
                blob.LodChunkIndices = new CArray<CArray<CUInt16>>
                {
                    new()
                };
                if (LODLvl.Contains(2U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                if (LODLvl.Contains(4U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                if (LODLvl.Contains(8U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                for (ushort i = 0; i < LODLvl.Length; i++)
                {
                    if (LODLvl[i] == 1)
                    {
                        blob.LodChunkIndices[0].Add(i);
                    }
                    if (LODLvl[i] == 2)
                    {
                        blob.LodChunkIndices[1].Add(i);
                    }
                    if (LODLvl[i] == 4)
                    {
                        blob.LodChunkIndices[2].Add(i);
                    }
                    if (LODLvl[i] == 8)
                    {
                        blob.LodChunkIndices[3].Add(i);
                    }
                }
            }
        }
    }
}
