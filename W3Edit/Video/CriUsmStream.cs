using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W3Edit.Video.Parsefile;

namespace W3Edit.Video
{
    public class OffsetDescription
    {
        public string OffsetValue { set; get; }
        public string OffsetSize { set; get; }
        public string OffsetByteOrder { set; get; }
    }

    public class CriUsmStream : MpegStream
    {
        public const string DefaultAudioExtension = ".adx";
        public const string DefaultVideoExtension = ".m2v";
        public const string HcaAudioExtension = ".hca";

        static readonly byte[] HCA_SIG_BYTES = new byte[] { 0x48, 0x43, 0x41, 0x00 };

        protected static readonly byte[] ALP_BYTES = new byte[] { 0x40, 0x41, 0x4C, 0x50 };
        protected static readonly byte[] CRID_BYTES = new byte[] { 0x43, 0x52, 0x49, 0x44 };
        protected static readonly byte[] SFV_BYTES = new byte[] { 0x40, 0x53, 0x46, 0x56 };
        protected static readonly byte[] SFA_BYTES = new byte[] { 0x40, 0x53, 0x46, 0x41 };
        protected static readonly byte[] SBT_BYTES = new byte[] { 0x40, 0x53, 0x42, 0x54 };
        protected static readonly byte[] CUE_BYTES = new byte[] { 0x40, 0x43, 0x55, 0x45 };

        protected static readonly byte[] UTF_BYTES = new byte[] { 0x40, 0x55, 0x54, 0x46 };

        protected static readonly byte[] HEADER_END_BYTES =
            new byte[] { 0x23, 0x48, 0x45, 0x41, 0x44, 0x45, 0x52, 0x20,
                         0x45, 0x4E, 0x44, 0x20, 0x20, 0x20, 0x20, 0x20,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x00 };

        protected static readonly byte[] METADATA_END_BYTES =
            new byte[] { 0x23, 0x4D, 0x45, 0x54, 0x41, 0x44, 0x41, 0x54,
                         0x41, 0x20, 0x45, 0x4E, 0x44, 0x20, 0x20, 0x20,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x00 };

        protected static readonly byte[] CONTENTS_END_BYTES =
            new byte[] { 0x23, 0x43, 0x4F, 0x4E, 0x54, 0x45, 0x4E, 0x54,
                         0x53, 0x20, 0x45, 0x4E, 0x44, 0x20, 0x20, 0x20,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x00 };

        public CriUsmStream(string path)
            : base(path)
        {
            this.UsesSameIdForMultipleAudioTracks = true;
            this.FileExtensionAudio = DefaultAudioExtension;
            this.FileExtensionVideo = DefaultVideoExtension;

            base.BlockIdDictionary.Clear();
            base.BlockIdDictionary[BitConverter.ToUInt32(ALP_BYTES, 0)] = new BlockSizeStruct(PacketSizeType.SizeBytes, 4); // @ALP
            base.BlockIdDictionary[BitConverter.ToUInt32(CRID_BYTES, 0)] = new BlockSizeStruct(PacketSizeType.SizeBytes, 4); // CRID
            base.BlockIdDictionary[BitConverter.ToUInt32(SFV_BYTES, 0)] = new BlockSizeStruct(PacketSizeType.SizeBytes, 4); // @SFV
            base.BlockIdDictionary[BitConverter.ToUInt32(SFA_BYTES, 0)] = new BlockSizeStruct(PacketSizeType.SizeBytes, 4); // @SFA
            base.BlockIdDictionary[BitConverter.ToUInt32(SBT_BYTES, 0)] = new BlockSizeStruct(PacketSizeType.SizeBytes, 4); // @SBT
            base.BlockIdDictionary[BitConverter.ToUInt32(CUE_BYTES, 0)] = new BlockSizeStruct(PacketSizeType.SizeBytes, 4); // @CUE
        }

        protected override byte[] GetPacketStartBytes() { return CRID_BYTES; }

        protected override int GetAudioPacketHeaderSize(Stream readStream, long currentOffset)
        {
            UInt16 checkBytes;
            OffsetDescription od = new OffsetDescription();

            od.OffsetByteOrder = Constants.BigEndianByteOrder;
            od.OffsetSize = "2";
            od.OffsetValue = "8";

            checkBytes = (UInt16)ParseFile.GetVaryingByteValueAtRelativeOffset(readStream, od, currentOffset);

            return checkBytes;
        }
        protected override int GetVideoPacketHeaderSize(Stream readStream, long currentOffset)
        {
            UInt16 checkBytes;
            OffsetDescription od = new OffsetDescription();

            od.OffsetByteOrder = Constants.BigEndianByteOrder;
            od.OffsetSize = "2";
            od.OffsetValue = "8";

            checkBytes = (UInt16)ParseFile.GetVaryingByteValueAtRelativeOffset(readStream, od, currentOffset);

            return checkBytes;
        }

        protected override bool IsThisAnAudioBlock(byte[] blockToCheck)
        {
            return ParseFile.CompareSegment(blockToCheck, 0, SFA_BYTES);
        }
        protected override bool IsThisAVideoBlock(byte[] blockToCheck)
        {
            return ParseFile.CompareSegment(blockToCheck, 0, SFV_BYTES);
        }

        protected override byte GetStreamId(Stream readStream, long currentOffset)
        {
            byte streamId;

            streamId = ParseFile.ParseSimpleOffset(readStream, currentOffset + 0xC, 1)[0];

            return streamId;
        }

        protected override int GetAudioPacketFooterSize(Stream readStream, long currentOffset)
        {
            UInt16 checkBytes;
            OffsetDescription od = new OffsetDescription();

            od.OffsetByteOrder = Constants.BigEndianByteOrder;
            od.OffsetSize = "2";
            od.OffsetValue = "0xA";

            checkBytes = (UInt16)ParseFile.GetVaryingByteValueAtRelativeOffset(readStream, od, currentOffset);

            return checkBytes;
        }

        protected override int GetVideoPacketFooterSize(Stream readStream, long currentOffset)
        {
            UInt16 checkBytes;
            OffsetDescription od = new OffsetDescription();

            od.OffsetByteOrder = Constants.BigEndianByteOrder;
            od.OffsetSize = "2";
            od.OffsetValue = "0xA";

            checkBytes = (UInt16)ParseFile.GetVaryingByteValueAtRelativeOffset(readStream, od, currentOffset);

            return checkBytes;
        }
    }
}
