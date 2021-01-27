using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Catel.IoC;
using CP77.CR2W;
using CP77.CR2W.Archive;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Services;

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
                var (fileBytes, _) = ar.GetFileData(fileEntry.NameHash64, false);

                using var ms = new MemoryStream(fileBytes);
                using var br = new BinaryReader(ms);

                var c = new CR2WFile {FileName = fileEntry.NameOrHash};
                var readResult = c.Read(br);

                switch (readResult)
                {
                    case EFileReadErrorCodes.NoCr2w:
                    case EFileReadErrorCodes.UnsupportedVersion:

                        break;
                    default:
                        var hasAdditionalBytes =
                            c.additionalCr2WFileBytes != null && c.additionalCr2WFileBytes.Any();


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

                        if (!correctStringTable)
                        {

                        }

                        break;
                }
            }




            return 1;
        }




    }
}