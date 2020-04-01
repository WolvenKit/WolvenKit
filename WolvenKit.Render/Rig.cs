using IrrlichtLime.Core;
using IrrlichtLime.Scene;
using System.Collections.Generic;
using System.IO;
using WolvenKit.CR2W;
using WolvenKit.CR2W.Types;

namespace WolvenKit.Render
{
    public class Rig
    {
        public CommonData CData { get; set; }

        private CSkeleton meshSkeleton = new CSkeleton();

        public Rig(CommonData cdata)
        {
            CData = cdata;

            CData.w3_DataCache.bones.Clear();
        }

        /// <summary>
        /// Read rig data.
        /// </summary>
        public void LoadData(CR2WFile rigFile)
        {
            // *************** READ RIG DATA ***************
            if (rigFile != null)
            foreach (var chunk in rigFile.chunks)
            {
                if (chunk.Type == "CSkeleton")
                {
                    var bones = chunk.GetVariableByName("bones") as CArray;
                    meshSkeleton.nbBones = (uint)bones.array.Count;
                    foreach (CVector bone in bones)
                    {
                        var boneName = bone.variables.GetVariableByName("nameAsCName") as CName;
                        meshSkeleton.names.Add(boneName.Value);
                    }
                    var parentIndices = chunk.GetVariableByName("parentIndices") as CArray;
                    foreach (CVariable parentIndex in parentIndices)
                    {
                        meshSkeleton.parentIdx.Add(short.Parse(parentIndex.ToString()));
                    }

                    var rigdata = (chunk.GetVariableByName("rigdata") as CCompressedBuffer<SSkeletonRigData>).elements;


                    for (int i = 0; i < meshSkeleton.nbBones; i++)
                    {

                        Vector3Df position = new Vector3Df(
                            rigdata[i].position.x.val,
                            rigdata[i].position.y.val,
                            rigdata[i].position.z.val);

                        Quaternion orientation = new Quaternion(
                            rigdata[i].rotation.x.val,
                            rigdata[i].rotation.y.val,
                            rigdata[i].rotation.z.val,
                            rigdata[i].rotation.w.val);

                        Vector3Df scale = new Vector3Df(
                            rigdata[i].scale.x.val,
                            rigdata[i].scale.y.val,
                            rigdata[i].scale.z.val);

                        Matrix posMat = new Matrix();
                        posMat.Translation = position;

                        Matrix rotMat = new Matrix();
                        Vector3Df euler = orientation.ToEuler();
                        checkNaNErrors(euler);

                        rotMat.SetRotationRadians(euler);

                        Matrix scaleMat = new Matrix();
                        scaleMat.Scale = scale;

                        Matrix localTransform = posMat * rotMat * scaleMat;
                        orientation = orientation.MakeInverse();
                        meshSkeleton.matrix.Add(localTransform);
                        meshSkeleton.positions.Add(position);
                        meshSkeleton.rotations.Add(orientation);
                        meshSkeleton.scales.Add(scale);
                    }
                }
            }
        }

        // sometimes toEuler give NaN numbers
        private void checkNaNErrors(Vector3Df vector3)
        {
            if (float.IsNaN(vector3.X) || float.IsNaN(vector3.X))
                vector3.X = 0.0f;

            if (float.IsNaN(vector3.Y) || float.IsNaN(vector3.Y))
                vector3.Y = 0.0f;

            if (float.IsNaN(vector3.Z) || float.IsNaN(vector3.Z))
                vector3.Z = 0.0f;

        }

