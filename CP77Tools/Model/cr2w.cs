using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RED.CRC32;
using WolvenKit.CR2W;

namespace CP77Tools.Model
{
    public class CR2WFile
    {
        public enum EFileReadErrorCodes
        {
            NoError,
            NoCr2w,
            UnsupportedVersion,

        }

        #region Constants
        private const long MAGIC_SIZE = 4;
        private const long FILEHEADER_SIZE = 36;
        private const long TABLEHEADER_SIZE = 12 * 10;
        private readonly int[] TABLES_SIZES = new int[6] { 8, 8, 16, 24, 24, 24 };
        #endregion

        #region Fields
        // constants
        private const uint MAGIC = 0x57325243; // "W2RC"
        private const uint DEADBEEF = 0xDEADBEEF;

        // IO
        private string filepath;
        private CR2WFileHeader m_fileheader;
        private CR2WTable[] m_tableheaders;
        private byte[] m_strings;
        public Dictionary<uint, string> StringDictionary { get; private set; }

        // misc
        private uint headerOffset = 0;
        private bool m_hasInternalBuffer;

        private byte[] additionalCr2WFileBytes;
        #endregion

        // Tables
        public List<CR2WName> Names { get; private set; }
        public List<CR2WImport> Imports { get; private set; }
        public List<CR2WProperty> Properties { get; private set; }
        public List<CR2WExport> Chunks { get; private set; }
        public List<CR2WBuffer> Buffers { get; private set; }
        public List<CR2WEmbedded> Embedded { get; private set; }


        public CR2WFile(string path) : base()
        {
            filepath = path;

            using var br = new BinaryReader(new FileStream(path, FileMode.Open));
            Read(br);
        }

        public CR2WFile()
        {
            Names = new List<CR2WName>();            //block 2
            Imports = new List<CR2WImport>();        //block 3
            Properties = new List<CR2WProperty>();   //block 4
            Chunks = new List<CR2WExport>();         //block 5
            Buffers = new List<CR2WBuffer>();        //block 6
            Embedded = new List<CR2WEmbedded>();     //block 7

            m_fileheader = new CR2WFileHeader();

            StringDictionary = new Dictionary<uint, string>();
            m_tableheaders = new CR2WTable[10];
        }


        public EFileReadErrorCodes Read(BinaryReader file)
        {


            #region Read Headers

            var startpos = file.BaseStream.Position;

            // read file header
            var id = file.BaseStream.ReadStruct<uint>();
            if (id != MAGIC)
                return EFileReadErrorCodes.NoCr2w;

            m_fileheader = file.BaseStream.ReadStruct<CR2WFileHeader>();
            if (m_fileheader.version > 195 || m_fileheader.version < 163)
                return EFileReadErrorCodes.UnsupportedVersion;

            

            // Tables [7-9] are not used in cr2w so far.
            m_tableheaders = file.BaseStream.ReadStructs<CR2WTable>(10);
            m_hasInternalBuffer = m_fileheader.bufferSize > m_fileheader.fileSize;

            // read strings - block 1 (index 0)
            m_strings = ReadStringsBuffer(file.BaseStream);

            // read the other tables
            Names = ReadTable<CR2WName>(file.BaseStream, 1).ToList();
            Imports = ReadTable<CR2WImport>(file.BaseStream, 2).ToList();
            Properties = ReadTable<CR2WProperty>(file.BaseStream, 3).ToList();
            Chunks = ReadTable<CR2WExport>(file.BaseStream, 4).ToList();
            Buffers = ReadTable<CR2WBuffer>(file.BaseStream, 5).ToList();
            Embedded = ReadTable<CR2WEmbedded>(file.BaseStream, 6).ToList();


            #endregion

            



           
            return 0;
        }

        private byte[] ReadStringsBuffer(Stream stream)
        {
            var start = m_tableheaders[0].offset;
            var m_strings_size = m_tableheaders[0].itemCount;
            var crc = m_tableheaders[0].crc32;

            var m_temp = new byte[m_strings_size];
            stream.Read(m_temp, 0, m_temp.Length);


            uint offset = 0;
            var tempstring = new List<byte>();
            for (uint i = 0; i < m_strings_size; i++)
            {
                byte b = m_temp[i];
                if (b == 0)
                {
                    var text = Encoding.GetEncoding("iso-8859-1").GetString(tempstring.ToArray());
                    StringDictionary.Add(offset, text);
                    tempstring.Clear();
                    offset = i + 1;
                }
                else
                {
                    tempstring.Add(b);
                }
            }

            return m_temp;
        }

        private T[] ReadTable<T>(Stream stream, int index) where T : struct
        {
            //stream.Seek(m_tableheaders[index].offset, SeekOrigin.Begin);

            var hash = new Crc32Algorithm(false);
            var table = stream.ReadStructs<T>(m_tableheaders[index].itemCount, hash);

            return table;
        }

        /// <summary>
        /// 
        /// </summary>
        public void DumpInfo()
        {


            //// dump chache info
            //using (var writer = File.CreateText($"{this.filepath}.info"))
            //{
            //    writer.WriteLine($"Magic: {Header.Magic}\r\n");
            //    writer.WriteLine($"Version: {Header.Version}\r\n");
            //    writer.WriteLine($"Tableoffset: {Header.Tableoffset}\r\n");
            //    writer.WriteLine($"Tablesize: {Header.Tablesize}\r\n");
            //    writer.WriteLine($"Unk3: {Header.Unk3}\r\n");
            //    writer.WriteLine($"Filesize: {Header.Filesize}\r\n");
            //    writer.WriteLine($"Size: {Table.Size}\r\n");
            //    writer.WriteLine($"Checksum: {Table.Checksum}\r\n");
            //    writer.WriteLine($"Num: {Table.Num}\r\n");
            //    writer.WriteLine($"Table1count: {Table.Table1count}\r\n");
            //    writer.WriteLine($"Table2count: {Table.Table2count}\r\n");
            //    writer.WriteLine($"Table3count: {Table.Table3count}\r\n");

            //}

            //const string head = //"Hash\t" +
            //                    "Offset\t" +
            //                    "Size\t" +
            //                    "Zsize\t" +
            //                    "Header\t" +
            //                    "somebool\t" +
            //                    "startindex\t" +
            //                    "nextindex\t" +
            //                    "unk1\t" +
            //                    "unk2\t" +
            //                    "Footer\t"
            //                    ;

            //// dump and extract files
            //using (var writer = File.CreateText($"{this.filepath}.txt"))
            //{
            //    // write header
            //    writer.WriteLine(head);

            //    // write info elements
            //    foreach (var entry in Table.FileInfo)
            //    {
            //        var x = entry.Value;
            //        var idx = entry.Key;

            //        var offsetEntry = Table.Offsets[idx];
            //        //var hashEntry = Table.HashTable[idx];

            //        //string ext = x.Name.Split('.').Last();

            //        string info =
            //            //$"{hashEntry.Hash:X2}\t +" +
            //            $"{offsetEntry.Offset}\t" +
            //            $"{offsetEntry.Size}\t" +
            //            $"{offsetEntry.Zsize}\t" +
            //            $"{x.Header:X2}\t" +
            //            $"{x.somebool}\t" +
            //            $"{x.startindex}\t" +
            //            $"{x.nextindex}\t" +
            //            $"{x.unk1}\t" +
            //            $"{x.unk2}\t" +
            //            $"{x.Footer:X2}\t"

            //            ;

            //        writer.WriteLine(info);
            //    }
            //}
        }
    }
}
