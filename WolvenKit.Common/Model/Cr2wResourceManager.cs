using CsvHelper;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using WolvenKit.Common.FNV1A;
using WolvenKit.Common.Model;

namespace WolvenKit.Common.Model
{
    public class Cr2wResourceManager
    {
        private static Cr2wResourceManager resourceManager;
        public Dictionary<string, ulong> HashdumpDict { get; }
        public Dictionary<string, ulong> CHashdumpDict { get; }

        public static readonly string pathashespath =
            Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "ManagerCache",
                "pathhashes.csv");

        private static readonly string custompathashespath =
            Path.Combine(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), "ManagerCache",
                "custompathhashes.csv");


        public static Cr2wResourceManager Get()
        {
            if (resourceManager == null)
            {
                resourceManager = new Cr2wResourceManager();
            }
            return resourceManager;
        }

        public Cr2wResourceManager()
        {
            HashdumpDict = new Dictionary<string, ulong>();
            CHashdumpDict = new Dictionary<string, ulong>();

            if (File.Exists(pathashespath))
            {
                StreamReader reader = null;
                try
                {
                    reader = File.OpenText(pathashespath);
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        HashdumpDict = csv.GetRecords<HashDump>().ToDictionary(_ => _.Path, _ => _.HashInt);
                        reader = null;
                    }
                }
                finally
                {
                    reader?.Dispose();
                }
            }

            if (File.Exists(custompathashespath))
            {
                StreamReader reader = null;
                try
                {
                    reader = File.OpenText(custompathashespath);
                    using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
                    {
                        CHashdumpDict = csv.GetRecords<HashDump>().ToDictionary(_ => _.Path, _ => _.HashInt);
                        reader = null;
                    }
                }
                finally
                {
                    reader?.Dispose();
                }
            }
        }

        public void RegisterAndWriteVanillaPaths(List<string> paths)
        {
            foreach (var path in paths)
            {
                RegisterVanillaPath(path);
            }
            Write();
        }
        public ulong RegisterVanillaPath(string path)
        {
            var hashint = FNV1A64HashAlgorithm.HashString(path);
            if (!HashdumpDict.ContainsKey(path))
                HashdumpDict.Add(path, hashint);
            return hashint;
        }

        public ulong RegisterAndWriteCustomPath(string path)
        {
            var hash = RegisterCustomPath(path);
            Write();
            return hash;
        }
        public void RegisterAndWriteCustomPaths(List<string> paths)
        {
            foreach (var path in paths)
            {
                RegisterCustomPath(path);
            }
            Write();
        }
        public ulong RegisterCustomPath(string path)
        {
            var hashint = FNV1A64HashAlgorithm.HashString(path);
            if (!CHashdumpDict.ContainsKey(path) && !HashdumpDict.ContainsKey(path))
                CHashdumpDict.Add(path, hashint);
            return hashint;
        }

        public void Write()
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(custompathashespath);
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    writer = null;
                    csv.WriteRecords(CHashdumpDict.Select(_ => new HashDump { Path = _.Key, HashInt = _.Value }));
                }
            }
            finally
            {
                writer?.Dispose();
            }
        }
        public void WriteVanilla()
        {
            StreamWriter writer = null;
            try
            {
                writer = new StreamWriter(pathashespath);
                using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
                {
                    writer = null;
                    csv.WriteRecords(HashdumpDict.Select(_ => new HashDump { Path = _.Key, HashInt = _.Value }));
                }
            }
            finally
            {
                writer?.Dispose();
            }
        }

    }
}
