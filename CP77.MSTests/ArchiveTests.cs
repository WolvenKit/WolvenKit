using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Catel.IoC;
using WolvenKit.Common.Services;
using CP77.CR2W;
using CP77.CR2W.Archive;
using Microsoft.Extensions.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using WolvenKit.Common;

namespace CP77.MSTests
{
    [TestClass]
    public class ArchiveTests : GameUnitTest
    {
        [TestMethod]
        public void Test_Unbundle()
        {
            
        }

        [TestMethod]
        public void Test_Uncook()
        {
            
        }


        private void test_archive(string extension = null)
        {
            var resultDir = Path.Combine(Environment.CurrentDirectory, TestResultsDirectory);
            Directory.CreateDirectory(resultDir);

            var success = true;

            List<Archive> archives;



        }
    }
}