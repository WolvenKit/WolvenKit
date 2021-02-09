using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CP77.CR2W.Archive;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CP77.MSTests
{
    public abstract class TestResult
    {
        public bool Success { get; set; }
        public Type ExceptionType { get; set; }
        public string Message { get; set; }
    }



    public class ReadTestResult : TestResult
    {
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

        public FileEntry FileEntry { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public ReadResultType ReadResult { get; set; }
        public int AdditionalBytes { get; set; }
        public int UnknownBytes { get; set; }
        public List<string> UnknownTypes { get; set; }
        
    }

    public class WriteTestResult : TestResult
    {
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

        public FileEntry FileEntry { get; set; }

        [JsonConverter(typeof(StringEnumConverter))]
        public WriteResultType WriteResult { get; set; }
        //public bool HasIncorrectStringTable { get; set; }
        public bool IsNotBinaryEqual { get; set; }

    }
}
