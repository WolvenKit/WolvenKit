namespace WolvenKit.RED4.Types
{
    [REDClass(SerializeDefault = true)]
    public partial class EulerAngles
    {
        public override string ToString() => $"EulerAngles, Pitch = {Pitch}, Yaw = {Yaw}, Roll = {Roll}";
    }
}
