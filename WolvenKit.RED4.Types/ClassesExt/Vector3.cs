namespace WolvenKit.RED4.Types
{
    [REDClass(SerializeDefault = true)]
    public partial class Vector3
    {
        public override string ToString() => $"Vector3, X = {X}, Y = {Y}, Z = {Z}";
    }
}
