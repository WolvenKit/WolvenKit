using System;
using System.Buffers;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.IO.Compression;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using Catel;
using Catel.IoC;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.Common.Services
{
    public class HashService : IHashService
    {
        public Dictionary<ulong, string> Hashdict { get; set; } = new();

        private const string HashZipName = "WolvenKit.Common.Resources.archivehashes.zip";
        private const string HashFileName = "archivehashes.txt";

        public void ReloadLocally()
        {
            var logger = ServiceLocator.Default.ResolveType<ILoggerService>();
            logger.LogString("Loading local filename hashes...", Logtype.Important);

            Stopwatch watch = new();
            watch.Restart();
            
            Hashdict.EnsureCapacity(1_500_000);

            var assembly = Assembly.GetExecutingAssembly();
            
            using (var stream = assembly.GetManifestResourceStream(HashZipName))
            {
                var archive = new ZipArchive(stream);
                var zipArchiveEntry = archive.GetEntry(HashFileName);
                if (zipArchiveEntry != null)
                {
                    using var zipstream = zipArchiveEntry.Open();
                    AddHashesFromStream(Hashdict, zipstream);
                }
            }

            watch.Stop();

            logger.LogString($"Loaded {Hashdict.Count.ToString()} hashes in {watch.ElapsedMilliseconds.ToString()}ms.", Logtype.Success);
        }

        private static void AddHashesFromStream(IDictionary<ulong, string> dictionary, Stream stream)
        {
            string line;
            using var sr = new StreamReader(stream, Encoding.UTF8);
            while ((line = sr.ReadLine()) != null)
            {
                dictionary[FNV1A64HashAlgorithm.HashString(line)] = line;
            }
        }
    }
}