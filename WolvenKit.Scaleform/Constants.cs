using System;

namespace WolvenKit.Scaleform
{
    public enum VfsFileRecordRelativeOffsetLocationType
    {
        FileRecordStart,
        FileRecordEnd
    }

    /// <summary>
    /// Struct containing criteria used to find offsets.
    /// </summary>
    public struct FindOffsetStruct
    {
        #region Fields

        private bool cutFile;
        private string cutSize;
        private string cutSizeOffsetSize;
        private string extraCutSizeBytes;
        private bool includeTerminatorLength;
        private bool isCutSizeAnOffset;
        private bool isLittleEndian;
        private string outputFileExtension;
        private string searchString;
        private string searchStringOffset;
        private string startingOffset;
        private string terminatorString;
        private bool treatSearchStringAsHex;
        private bool treatTerminatorStringAsHex;
        private bool useTerminatorForCutSize;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets flag to cut the file when the offset is found.
        /// </summary>
        public bool CutFile
        {
            get { return cutFile; }
            set { cutFile = value; }
        }

        /// <summary>
        /// Gets or sets size to cut from file
        /// </summary>
        public string CutSize
        {
            get { return cutSize; }
            set { cutSize = value; }
        }

        /// <summary>
        /// Gets or sets size of offset holding cut size
        /// </summary>
        public string CutSizeOffsetSize
        {
            get { return cutSizeOffsetSize; }
            set { cutSizeOffsetSize = value; }
        }

        public bool CutToEofIfTerminatorNotFound { set; get; }

        public bool DoSearchStringModulo
        {
            set;
            get;
        }

        public bool DoTerminatorModulo
        {
            set;
            get;
        }

        /// <summary>
        /// Gets or sets additional bytes to include in the cut size.
        /// </summary>
        public string ExtraCutSizeBytes
        {
            get { return extraCutSizeBytes; }
            set { extraCutSizeBytes = value; }
        }

        /// <summary>
        /// Gets or sets flag indicating that the length of the terminator should be included in the cut size.
        /// </summary>
        public bool IncludeTerminatorLength
        {
            get { return includeTerminatorLength; }
            set { includeTerminatorLength = value; }
        }

        /// <summary>
        /// Gets or sets flag indicating that cut size is an offset.
        /// </summary>
        public bool IsCutSizeAnOffset
        {
            get { return isCutSizeAnOffset; }
            set { isCutSizeAnOffset = value; }
        }

        /// <summary>
        /// Gets or sets flag indicating that offset based cut size is stored in Little Endian byte order.
        /// </summary>
        public bool IsLittleEndian
        {
            get { return isLittleEndian; }
            set { isLittleEndian = value; }
        }

        public string LengthMultiplier { set; get; }

        public string MinimumSize
        {
            set;
            get;
        }

        /// <summary>
        /// Gets or sets file extension to use for cut files.
        /// </summary>
        public string OutputFileExtension
        {
            get { return outputFileExtension; }
            set { outputFileExtension = value; }
        }

        public string OutputFolder { get; set; }

        public string SearchString
        {
            get { return searchString; }
            set { searchString = value; }
        }

        public string SearchStringModuloDivisor
        {
            set;
            get;
        }

        public string SearchStringModuloResult
        {
            set;
            get;
        }

        /// <summary>
        /// Gets or sets offset within destination file Search String would reside.
        /// </summary>
        public string SearchStringOffset
        {
            get { return searchStringOffset; }
            set { searchStringOffset = value; }
        }

        /// <summary>
        /// Gets or sets offset to being searching at
        /// </summary>
        public string StartingOffset
        {
            set { startingOffset = value; }
            get { return startingOffset; }
        }

        /// <summary>
        /// Gets or sets terminator string to search for.
        /// </summary>
        public string TerminatorString
        {
            get { return terminatorString; }
            set { terminatorString = value; }
        }

        public string TerminatorStringModuloDivisor
        {
            set;
            get;
        }

