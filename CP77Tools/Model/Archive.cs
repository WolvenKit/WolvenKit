using CP77Tools.Oodle;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using System.IO.MemoryMappedFiles;
using System.Linq;
using System.Reflection.Metadata;
using System.Runtime.InteropServices.ComTypes;
using System.Text;
using System.Threading.Tasks;
using ConsoleProgressBar;
using WolvenKit.Common.Extensions;

namespace CP77Tools.Model
{
    public class Archive
    {
        #region fields

        private ArHeader _header;
        private uint _filesCount;
        private ArTable _table;
        public readonly string _filepath;

        public Dictionary<ulong, int> HashDictionary { get; set; } = new Dictionary<ulong, int>();

        #endregion

        private string Mmfhash => _filepath.GetHashMD5();



        public Archive(string path)
        {
            _filepath = path;
            

            ReadTables();
        }

        #region methods

        /// <summary>
        /// 
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public ulong GetHashFromIndex(int idx) => _table.FileInfo[idx].NameHash64;


        /// <summary>
        /// Reads the tables info to the archive.
        /// </summary>
        private void ReadTables()
        {
            using var mmf = MemoryMappedFile.CreateFromFile(_filepath, FileMode.Open, Mmfhash, 0,
                MemoryMappedFileAccess.Read);

            using (var vs = mmf.CreateViewStream(0, ArHeader.SIZE, MemoryMappedFileAccess.Read))
            {
                using var br = new BinaryReader(vs);
                _header = new ArHeader(br);
            }

            using (var vs = mmf.CreateViewStream((long)_header.Tableoffset, (long)_header.Tablesize,
                MemoryMappedFileAccess.Read))
            {
                using var br = new BinaryReader(vs);
                _table = new ArTable(br);
            }

            foreach (var (key, value) in _table.FileInfo)
            {
                HashDictionary.Add(value.NameHash64, key);
            }

            _filesCount = _table.Table1count;
        }

