using System;
using System.Collections.Generic;
using CP77.CR2W.Archive;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

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

        public int AdditionalBytes { get; set; }
        public FileEntry FileEntry { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ReadResultType ReadResult { get; set; }

        public int UnknownBytes { get; set; }
        public List<string> UnknownTypes { get; set; }

        #endregion Properties
    }

    public abstract class TestResult
    {
        #region Properties

        public Type ExceptionType { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }

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

        public FileEntry FileEntry { get; set; }

        //public bool HasIncorrectStringTable { get; set; }
        public bool IsNotBinaryEqual { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public WriteResultType WriteResult { get; set; }

        #endregion Properties
    }
}
