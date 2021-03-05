using System;
using System.Collections.Generic;
using System.IO;

namespace WolvenKit.Scaleform
{
    public class CriUsmStream : MpegStream
    {
        #region Fields

        public const string DefaultAudioExtension = ".adx";
        public const string DefaultVideoExtension = ".m2v";
        public const string HcaAudioExtension = ".hca";

        protected static readonly byte[] ALP_BYTES = new byte[] { 0x40, 0x41, 0x4C, 0x50 };

        protected static readonly byte[] CONTENTS_END_BYTES =
            new byte[] { 0x23, 0x43, 0x4F, 0x4E, 0x54, 0x45, 0x4E, 0x54,
                         0x53, 0x20, 0x45, 0x4E, 0x44, 0x20, 0x20, 0x20,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x00 };

        protected static readonly byte[] CRID_BYTES = new byte[] { 0x43, 0x52, 0x49, 0x44 };
        protected static readonly byte[] CUE_BYTES = new byte[] { 0x40, 0x43, 0x55, 0x45 };

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

        protected static readonly byte[] SBT_BYTES = new byte[] { 0x40, 0x53, 0x42, 0x54 };
        protected static readonly byte[] SFA_BYTES = new byte[] { 0x40, 0x53, 0x46, 0x41 };
        protected static readonly byte[] SFV_BYTES = new byte[] { 0x40, 0x53, 0x46, 0x56 };
        protected static readonly byte[] UTF_BYTES = new byte[] { 0x40, 0x55, 0x54, 0x46 };
        private static readonly byte[] HCA_SIG_BYTES = new byte[] { 0x48, 0x43, 0x41, 0x00 };

        #endregion Fields

        #region Constructors

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

        #endregion Constructors

        #region Methods

        protected override Dictionary<string, byte[]> DoFinalTasks(FileStream sourceFileStream, Dictionary<uint, string> Filenametable, Dictionary<uint, MemoryStream> outputFiles, bool addHeader)
        {
            long headerEndOffset;
            long metadataEndOffset;
            long headerSize;

            long footerOffset;
            long footerSize;

            string sourceFileName;
            byte[] workingFile;
            string fileExtension;
            Dictionary<string, byte[]> Files = new Dictionary<string, byte[]>();
            foreach (uint streamId in outputFiles.Keys)
            {
                sourceFileName = Filenametable[streamId];

                //--------------------------
                // get header size
                //--------------------------
                headerEndOffset = ParseFile.GetNextOffset(outputFiles[streamId], 0, HEADER_END_BYTES);
                metadataEndOffset = ParseFile.GetNextOffset(outputFiles[streamId], 0, METADATA_END_BYTES);

                if (metadataEndOffset > headerEndOffset)
                {
                    headerSize = metadataEndOffset + METADATA_END_BYTES.Length;
                }
                else
                {
                    headerSize = headerEndOffset + METADATA_END_BYTES.Length;
                }

                //-----------------
                // get footer size
                //-----------------
                footerOffset = ParseFile.GetNextOffset(outputFiles[streamId], 0, CONTENTS_END_BYTES) - headerSize;
                footerSize = outputFiles[streamId].Length - footerOffset;

                //------------------------------------------
                // check data to adjust extension if needed
                //------------------------------------------
                if (this.IsThisAnAudioBlock(BitConverter.GetBytes(streamId & 0xFFFFFFF0))) // may need to change mask if more than 0xF streams
                {
                    byte[] checkBytes = ParseFile.ParseSimpleOffset(outputFiles[streamId], headerSize, 4);

                    if (ParseFile.CompareSegment(checkBytes, 0, SofdecStream.AixSignatureBytes))
                    {
                        fileExtension = SofdecStream.AixAudioExtension;
                    }
                    else if (checkBytes[0] == 0x80)
                    {
                        fileExtension = SofdecStream.AdxAudioExtension;
                    }
                    else if (ParseFile.CompareSegment(checkBytes, 0, HCA_SIG_BYTES))
                    {
                        fileExtension = HcaAudioExtension;
                    }
                    else
                    {
                        fileExtension = ".bin";
                    }
                }
                else
                {
                    fileExtension = Path.GetExtension(sourceFileName);
                }

                workingFile = FileUtil.RemoveChunkFromStream(outputFiles[streamId], 0, headerSize);
                workingFile = FileUtil.RemoveChunkFromStream(new MemoryStream(workingFile), footerOffset, footerSize);
                Files.Add(Path.ChangeExtension(Filenametable[streamId], fileExtension), workingFile);
                outputFiles[streamId].Close();
                outputFiles[streamId].Dispose();
            }
            return Files;
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

        protected override byte[] GetPacketStartBytes()
        {
            return CRID_BYTES;
        }

        protected override byte GetStreamId(Stream readStream, long currentOffset)
        {
            byte streamId;

            streamId = ParseFile.ParseSimpleOffset(readStream, currentOffset + 0xC, 1)[0];

            return streamId;
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

        #endregion Methods
    }
}