        public string TerminatorStringModuloResult
        {
            set;
            get;
        }

        /// <summary>
        /// Gets or sets flag to indicate search string is a hex value.
        /// </summary>
        public bool TreatSearchStringAsHex
        {
            get { return treatSearchStringAsHex; }
            set { treatSearchStringAsHex = value; }
        }

        /// <summary>
        /// Gets or sets flag indicating that a terminator should be used to determine the cut size.
        /// </summary>

        /// <summary>
        /// Gets or sets flag indicating that Terminator String is hex.
        /// </summary>
        public bool TreatTerminatorStringAsHex
        {
            get { return treatTerminatorStringAsHex; }
            set { treatTerminatorStringAsHex = value; }
        }

        public bool UseLengthMultiplier { set; get; }

        public bool UseTerminatorForCutSize
        {
            get { return useTerminatorForCutSize; }
            set { useTerminatorForCutSize = value; }
        }

        #endregion Properties
    }

    /// <summary>
    /// Struct used to send messages conveying progress.
    /// </summary>
    //public struct ProgressStruct
    //{
    //    /// <summary>
    //    /// File name to display in progress bar.
    //    /// </summary>
    //    private string fileName;

    //    /// <summary>
    //    /// Error message to display in output window.
    //    /// </summary>
    //    private string errorMessage;

    //    /// <summary>
    //    /// Generic message to display in output window.
    //    /// </summary>
    //    private string genericMessage;

    //    /// <summary>
    //    /// New tree node to add to a TreeView.
    //    /// </summary>
    //    private TreeNode newNode;

    //    /// <summary>
    //    /// Gets or sets fileName.
    //    /// </summary>
    //    public string FileName
    //    {
    //        get { return fileName; }
    //        set { fileName = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets errorMessage.
    //    /// </summary>
    //    public string ErrorMessage
    //    {
    //        get { return errorMessage; }
    //        set { errorMessage = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets genericMessage.
    //    /// </summary>
    //    public string GenericMessage
    //    {
    //        get { return genericMessage; }
    //        set { genericMessage = value; }
    //    }

    //    /// <summary>
    //    /// Gets or sets newNode.
    //    /// </summary>
    //    public TreeNode NewNode
    //    {
    //        get { return newNode; }
    //        set { newNode = value; }
    //    }

    //    /// <summary>
    //    /// Reset this node's values
    //    /// </summary>
    //    public void Clear()
    //    {
    //        fileName = String.Empty;
    //        errorMessage = String.Empty;
    //        genericMessage = String.Empty;
    //        newNode = null;
    //    }
    //}

    /// <summary>
    /// Struct used to allow TreeView to select a specific form and modify the originating node upon completion of a task.
    /// </summary>
    public struct NodeTagStruct
    {
        #region Fields

        /// <summary>
        /// File path of the file this node represents.
        /// </summary>
        private string filePath;

        /// <summary>
        /// Class name of the Form this node will bring to focus.
        /// </summary>
        private string formClass;

        /// <summary>
        /// Object type this node represents.
        /// </summary>
        private string objectType;

        #endregion Fields

        #region Properties

        /// <summary>
        /// Gets or sets filePath
        /// </summary>
        public string FilePath
        {
            get { return filePath; }
            set { filePath = value; }
        }

        /// <summary>
        /// Gets or sets formClass
        /// </summary>
        public string FormClass
        {
            get { return formClass; }
            set { formClass = value; }
        }

        /// <summary>
        /// Gets or sets objectType
        /// </summary>
        public string ObjectType
        {
            get { return objectType; }
            set { objectType = value; }
        }

        #endregion Properties
    }

    public struct SimpleFileExtractionStruct
    {
        #region Properties

        public long FileLength { set; get; }
        public long FileNameLength { set; get; }
        public long FileOffset { set; get; }
        public string FilePath { set; get; }

        #endregion Properties

        #region Methods

        public void Clear()
        {
            this.FilePath = String.Empty;
            this.FileOffset = -1;
            this.FileLength = -1;
            this.FileNameLength = -1;
        }

