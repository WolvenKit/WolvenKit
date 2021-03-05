namespace WolvenKit.Radish.Model
{
    public class RadishBatFileWrapper
    {
        #region Constructors

        public RadishBatFileWrapper(string path)
        {
            Path = path;
        }

        #endregion Constructors

        #region Properties

        public bool Interactive { get; set; }
        public string Name { get => System.IO.Path.GetFileName(Path); }
        public string Path { get; set; }

        #endregion Properties
    }
}
