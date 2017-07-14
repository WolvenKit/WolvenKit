using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using WolvenKit.Interfaces;

namespace WolvenKit.Bundles
{
    public class Bundle : IWitcherArchiveType
    {
        private static readonly byte[] IDString =
        {
            (byte) 'P', (byte) 'O', (byte) 'T', (byte) 'A', (byte) 'T',
            (byte) 'O', (byte) '7', (byte) '0'
        };

        private static int HEADER_SIZE = 32;
        private static int ALIGNMENT_TARGET = 4096;
        private static string FOOTER_DATA = "AlignmentUnused"; //The bundle's final filesize should be an even multiple of 16; garbage data should be appended at the end if necessary to make this happen [appears to be unnecessary/optional, as far as the game cares]

        private uint bundlesize;
        private uint dataoffset;
        private uint dummysize;

        public static int GetHeaderEntrySize => 100 +      //filename
                    16 +                                //hash/checksum
                    4 +                                 //0
                    4 +                                 //uncompressed size
                    4 +                                 //compressed size
                    4 +                                 //data offset
                    8 +                                 //timestamp
                    16 +                                //0
                    4 +                                 //purpose unknown
                    4;                                  //compression algo

        public Bundle(string filename)
        {
            FileName = filename;

            ReadTOC();
        }

        public string TypeName { get { return "Bundle"; } }
        public string FileName { get; set; }
        public Dictionary<string, BundleItem> Items { get; set; }

        private void ReadTOC()
        {
            Items = new Dictionary<string, BundleItem>();

            using (var reader = new BinaryReader(new FileStream(FileName, FileMode.Open, FileAccess.Read)))
            {
                var idstring = reader.ReadBytes(IDString.Length);

                if (!IDString.SequenceEqual(idstring))
                {
                    throw new InvalidBundleException("Bundle header mismatch.");
                }

                bundlesize = reader.ReadUInt32();
                dummysize = reader.ReadUInt32();
                dataoffset = reader.ReadUInt32();

                reader.BaseStream.Seek(0x20, SeekOrigin.Begin);

                while (reader.BaseStream.Position < dataoffset + 0x20)
                {
                    var item = new BundleItem
                    {
                        Bundle = this
                    };

                    var strname = Encoding.Default.GetString(reader.ReadBytes(0x100));

                    item.Name = item.Bundle.TypeName + "\\" + strname.Substring(0, strname.IndexOf('\0'));
                    item.Hash = reader.ReadBytes(16);
                    item.Empty = reader.ReadUInt32();
                    item.Size = reader.ReadUInt32();
                    item.ZSize = reader.ReadUInt32();
                    item.Offset = reader.ReadUInt32();

                    //item.TimeStamp = reader.ReadUInt64();

                    //var datetime = reader.ReadBytes(8);

                    var date = reader.ReadUInt32();

                    var y = date >> 20;
                    var m = date >> 15 & 0x1F;
                    var d = date >> 10 & 0x1F;


                    var time = reader.ReadUInt32();

                    var h = time >> 20;
                    var n = time >> 15 & 0x1F;
                    var s = time >> 10 & 0x1F;

                    //if (date > 0)
                    //{
                    //    var datetime = new DateTime((int)y, (int)m, (int)d);
                    //}

                    item.DateString = string.Format(" {0}/{1}/{2} {3}:{4}:{5}", d, m, y, h, n, s);


                    item.Zero = reader.ReadBytes(16);    //00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 00 (always, in every archive)
                    item.UniqueId = reader.ReadUInt32();    //Depending on the .bundle archive, this is either 0 (patch.bundle) or a random value
                    item.Compression = reader.ReadUInt32();

                    Items.Add(item.Name, item);
                }


                reader.Close();
            }
        }

        /// <summary>
        /// Packs files to a bundle.
        /// </summary>
        /// <param name="Outputpath">The path to save the bundle to with the packed files.</param>
        /// <param name="Files">The Files to pack</param>
        public static void Write(string Outputpath, params string[] Files)
        {
            //https://github.com/ketwaroo/stuff/blob/master/witcher3/bundle-repack.php
            //http://aluigi.altervista.org/bms/witcher3.bms
            //https://github.com/ngoedde/The-Witcher-3-XBundle
            //https://github.com/adam-roth/bundle-explorer/ <-- this may be the best.

            using (var fs = new FileStream(Outputpath, FileMode.Create))
            using (var bw = new BinaryWriter(fs))
            {
                var dataoffset = 0;
                var bundlesize = 0;
                var dummysize = 0;

                int writePosition = HEADER_SIZE;
                foreach (var f in Files)
                    writePosition += GetHeaderEntrySize;
                dataoffset = writePosition - HEADER_SIZE;


                bw.Write(IDString);
                bw.Write(bundlesize);
                bw.Write(dummysize);
                bw.Write(dataoffset);
                foreach (var f in Files)
                {





                }
            }
        }
    }
}