namespace W3SavegameEditor.Core.SaveModels
{
    public class SavegameModel
    {
        public string Name { get; set; }

        public string Path { get; set; }

        public string ThumbnailPath { get; set; }

        public SavegameDataModel Data { get; set; }
    }
}