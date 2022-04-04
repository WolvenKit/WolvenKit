namespace WolvenKit.RED4.Types
{
    public partial class Quaternion
    {
        public static implicit operator Quaternion(System.Numerics.Quaternion quaternion)
        {
            Quaternion cquat = new Quaternion();
            cquat.I = quaternion.X;
            cquat.J = quaternion.Y;
            cquat.K = quaternion.Z;
            cquat.R = quaternion.W;

            return cquat;
        }

        public override string ToString() => $"Quaternion, i = {I}, j = {J}, k = {K}, r = {R}";
    }
}
