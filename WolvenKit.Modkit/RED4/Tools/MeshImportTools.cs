using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using DynamicData;
using SharpGLTF.Schema2;
using WolvenKit.Common.Model.Arguments;
using WolvenKit.Core.Extensions;
using WolvenKit.Modkit.RED4.GeneralStructs;
using WolvenKit.Modkit.RED4.RigFile;
using WolvenKit.Modkit.RED4.Tools;
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
        //public bool ImportRig(FileInfo inGltfFile, Stream rigStream, GltfImportArgs args)
        //{
        //    var cr2w = _parserService.ReadRed4File(rigStream);

        //    if (cr2w is not { RootChunk: animRig rig })
        //    {
        //        return false;
        //    }

        //    var model = ModelRoot.Load(inGltfFile.FullName, new ReadSettings(args.ValidationMode));

        //    //VerifyGLTF(model);

        //    List<LogicalChildOfRoot> armature;

        //    var joints = new List<(Node Joint, Mat4 InverseBindMatrix)>();
        //    var jointlist = new List<Node>();
        //    var jointnames = new List<string>();
        //    var jointparentnames = new List<string>();
        //    var ibm = new List<Mat4>();
        //    var wm = new List<Mat4>();


        //    if (model.LogicalSkins.Count > 0)
        //    {
        //        armature = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => (LogicalChildOfRoot)model.LogicalSkins[0]).ToList();
        //        joints = Enumerable.Range(0, armature.Count).Select(_ => ((Skin)armature[_]).GetJoint(_)).ToList();
        //        jointlist = Enumerable.Range(0, armature.Count).Select(_ => ((Skin)armature[_]).GetJoint(_).Joint).ToList();
        //        jointnames = Enumerable.Range(0, armature.Count).Select(_ => ((Skin)armature[_]).GetJoint(_).Joint.Name).ToList();
        //        jointparentnames = Enumerable.Range(0, armature.Count).Select(_ => ((Skin)armature[_]).GetJoint(_).Joint.VisualParent.Name).ToList();
        //        ibm = Enumerable.Range(0, armature.Count).Select(_ => ((Skin)armature[_]).GetJoint(_).InverseBindMatrix).ToList();
        //        wm = Enumerable.Range(0, armature.Count).Select(_ => ((Skin)armature[_]).GetJoint(_).Joint.WorldMatrix).ToList();
        //    }
        //    else
        //    {
        //        if (model.LogicalNodes.Count > 0)
        //        {
        //            armature = Enumerable.Range(0, model.LogicalNodes.Count).Select(_ => (LogicalChildOfRoot)model.LogicalNodes[_]).ToList();
        //            jointlist = Enumerable.Range(0, armature.Count).Select(_ => (Node)armature[_]).ToList();
        //            jointnames = Enumerable.Range(0, armature.Count).Select(_ => ((Node)armature[_]).Name).ToList();
        //            jointparentnames = Enumerable.Range(0, armature.Count).Select(_ => ((Node)armature[_]).VisualParent is null
        //                                                                ? "firstbone" : ((Node)armature[_]).VisualParent.Name).ToList();
        //            wm = Enumerable.Range(0, armature.Count).Select(_ => ((Node)armature[_]).WorldMatrix).ToList();

        //            for (var i = 0; i < wm.Count; i++)
        //            {
        //                var temp = new Mat4();
        //                Mat4.Invert(wm[i], out temp);
        //                ibm.Add(temp);
        //            }
        //            //ibm = Enumerable.Range(0, wm.Count).Select(_ => Mat4.Invert( wm[_], out ibm[_] )).ToList();
        //            joints = Enumerable.Range(0, armature.Count).Select(_ => (jointlist[_], ibm[_])).ToList();
        //        }
        //    }

        //    int[]? GetLevels(string root = "Root")
        //    {
        //        var rootIndex = jointnames.IndexOf("Root");
        //        var treeLevel = new int[jointnames.Count];

        //        if (jointparentnames[rootIndex].Contains("Armature"))
        //        {
        //            void rec(string parent, int level)
        //            {
        //                var tIndex = Enumerable.Range(0, jointnames.Count).Where(i => jointparentnames[i] == parent).ToList();
        //                foreach (var ind in tIndex)
        //                {
        //                    treeLevel[ind] = level;
        //                    rec(jointnames[ind], level + 1);
        //                }
        //            }
        //            rec(root, 0);
        //            return treeLevel;
        //        }
        //        return null;
        //    }

        //    Mat4.Invert(joints[1].Joint.WorldMatrix, out var inversedWorldMatrix);
        //    Mat4.Invert(joints[1].Joint.LocalMatrix, out var inversedLocalMatrix);

        //    var oriRotM = Mat4.CreateFromQuaternion(joints[1].Joint.LocalTransform.Rotation);
        //    var oriScaM = Mat4.CreateScale(joints[1].Joint.LocalTransform.Scale);
        //    var oriTraM = Mat4.CreateTranslation(joints[1].Joint.LocalTransform.Translation);

        //    var rotM = oriScaM * joints[1].InverseBindMatrix * oriTraM;
        //    Mat4.Invert(rotM, out rotM);

        //    var manualTRS = oriTraM * oriRotM * oriScaM;
        //    Mat4.Invert(manualTRS, out var inversedManualTRS);

        //    var manualRotM = oriScaM * inversedManualTRS * oriTraM;
        //    Mat4.Invert(manualRotM, out manualRotM);

        //    var inv2 = oriTraM * rotM * oriScaM;

        //    var localInvRotM = oriScaM * inversedLocalMatrix * oriTraM;
        //    Mat4.Invert(localInvRotM, out localInvRotM);

        //    var rotationVector = Quat.CreateFromRotationMatrix(rotM);
        //    var manualRotationVector = Quat.CreateFromRotationMatrix(manualRotM);
        //    var localRotationVector = Quat.CreateFromRotationMatrix(localInvRotM);

        //    var levels = GetLevels("Root");
        //    if (levels is not null)
        //    {
        //        for (var i = 0; i < rig.BoneNames.Count; i++)
        //        {
        //            var currentBone = rig.BoneNames[i];
        //            var index = jointnames.IndexOf(currentBone.ToString().NotNull());
        //            var parindex = jointnames.IndexOf(jointlist[index].VisualParent.Name);
        //            var transform = rig.BoneTransforms[i].NotNull();

        //            {
        //                /*
        //                transform.Rotation.I = jointlist[index].LocalTransform.Rotation.X;
        //                transform.Rotation.J = -jointlist[index].LocalTransform.Rotation.Z;
        //                transform.Rotation.K = jointlist[index].LocalTransform.Rotation.Y;
        //                transform.Rotation.R = jointlist[index].LocalTransform.Rotation.W;

        //                transform.Scale.W = 1;
        //                transform.Scale.X = jointlist[index].LocalTransform.Scale.X;
        //                transform.Scale.Y = jointlist[index].LocalTransform.Scale.Y;
        //                transform.Scale.Z = jointlist[index].LocalTransform.Scale.Z;

        //                transform.Translation.W = i == 0 ? 1 : 0;
        //                transform.Translation.X = jointlist[index].LocalTransform.Translation.X;
        //                transform.Translation.Y = -jointlist[index].LocalTransform.Translation.Z;
        //                transform.Translation.Z = jointlist[index].LocalTransform.Translation.Y;
        //                */
        //            } //gotta figure out those rotations

        //            var oriR = transform.Rotation;
        //            var oriRquat = new Quat(oriR.I, oriR.J, oriR.K, oriR.R);
        //            var newR = jointlist[index].LocalTransform.Rotation;
        //            var parR = jointlist[index].VisualParent.LocalTransform.Rotation;

        //            var oriT = transform.Translation;
        //            var oriTvec = new Vec4(oriT.X, oriT.Y, oriT.Z, oriT.W);
        //            var newT = jointlist[index].LocalTransform.Translation;
        //            var parT = jointlist[index].VisualParent.LocalTransform.Translation;

        //            var herewegoagane = parR * newR;


        //            var quatM = Mat4.CreateFromQuaternion(oriRquat);

        //            var d = newR - oriRquat + new Quat(0, 0, 0, 1);
        //            var p = newR * oriRquat;
        //            var e = d == p;
        //            var esmall = (d - p).Length() < 0.001;

        //            var level = levels[index];

        //            {/*
        //                var nya = System.Numerics.Vector3.Transform(tr, parR);

        //                //var rr = jointlist[index].VisualParent.VisualParent.LocalTransform.Rotation;
        //                var nye = System.Numerics.Vector3.Transform(tr, parR * rr);
        //                var rrr = jointlist[index].VisualParent.VisualParent.VisualParent.LocalTransform.Rotation;
        //                var ya = System.Numerics.Vector3.Transform(tr, parR * rr * rrr);

        //                var (r, s, t) = (new Quat(), new Vec3(), new Vec3());
        //                var tinverse = new Mat4();
        //                Mat4.Invert(jointlist[index].VisualParent.WorldMatrix, out tinverse);
        //                Mat4.Decompose(tinverse, out s, out r, out t);

        //                var yaya = System.Numerics.Vector3.Transform(tr, r * parR);*/
        //            }

        //            /*Mat4 TRSFromRig(QsTransform parTr)
        //            {
        //                var (r, s, t) = (parTr.Rotation, parTr.Scale, parTr.Translation);

        //                var R = Mat4.CreateFromQuaternion(new Quat(r.R, r.I, r.J, r.K));
        //                var S = Mat4.CreateScale(new Vec3(s.X, s.Y, s.Z));
        //                var T = Mat4.CreateTranslation(new Vec3(t.X, t.Y, t.Z));
        //                var M = T * R * S;
        //                return M;
        //            }

        //            if (index > -1 && parindex > -1)
        //            {
        //                var parM = TRSFromRig(rig.BoneTransforms[parindex]);
        //                Mat4.Invert(parM, out var parMinv);
        //                var M = TRSFromRig(rig.BoneTransforms[index]);
        //                Mat4.Invert(jointlist[index].VisualParent.WorldMatrix, out var tinverse);
        //                Mat4.Decompose(parMinv * M, out var s, out var r, out var t);
        //            }*/

        //            Quat AllOriginalRotations(int i)
        //            {
        //                var wquat = transform.Rotation;
        //                var quat = new Quat(wquat.I, wquat.J, wquat.K, wquat.R);
        //                return (rig.BoneNames[i] == "Root") ? quat : AllOriginalRotations(rig.BoneParentIndexes[i]) * quat;
        //            }

        //            var oriAllR = AllOriginalRotations(i);
        //            var oriParAllR = oriAllR * Quat.Inverse(oriRquat);
        //            var yetatr = Vec4.Transform(newT, oriAllR);

        //            Quat AllRotations(Node node)
        //            {
        //                var quat = node.LocalTransform.Rotation;
        //                return (node.Name == "Root") ? quat : AllRotations(node.VisualParent) * quat;
        //            }

        //            var infinya = AllRotations(jointlist[index]);
        //            var finit = Vec4.Transform(newT, infinya);
        //            var aynifni = Vec4.Transform(newT, Quat.Inverse(infinya));


        //            var before = transform.Translation.DeepCopy();

        //            //level = 0;

        //            var x90 = Quat.CreateFromAxisAngle(Vec3.UnitX, (float)Math.PI / 2);
        //            var y90 = Quat.CreateFromAxisAngle(Vec3.UnitY, (float)Math.PI / 2);
        //            var z90 = Quat.CreateFromAxisAngle(Vec3.UnitZ, (float)Math.PI / 2);


        //            //works only for the rig of the kusanagi bike
        //            transform.Translation = level == 1 ? Vec4.Transform(newT, x90) :
        //                                                level is 3 or
        //                                                4 ? Vec4.Transform(newT, new Quat(0, 1, 0, 0) * x90) :
        //                                                level == 5 ? Vec4.Transform(newT, x90) :
        //                                                level == 6 ? Vec4.Transform(newT, z90) :
        //                                                level == 8 ? Vec4.Transform(newT, y90 * new Quat(0, 0, 0, 1)) : // Quat(0, 0, 0, 1) is z90 * z90
        //                                                new Vec4(newT.X, newT.Y, newT.Z, 0);

        //            transform.Translation.W = i == 0 ? 1 : 0;

        //            /*
        //            transform.Translation.X = level == 6 ? -newT.Y :
        //                                                  level == 8 ? newT.Z :
        //                                                  newT.X;
        //            transform.Translation.Y = level == 1 ? newT.Z :
        //                                                  level == 3 ? -newT.Z :
        //                                                  level == 4 ? -newT.Z :
        //                                                  level == 5 ? -newT.Z :
        //                                                  level == 6 ? newT.X :
        //                                                  level == 8 ? -newT.Y :
        //                                                  newT.Y;
        //            transform.Translation.Z = level == 1 ? newT.Y :
        //                                                  level == 3 ? -newT.Y :
        //                                                  level == 4 ? -newT.Y :
        //                                                  level == 5 ? newT.Y :
        //                                                  level == 8 ? newT.X :
        //                                                  newT.Z;
        //            */

        //            var after = transform.Translation;
        //        }
        //    }
        //    var ms = new MemoryStream();
        //    using var writer = new CR2WWriter(ms, Encoding.UTF8, true) { LoggerService = _loggerService };
        //    writer.WriteFile(cr2w);
        //    ms.Seek(0, SeekOrigin.Begin);

        //    rigStream.SetLength(0);
        //    ms.CopyTo(rigStream);

        //    return true;
        //}


        public bool ImportMesh(FileInfo inGltfFile, Stream inMeshStream, GltfImportArgs args)
        {
            var cr2w = _parserService.ReadRed4File(inMeshStream);

            if (cr2w is not { RootChunk: CMesh meshBlob } || meshBlob.RenderResourceBlob.Chunk is not rendRenderMeshBlob rendBlob)
            {
                return false;
            }

            var originalRig = args.Rig?.FirstOrDefault();

            if (File.Exists(Path.ChangeExtension(inGltfFile.FullName, ".Material.json")) && (args.ImportMaterialOnly || args.ImportMaterials))
            {
                WriteMatToMesh(ref cr2w, File.ReadAllText(Path.ChangeExtension(inGltfFile.FullName, ".Material.json")));
                if (args.ImportMaterialOnly)
                {
                    var matOnlyStream = new MemoryStream();

                    //cr2w.Write(new BinaryWriter(matOnlyStream));
                    using var writer = new CR2WWriter(matOnlyStream) { LoggerService = _loggerService };
                    writer.WriteFile(cr2w);


                    matOnlyStream.Seek(0, SeekOrigin.Begin);
                    //if (outStream != null)
                    //{
                    //    matOnlyStream.CopyTo(outStream);
                    //}
                    //else
                    {
                        inMeshStream.SetLength(0);
                        matOnlyStream.CopyTo(inMeshStream);
                    }
                    return true;
                }

            }

            var model = ModelRoot.Load(inGltfFile.FullName, new ReadSettings(args.ValidationMode));

            VerifyGLTF(model, args);

            if (model.LogicalSkins.Count > 0 && args.ImportInverseBindingOnly)
            {
                var joints = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_)).ToArray();

                if (cr2w.RootChunk is CMesh root)
                {
                    var tempp = root.BoneNames.ToList();
                    for (int idx = 0; idx < joints.Count(); idx++)
                    {
                        var inMat = joints[idx].InverseBindMatrix;
                        Mat4 outMat = new Mat4(
                            inMat.M11, -inMat.M13, inMat.M12, inMat.M14,
                            -inMat.M31, inMat.M33, -inMat.M32, inMat.M34,
                            inMat.M21, -inMat.M23, inMat.M22, inMat.M24,
                            inMat.M41, -inMat.M43, inMat.M42, inMat.M44);


                        var idxx = tempp.FindIndex(x => x.ToString() == joints[idx].Joint.Name);

                        if (idxx == -1)
                        {
                            root.BoneRigMatrices.Add(outMat);
                            root.BoneNames.Add(joints[idx].Joint.Name);
                            root.BoneVertexEpsilons.Add(0);
                            root.LodBoneMask.Add(0);
                        }
                        else
                            root.BoneRigMatrices[idxx] = outMat;
                    }
                }

            }

            var meshes = new List<RawMeshContainer>();
            foreach (var node in model.LogicalNodes)
            {
                if (node.Mesh != null)
                {
                    meshes.Add(GltfMeshToRawContainer(node, args));
                }
                else if (args.FillEmpty)
                {
                    meshes.Add(CreateEmptyMesh(node.Name));
                }
            }
            meshes = meshes.OrderBy(mesh => mesh.name).ToList();

            var max = new Vec3(float.MinValue, float.MinValue, float.MinValue);
            var min = new Vec3(float.MaxValue, float.MaxValue, float.MaxValue);

            foreach (var p in meshes)
            {
                ArgumentNullException.ThrowIfNull(p.positions);
                foreach (var q in p.positions.ToList())
                {
                    max.X = Math.Max(q.X, max.X);
                    max.Y = Math.Max(q.Y, max.Y);
                    max.Z = Math.Max(q.Z, max.Z);
                }
            }

            foreach (var p in meshes)
            {
                ArgumentNullException.ThrowIfNull(p.positions);
                foreach (var q in p.positions.ToList())
                {
                    min.X = Math.Min(q.X, min.X);
                    min.Y = Math.Min(q.Y, min.Y);
                    min.Z = Math.Min(q.Z, min.Z);
                }
            }

            // GarmentSupport not accounted here. Might be an issue?
            // TODO: https://github.com/WolvenKit/WolvenKit/issues/1504 
            meshBlob.BoundingBox.Min = new Vector4 { X = min.X, Y = min.Y, Z = min.Z, W = 1f };
            meshBlob.BoundingBox.Max = new Vector4 { X = max.X, Y = max.Y, Z = max.Z, W = 1f };

            var quantScale = new Vec4((max.X - min.X) / 2, (max.Y - min.Y) / 2, (max.Z - min.Z) / 2, 0);
            var quantTrans = new Vec4((max.X + min.X) / 2, (max.Y + min.Y) / 2, (max.Z + min.Z) / 2, 1);


            RawArmature? incomingJoints = null;
            RawArmature? existingJoints = null;
            if (originalRig != null)
            {

                using var msss = new MemoryStream(rendBlob.RenderBuffer.Buffer.GetBytes());

                var meshesinfo = MeshTools.GetMeshesinfo(rendBlob, cr2w.RootChunk as CMesh);

                var expMeshesss = MeshTools.ContainRawMesh(msss, meshesinfo, true);

                foreach (var mesh in meshes)
                {
                    ArgumentNullException.ThrowIfNull(mesh.boneindices);
                    Array.Clear(mesh.boneindices, 0, mesh.boneindices.Length);
                }

                incomingJoints = MeshTools.GetOrphanRig(meshBlob);

                using var msr = new MemoryStream();
                originalRig.Extract(msr);
                existingJoints = RIG.ProcessRig(_parserService.ReadRed4File(msr));
            }
            else
            {
                existingJoints = MeshTools.GetOrphanRig(meshBlob);
                if (model.LogicalSkins.Count > 0 && model.LogicalSkins[0].JointsCount > 0)
                {
                    incomingJoints = new RawArmature
                    {
                        BoneCount = model.LogicalSkins[0].JointsCount,
                        Names = Enumerable.Range(0, model.LogicalSkins[0].JointsCount).Select(_ => model.LogicalSkins[0].GetJoint(_).Joint.Name).ToArray()
                    };
                }
            }


            MeshTools.UpdateMeshJoints(ref meshes, existingJoints, incomingJoints);

            UpdateSkinningParamCloth(ref meshes, ref cr2w, args);

            UpdateGarmentSupportParameters(meshes, cr2w, args.ImportGarmentSupport);

            var expMeshes = meshes.Select(_ => RawMeshToRE4Mesh(_, quantScale, quantTrans)).ToList();

            var meshBuffer = new MemoryStream();
            var meshesInfo = BufferWriter(expMeshes, ref meshBuffer, args);

            meshesInfo.quantScale = quantScale;
            meshesInfo.quantTrans = quantTrans;

            MemoryStream ms;

            if (originalRig != null)
            {
                var tt = model.LogicalSkins.Count >= 2
                    ? Enumerable.Range(0, model.LogicalSkins[1].JointsCount).Select(_ => model.LogicalSkins[1].GetJoint(_).Joint.WorldMatrix).ToArray()
                    : null;

                var tJointNames = model.LogicalSkins.Count >= 2 ?
                    Enumerable.Range(0, model.LogicalSkins[1].JointsCount).Select(_ => model.LogicalSkins[1].GetJoint(_).Joint.Name).ToArray()
                    : null;
                ms = GetEditedCr2wFile(cr2w, meshesInfo, meshBuffer, tt, tJointNames);
            }
            else
            {
                ms = GetEditedCr2wFile(cr2w, meshesInfo, meshBuffer);
            }

            ms.Seek(0, SeekOrigin.Begin);
            //if (outStream != null)
            //{
            //    ms.CopyTo(outStream);
            //}
            //else
            {
                inMeshStream.SetLength(0);
                ms.CopyTo(inMeshStream);
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

        // TODO: https://github.com/WolvenKit/WolvenKit/issues/1505
        // Maintaining compatibility but need to review if we really want to support empties via nodes
        private RawMeshContainer GltfMeshToRawContainer(Node node, GltfImportArgs args)
        {
            if (node.Mesh != null)
            {
                return GltfMeshToRawContainer(node.Mesh, args);
            }

            if (args.ShowVerboseLogOutput)
            {
                _loggerService.Warning($"Node {node.Name} has no mesh, creating empty mesh (this is probably wrong.)");
            }

            return CreateEmptyMesh(node.Name);

        }

        private RawMeshContainer GltfMeshToRawContainer(Mesh mesh, GltfImportArgs args)
        {
            var accessors = mesh.Primitives[0].VertexAccessors.Keys.ToList();

            var parenting = mesh.VisualParents.ToList();

            if (parenting.Count > 1)
            {
                throw new ArgumentException($"Mesh {mesh.Name} has more than one parent node! Duplicate the mesh instead of sharing it.");
            }

            var node = parenting[0];

            if (mesh.Name != node.Name && args.ShowVerboseLogOutput)
            {
                _loggerService.Warning($"Mesh name `{mesh.Name}` does not match parent node name `{node.Name}`. Using {(args.OverrideMeshNameWithNodeName ? "NODE" : "MESH")} name.");
            }

            var meshContainer = new RawMeshContainer
            {
                name = args.OverrideMeshNameWithNodeName ? node.Name : mesh.Name,

                // Copying PNT w/ RHS to LHS Y+ to Z+
                positions = mesh.Primitives[0].GetVertices("POSITION").AsVector3Array().ToList().AsParallel().Select(p => new Vec3(p.X, -p.Z, p.Y)).ToArray(),
                normals = mesh.Primitives[0].GetVertices("NORMAL").AsVector3Array().ToList().AsParallel().Select(p => new Vec3(p.X, -p.Z, p.Y)).ToArray(),
                tangents = mesh.Primitives[0].GetVertices("TANGENT").AsVector4Array().ToList().AsParallel().Select(p => new Vec4(p.X, -p.Z, p.Y, p.W)).ToArray(),

                // Blender glTF omits alpha if possible
                colors0 = accessors.Contains("COLOR_0")
                            ? (mesh.Primitives[0].GetVertices("COLOR_0").Attribute.Dimensions == DimensionType.VEC4
                                ? mesh.Primitives[0].GetVertices("COLOR_0").AsVector4Array().ToArray()
                                : mesh.Primitives[0].GetVertices("COLOR_0").AsVector3Array().Select(vec3 => new Vec4(vec3, 1)).ToArray())
                            : [],
                colors1 = accessors.Contains("COLOR_1")
                            ? (mesh.Primitives[0].GetVertices("COLOR_1").Attribute.Dimensions == DimensionType.VEC4
                                ? mesh.Primitives[0].GetVertices("COLOR_1").AsVector4Array().ToArray()
                                : mesh.Primitives[0].GetVertices("COLOR_1").AsVector3Array().Select(vec3 => new Vec4(vec3, 1)).ToArray())
                            : [],

                texCoords0 = accessors.Contains("TEXCOORD_0") ? mesh.Primitives[0].GetVertices("TEXCOORD_0").AsVector2Array().ToArray() : Array.Empty<Vec2>(),
                texCoords1 = accessors.Contains("TEXCOORD_1") ? mesh.Primitives[0].GetVertices("TEXCOORD_1").AsVector2Array().ToArray() : Array.Empty<Vec2>(),

                garmentSupportWeight = accessors.Contains("_GARMENTSUPPORTWEIGHT") ? mesh.Primitives[0].GetVertices("_GARMENTSUPPORTWEIGHT").AsVector4Array().ToArray() : Array.Empty<Vec4>(),
                garmentSupportCap = accessors.Contains("_GARMENTSUPPORTCAP") ? mesh.Primitives[0].GetVertices("_GARMENTSUPPORTCAP").AsVector4Array().ToArray() : Array.Empty<Vec4>()
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

            var jointCount = 0;
            var weightCount = 0;
            foreach (var accessor in accessors)
            {
                if (accessor.StartsWith("JOINTS_"))
                {
                    jointCount++;
                }

                if (accessor.StartsWith("WEIGHTS_"))
                {
                    weightCount++;
                }
            }

            if (jointCount != weightCount)
            {
                throw new Exception("Number of JOINTS does not match the number of WEIGHTS");
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
                if (joints0 != null && weights0 is not null && i < joints0.Count)
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
                if (joints1 != null && weights1 is not null && i < joints1.Count)
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
            // TODO: https://github.com/WolvenKit/WolvenKit/issues/1506
            //       Mesh Import Needs to Actually Check it's Working with GarmentSupport Targets.
            //       For now we'll keep assuming GS is at index 0
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
            var re4Mesh = new Re4MeshContainer
            {
                name = mesh.name
            };

            ArgumentNullException.ThrowIfNull(mesh.positions);
            ArgumentNullException.ThrowIfNull(mesh.normals);
            ArgumentNullException.ThrowIfNull(mesh.tangents);
            ArgumentNullException.ThrowIfNull(mesh.texCoords0);
            ArgumentNullException.ThrowIfNull(mesh.texCoords1);
            ArgumentNullException.ThrowIfNull(mesh.colors0);
            ArgumentNullException.ThrowIfNull(mesh.boneindices);
            ArgumentNullException.ThrowIfNull(mesh.weights);
            ArgumentNullException.ThrowIfNull(mesh.garmentMorph);
            ArgumentNullException.ThrowIfNull(mesh.indices);

            var vertCount = mesh.positions.Length;
            re4Mesh.ExpVerts = new short[vertCount, 3];

            for (var i = 0; i < vertCount; i++)
            {
                var x = qScale.X != 0 ? (mesh.positions[i].X - qTrans.X) / qScale.X : 0;
                var y = qScale.Y != 0 ? (mesh.positions[i].Y - qTrans.Y) / qScale.Y : 0;
                var z = qScale.Z != 0 ? (mesh.positions[i].Z - qTrans.Z) / qScale.Z : 0;
                re4Mesh.ExpVerts[i, 0] = Convert.ToInt16(x * 32767);
                re4Mesh.ExpVerts[i, 1] = Convert.ToInt16(y * 32767);
                re4Mesh.ExpVerts[i, 2] = Convert.ToInt16(z * 32767);
            }

            // converting normals struct
            re4Mesh.Nor32s = new uint[vertCount];
            for (var i = 0; i < vertCount; i++)
            {
                var v = new Vec4(mesh.normals[i], 0); // for normal w == 0
                re4Mesh.Nor32s[i] = Converters.Vec4ToU32(v);
            }

            // converting tangents struct
            re4Mesh.Tan32s = new uint[vertCount];
            for (var i = 0; i < vertCount; i++)
            {
                var v = mesh.tangents[i]; // for tangents w == 1 or -1
                re4Mesh.Tan32s[i] = Converters.Vec4ToU32(v);
            }

            re4Mesh.uv0s = new ushort[vertCount, 2];
            for (var i = 0; i < mesh.texCoords0.Length; i++)
            {
                re4Mesh.uv0s[i, 0] = Converters.converthf(mesh.texCoords0[i].X);
                re4Mesh.uv0s[i, 1] = Converters.converthf((mesh.texCoords0[i].Y * -1) + 1);
            }

            re4Mesh.uv1s = new ushort[vertCount, 2];
            for (var i = 0; i < mesh.texCoords1.Length; i++)
            {
                re4Mesh.uv1s[i, 0] = Converters.converthf(mesh.texCoords1[i].X);
                re4Mesh.uv1s[i, 1] = Converters.converthf(mesh.texCoords1[i].Y);
            }

            re4Mesh.colors = new byte[vertCount, 4];
            for (var i = 0; i < mesh.colors0.Length; i++)
            {
                re4Mesh.colors[i, 0] = Convert.ToByte(mesh.colors0[i].X * 255);
                re4Mesh.colors[i, 1] = Convert.ToByte(mesh.colors0[i].Y * 255);
                re4Mesh.colors[i, 2] = Convert.ToByte(mesh.colors0[i].Z * 255);
                re4Mesh.colors[i, 3] = Convert.ToByte(mesh.colors0[i].W * 255);
            }

            re4Mesh.weightcount = mesh.weightCount;

            re4Mesh.boneindices = new byte[vertCount, re4Mesh.weightcount];
            for (var i = 0; i < vertCount; i++)
            {
                for (var e = 0; e < re4Mesh.weightcount; e++)
                {
                    re4Mesh.boneindices[i, e] = Convert.ToByte(mesh.boneindices[i, e]); // mesh.boneindices are supposed to be processed
                }
            }
            // (updated according to the mesh bones rather than rig bones) before putting here

            re4Mesh.weights = new byte[vertCount, re4Mesh.weightcount];
            for (var i = 0; i < vertCount; i++)
            {
                for (var e = 0; e < re4Mesh.weightcount; e++)
                {
                    re4Mesh.weights[i, e] = Convert.ToByte(mesh.weights[i, e] * 255);
                }
                // weight summing can cause problems here, sometimes sum >= 256, idk how to fix them yet
            }

            // extradata/ morphoffsetbs
            re4Mesh.garmentMorph = new ushort[0, 0];
            if (mesh.garmentMorph.Length > 0)
            {
                re4Mesh.garmentMorph = new ushort[vertCount, 3];
                for (var i = 0; i < vertCount; i++)
                {
                    re4Mesh.garmentMorph[i, 0] = Converters.converthf(mesh.garmentMorph[i].X);
                    re4Mesh.garmentMorph[i, 1] = Converters.converthf(mesh.garmentMorph[i].Y);
                    re4Mesh.garmentMorph[i, 2] = Converters.converthf(mesh.garmentMorph[i].Z);
                }
            }

            re4Mesh.indices = new ushort[mesh.indices.Length];
            for (var i = 0; i < mesh.indices.Length; i++)
            {
                if (mesh.indices[i] <= ushort.MaxValue)
                {
                    re4Mesh.indices[i] = Convert.ToUInt16(mesh.indices[i]);
                }
                else
                {
                    throw new Exception($"Too many vertices ({mesh.indices[i]}) in submesh - max is {ushort.MaxValue}");
                }
            }

            return re4Mesh;
        }

        private static MeshesInfo BufferWriter(List<Re4MeshContainer> expMeshes, ref MemoryStream ms, GltfImportArgs args)
        {
            var meshesInfo = new MeshesInfo(expMeshes.Count);

            var bw = new BinaryWriter(ms);
            for (var i = 0; i < expMeshes.Count; i++)
            {
                var expMesh = expMeshes[i];

                ArgumentNullException.ThrowIfNull(expMesh.ExpVerts);
                ArgumentNullException.ThrowIfNull(expMesh.garmentMorph);
                ArgumentNullException.ThrowIfNull(expMesh.boneindices);
                ArgumentNullException.ThrowIfNull(expMesh.weights);
                ArgumentNullException.ThrowIfNull(expMesh.uv0s);
                ArgumentNullException.ThrowIfNull(expMesh.Nor32s);
                ArgumentNullException.ThrowIfNull(expMesh.Tan32s);
                ArgumentNullException.ThrowIfNull(expMesh.colors);
                ArgumentNullException.ThrowIfNull(expMesh.uv1s);

                var vertCount = expMesh.ExpVerts.Length / 3;

                meshesInfo.vertCounts[i] = (uint)vertCount;
                meshesInfo.posnOffsets[i] = (uint)ms.Position;

                meshesInfo.vpStrides[i] = (expMesh.weightcount * 2) + 8;
                meshesInfo.weightCounts[i] = expMesh.weightcount;

                if (expMesh.garmentMorph.Length > 0)
                {
                    meshesInfo.garmentSupportExists[i] = true;
                    meshesInfo.vpStrides[i] += 8;
                }

                for (var e = 0; e < vertCount; e++)
                {
                    bw.Write(expMesh.ExpVerts[e, 0]);
                    bw.Write(expMesh.ExpVerts[e, 1]);
                    bw.Write(expMesh.ExpVerts[e, 2]);
                    bw.Write((short)32767);
                    for (var eye = 0; eye < expMesh.weightcount; eye++)
                    {
                        bw.Write(expMesh.boneindices[e, eye]);
                    }

                    for (var eye = 0; eye < expMesh.weightcount; eye++)
                    {
                        bw.Write(expMesh.weights[e, eye]);
                    }

                    if (meshesInfo.garmentSupportExists[i])
                    {
                        bw.Write(expMesh.garmentMorph[e, 0]);
                        bw.Write(expMesh.garmentMorph[e, 1]);
                        bw.Write(expMesh.garmentMorph[e, 2]);
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
                    bw.Write(expMesh.uv0s[e, 0]);
                    bw.Write(expMesh.uv0s[e, 1]);
                }

                // 16 bytes Padding between uv0 and normals, if required
                paddingLen = ((ms.Length + 15U) & (~15)) - ms.Length;
                bw.Write(new byte[paddingLen]);

                // writing normals and tangents
                meshesInfo.normalOffsets[i] = (uint)ms.Position;
                for (var e = 0; e < vertCount; e++)
                {
                    bw.Write(expMesh.Nor32s[e]);
                    bw.Write(expMesh.Tan32s[e]);
                }

                // 16 bytes Padding between nors/tans and colors/uv1s, if required
                paddingLen = ((ms.Length + 15U) & (~15)) - ms.Length;
                bw.Write(new byte[paddingLen]);

                // writing colors and tx1s
                meshesInfo.colorOffsets[i] = (uint)ms.Position;
                for (var e = 0; e < vertCount; e++)
                {

                    bw.Write(expMesh.colors[e, 0]);
                    bw.Write(expMesh.colors[e, 1]);
                    bw.Write(expMesh.colors[e, 2]);
                    bw.Write(expMesh.colors[e, 3]);


                    // Temp fix for improved lighting geomertry
                    /*
                    bw.Write((byte)0);
                    bw.Write((byte)0);
                    bw.Write((byte)0);
                    bw.Write((byte)0);
                    */
                    bw.Write(expMesh.uv1s[e, 0]);
                    bw.Write(expMesh.uv1s[e, 1]);
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
                var mesh = expMeshes[i];

                ArgumentNullException.ThrowIfNull(mesh.indices);

                var indCount = mesh.indices.Length;
                meshesInfo.indCounts[i] = (uint)indCount;

                meshesInfo.indicesOffsets[i] = (uint)ms.Position;
                for (var e = 0; e < indCount; e++)
                {
                    bw.Write(mesh.indices[e]);
                }
            }
            meshesInfo.indexBufferSize = (uint)ms.Length - meshesInfo.indexBufferOffset;


            for (var i = 0; i < meshesInfo.meshCount; i++)
            {
                var mesh = expMeshes[i];

                ArgumentNullException.ThrowIfNull(mesh.name);

                if (mesh.name.Contains("LOD"))
                {
                    var idx = mesh.name.IndexOf("LOD_", StringComparison.Ordinal);
                    if (idx < mesh.name.Length - 1)
                    {
                        var lod = Convert.ToUInt32(mesh.name.Substring(idx + 4, 1));
                        meshesInfo.LODLvl[i] = lod;
                    }
                }
                else
                {
                    meshesInfo.LODLvl[i] = 1;
                }
            }

            return meshesInfo;
        }

        private MemoryStream GetEditedCr2wFile(CR2WFile cr2w, MeshesInfo info, MemoryStream buffer, Mat4[]? inverseBindMatrices = null, string[]? boneNames = null)
        //private static MemoryStream GetEditedCr2wFile(CR2WFile cr2w, MeshesInfo info, MemoryStream buffer)
        {
            rendRenderMeshBlob? blob = null;
            if (cr2w.RootChunk is CMesh obj1 && obj1.RenderResourceBlob.Chunk is rendRenderMeshBlob obj2)
            {
                blob = obj2;
            }

            if (cr2w.RootChunk is MorphTargetMesh obj3 && obj3.Blob.Chunk is rendRenderMorphTargetMeshBlob obj4 && obj4.BaseBlob.Chunk is rendRenderMeshBlob obj5)
            {
                blob = obj5;
            }

            ArgumentNullException.ThrowIfNull(blob, nameof(blob));

            // removing BS topology data which causes a lot of issues with improved facial lighting geometry, vertex colors uroborus and what not
            if (blob.Header.Topology is not null)
            {
                blob.Header.Topology.Clear();
                for (var i = 0; i < info.meshCount; i++)
                {
                    blob.Header.Topology.Add(new rendTopologyData());
                }
            }

            // dependent RenderLOD's removal and addition
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
            if (cr2w.RootChunk is CMesh cMeshBlob)
            {
                if (cMeshBlob.LodLevelInfo is not null)
                {
                    cMeshBlob.LodLevelInfo.Clear();

                    cMeshBlob.LodLevelInfo.Add(0f);
                    if (info.LODLvl.ToList().Contains(2))
                    {
                        cMeshBlob.LodLevelInfo.Add(3f);
                    }
                    if (info.LODLvl.ToList().Contains(4))
                    {
                        cMeshBlob.LodLevelInfo.Add(6f);
                    }
                    if (info.LODLvl.ToList().Contains(8))
                    {
                        cMeshBlob.LodLevelInfo.Add(9f);
                    }
                }
            }

            //source mesh renderMasks for updation 
            var renderMasks = blob.Header.RenderChunkInfos.Select(s => s.RenderMask).ToList();

            // removing existing rendChunks
            blob.Header.RenderChunkInfos.Clear();

            // adding new rendChunks
            for (var i = 0; i < info.meshCount; i++)
            {
                var chunk = new rendChunk
                {
                    LodMask = (byte)info.LODLvl[i],
                    RenderMask = renderMasks[i >= renderMasks.Count ? 0 : i],
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
                    //hash is not understood/no-interest, subject to change
                    Hash = 0
                };

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

                chunk.ChunkVertices.VertexLayout.SlotStrides = new CStatic<CUInt8>(8);
                for (var j = 0; j < 8; j++)
                {
                    chunk.ChunkVertices.VertexLayout.SlotStrides.Add(0);
                }

                foreach (var element in chunk.ChunkVertices.VertexLayout.Elements)
                {
                    chunk.ChunkVertices.VertexLayout.SlotStrides[element.StreamIndex] += GetDataSize(element.Type);
                }

                var slotMask = 0;
                for (var j = 0; j < chunk.ChunkVertices.VertexLayout.SlotStrides.Count; j++)
                {
                    if (chunk.ChunkVertices.VertexLayout.SlotStrides[j] > 0)
                    {
                        slotMask |= (1 << j);
                    }
                }
                chunk.ChunkVertices.VertexLayout.SlotMask = (uint)slotMask;

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
                    if (boneNames is not null)
                    {
                        var index = Array.FindIndex(boneNames, x => x.Contains(root.BoneNames[i].ToString().NotNull()) && x.Length == root.BoneNames[i].Length);

                        var position = blob.Header.BonePositions[i].NotNull();

                        position.X = inverseBindMatrices[index].M41;
                        position.Y = -inverseBindMatrices[index].M43;
                        position.Z = inverseBindMatrices[index].M42;
                        position.W = inverseBindMatrices[index].M44;
                        //position = root.BoneRigMatrices[i].W;
                    }
                }
            }

            var ms = new MemoryStream();
            using var writer = new CR2WWriter(ms, Encoding.UTF8, true) { LoggerService = _loggerService };
            writer.WriteFile(cr2w);

            return ms;
        }

        private static CUInt8 GetDataSize(Enums.GpuWrapApiVertexPackingePackingType type) =>
            type switch
            {
                Enums.GpuWrapApiVertexPackingePackingType.PT_Invalid => 0,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Float1 => 4,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Float2 => 8,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Float3 => 12,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Float4 => 16,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Float16_2 => 4,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Float16_4 => 8,
                Enums.GpuWrapApiVertexPackingePackingType.PT_UShort1 => 2,
                Enums.GpuWrapApiVertexPackingePackingType.PT_UShort2 => 4,
                Enums.GpuWrapApiVertexPackingePackingType.PT_UShort4 => 8,
                Enums.GpuWrapApiVertexPackingePackingType.PT_UShort4N => 8,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Short1 => 2,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Short2 => 4,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Short4 => 8,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Short4N => 8,
                Enums.GpuWrapApiVertexPackingePackingType.PT_UInt1 => 4,
                Enums.GpuWrapApiVertexPackingePackingType.PT_UInt2 => 8,
                Enums.GpuWrapApiVertexPackingePackingType.PT_UInt3 => 12,
                Enums.GpuWrapApiVertexPackingePackingType.PT_UInt4 => 16,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Int1 => 4,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Int2 => 8,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Int3 => 12,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Int4 => 16,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Color => 4,
                Enums.GpuWrapApiVertexPackingePackingType.PT_UByte1 => 1,
                Enums.GpuWrapApiVertexPackingePackingType.PT_UByte1F => 1,
                Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4 => 4,
                Enums.GpuWrapApiVertexPackingePackingType.PT_UByte4N => 4,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Byte4N => 4,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Dec4 => 4,
                Enums.GpuWrapApiVertexPackingePackingType.PT_Index16 => throw new NotImplementedException(),
                Enums.GpuWrapApiVertexPackingePackingType.PT_Index32 => throw new NotImplementedException(),
                Enums.GpuWrapApiVertexPackingePackingType.PT_Max => throw new NotImplementedException(),
                _ => throw new ArgumentOutOfRangeException(nameof(type), type, null)
            };

        private static void VerifyGLTF(ModelRoot model, GltfImportArgs args)
        {
            if (model.LogicalMeshes.Count < 1)
            {
                throw new Exception("Provided glTF doesn't contain any 3D Meshes");
            }
            /*if (model.LogicalSkins.Count > 1)
            {
                throw new Exception($"Armature Count: {model.LogicalSkins.Count}, Only 1 Armature is allowed");
            }*/

            var lods = new List<uint>();
            foreach (var m in model.LogicalMeshes)
            {
                var accessors = m.Primitives[0].VertexAccessors.Keys.ToList();

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
                if (m.Primitives[0].GetIndices().ToList().Count < 3)
                {
                    throw new Exception("One or more Geometry in provided GLTF doesn't contain any Triangle primitives");
                }
                var name = m.Name;
                uint lod = 0;

                if (name.Contains("LOD"))
                {
                    var idx = name.IndexOf("LOD_");
                    if (idx < name.Length - 1)
                    {
                        if (!uint.TryParse(name.AsSpan(idx + 4, 1), out lod))
                        {
                            throw new Exception("Invalid Geometry/sub mesh name: " + name + " , Character after \"LOD_\" should be 1 or 2 or 4 or 8, Representing the Level of Detail (LOD) of the submesh.");
                        }

                        if (lod is not 1 and not 2 and not 4 and not 8)
                        {
                            throw new Exception("Invalid Geometry/sub mesh name: " + name + " , Character after \"LOD_\"  should be 1 or 2 or 4 or 8, Representing the Level of Detail (LOD) of the submesh.");
                        }

                        lods.Add(lod);
                    }
                }
                else
                {
                    lods.Add(1);
                }
            }
            if (!lods.Contains(1))
            {
                throw new Exception("None of the Geometry/submeshes are of 1 Level of Detail or (LOD 1) in provided GLTF");
            }
        }
        private static void UpdateSkinningParamCloth(ref List<RawMeshContainer> meshes, ref CR2WFile cr2w, GltfImportArgs args)
        {
            var cMesh = (CMesh)cr2w.RootChunk;

            var lodLvl = new uint[meshes.Count];
            for (var i = 0; i < meshes.Count; i++)
            {
                var mesh = meshes[i];

                ArgumentNullException.ThrowIfNull(mesh.name);

                if (mesh.name.Contains("LOD"))
                {
                    var idx = mesh.name.IndexOf("LOD_", StringComparison.Ordinal);
                    if (idx < mesh.name.Length - 1)
                    {
                        if (!uint.TryParse(mesh.name.AsSpan(idx + 4, 1), out var lod) || lod is not 1 and not 2 and not 4 and not 8)
                        {
                            throw new Exception(
                                $"Invalid submesh name: {mesh.name}, Character after \"LOD_\" should be 1 or 2 or 4 or 8 to indicate submesh Level of Detail");
                        }

                        lodLvl[i] = lod;
                    }
                }
                else
                {
                    lodLvl[i] = 1;
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

            var clothBlob = cMesh.Parameters.FirstOrDefault(x => x is not null && x.Chunk is meshMeshParamCloth);
            var clothGraphicalBlob = cMesh.Parameters.FirstOrDefault(x => x is not null && x.Chunk is meshMeshParamCloth_Graphical);

            if (clothBlob != null)
            {
                var blob = (meshMeshParamCloth)clothBlob.Chunk.NotNull();
                blob.Chunks = new CArray<meshPhxClothChunkData>();
                foreach (var mesh in meshes)
                {
                    ArgumentNullException.ThrowIfNull(mesh.name);
                    ArgumentNullException.ThrowIfNull(mesh.positions);
                    ArgumentNullException.ThrowIfNull(mesh.indices);
                    ArgumentNullException.ThrowIfNull(mesh.weights);
                    ArgumentNullException.ThrowIfNull(mesh.boneindices);
                    ArgumentNullException.ThrowIfNull(mesh.normals);

                    var chunk = new meshPhxClothChunkData();
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            bw.Write(mesh.positions[e].X);
                            bw.Write(mesh.positions[e].Y);
                            bw.Write(mesh.positions[e].Z);
                        }

                        chunk.Positions = new DataBuffer(buffer.ToArray());
                    }
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        foreach (var i in mesh.indices)
                        {
                            bw.Write(Convert.ToUInt16(i));
                        }

                        chunk.Indices = new DataBuffer(buffer.ToArray());
                    }
                    if (mesh.weightCount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            bw.Write(mesh.weights[e, 0]);
                            bw.Write(mesh.weights[e, 1]);
                            bw.Write(mesh.weights[e, 2]);
                            bw.Write(mesh.weights[e, 3]);
                        }

                        chunk.SkinWeights = new DataBuffer(buffer.ToArray());
                    }
                    if (mesh.weightCount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 0]));
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 1]));
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 2]));
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 3]));
                        }

                        chunk.SkinIndices = new DataBuffer(buffer.ToArray());
                    }
                    if (mesh.weightCount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            bw.Write(mesh.weights[e, 4]);
                            bw.Write(mesh.weights[e, 5]);
                            bw.Write(mesh.weights[e, 6]);
                            bw.Write(mesh.weights[e, 7]);
                        }

                        chunk.SkinWeightsExt = new DataBuffer(buffer.ToArray());
                    }
                    if (mesh.weightCount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 4]));
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 5]));
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 6]));
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 7]));
                        }

                        chunk.SkinIndicesExt = new DataBuffer(buffer.ToArray());
                    }
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < mesh.normals.Length; e++)
                        {
                            bw.Write(mesh.normals[e].X);
                            bw.Write(mesh.normals[e].Y);
                            bw.Write(mesh.normals[e].Z);
                        }

                        chunk.Normals = new DataBuffer(buffer.ToArray());
                    }
                    blob.Chunks.Add(chunk);
                    mesh.weightCount = 0;
                }
                blob.LodChunkIndices = new CArray<CArray<CUInt16>>
                {
                    new()
                };
                if (lodLvl.Contains(2U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                if (lodLvl.Contains(4U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                if (lodLvl.Contains(8U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                for (ushort i = 0; i < lodLvl.Length; i++)
                {
                    if (lodLvl[i] == 1)
                    {
                        blob.LodChunkIndices[0].NotNull().Add(i);
                    }
                    if (lodLvl[i] == 2)
                    {
                        blob.LodChunkIndices[1].NotNull().Add(i);
                    }
                    if (lodLvl[i] == 4)
                    {
                        blob.LodChunkIndices[2].NotNull().Add(i);
                    }
                    if (lodLvl[i] == 8)
                    {
                        blob.LodChunkIndices[3].NotNull().Add(i);
                    }
                }
            }
            if (clothGraphicalBlob != null)
            {
                var blob = (meshMeshParamCloth_Graphical)clothGraphicalBlob.Chunk.NotNull();
                blob.Chunks = new CArray<meshGfxClothChunkData>();
                foreach (var mesh in meshes)
                {
                    ArgumentNullException.ThrowIfNull(mesh.name);
                    ArgumentNullException.ThrowIfNull(mesh.positions);
                    ArgumentNullException.ThrowIfNull(mesh.indices);
                    ArgumentNullException.ThrowIfNull(mesh.weights);
                    ArgumentNullException.ThrowIfNull(mesh.boneindices);
                    ArgumentNullException.ThrowIfNull(mesh.colors1);

                    var chunk = new meshGfxClothChunkData();
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            bw.Write(mesh.positions[e].X);
                            bw.Write(mesh.positions[e].Y);
                            bw.Write(mesh.positions[e].Z);
                        }

                        chunk.Positions = new DataBuffer(buffer.ToArray());
                    }
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        foreach (var i in mesh.indices)
                        {
                            bw.Write(Convert.ToUInt16(i));
                        }

                        chunk.Indices = new DataBuffer(buffer.ToArray());
                    }
                    if (mesh.weightCount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            bw.Write(mesh.weights[e, 0]);
                            bw.Write(mesh.weights[e, 1]);
                            bw.Write(mesh.weights[e, 2]);
                            bw.Write(mesh.weights[e, 3]);
                        }

                        chunk.SkinWeights = new DataBuffer(buffer.ToArray());
                    }
                    if (mesh.weightCount > 0)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 0]));
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 1]));
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 2]));
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 3]));
                        }

                        chunk.SkinIndices = new DataBuffer(buffer.ToArray());
                    }
                    if (mesh.weightCount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            bw.Write(mesh.weights[e, 4]);
                            bw.Write(mesh.weights[e, 5]);
                            bw.Write(mesh.weights[e, 6]);
                            bw.Write(mesh.weights[e, 7]);
                        }

                        chunk.SkinWeightsExt = new DataBuffer(buffer.ToArray());
                    }
                    if (mesh.weightCount > 4)
                    {
                        var buffer = new MemoryStream();
                        var bw = new BinaryWriter(buffer);
                        for (var e = 0; e < mesh.positions.Length; e++)
                        {
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 4]));
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 5]));
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 6]));
                            bw.Write(Convert.ToByte(mesh.boneindices[e, 7]));
                        }

                        chunk.SkinIndicesExt = new DataBuffer(buffer.ToArray());
                    }
                    {
                        chunk.Simulation = new CArray<CUInt16>();
                        for (ushort e = 0; e < mesh.colors1.Length; e++)
                        {
                            if (mesh.colors1[e].X > 0.01f)
                            {
                                chunk.Simulation.Add(e);
                            }
                        }
                    }
                    blob.Chunks.Add(chunk);
                    mesh.weightCount = 0;
                }
                blob.LodChunkIndices = new CArray<CArray<CUInt16>>
                {
                    new()
                };
                if (lodLvl.Contains(2U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                if (lodLvl.Contains(4U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                if (lodLvl.Contains(8U))
                {
                    blob.LodChunkIndices.Add(new CArray<CUInt16>());
                }
                for (ushort i = 0; i < lodLvl.Length; i++)
                {
                    if (lodLvl[i] == 1)
                    {
                        blob.LodChunkIndices[0].NotNull().Add(i);
                    }
                    if (lodLvl[i] == 2)
                    {
                        blob.LodChunkIndices[1].NotNull().Add(i);
                    }
                    if (lodLvl[i] == 4)
                    {
                        blob.LodChunkIndices[2].NotNull().Add(i);
                    }
                    if (lodLvl[i] == 8)
                    {
                        blob.LodChunkIndices[3].NotNull().Add(i);
                    }
                }
            }
        }

        private static void UpdateGarmentSupportParameters(List<RawMeshContainer> meshes, CR2WFile cr2w, bool importGarmentSupport = true)
        {
            if (importGarmentSupport && cr2w.RootChunk is CMesh cMesh)
            {

                if (meshes.All(x => x.garmentMorph?.Length > 0))
                {
                    var garmentMeshBlobChunk = GetParameter_meshMeshParamGarmentSupport(cMesh);

                    var garmentBlobChunk = GetParameter_garmentMeshParamGarment(cMesh);

                    foreach (var mesh in meshes)
                    {
                        WriteToGarmentSupportParameters(mesh, garmentMeshBlobChunk, garmentBlobChunk);
                    }
                }
                else
                {
                    RemoveGarmentSupportParameters(cMesh);
                }
            }
        }

        private static meshMeshParamGarmentSupport GetParameter_meshMeshParamGarmentSupport(CMesh cMesh)
        {
            var garmentMeshBlob = cMesh.Parameters.FirstOrDefault(x => x is not null && x.Chunk is meshMeshParamGarmentSupport);
            if (garmentMeshBlob == null)
            {
                garmentMeshBlob = new CHandle<meshMeshParameter>( new meshMeshParamGarmentSupport() );
                cMesh.Parameters.Add(garmentMeshBlob);
            }

            if (garmentMeshBlob.Chunk is not meshMeshParamGarmentSupport garmentMeshBlobChunk)
            {
                garmentMeshBlobChunk = new meshMeshParamGarmentSupport();
                garmentMeshBlob.Chunk = garmentMeshBlobChunk;
            }

            garmentMeshBlobChunk.ChunkCapVertices = new CArray<CArray<CUInt32>>();
            garmentMeshBlobChunk.CustomMorph = true;

            return garmentMeshBlobChunk;
        }

        private static garmentMeshParamGarment GetParameter_garmentMeshParamGarment(CMesh cMesh)
        {
            var garmentBlob = cMesh.Parameters.FirstOrDefault(x => x is not null && x.Chunk is garmentMeshParamGarment);
            if (garmentBlob == null)
            {
                garmentBlob = new CHandle<meshMeshParameter> ( new garmentMeshParamGarment() );
                cMesh.Parameters.Add(garmentBlob);
            }

            if (garmentBlob.Chunk is not garmentMeshParamGarment garmentBlobChunk)
            {
                garmentBlobChunk = new garmentMeshParamGarment();
                garmentBlob.Chunk = garmentBlobChunk;
            }

            garmentBlobChunk.Chunks = new CArray<garmentMeshParamGarmentChunkData>();

            return garmentBlobChunk;
        }

        private static void WriteToGarmentSupportParameters(RawMeshContainer mesh, meshMeshParamGarmentSupport garmentMeshBlobChunk, garmentMeshParamGarment garmentBlobChunk)
        {
            ArgumentNullException.ThrowIfNull(mesh.positions, nameof(mesh));
            ArgumentNullException.ThrowIfNull(mesh.indices, nameof(mesh));
            ArgumentNullException.ThrowIfNull(mesh.garmentMorph, nameof(mesh));

            var vertBuffer = new MemoryStream();
            var vertBw = new BinaryWriter(vertBuffer);

            var indBuffer = new MemoryStream();
            var indBw = new BinaryWriter(indBuffer);

            var morphBuffer = new MemoryStream();
            var morphBw = new BinaryWriter(morphBuffer);

            var flagBuffer = new MemoryStream();
            var flagBw = new BinaryWriter(flagBuffer);

            var capVertices = new CArray<CUInt32>();

            for (var v = 0; v < mesh.positions.Length; v++)
            {
                vertBw.Write(mesh.positions[v].X);
                vertBw.Write(mesh.positions[v].Y);
                vertBw.Write(mesh.positions[v].Z);

                morphBw.Write(mesh.garmentMorph[v].X);
                morphBw.Write(mesh.garmentMorph[v].Y);
                morphBw.Write(mesh.garmentMorph[v].Z);

                var vertexHasValidCap = mesh.garmentSupportCap?.Length > v && mesh.garmentSupportCap[v].X >= .5f;
                flagBw.Write(Convert.ToByte(mesh.garmentSupportWeight?.Length > v ? mesh.garmentSupportWeight[v].X * 255 : 0));
                flagBw.Write(Convert.ToByte(vertexHasValidCap ? 1 : 0));
                flagBw.Write((byte)0);
                flagBw.Write((byte)0);
                if (vertexHasValidCap)
                {
                    capVertices.Add(Convert.ToUInt32(v));
                }
            }

            foreach (var i in mesh.indices)
            {
                indBw.Write(Convert.ToUInt16(i));
            }

            garmentMeshBlobChunk.ChunkCapVertices.Add(capVertices);

            garmentBlobChunk.Chunks.Add(new garmentMeshParamGarmentChunkData
            {
                GarmentFlags = new DataBuffer(flagBuffer.ToArray()),
                Indices = new DataBuffer(indBuffer.ToArray()),
                MorphOffsets = new DataBuffer(morphBuffer.ToArray()),
                Vertices = new DataBuffer(vertBuffer.ToArray()),
                NumVertices = Convert.ToUInt32(mesh.positions.Length),
                LodMask = 1
            });
        }

        private static void RemoveGarmentSupportParameters(CMesh cMesh)
        {
            var garmentMeshBlob = cMesh.Parameters.FirstOrDefault(x => x is not null && x.Chunk is meshMeshParamGarmentSupport);
            if (garmentMeshBlob != null)
            {
                cMesh.Parameters.Remove(garmentMeshBlob);
            }
            var garmentBlob = cMesh.Parameters.FirstOrDefault(x => x is not null && x.Chunk is garmentMeshParamGarment);
            if (garmentBlob != null)
            {
                cMesh.Parameters.Remove(garmentBlob);
            }
        }
    }
}
