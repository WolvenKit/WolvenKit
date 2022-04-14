using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
    public partial class CMatrix : RedBaseClass
    {
/*        public CMatrix(System.Numerics.Matrix4x4 matrix)
        {
            X = new() { X = matrix.M11 };
            Y = new() { Y = matrix.M22 };
            Z = new() { Z = 1.000000F };
            W = new() { W = 1.000000F };
        }
*/
        public static implicit operator CMatrix(System.Numerics.Matrix4x4 matrix)
        {
            CMatrix cmatrix = new CMatrix();
            cmatrix.X.X = matrix.M11;
            cmatrix.X.Y = matrix.M12;
            cmatrix.X.Z = matrix.M13;
            cmatrix.X.W = matrix.M14;

            cmatrix.Y.X = matrix.M21;
            cmatrix.Y.Y = matrix.M22;
            cmatrix.Y.Z = matrix.M23;
            cmatrix.Y.W = matrix.M24;

            cmatrix.Z.X = matrix.M31;
            cmatrix.Z.Y = matrix.M32;
            cmatrix.Z.Z = matrix.M33;
            cmatrix.Z.W = matrix.M34;

            cmatrix.W.X = matrix.M41;
            cmatrix.W.Y = - matrix.M43;
            cmatrix.W.Z = matrix.M42;
            cmatrix.W.W = matrix.M44;

            return cmatrix;
        }
    }
}
