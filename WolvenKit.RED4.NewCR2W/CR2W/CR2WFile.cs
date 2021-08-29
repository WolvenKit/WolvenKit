using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WolvenKit.RED4.IO;
using WolvenKit.RED4.Types;
using WolvenKit.RED4.Types.Exceptions;

namespace WolvenKit.RED4.NewCR2W
{
    public enum EFileReadErrorCodes
    {
        NoError,
        NoCr2w,
        UnsupportedVersion,
    }

    public class NewCR2WFile
    {
        public const uint MAGIC = 0x57325243; // "W2RC"

        private CR2WFileHeader m_fileheader;
        private CR2WTable[] m_tableheaders;
        private byte[] m_strings;

        public Dictionary<uint, string> StringDictionary { get; private set; }

        public List<ICR2WName> Names { get; private set; }
        public List<ICR2WImport> Imports { get; private set; }
        public List<CR2WPropertyWrapper> Properties { get; private set; }
        public List<ICR2WExport> Chunks { get; private set; }
        public List<ICR2WBuffer> Buffers { get; private set; }
        public List<CR2WEmbeddedWrapper> Embedded { get; private set; }

        public NewCR2WFile()
        {
            Names = new List<ICR2WName>();                  //block 2
            Imports = new List<ICR2WImport>();              //block 3
            Properties = new List<CR2WPropertyWrapper>();   //block 4
            Chunks = new List<ICR2WExport>();               //block 5
            Buffers = new List<ICR2WBuffer>();              //block 6
            Embedded = new List<CR2WEmbeddedWrapper>();     //block 7

            m_fileheader = new CR2WFileHeader()
            {
                version = 195,
                numChunks = 6
            };

            StringDictionary = new Dictionary<uint, string>();
            m_tableheaders = new CR2WTable[10];
        }

        public EFileReadErrorCodes Read(Stream stream)
        {
            using var br = new Red4ReaderExt(stream);
            return Read(br);
        }

        public EFileReadErrorCodes Read(Red4ReaderExt file)
        {
            StringDictionary.Clear();

            #region Read Headers

            var startpos = file.BaseStream.Position;

            // read file header
            var id = file.BaseStream.ReadStruct<uint>();
            if (id != MAGIC)
                return EFileReadErrorCodes.NoCr2w;

            m_fileheader = file.BaseStream.ReadStruct<CR2WFileHeader>();
            if (m_fileheader.version > 195 || m_fileheader.version < 163)
                return EFileReadErrorCodes.UnsupportedVersion;

            //var dt = new CDateTime(m_fileheader.timeStamp, null, "");

            // Tables [7-9] are not used in cr2w so far.
            m_tableheaders = file.BaseStream.ReadStructs<CR2WTable>(10);
            var m_hasInternalBuffer = m_fileheader.buffersEnd > m_fileheader.objectsEnd;

            // read strings - block 1 (index 0)
            m_strings = ReadStringsBuffer(file.BaseStream);

            // read the other tables
            Names = ReadTable<CR2WName>(file.BaseStream, 1).Select(_ => new CR2WNameWrapper(_, this) as ICR2WName).ToList(); // block 2
            Imports = ReadTable<CR2WImport>(file.BaseStream, 2).Select(_ => new CR2WImportWrapper(_, this) as ICR2WImport).ToList(); // block 3
            Properties = ReadTable<CR2WProperty>(file.BaseStream, 3).Select(_ => new CR2WPropertyWrapper(_)).ToList(); // block 4
            Chunks = ReadTable<CR2WExport>(file.BaseStream, 4).Select(_ => new CR2WExportWrapper(_, this) as ICR2WExport).ToList(); // block 5
            Buffers = ReadTable<CR2WBuffer>(file.BaseStream, 5).Select(_ => new CR2WBufferWrapper(_) as ICR2WBuffer).ToList(); // block 6
            Embedded = ReadTable<CR2WEmbedded>(file.BaseStream, 6).Select(_ => new CR2WEmbeddedWrapper(_)
            {
                ParentFile = this,
            }).ToList(); // block 7

            //if (Embedded.Count > 1)
            //    throw new NotImplementedException("Embedded files present?");

            #endregion

            #region Read Data

            var stringList = StringDictionary.Select(e => e.Value).ToList();
            file.SetStringList(stringList);

            // Read object data //block 5
            for (int i = 0; i < Chunks.Count; i++)
            {
                var chunk = Chunks[i];

                try
                {
                    chunk.ReadData(file);
                }
                catch (MissingRTTIException e)
                {
                    throw;
                }

                //int percentprogress = (int)((float)i / (float)Chunks.Count * 100.0);
                //Logger?.LogProgress(percentprogress, $"Reading chunk {chunk.REDName}...");
            }

            #endregion

            return EFileReadErrorCodes.NoError;
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
    }
}

