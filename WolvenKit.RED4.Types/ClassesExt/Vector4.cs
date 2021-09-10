namespace WolvenKit.RED4.Types
{
    [REDClass(SerializeDefault = true)]
    public partial class Vector4
    {
        public override string ToString() => $"Vector4, X = {X}, Y = {Y}, Z = {Z}, W = {W}";
    }
}
