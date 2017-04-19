using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace WolvenKit.Bundles
{
    public class Bundle
    {
        private static readonly byte[] IDString =
        {
            (byte) 'P', (byte) 'O', (byte) 'T', (byte) 'A', (byte) 'T',
            (byte) 'O', (byte) '7', (byte) '0'
        };

        private uint bundlesize;
        private uint dataoffset;
        private uint unknown;

        public Bundle(string filename)
        {
            FileName = filename;

            ReadTOC();
        }

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
                unknown = reader.ReadUInt32();
                dataoffset = reader.ReadUInt32();

                reader.BaseStream.Seek(0x20, SeekOrigin.Begin);

                while (reader.BaseStream.Position < dataoffset + 0x20)
                {
                    var item = new BundleItem
                    {
                        Bundle = this
                    };

                    var strname = Encoding.Default.GetString(reader.ReadBytes(0x100));

                    item.Name = strname.Substring(0, strname.IndexOf('\0'));
                    item.Hash = reader.ReadBytes(16);
                    item.Unknown = reader.ReadUInt32();
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


                    item.Unknown2 = reader.ReadBytes(16);
                    item.Unknown3 = reader.ReadUInt32();
                    item.Compression = reader.ReadUInt32();

                    Items.Add(item.Name, item);
                }


                reader.Close();
            }
        }
    }
}