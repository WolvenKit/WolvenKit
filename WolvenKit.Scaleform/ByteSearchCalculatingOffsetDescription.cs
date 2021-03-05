namespace WolvenKit.Scaleform
{
    public class ByteSearchCalculatingOffsetDescription : CalculatingOffsetDescription
    {
        #region Fields

        public const string END_OF_STRING = "end of";
        public const string START_OF_STRING = "start of";

        #endregion Fields

        #region Properties

        public string ByteString { set; get; }
        public string RelativeLocationToByteString { set; get; }
        public bool TreatByteStringAsHex { set; get; }

        #endregion Properties
    }
}