        /// <summary>
        /// Extracts all Files to the specified directory.
        /// </summary>
        /// <param name="outDir"></param>
        /// <returns></returns>
        public int ExtractAll(DirectoryInfo outDir)
        {
            using var pb = new ProgressBar();
            using var p1 = pb.Progress.Fork();

            int progress = 0;

            try
            {
                using var mmf = MemoryMappedFile.CreateFromFile(_filepath, FileMode.Open, Mmfhash, 0,
                    MemoryMappedFileAccess.Read);
           

                Parallel.For(0, _filesCount, new ParallelOptions { MaxDegreeOfParallelism = 8 }, i =>
                {
                    var file = GetFileData((int)i, mmf);

                    string extension = "bin";
                    

                    string outpath = Path.Combine(outDir.FullName,
                        $"{_table.FileInfo[(int)i].NameHash64:X8}.{extension}");

                    File.WriteAllBytes(outpath, file);


                    progress += 1;
                    var perc = progress / (double)_filesCount;
                    p1.Report(perc, $"Loading bundle entries: {progress}/{_filesCount}");
                });
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw;
            }

            return 1;
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public byte[] ExtractOne(ulong hash)
        {
            using var mmf = MemoryMappedFile.CreateFromFile(_filepath, FileMode.Open, Mmfhash, 0,
                MemoryMappedFileAccess.Read);


            var idx = HashDictionary[hash];
            var file = GetFileData(idx, mmf);

            return file;
        }

        /// <summary>
        /// Gets the bytes of one file by index from the archive.
        /// </summary>
        /// <param name="idx"></param>
        /// <returns></returns>
        public byte[] GetFileData(int idx, MemoryMappedFile mmf)
        {
            if (idx >= _table.FileInfo.Count) return null;

            var entry = _table.FileInfo[idx];
            var startindex = (int)entry.FirstDataSector;
            var nextindex = (int)entry.NextDataSector;

            using var ms = new MemoryStream();
            using var bw = new BinaryWriter(ms);

            for (int j = startindex; j < nextindex; j++)
            {
                var offsetentry = this._table.Offsets[j];

                using var vs = mmf.CreateViewStream((long)offsetentry.Offset, (long)offsetentry.PhysicalSize,
                    MemoryMappedFileAccess.Read);
                using var binaryReader = new BinaryReader(vs);

                if (offsetentry.PhysicalSize == offsetentry.VirtualSize)
                {
                    var buffer = binaryReader.ReadBytes((int)offsetentry.PhysicalSize);
                    bw.Write(buffer);
                }
                else
                {
                    var oodleCompression = binaryReader.ReadBytes(4);
                    if (!(oodleCompression.SequenceEqual(new byte[] { 0x4b, 0x41, 0x52, 0x4b })))
                        throw new NotImplementedException();
                    var size = binaryReader.ReadUInt32();

                    if (size != offsetentry.VirtualSize)
                        throw new NotImplementedException();

                    var buffer = binaryReader.ReadBytes((int)offsetentry.PhysicalSize - 8);

                    byte[] unpacked = new byte[offsetentry.VirtualSize];
                    long unpackedSize = OodleLZ.Decompress(buffer, unpacked);

                    if (unpackedSize != offsetentry.VirtualSize)
                        throw new Exception(string.Format("Unpacked size doesn't match real size. {0} vs {1}", unpackedSize, offsetentry.VirtualSize));
                    bw.Write(unpacked);
                }
            }

            return ms.ToArray();
        }

        /// <summary>
        /// Dump archive info.
        /// </summary>
        public void DumpInfo(DirectoryInfo outdir)
        {
            if (!outdir.Exists)
                return;
            if (string.IsNullOrEmpty(_filepath))
                return;

            var outpath = Path.Combine(outdir.FullName, $"_{Path.GetFileNameWithoutExtension(_filepath)}" ?? "_archivedump");

            // dump chache info
            using (var writer = File.CreateText($"{outpath}.info"))
            {
                writer.WriteLine($"Magic: {_header.Magic}\r\n");
                writer.WriteLine($"Version: {_header.Version}\r\n");
                writer.WriteLine($"Tableoffset: {_header.Tableoffset}\r\n");
                writer.WriteLine($"Tablesize: {_header.Tablesize}\r\n");
                writer.WriteLine($"Unk3: {_header.Unk3}\r\n");
                writer.WriteLine($"Filesize: {_header.Filesize}\r\n");
                writer.WriteLine($"Size: {_table.Size}\r\n");
                writer.WriteLine($"Checksum: {_table.Checksum}\r\n");
                writer.WriteLine($"Num: {_table.Num}\r\n");
                writer.WriteLine($"Table1count: {_table.Table1count}\r\n");
                writer.WriteLine($"Table2count: {_table.Table2count}\r\n");
                writer.WriteLine($"Table3count: {_table.Table3count}\r\n");

            }

            const string head = //"Hash\t" +
                "Hash64," +
                "Datetime," +
                "VirtualSize," +
                "PhysicalSize," +
                //"Unk1," +
                //"Unk2," +
                "Flags," +
                "StartDataSector," +
                "NextDataSector," +
                "StartUnkSector," +
                "NextUnkSector," +
                "Footer,";

            // dump and extract files
            using (var writer = File.CreateText($"{outpath}.csv"))
            {
                // write header
                writer.WriteLine(head);

                // write info elements
                foreach (var entry in _table.FileInfo)
                {
                    var x = entry.Value;
                    var idx = entry.Key;

                    int PhysicalSize = 0;
                    int VirtualSize = 0;

                    var startindex = (int)x.FirstDataSector;
                    var nextindex = (int)x.NextDataSector;

                    for (int i = startindex; i < nextindex; i++)
                    {
                        PhysicalSize += (int)_table.Offsets[i].PhysicalSize;
                        VirtualSize += (int)_table.Offsets[i].VirtualSize;
                    }

                    var offsetEntry = _table.Offsets[idx];

                    string info =
                        $"{x.NameHash64:X2}," +
                        $"{x.DateTime.ToString(CultureInfo.InvariantCulture)}," +
                        $"{VirtualSize}," +
                        $"{PhysicalSize}," +
                        //$"{x.Unk1:X2}," +
                        //$"{x.Unk2:X2}," +
                        $"{x.FileFlags}," +
                        $"{x.FirstDataSector}," +
                        $"{x.NextDataSector}," +
                        $"{x.FirstUnkIndex}," +
                        $"{x.NextUnkIndex}," +
                        $"{BitConverter.ToString(x.SHA1Hash)}";

                    writer.WriteLine(info);
                }
            }
        }

        #endregion
    }

    
}



