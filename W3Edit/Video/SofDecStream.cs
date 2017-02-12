using System.IO;
using W3Edit.Video.Parsefile;

namespace W3Edit.Video
{
    public class SofdecStream : Mpeg1Stream
    {
        new public const string DefaultVideoExtension = ".m2v";

        public const string AdxAudioExtension = ".adx";
        public const string AixAudioExtension = ".aix";

        public static readonly byte[] AixSignatureBytes = { 0x41, 0x49, 0x58, 0x46 };

        public SofdecStream(string path) : base(path)
        {
            FileExtensionAudio = AdxAudioExtension;
            FileExtensionVideo = DefaultVideoExtension;
        }

        protected override string GetAudioFileExtension(Stream readStream, long currentOffset)
        {
            string fileExtension;
            byte[] checkBytes;

            int headerSize = GetAudioPacketHeaderSize(readStream, currentOffset);
            checkBytes = ParseFile.ParseSimpleOffset(readStream, (currentOffset + 6 + headerSize), 4);

            if (ParseFile.CompareSegment(checkBytes, 0, AixSignatureBytes))
            {
                fileExtension = AixAudioExtension;
            }
            else if (checkBytes[0] == 0x80)
            {
                fileExtension = AdxAudioExtension;
            }
            else
            {
                fileExtension = ".bin";
            }

            return fileExtension;
        }
    }
}
