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
            var bm = new ArchiveManager(gameArchiveDir);

            if (path != null)
                foreach (var s in path)
                {
                    var hash = FNV1A64HashAlgorithm.HashString(s);

                    if (!hashService.Hashdict.ContainsKey(hash))
                        continue;

                    var file = bm.Files[hash];

                    foreach (var fileEntry in file)
                        VerifyFile(fileEntry);
                }

            if (hashes != null)
                foreach (var hash in hashes)
                {
                    if (!hashService.Hashdict.ContainsKey(hash))
                        continue;

                    var file = bm.Files[hash];

                    foreach (var fileEntry in file)
                        VerifyFile(fileEntry);
                }


            void VerifyFile(FileEntry fileEntry)
            {

                if (fileEntry.Archive is not Archive ar)
                    return;
                using var ms = new MemoryStream();
                ar.CopyFileToStream(ms, fileEntry.NameHash64, false);

                var c = new CR2WFile { FileName = fileEntry.NameOrHash };
                ms.Seek(0, SeekOrigin.Begin);
                var readResult = c.Read(ms);
                var originalbytes = StreamExtensions.ToByteArray(ms);

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
                                compstr += oldst[i];
                            compstr += ",";
                            if (i < newst.Count)
                                compstr += newst[i];
                            compstr += "\n";

                            if (str1 != str2)
                                correctStringTable = false;
                        }

                        // Binary Equal Test
                        var isBinaryEqual = true;

                        using (var wms = new MemoryStream())
                        using (var bw = new BinaryWriter(wms))
                        {
                            c.Write(bw);

                            var newbytes = StreamExtensions.ToByteArray(wms);
                            isBinaryEqual = originalbytes.SequenceEqual(newbytes);


                        }


                        var msg = "";
                        if (!correctStringTable)
                        {
                            Debugger.Break();
                        }

                        if (!isBinaryEqual)
                        {
                            Debugger.Break();
                        }

                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
            }




            return 1;
        }




    }
}