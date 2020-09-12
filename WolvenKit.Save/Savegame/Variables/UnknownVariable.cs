namespace WolvenKit.W3SavegameEditor.Core.Savegame.Variables
{
    public class UnknownVariable : Variable
    {
        public static readonly UnknownVariable None = new UnknownVariable { Name = "None" };

        public byte[] Data { get; set; }

        public override string ToString()
        {
            return string.Format("Unknown[{0}] {1}", (Data == null ? "null" : Data.Length.ToString()), base.ToString());
        }
    }
}