namespace WolvenKit.W3SavegameEditor.Core.SaveModels
{
    public class SavegameModel
    {
        #region Properties

        public SavegameDataModel Data { get; set; }
        public string Name { get; set; }

        public string Path { get; set; }

        public string ThumbnailPath { get; set; }

        #endregion Properties
    }
}
