namespace WolvenKit.Scaleform
{
    public class RiffCalculatingOffsetDescription : CalculatingOffsetDescription
    {
        #region Fields

        public const string END_OF_STRING = "end of";
        public const string START_OF_STRING = "start of";

        #endregion Fields

        #region Properties

        public string RelativeLocationToRiffChunkString { set; get; }
        public string RiffChunkString { set; get; }

        #endregion Properties
    }
}
