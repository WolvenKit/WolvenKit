using IrrlichtLime.Core;
using IrrlichtLime.Scene;
using System.Collections.Generic;

namespace WolvenKit.Render
{
    // Skeleton informations
    public class RenderSkeleton
    {
        public uint nbBones = 0;
        public List<string> names = new List<string>();
        public List<short> parentIdx = new List<short>();
        public List<Matrix> matrix = new List<Matrix>();

        public List<Vector3Df> positions = new List<Vector3Df>();
        public List<Quaternion> rotations = new List<Quaternion>();
        public List<Vector3Df> scales = new List<Vector3Df>();

        /// <summary>
        /// Try to get real parent.
        /// </summary>
        public static SJoint GetRealParent(SkinnedMesh mesh, SJoint joint)
        {
            List<SJoint> allJoints = mesh.GetAllJoints();
            for (int j = 0; j < allJoints.Count; j++)
            {
                SJoint testedJoint = allJoints[j];
                for (int k = 0; k < testedJoint.Children.Count; k++)
                {
                    if (joint == testedJoint.Children[k])
                        return testedJoint;
                }
            }

            return null;
        }
        /// <summary>
        /// Try to compute global matrix.
        /// </summary>
        public static void ComputeGlobal(SkinnedMesh mesh, SJoint joint)
        {
            SJoint parent = GetRealParent(mesh, joint);
            if (parent != null)
                joint.GlobalMatrix = parent.GlobalMatrix * joint.LocalMatrix;
            else
                joint.GlobalMatrix = joint.LocalMatrix;

            for (int i = 0; i < joint.Children.Count; ++i)
            {
                ComputeGlobal(mesh, joint.Children[i]);
            }
        }
        /// <summary>
        /// Try to get all root joints.
        /// </summary>
        public static List<SJoint> GetRootJoints(SkinnedMesh mesh)
        {
            List<SJoint> roots = new List<SJoint>();

            List<SJoint> allJoints = mesh.GetAllJoints();
            for (int i = 0; i < allJoints.Count; i++)
            {
                bool isRoot = true;
                SJoint testedJoint = allJoints[i];
                for (int j = 0; j < allJoints.Count; j++)
                {
                    SJoint testedJoint2 = allJoints[j];
                    for (int k = 0; k < testedJoint2.Children.Count; k++)
                    {
                        if (testedJoint.Equals(testedJoint2.Children[k]))
                            isRoot = false;
                    }
                }
                if (isRoot)
                    roots.Add(testedJoint);
            }

            return roots;
        }
        /// <summary>
        /// Try to get joint by name.
        /// </summary>
        public static SJoint GetJointByName(SkinnedMesh mesh, string name)
        {
            int jointID = mesh.GetJointIndex(name);
            if (jointID == -1)
                return null;

            return mesh.GetAllJoints()[jointID];
        }
    };
}
