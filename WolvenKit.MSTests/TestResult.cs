using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;
using WolvenKit.RED4.CR2W.Archive;

namespace CP77.MSTests
{
    public class ReadTestResult : TestResult
    {
        #region Enums

        [Flags]
        public enum ReadResultType
        {
            NoError,
            NoCr2W,
            UnsupportedVersion,
            RuntimeException,
            HasAdditionalBytes,
            HasUnknownBytes,
        }

        #endregion Enums

        #region Properties

        public int AdditionalBytes { get; init; }
        public FileEntry FileEntry { get; init; }

        public ReadResultType ReadResult { get; init; }

        public int UnknownBytes { get; init; }
        public List<string> UnknownTypes { get; init; }

        #endregion Properties
    }

    public abstract class TestResult
    {
        #region Properties

        public Type ExceptionType { get; init; }
        public string Message { get; init; }
        public bool Success { get; init; }

        #endregion Properties
    }

    public class WriteTestResult : TestResult
    {
        #region Enums

        [Flags]
        public enum WriteResultType
        {
            NoError,
            NoCr2W,
            UnsupportedVersion,
            RuntimeException,

            //HasIncorrectStringTable,
            IsNotBinaryEqual
        }

        #endregion Enums

        #region Properties

        public FileEntry FileEntry { get; init; }

        //public bool HasIncorrectStringTable { get; set; }
        public bool IsNotBinaryEqual { get; init; }

        public WriteResultType WriteResult { get; init; }

        #endregion Properties
    }

    public class ArchiveTestResult : TestResult
    {
        public string ArchiveName { get; init; }
        public string Hash { get; init; }
    }
}
