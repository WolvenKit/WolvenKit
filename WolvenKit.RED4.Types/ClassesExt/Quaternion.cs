namespace WolvenKit.RED4.Types
{
    [REDClass(SerializeDefault = true)]
    public partial class Quaternion
    {
        public override string ToString() => $"Quaternion, i = {I}, j = {J}, k = {K}, r = {R}";
    }
}
