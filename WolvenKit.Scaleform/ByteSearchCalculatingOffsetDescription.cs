namespace WolvenKit.Scaleform
{
    public class ByteSearchCalculatingOffsetDescription : CalculatingOffsetDescription
    {
        public const string START_OF_STRING = "start of";
        public const string END_OF_STRING = "end of";

        public string RelativeLocationToByteString { set; get; }
        public string ByteString { set; get; }
        public bool TreatByteStringAsHex { set; get; }
    }
}
