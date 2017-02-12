using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using W3Edit.Video.Parsefile;

namespace W3Edit.Video
{
    public struct MpegDemuxStruct
    {
        public string SourceFormat { set; get; }

        public bool ExtractAudio { set; get; }
        public bool ExtractVideo { set; get; }

        public bool AddHeader { set; get; }
        public bool SplitAudioTracks { set; get; }
        public bool AddPlaybackHacks { set; get; }

        public string[] SourcePaths { set; get; }
    }

    public abstract class MpegStream
    {
        public const string DefaultAudioExtension = ".adx";
        public const string DefaultVideoExtension = ".m2v";
        public const string HcaAudioExtension = ".hca";

        static readonly byte[] HCA_SIG_BYTES = { 0x48, 0x43, 0x41, 0x00 };

        protected static readonly byte[] ALP_BYTES = { 0x40, 0x41, 0x4C, 0x50 };
        protected static readonly byte[] CRID_BYTES = { 0x43, 0x52, 0x49, 0x44 };
        protected static readonly byte[] SFV_BYTES = { 0x40, 0x53, 0x46, 0x56 };
        protected static readonly byte[] SFA_BYTES = { 0x40, 0x53, 0x46, 0x41 };
        protected static readonly byte[] SBT_BYTES = { 0x40, 0x53, 0x42, 0x54 };
        protected static readonly byte[] CUE_BYTES = { 0x40, 0x43, 0x55, 0x45 };

        protected static readonly byte[] UTF_BYTES = { 0x40, 0x55, 0x54, 0x46 };

        protected static readonly byte[] HEADER_END_BYTES =
            { 0x23, 0x48, 0x45, 0x41, 0x44, 0x45, 0x52, 0x20,
                         0x45, 0x4E, 0x44, 0x20, 0x20, 0x20, 0x20, 0x20,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x00 };

        protected static readonly byte[] METADATA_END_BYTES =
            { 0x23, 0x4D, 0x45, 0x54, 0x41, 0x44, 0x41, 0x54,
                         0x41, 0x20, 0x45, 0x4E, 0x44, 0x20, 0x20, 0x20,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x00 };

        protected static readonly byte[] CONTENTS_END_BYTES =
            { 0x23, 0x43, 0x4F, 0x4E, 0x54, 0x45, 0x4E, 0x54,
                         0x53, 0x20, 0x45, 0x4E, 0x44, 0x20, 0x20, 0x20,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D,
                         0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x3D, 0x00 };

        protected static readonly byte[] PacketStartBytes = { 0x00, 0x00, 0x01, 0xBA };
        protected static readonly byte[] PacketEndBytes = { 0x00, 0x00, 0x01, 0xB9 };

        public MpegStream(string path)
        {
            FilePath = path;
            UsesSameIdForMultipleAudioTracks = false;
            SubTitleExtractionSupported = false;
            BlockSizeIsLittleEndian = false;

            //********************
            // Add Slice Packets 
            //********************
            byte[] sliceBytes;
            uint sliceBytesValue;
            BlockSizeStruct blockSize = new BlockSizeStruct(PacketSizeType.Static, 0xE);

            for (byte i = 0; i <= 0xAF; i++)
            {
                sliceBytes = new byte[] { 0x00, 0x00, 0x01, i };
                sliceBytesValue = BitConverter.ToUInt32(sliceBytes, 0);
                BlockIdDictionary.Add(sliceBytesValue, blockSize);
            }
        }

        public enum PacketSizeType
        {
            Static,
            SizeBytes,
            Eof
        }

        public struct MpegDemuxOptions
        {
            public bool AddHeader { set; get; }
        }

        public struct BlockSizeStruct
        {
            public PacketSizeType SizeType;
            public int Size;

            public BlockSizeStruct(PacketSizeType sizeTypeValue, int sizeValue)
            {
                SizeType = sizeTypeValue;
                Size = sizeValue;
            }
        }

        public struct DemuxOptionsStruct
        {
            public bool ExtractVideo { set; get; }
            public bool ExtractAudio { set; get; }

            public bool AddHeader { set; get; }
            public bool SplitAudioStreams { set; get; }
            public bool AddPlaybackHacks { set; get; }
        }

        #region Dictionary Initialization

        protected Dictionary<uint, BlockSizeStruct> BlockIdDictionary =
            new Dictionary<uint, BlockSizeStruct>
            {                                                
                //********************
                // System Packets
                //********************
                {BitConverter.ToUInt32(PacketEndBytes, 0), new BlockSizeStruct(PacketSizeType.Eof, -1)},   // Program End
                {BitConverter.ToUInt32(PacketStartBytes, 0), new BlockSizeStruct(PacketSizeType.Static, 0xE)}, // Pack Header
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xBB }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // System Header, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xBD }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Private Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xBE }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Padding Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xBF }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Private Stream, two bytes following equal length (Big Endian)