        /// <summary>
        /// Try to apply skeleton to model.
        /// </summary>
        public void Apply(SkinnedMesh skinnedMesh)
        {
            // Create the bones
            for (int i = 0; i < meshSkeleton.nbBones; i++)
            {
                string boneName = meshSkeleton.names[i];
                if (skinnedMesh.GetJointIndex(boneName) == -1)
                {
                    var joint = skinnedMesh.AddJoint();
                    joint.Name = boneName;
                }
            }

            // Set the hierarchy
            for (int i = 0; i < meshSkeleton.nbBones; i++)
            {
                short parent = meshSkeleton.parentIdx[i];
                if (parent != -1) // root
                {
                    var parentJoint = CSkeleton.GetJointByName(skinnedMesh, meshSkeleton.names[parent]);
                    if (parentJoint != null)
                        parentJoint.AddChildren(skinnedMesh.GetAllJoints()[i]);
                }
            }

            // Set the transformations
            for (int i = 0; i < meshSkeleton.nbBones; i++)
            {
                string boneName = meshSkeleton.names[i];

                var joint = CSkeleton.GetJointByName(skinnedMesh, boneName);
                if (joint == null)
                    continue;

                joint.LocalMatrix = meshSkeleton.matrix[i];

                joint.Animatedposition = meshSkeleton.positions[i];
                joint.Animatedrotation = meshSkeleton.rotations[i];
                joint.Animatedscale = meshSkeleton.scales[i];
            }

            // Compute the global matrix
            List<SJoint> roots = CSkeleton.GetRootJoints(skinnedMesh);
            for (int i = 0; i < roots.Count; ++i)
            {
                CSkeleton.ComputeGlobal(skinnedMesh, roots[i]);
            }

            // The matrix of the bones
            for (int i = 0; i < CData.boneData.nbBones; i++)
            {
                var jointIdx = skinnedMesh.GetJointIndex(CData.boneData.jointNames[i]);
                SJoint joint = skinnedMesh.GetAllJoints()[jointIdx];

                Matrix matrix = CData.boneData.boneMatrices[i];

                Vector3Df position = matrix.Translation;
                Matrix invRot = matrix.GetInverse();
                //invRot.rotateVect(position);

                Vector3Df rotation = invRot.GetRotationDegrees(invRot.Scale);
                //rotation = core::vector3df(0, 0, 0);
                position = -position;
                Vector3Df scale = matrix.Scale;

                if (joint != null)
                {
                    // Build GlobalMatrix:
                    Matrix positionMatrix = new Matrix();
                    positionMatrix.Translation = position;
                    Matrix scaleMatrix = new Matrix();
                    scaleMatrix.Scale = scale;
                    Matrix rotationMatrix = new Matrix();
                    rotationMatrix.SetRotationRadians(rotation * CommonData.PI_OVER_180);

                    //joint.GlobalMatrix = scaleMatrix * rotationMatrix * positionMatrix;
                    //joint.LocalMatrix = joint.GlobalMatrix;

                    //joint.Animatedposition = joint.LocalMatrix.Translation;
                    //joint.Animatedrotation = new Quaternion(joint.LocalMatrix.GetRotationDegrees(joint.LocalMatrix.Scale)).MakeInverse();
                    //joint.Animatedscale = joint.LocalMatrix.Scale;

                    var bone = new W3_DataCache.BoneEntry();
                    bone.name = joint.Name;
                    bone.offsetMatrix = matrix;
                    CData.w3_DataCache.bones.Add(bone);
                }
            }

            // Apply skin
            for (int i = 0; i < CData.w3_DataCache.vertices.Count; i++)
            {
                var entry = CData.w3_DataCache.vertices[i];

                // Check if it's a valid entry
                if (entry.boneId >= CData.w3_DataCache.bones.Count
                    || entry.meshBufferId >= skinnedMesh.MeshBufferCount
                    || entry.vertexId >= skinnedMesh.GetMeshBuffer(entry.meshBufferId).VertexCount)
                {
                    // Console.WriteLine("Fail to skin : the vertex entry is not valid.");
                    continue;
                }


                int jointID = skinnedMesh.GetJointIndex(CData.w3_DataCache.bones[(int)entry.boneId].name);
                if (jointID == -1)
                {
                    // Console.WriteLine("Fail to skin : joint not found." );
                    continue;
                }

                SJoint joint = skinnedMesh.GetAllJoints()[jointID];
                SWeight weight = skinnedMesh.AddWeight(joint);
                weight.BufferId = entry.meshBufferId;
                weight.VertexId = entry.vertexId;
                weight.Strength = entry.strength;
            }

            // Add weights
            /*for (int i = 0; i < w3_DataCache.vertices.Count; i++)
            {
                uint boneId = w3_DataCache.vertices[i].boneId;
                ushort bufferId = w3_DataCache.vertices[i].meshBufferId;
                uint vertexId = w3_DataCache.vertices[i].vertexId;
                float fweight = w3_DataCache.vertices[i].strength;

                if (boneId >= skinnedMesh.GetAllJoints().Count) // If bone doesnt exist
                    continue;

                SJoint joint = skinnedMesh.GetAllJoints()[(int)boneId];

                SWeight w = skinnedMesh.AddWeight(joint);
                w.BufferId = bufferId;
                w.Strength = fweight;
                w.VertexId = vertexId;
            }*/
        }
    }
}
