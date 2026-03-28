using System;
using System.IO;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using WolvenKit.Core.Services;

namespace WolvenKit.UnitTests
{
    [TestClass]
    public class FilepathValidationToolsTests
    {
        #region OperatingSystem Tests

        [DataTestMethod]
        [DataRow("valid/path/file.txt", true)]
        [DataRow("valid\\path\\file.txt", true)]
        [DataRow("invalid|path.txt", false)]
        [DataRow("path/ /file.txt", false)] // trimmed check
        [DataRow("path/..../file.txt", false)] // InvalidPathTraversal
        [DataRow("path/.. /file.txt", false)] // trimmed check or traversal
        [DataRow("path/file.txt ", false)] // trimmed
        [DataRow(" path/file.txt", false)] // trimmed
        [DataRow("file...", false)] // IsOnlyDotsAndSpaces on last segment
        [DataRow("folder/...", false)] // IsOnlyDotsAndSpaces on last segment
        [DataRow("folder/valid.txt", true)]
        public void IsOsFilePathValid_Tests(string path, bool expected)
        {
            Assert.AreEqual(expected, FilepathValidationTools.IsOsFilePathValid(path), $"Path: {path}");
        }

        [DataTestMethod]
        [DataRow("file.txt", true)]
        [DataRow("file|txt", false)]
        [DataRow("folder/file.txt", false)]
        [DataRow("...", false)]
        public void IsOsFileNameValid_Tests(string name, bool expected)
        {
            Assert.AreEqual(expected, FilepathValidationTools.IsOsFileNameValid(name), $"Name: {name}");
        }

        [DataTestMethod]
        [DataRow("valid/path/file.txt", "valid\\path\\file.txt")]
        [DataRow("invalid|path.txt", "invalidpath.txt", "")]
        [DataRow("invalid|path.txt", "invalid_path.txt", "_")]
        [DataRow("path/   /file.txt", "path\\file.txt")] // empty segment removed
        [DataRow("path/..../file.txt", "path\\file.txt")] // traversal replaced by replacement (empty) -> empty segment removed
        [DataRow("folder/...", "folder")] // last segment traversal/dots removed
        public void SanitizeOsFilePath_Tests(string path, string expected, string replacement = "")
        {
            // Note: the implementation of SanitizeOsFilePath uses Path.DirectorySeparatorChar
            // On Windows it's '\'
            var result = FilepathValidationTools.SanitizeOsFilePath(path, replacement);
            Assert.AreEqual(expected.Replace('\\', Path.DirectorySeparatorChar), result, $"Path: {path}");
        }

        [DataTestMethod]
        [DataRow("folder/file.txt", "file.txt")]
        [DataRow("file|txt", "filetxt", "")]
        [DataRow("file|txt", "file_txt", "_")]
        public void SanitizeOsFileName_Tests(string name, string expected, string replacement = "")
        {
            Assert.AreEqual(expected, FilepathValidationTools.SanitizeOsFileName(name, replacement), $"Name: {name}");
        }

        #endregion

        #region Archive Tests

        [DataTestMethod]
        [DataRow("valid/path/file.txt", true)]
        [DataRow("VALID/PATH/FILE.TXT", false)] // only lowercase
        [DataRow("path with space/file.txt", false)] // only ValidArchiveCharacters
        [DataRow("path/../file.txt", false)] // traversal
        [DataRow("path/file-123_test.bin", true)]
        public void IsArchiveFilePathValid_Tests(string path, bool expected)
        {
            Assert.AreEqual(expected, FilepathValidationTools.IsArchiveFilePathValid(path), $"Path: {path}");
        }

        [DataTestMethod]
        [DataRow("file.txt", true)]
        [DataRow("FILE.TXT", false)]
        [DataRow("file name.txt", false)]
        public void IsArchiveFileNameValid_Tests(string name, bool expected)
        {
            Assert.AreEqual(expected, FilepathValidationTools.IsArchiveFileNameValid(name), $"Name: {name}");
        }

        [DataTestMethod]
        [DataRow("Valid/Path With Space/File.txt", "valid\\path_with_space\\file.txt")]
        [DataRow("invalid|char.txt", "invalidchar.txt")]
        [DataRow("path/../file.txt", "path\\file.txt")]
        public void SanitizeArchiveFilePath_Tests(string path, string expected)
        {
            var result = FilepathValidationTools.SanitizeArchiveFilePath(path);
            Assert.AreEqual(expected.Replace('\\', Path.DirectorySeparatorChar), result, $"Path: {path}");
        }

        [DataTestMethod]
        [DataRow("Folder/File Name.txt", "file_name.txt")]
        public void SanitizeArchiveFileName_Tests(string name, string expected)
        {
            Assert.AreEqual(expected, FilepathValidationTools.SanitizeArchiveFileName(name), $"Name: {name}");
        }

        #endregion
    }
}
