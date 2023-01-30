using System.Windows.Media.Media3D;

namespace WolvenKit.ViewModels.Documents
{
    public class SeparateMatrix
    {
        public Matrix3D rotation = new();
        public Matrix3D translation = new();
        public Matrix3D scale = new();
        public Matrix3D post = new();

        public SeparateMatrix()
        {

        }

        public void Append(SeparateMatrix matrix)
        {
            if (matrix != null)
            {
                scale.Append(matrix.scale);
                rotation.Append(matrix.rotation);
                translation.Append(matrix.translation);
                //scale.Append(matrix.rotation);
                //scale.Append(matrix.translation);
            }
        }

        public void AppendPost(SeparateMatrix matrix)
        {
            post.Append(matrix.scale);
            post.Append(matrix.rotation);
            post.Append(matrix.translation);
        }

        public void Scale(Vector3D v) => scale.Scale(v);

        public void Rotate(System.Windows.Media.Media3D.Quaternion q) => rotation.Rotate(q);//scale.Rotate(q);

        public void Translate(Vector3D v) => translation.Translate(v);//scale.Translate(v);

        public Matrix3D ToMatrix3D()
        {
            //return scale;
            var matrix = new Matrix3D();
            matrix.Append(scale);
            matrix.Append(rotation);
            matrix.Append(translation);
            matrix.Append(post);
            return matrix;
        }
    }
}
