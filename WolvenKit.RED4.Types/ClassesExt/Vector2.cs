namespace WolvenKit.RED4.Types
{
    [REDClass(SerializeDefault = true)]
    public partial class Vector2
    {
        public override string ToString() => $"Vector2, X = {X}, Y = {Y}";
    }
}
