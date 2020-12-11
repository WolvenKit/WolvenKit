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
using Catel.IoC;
using ConsoleProgressBar;
using CP77Tools.Services;
using WolvenKit.Common.Extensions;

namespace CP77Tools.Model
{
    public class Archive
    {
        #region fields

        private ArHeader _header;
        private ArTable _table;

        private string Mmfhash => Filepath.GetHashMD5();



        #endregion

        #region constructors

        public Archive(string path)
        {
            Filepath = path;
            
            ReadTables();
        }

        #endregion

        #region properties

        public string Filepath { get; private set; }

        public Dictionary<ulong, FileInfoEntry> Files => _table?.FileInfo;
        public int FileCount => Files?.Count ?? 0;

        #endregion

        #region methods

        /// <summary>
        /// Reads the tables info to the archive.
        /// </summary>
        private void ReadTables()
        {
            using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open, Mmfhash, 0,
                MemoryMappedFileAccess.Read);

            using (var vs = mmf.CreateViewStream(0, ArHeader.SIZE, MemoryMappedFileAccess.Read))
            {
                _header = new ArHeader(new BinaryReader(vs));
            }

            using (var vs = mmf.CreateViewStream((long)_header.Tableoffset, (long)_header.Tablesize,
                MemoryMappedFileAccess.Read))
            {
                _table = new ArTable(new BinaryReader(vs));
            }
        }

        /// <summary>
        /// Extracts all Files to the specified directory.
        /// </summary>
        /// <param name="outDir"></param>
        /// <returns></returns>
        public int ExtractAll(DirectoryInfo outDir)
        {
            var _maincontroller = ServiceLocator.Default.ResolveType<IMainController>();

            using var pb = new ProgressBar();
            using var p1 = pb.Progress.Fork();

            int progress = 0;

            try
            {
                using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open, Mmfhash, 0,
                    MemoryMappedFileAccess.Read);

                Parallel.For(0, FileCount, new ParallelOptions { MaxDegreeOfParallelism = 8 }, i =>
                {
                    var info = Files.Values.ToList()[i];

                    var (file, buffers) = GetFileData(info.NameHash64, mmf);

                    var hash = info.NameHash64;
                    string name = $"{hash:X2}.bin";
                    if (_maincontroller.Hashdict.ContainsKey(hash))
                    {
                        name = _maincontroller.Hashdict[hash];
                    }
                    else
                    {
                        //Console.WriteLine($"Could not find hash {hash}");
                    }

                    string outpath = Path.Combine(outDir.FullName,
                        $"{name}");
                    var fi = new FileInfo(outpath);
                    Directory.CreateDirectory(fi.Directory.FullName);

                    // write main file
                    File.WriteAllBytes(outpath, file);
                    // write buffers
                    for (int j = 0; j < buffers.Count(); j++)
                    {
                        var buffer = buffers[j];
                        var bufferpath = $"{outpath}.{j}.buffer";
                        File.WriteAllBytes(bufferpath, buffer);
                    }

                    progress += 1;
                    var perc = progress / (double)FileCount;
                    p1.Report(perc, $"Loading bundle entries: {progress}/{FileCount}");
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
        /// Returns a file by a given hash
        /// </summary>
        /// <param name="hash"></param>
        /// <returns></returns>
        public byte[] GetFileByHash(ulong hash)
        {
            using var mmf = MemoryMappedFile.CreateFromFile(Filepath, FileMode.Open, Mmfhash, 0,
                MemoryMappedFileAccess.Read);

            var (file, buffers) = GetFileData(hash, mmf);

            return file;
        }

        /// <summary>
        /// Gets the bytes of one file by index from the archive.
        /// </summary>
        /// <param name="hash"></param>
        /// <param name="mmf"></param>
        /// <returns></returns>
        public (byte[], List<byte[]>) GetFileData(ulong hash, MemoryMappedFile mmf)
        {
            if (!Files.ContainsKey(hash)) return (null, null);

            var entry = Files[hash];
            var startindex = (int)entry.FirstDataSector;
            var nextindex = (int)entry.NextDataSector;

            var file = ExtractFile(this._table.Offsets[startindex]);
            var buffers = new List<byte[]>();

            for (int j = startindex + 1; j < nextindex; j++)
            {
                var offsetentry = this._table.Offsets[j];
                var buffer = ExtractFile(offsetentry);
                buffers.Add(buffer);
            }

            return (file, buffers);

            // local
            byte[] ExtractFile(OffsetEntry offsetentry)
            {
                using var ms = new MemoryStream();
                using var bw = new BinaryWriter(ms);
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
                        throw new Exception(
                            $"Unpacked size doesn't match real size. {unpackedSize} vs {offsetentry.VirtualSize}");
                    bw.Write(unpacked);
                }

                return ms.ToArray();
            }
        }

        /// <summary>
        /// Dump archive info to the specified directory.
        /// </summary>
        public void DumpInfo(DirectoryInfo outdir)
        {
            if (!outdir.Exists)
                return;
            if (string.IsNullOrEmpty(Filepath))
                return;

            var outpath = Path.Combine(outdir.FullName, $"_{Path.GetFileNameWithoutExtension(Filepath)}" ?? "_archivedump");

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

            const string head = "Name\t" +
                "Hash64," +
                "Datetime," +
                "VirtualSize," +
                "PhysicalSize," +
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
                foreach (var (idx, x) in _table.FileInfo)
                {
                    int physicalSize = 0;
                    int virtualSize = 0;

                    var startindex = (int)x.FirstDataSector;
                    var nextindex = (int)x.NextDataSector;

                    for (int i = startindex; i < nextindex; i++)
                    {
                        physicalSize += (int)_table.Offsets[i].PhysicalSize;
                        virtualSize += (int)_table.Offsets[i].VirtualSize;
                    }

                    string info =
                        $"{x.NameStr}," +
                        $"{x.NameHash64:X2}," +
                        $"{x.DateTime.ToString(CultureInfo.InvariantCulture)}," +
                        $"{virtualSize}," +
                        $"{physicalSize}," +
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



