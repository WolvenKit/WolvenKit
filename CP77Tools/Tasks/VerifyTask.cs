using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.CR2W;
using CP77.CR2W.Archive;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;
using StreamExtensions = Catel.IO.StreamExtensions;

namespace CP77Tools.Tasks
{

    public static partial class ConsoleFunctions
    {

        public static int VerifyTask(string[] path, ulong[] hashes)
        {

            var hashService = ServiceLocator.Default.ResolveType<IHashService>();
            var CP77_DIR = System.Environment.GetEnvironmentVariable("CP77_DIR", EnvironmentVariableTarget.User);
            var gameDirectory = new DirectoryInfo(CP77_DIR);
            var gameArchiveDir = new DirectoryInfo(Path.Combine(gameDirectory.FullName, "archive", "pc", "content"));

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
                        logger.LogString($"{s} - No problems found.", Logtype.Success);
                    }
                    else
                    {
                        logger.LogString($"{s} - Verification failed, files not binary equal.", Logtype.Error);
                    }
                }
            }

            if (hashes != null)
            {
                var bm = new ArchiveManager(gameArchiveDir);
                foreach (var hash in hashes)
                {
                    if (!hashService.Contains(hash))
                    {
                        continue;
                    }

                    var file = bm.Files[hash];

                    foreach (var fileEntry in file)
                    {
                        if (fileEntry.Archive is not Archive ar)
                        {
                            continue;
                        }

                        using var ms = new MemoryStream();
                        ar.CopyFileToStream(ms, fileEntry.NameHash64, false);
                        if (VerifyFile(ms))
                        {
                            logger.LogString($"{fileEntry.NameOrHash} - No errors found.", Logtype.Success);
                        }
                        else
                        {
                            logger.LogString($"{fileEntry.NameOrHash} - Verification failed, files not binary equal.", Logtype.Error);
                        }
                    }
                }
            }


            static bool VerifyFile(Stream ms, string infilepath = "")
            {
                var c = new CR2WFile();// { FileName = fileEntry.NameOrHash };
                var originalbytes = StreamExtensions.ToByteArray(ms);
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
                        var newst = c.GenerateStringtable().Item1.Values.ToList();
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




    }
}