                //****************************
                // Audio Streams
                //****************************
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xC0 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xC1 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xC2 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xC3 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xC4 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xC5 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xC6 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xC7 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xC8 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xC9 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xCA }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xCB }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xCC }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xCD }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xCE }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xCF }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xD0 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xD1 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xD2 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xD3 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xD4 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xD5 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xD6 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xD7 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xD8 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xD9 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xDA }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xDB }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xDC }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xDD }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xDE }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xDF }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Audio Stream, two bytes following equal length (Big Endian)

                //****************************
                // Video Streams
                //****************************
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xE0 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xE1 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xE2 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xE3 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xE4 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xE5 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xE6 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xE7 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xE8 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xE9 }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xEA }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xEB }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xEC }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xED }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xEE }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)}, // Video Stream, two bytes following equal length (Big Endian)
                {BitConverter.ToUInt32(new byte[] { 0x00, 0x00, 0x01, 0xEF }, 0), new BlockSizeStruct(PacketSizeType.SizeBytes, 2)} // Video Stream, two bytes following equal length (Big Endian)
            };
        #endregion

        public string FilePath { get; set; }
        public string FileExtensionAudio { get; set; }
        public string FileExtensionVideo { get; set; }

        protected Dictionary<byte, string> StreamIdFileType = new Dictionary<byte, string>();

        public bool UsesSameIdForMultipleAudioTracks { set; get; } // for PMF/PAM/DVD, who use 000001BD for all audio tracks
        public bool SubTitleExtractionSupported { set; get; } // assume not supported.

        public bool BlockSizeIsLittleEndian { set; get; }

        protected virtual byte[] GetPacketStartBytes() { return PacketStartBytes; }

        protected virtual byte[] GetPacketEndBytes() { return PacketEndBytes; }

        protected abstract int GetAudioPacketHeaderSize(Stream readStream, long currentOffset);

        protected virtual int GetAudioPacketSubHeaderSize(Stream readStream, long currentOffset, byte streamId) { return 0; }

        protected abstract int GetVideoPacketHeaderSize(Stream readStream, long currentOffset);

        protected virtual int GetAudioPacketFooterSize(Stream readStream, long currentOffset) { return 0; }

        protected virtual int GetVideoPacketFooterSize(Stream readStream, long currentOffset) { return 0; }

        protected virtual bool IsThisAnAudioBlock(byte[] blockToCheck)
        {
            return ((blockToCheck[3] >= 0xC0) &&
                    (blockToCheck[3] <= 0xDF));
        }

        protected virtual bool IsThisAVideoBlock(byte[] blockToCheck)
        {
            return ((blockToCheck[3] >= 0xE0) && (blockToCheck[3] <= 0xEF));
        }

        protected virtual bool IsThisASubPictureBlock(byte[] blockToCheck)
        {
            return ((blockToCheck[3] >= 0xE0) && (blockToCheck[3] <= 0xEF));
        }

        protected virtual string GetAudioFileExtension(Stream readStream, long currentOffset)
        {
            return FileExtensionAudio;
        }

        protected virtual string GetVideoFileExtension(Stream readStream, long currentOffset)
        {
            return FileExtensionVideo;
        }

        protected virtual byte GetStreamId(Stream readStream, long currentOffset) { return 0; }

        protected virtual long GetStartOffset(Stream readStream, long currentOffset) { return 0; }

        public virtual Dictionary<string, byte[]> DemultiplexStreams(DemuxOptionsStruct demuxOptions)
        {
            var files = new Dictionary<uint, byte[]>();
            var filenametable = new Dictionary<uint,string>();
            using (FileStream fs = File.OpenRead(FilePath))
            {
                long fileSize = fs.Length;
                long currentOffset = 0;

                byte[] currentBlockId;
                uint currentBlockIdVal;
                byte[] currentBlockIdNaming;

                BlockSizeStruct blockStruct = new BlockSizeStruct();
                byte[] blockSizeArray;
                uint blockSize;

                int audioBlockSkipSize;
                int videoBlockSkipSize;

                int audioBlockFooterSize;
                int videoBlockFooterSize;

                int cutSize;

                bool eofFlagFound = false;

                string outputFileName;

                byte streamId = 0;          // for types that have multiple streams in the same block ID
                uint currentStreamKey;  // hash key for each file
                bool isAudioBlock;
                string audioFileExtension;

                // look for first packet
                currentOffset = GetStartOffset(fs, currentOffset);
                currentOffset = ParseFile.GetNextOffset(fs, currentOffset, GetPacketStartBytes());

                if (currentOffset != -1)
                {
                    while (currentOffset < fileSize)
                    {
                        try
                        {
                            // get the current block
                            currentBlockId = ParseFile.ParseSimpleOffset(fs, currentOffset, 4);

                            // get value to use as key to hash table
                            currentBlockIdVal = BitConverter.ToUInt32(currentBlockId, 0);

                            if (BlockIdDictionary.ContainsKey(currentBlockIdVal))
                            {
                                // get info about this block type
                                blockStruct = BlockIdDictionary[currentBlockIdVal];

                                switch (blockStruct.SizeType)
                                {
                                    /////////////////////
                                    // Static Block Size
                                    /////////////////////
                                    case PacketSizeType.Static:
                                        currentOffset += blockStruct.Size; // skip this block
                                        break;

                                    //////////////////
                                    // End of Stream
                                    //////////////////
                                    case PacketSizeType.Eof:
                                        eofFlagFound = true; // set EOF block found so we can exit the loop
                                        break;

                                    //////////////////////
                                    // Varying Block Size
                                    //////////////////////
                                    case PacketSizeType.SizeBytes:

                                        // Get the block size
                                        blockSizeArray = ParseFile.ParseSimpleOffset(fs, currentOffset + currentBlockId.Length, blockStruct.Size);

                                        if (!BlockSizeIsLittleEndian)
                                        {
                                            Array.Reverse(blockSizeArray);
                                        }

                                        switch (blockStruct.Size)
                                        {
                                            case 4:
                                                blockSize = BitConverter.ToUInt32(blockSizeArray, 0);
                                                break;
                                            case 2:
                                                blockSize = BitConverter.ToUInt16(blockSizeArray, 0);
                                                break;
                                            case 1:
                                                blockSize = blockSizeArray[0];
                                                break;
                                            default:
                                                throw new ArgumentOutOfRangeException(String.Format("Unhandled size block size.{0}", Environment.NewLine));
                                        }


                                        // if block type is audio or video, extract it
                                        isAudioBlock = IsThisAnAudioBlock(currentBlockId);

                                        if ((demuxOptions.ExtractAudio && isAudioBlock) ||
                                            (demuxOptions.ExtractVideo && IsThisAVideoBlock(currentBlockId)))
                                        {
                                            // reset stream id
                                            streamId = 0;

                                            // if audio block, get the stream number from the queue                                                                                
                                            if (isAudioBlock && UsesSameIdForMultipleAudioTracks)
                                            {
                                                streamId = GetStreamId(fs, currentOffset);
                                                currentStreamKey = (streamId | currentBlockIdVal);
                                            }
                                            else
                                            {
                                                currentStreamKey = currentBlockIdVal;
                                            }

                                            // check if we've already started parsing this stream
                                            if (!files.ContainsKey(currentStreamKey))
                                            {
                                                // convert block id to little endian for naming
                                                currentBlockIdNaming = BitConverter.GetBytes(currentStreamKey);
                                                Array.Reverse(currentBlockIdNaming);

                                                // build output file name
                                                outputFileName = Path.GetFileNameWithoutExtension(FilePath);
                                                outputFileName = outputFileName + "_" + BitConverter.ToUInt32(currentBlockIdNaming, 0).ToString("X8");

                                                // add proper extension
                                                if (IsThisAnAudioBlock(currentBlockId))
                                                {
                                                    audioFileExtension = GetAudioFileExtension(fs, currentOffset);
                                                    outputFileName += audioFileExtension;

                                                    if (!StreamIdFileType.ContainsKey(streamId))
                                                    {
                                                        StreamIdFileType.Add(streamId, audioFileExtension);
                                                    }
                                                }
                                                else
                                                {
                                                    FileExtensionVideo = GetVideoFileExtension(fs, currentOffset);
                                                    outputFileName += FileExtensionVideo;
                                                }

                                                filenametable[currentStreamKey] = Path.Combine(Path.GetDirectoryName(FilePath), outputFileName);
                                                files[currentStreamKey] = new byte[0];
                                            }

                                            // write the block
                                            if (IsThisAnAudioBlock(currentBlockId))
                                            {
                                                // write audio
                                                audioBlockSkipSize = GetAudioPacketHeaderSize(fs, currentOffset) + GetAudioPacketSubHeaderSize(fs, currentOffset, streamId);
                                                audioBlockFooterSize = GetAudioPacketFooterSize(fs, currentOffset);
                                                cutSize = (int)(blockSize - audioBlockSkipSize - audioBlockFooterSize);
                                                if (cutSize > 0)
                                                {
                                                    var audioarray = ParseFile.ParseSimpleOffset(fs,
                                                        currentOffset + currentBlockId.Length +
                                                        blockSizeArray.Length + audioBlockSkipSize,
                                                        (int) (blockSize - audioBlockSkipSize));
                                                    files[currentStreamKey] =
                                                        files[currentStreamKey].Concat(audioarray.Take(cutSize)).ToArray();
                                                }
                                            }
                                            else
                                            {
                                                // write video
                                                videoBlockSkipSize = GetVideoPacketHeaderSize(fs, currentOffset);
                                                videoBlockFooterSize = GetVideoPacketFooterSize(fs, currentOffset);
                                                cutSize = (int)(blockSize - videoBlockSkipSize - videoBlockFooterSize);
                                                if (cutSize > 0)
                                                {
                                                    var videoarray = ParseFile.ParseSimpleOffset(fs,
                                                        currentOffset + currentBlockId.Length +
                                                        blockSizeArray.Length + videoBlockSkipSize,
                                                        (int) (blockSize - videoBlockSkipSize));
                                                    files[currentStreamKey] =
                                                        files[currentStreamKey].Concat(videoarray.Take(cutSize)).ToArray();
                                                }
                                            }
                                        }

                                        // move to next block
                                        currentOffset += currentBlockId.Length + blockSizeArray.Length + blockSize;
                                        blockSizeArray = new byte[] { };
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else // this is an undexpected block type
                            {
                                Array.Reverse(currentBlockId);
                                throw new FormatException(String.Format("Block ID at 0x{0} not found in table: 0x{1}", currentOffset.ToString("X8"), BitConverter.ToUInt32(currentBlockId, 0).ToString("X8")));
                            }

                            // exit loop if EOF block found
                            if (eofFlagFound)
                            {
                                break;
                            }
                        }
                        catch (Exception _ex)
                        {
                            throw new Exception(String.Format("Error parsing file at offset {0), '{1}'", currentOffset.ToString("X8"), _ex.Message), _ex);
                        }
                    } // while (currentOffset < fileSize)
                }
                else
                {
                    throw new FormatException(String.Format("Cannot find Pack Header for file: {0}{1}", Path.GetFileName(FilePath), Environment.NewLine));
                }

                ///////////////////////////////////
                // Perform any final tasks needed
                ///////////////////////////////////

                //////////////////////////
                // close all open writers
                //////////////////////////;

            } // using (FileStream fs = File.OpenRead(path))
            files = DoFinalTasks(FilePath, files, filenametable, true);
            return files.ToDictionary(file => filenametable[file.Key], file => file.Value);
        }

        private Dictionary<uint, byte[]> DoFinalTasks(string file, Dictionary<uint, byte[]> outputFiles, Dictionary<uint, string> filenamemap, bool addHeader)
        {
            long headerEndOffset;
            long metadataEndOffset;
            long headerSize;

            long footerOffset;
            long footerSize;

            string sourceFileName;
            string workingFile;
            string fileExtension;
            string destinationFileName;

            foreach (uint streamId in outputFiles.Keys)
            {

                sourceFileName = filenamemap.First(x => x.Key == streamId).Value;

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
                if (IsThisAnAudioBlock(BitConverter.GetBytes(streamId & 0xFFFFFFF0))) // may need to change mask if more than 0xF streams
                {
                    byte[] checkBytes = ParseFile.ParseSimpleOffset(outputFiles[streamId], (int)headerSize, 4);

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


                workingFile = FileUtil.RemoveChunkFromFile(sourceFileName, 0, headerSize);
                File.Copy(workingFile, sourceFileName, true);
                File.Delete(workingFile);

                workingFile = FileUtil.RemoveChunkFromFile(sourceFileName, footerOffset, footerSize);
                destinationFileName = Path.ChangeExtension(sourceFileName, fileExtension);
                File.Copy(workingFile, destinationFileName, true);
                File.Delete(workingFile);

                if ((sourceFileName != destinationFileName) && (File.Exists(sourceFileName)))
                {
                    File.Delete(sourceFileName);
                }
            }
            return outputFiles; //TODO: properly do this
        }

        public static int GetMpegStreamType(string path)
        {
            int mpegType = -1;

            using (FileStream fs = File.OpenRead(path))
            {
                // look for first packet
                long currentOffset = ParseFile.GetNextOffset(fs, 0, PacketStartBytes);

                if (currentOffset != -1)
                {
                    currentOffset += 4;
                    fs.Position = currentOffset;
                    byte idByte = (byte)fs.ReadByte();

                    if (ByteConversion.GetHighNibble(idByte) == 2)
                    {
                        mpegType = 1;
                    }
                    else if (ByteConversion.GetHighNibble(idByte) == 4)
                    {
                        mpegType = 2;
                    }
                }
                else
                {
                    throw new FormatException(String.Format("Cannot find Pack Header for file: {0}{1}", Path.GetFileName(path), Environment.NewLine));
                }
            }

            return mpegType;
        }
    }
}
