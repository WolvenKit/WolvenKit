using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types;

public partial class CMatrix : RedBaseClass
{
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
        cmatrix.W.Y = matrix.M42;
        cmatrix.W.Z = matrix.M43;
        cmatrix.W.W = matrix.M44;

        return cmatrix;
    }

    public static implicit operator System.Numerics.Matrix4x4(CMatrix matrix) =>
        new System.Numerics.Matrix4x4()
        {
            M11 = matrix.X.X,
            M12 = matrix.X.Y,
            M13 = matrix.X.Z,
            M14 = matrix.X.W,

            M21 = matrix.Y.X,
            M22 = matrix.Y.Y,
            M23 = matrix.Y.Z,
            M24 = matrix.Y.W,

            M31 = matrix.Z.X,
            M32 = matrix.Z.Y,
            M33 = matrix.Z.Z,
            M34 = matrix.Z.W,

            M41 = matrix.W.X,
            M42 = matrix.W.Y,
            M43 = matrix.W.Z,
            M44 = matrix.W.W
        };

}