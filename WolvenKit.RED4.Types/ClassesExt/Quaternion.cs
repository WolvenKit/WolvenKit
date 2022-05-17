namespace WolvenKit.RED4.Types
{
    public partial class Quaternion
    {
        public static implicit operator Quaternion(System.Numerics.Quaternion q) =>
            new Quaternion { I = q.X, J = q.Y, K = q.Z, R = q.W };

        public static implicit operator System.Numerics.Quaternion(Quaternion q) =>
            new System.Numerics.Quaternion { X = q.I, Y = q.J, Z = q.K, W = q.R };

        public override string ToString() => $"Quaternion, i = {I}, j = {J}, k = {K}, r = {R}";
    }
}
