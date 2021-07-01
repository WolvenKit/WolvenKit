using System;
using System.IO;
using System.Linq;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common;
using WolvenKit.Core;
using WolvenKit.Interfaces.Extensions;

namespace CP77Tools.Tasks
{
    public partial class ConsoleFunctions
    {
        #region Methods

        public int VerifyTask(string[] path, ulong[] hashes)
        {
            var CP77_DIR = System.Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
            var gameDirectory = new DirectoryInfo(CP77_DIR);
            var gameArchiveDir = Path.Combine(gameDirectory.FullName, "archive", "pc", "content");
            var exe = new FileInfo(Path.Combine(gameArchiveDir, Constants.Red4Exe));

            if (path != null)
            {
                foreach (var s in path)
                {
                    if (!File.Exists(s))
                    {
                        continue;
                    }

                    using var fs = new FileStream(s, FileMode.Open, FileAccess.Read);
                    if (VerifyFile(fs, s))
                    {
                        _loggerService.Success($"{s} - No problems found.");
                    }
                    else
                    {
                        _loggerService.Error($"{s} - Verification failed, files not binary equal.");
                    }
                }
            }

            if (hashes != null)
            {
                var bm =  new ArchiveManager(_hashService);
                bm.LoadAll(exe, false);
                foreach (var hash in hashes)
                {
                    if (!_hashService.Contains(hash))
                    {
                        continue;
                    }

                    var file = bm.Items[hash];

                    foreach (var ifileEntry in file)
                    {
                        var fileEntry = ifileEntry as FileEntry;
                        var ar = bm.Archives[fileEntry.Archive.ArchiveAbsolutePath] as Archive;

                        using var ms = new MemoryStream();
                        ar.CopyFileToStream(ms, fileEntry.NameHash64, false);
                        if (VerifyFile(ms))
                        {
                            _loggerService.Success($"{fileEntry.NameOrHash} - No errors found.");
                        }
                        else
                        {
                            _loggerService.Error($"{fileEntry.NameOrHash} - Verification failed, files not binary equal.");
                        }
                    }
                }
            }

            static bool VerifyFile(Stream ms, string infilepath = "")
            {
                var c = new CR2WFile();// { FileName = fileEntry.NameOrHash };
                var originalbytes = ms.ToByteArray();
                ms.Seek(0, SeekOrigin.Begin);
                var readResult = c.Read(ms);

                switch (readResult)
                {
                    case EFileReadErrorCodes.NoCr2w:
                    case EFileReadErrorCodes.UnsupportedVersion:
                        break;

                    case EFileReadErrorCodes.NoError:
                        var hasAdditionalBytes =
                            c.AdditionalCr2WFileBytes != null && c.AdditionalCr2WFileBytes.Any();

                        var oldst = c.StringDictionary.Values.ToList();
                        var newst = Cr2wHelpers.GenerateStringtable(c).Item1.Values.ToList();
                        var compstr = "OLD,NEW";
                        var correctStringTable = oldst.Count == newst.Count;

                        // Stringtable test
                        for (int i = 0; i < Math.Max(oldst.Count, newst.Count); i++)
                        {
                            string str1 = "";
                            string str2 = "";
                            if (i < oldst.Count)
                            {
                                compstr += oldst[i];
                            }

                            compstr += ",";
                            if (i < newst.Count)
                            {
                                compstr += newst[i];
                            }

                            compstr += "\n";

                            if (str1 != str2)
                            {
                                correctStringTable = false;
                            }
                        }

                        // Binary Equal Test
                        var isBinaryEqual = true;

                        using (var wms = new MemoryStream())
                        using (var bw = new BinaryWriter(wms))
                        {
                            c.Write(bw);

                            var newbytes = StreamExtensions.ToByteArray(wms);
                            isBinaryEqual = originalbytes.SequenceEqual(newbytes);

                            if (!isBinaryEqual && !string.IsNullOrEmpty(infilepath))
                            {
                                File.WriteAllBytes($"{infilepath}.n.bin", newbytes);
                                return false;
                            }
                        }

                        if (!correctStringTable)
                        {
                            return false;
                        }

                        return true;

                    default:
                        throw new ArgumentOutOfRangeException();
                }

                return false;
            }

            return 1;
        }

        #endregion Methods
    }
}