        #endregion Methods
    }

    public struct VfsExtractionStruct
    {
        #region Properties

        public OffsetDescription AbsoluteFileNameOffsetDescription { set; get; }

        public string BeginCuttingFilesAtOffset { set; get; }

        public string ByteAlignmentValue { set; get; }

        public OffsetDescription FileCountOffsetDescription { set; get; }

        public CalculatingOffsetDescription FileLengthOffsetDescription { set; get; }

        // file name
        public bool FileNameIsPresent { set; get; }

        public string FileNameTerminatorString { set; get; }

        public CalculatingOffsetDescription FileOffsetOffsetDescription { set; get; }

        public VfsFileRecordRelativeOffsetLocationType FileRecordNameRelativeOffsetLocation { set; get; }

        public string FileRecordSize { set; get; }

        // file record basic information
        public string FileRecordsStartOffset { set; get; }

        public OffsetDescription HeaderSizeOffsetDescription { set; get; }

        public bool ReadHeaderToEof { set; get; }

        public OffsetDescription RelativeFileNameOffsetDescription { set; get; }

        public string StaticFileCount { set; get; }

        public string StaticFileNameLength { set; get; }

        public string StaticFileNameOffsetWithinRecord { set; get; }

        public string StaticHeaderSize { set; get; }

        public bool UseAbsoluteFileNameOffset { set; get; }

        public bool UseByteAlignmentValue { set; get; }

        public bool UseFileCountOffset { set; get; }

        // file length/size
        public bool UseFileLengthOffset { set; get; }

        public bool UseFileNameTerminatorString { set; get; }

        // file offset
        public bool UseFileOffsetOffset { set; get; }

        public bool UseHeaderSizeOffset { set; get; }

        public bool UseLocationOfNextFileToDetermineLength { set; get; }

        public bool UsePreviousFilesSizeToDetermineOffset { set; get; }

        public bool UseRelativeFileNameOffset { set; get; }

        // file count
        public bool UseStaticFileCount { set; get; }

        // name size
        public bool UseStaticFileNameLength { set; get; }

        public bool UseStaticFileNameOffsetWithinRecord { set; get; }

        // header size
        public bool UseStaticHeaderSize { set; get; }

        #endregion Properties
    }

    /// <summary>
    /// Class containing universal constants.
    /// </summary>
    public sealed class Constants
    {
        #region Fields

        /// <summary>
        /// Text description to use when describing a Big Endian option
        /// </summary>
        public const string BigEndianByteOrder = "Big Endian";

        /// <summary>
        /// Chunk size to use when reading from files.  Used to grab maximum buffer
        /// size without using the large object heap which has poor collection.
        /// </summary>
        public const int FileReadChunkSize = 71680;

        /// <summary>
        /// Constant used to send an ignore the value message to the progress bar.
        /// </summary>
        public const int IgnoreProgress = -1;

        /// <summary>
        /// Text description to use when describing a Little Endian option
        /// </summary>
        public const string LittleEndianByteOrder = "Little Endian";

        /// <summary>
        /// Constant used to send a generic message to the progress bar.
        /// </summary>
        public const int ProgressMessageOnly = -2;

        public const string StringNullTerminator = "\0";
        public static readonly byte[] NullByteArray = new byte[] { 0x00 };
        public static readonly byte[] RiffDataBytes = new byte[] { 0x64, 0x61, 0x74, 0x61 };
        public static readonly byte[] RiffFmtBytes = new byte[] { 0x66, 0x6D, 0x74, 0x20 };
        public static readonly byte[] RiffHeaderBytes = new byte[] { 0x52, 0x49, 0x46, 0x46 };
        public static readonly byte[] RiffWaveBytes = new byte[] { 0x57, 0x41, 0x56, 0x45 };

        #endregion Fields

        #region Constructors

        // empty constructor
        private Constants() { }

        #endregion Constructors
    }
}
