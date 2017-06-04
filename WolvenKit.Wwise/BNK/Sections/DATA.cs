using System;
using System.Collections.Generic;
using System.IO;

namespace WolvenKit.Wwise.BNK.Sections
{
    internal class DATA
    {
        private readonly uint DATA_tag = 0x41544144;
        public Dictionary<uint, byte[]> files = new Dictionary<uint, byte[]>();
        public uint length;
        public long offset;
        public byte[] remaining_data;

        public DATA(BinaryReader instream)
        {
            length = instream.ReadUInt32();
            offset = instream.BaseStream.Position;

            if (instream.BaseStream.Position - offset < length)
            {
                remaining_data = instream.ReadBytes((int) (length - (uint) (instream.BaseStream.Position - offset)));
            }
            else if (instream.BaseStream.Position - offset > length)
            {
                Console.WriteLine("DATA - YOU READ TOO MUCH!!!");
            }
        }

        public Dictionary<uint, uint> GenerateFileData()
        {
            if (files.Count == 0)
                return null;

            var offsets = new Dictionary<uint, uint>();
            var newData = new List<byte>();

            uint currentOffset = 0;
            foreach (var kvp in files)
            {
                var padding = newData.Count%16;
                if (padding > 0)
                {
                    for (var x = 16 - padding; x > 0; x--)
                        newData.Add(0);
                }

                offsets.Add(kvp.Key, currentOffset);
                newData.AddRange(kvp.Value);
                currentOffset += (uint) kvp.Value.Length;
            }

            remaining_data = newData.ToArray();

            return offsets;
        }

        public void StreamWrite(BinaryWriter outstream)
        {
            outstream.Write(DATA_tag);
            var newsizestart = outstream.BaseStream.Position;
            outstream.Write(length);

            if (remaining_data != null)
                outstream.Write(remaining_data);
            //update section size
            var newsizeend = outstream.BaseStream.Position;
            outstream.BaseStream.Position = newsizestart;
            outstream.Write((uint) (newsizeend - (newsizestart + 4)));

            outstream.BaseStream.Position = newsizeend;
        }

        public override string ToString()
        {
            return "[DATA] offset: " + offset + " length: " + length + " files count: " + files.Count +
                   (remaining_data != null ? " REMAINING DATA! " + remaining_data.Length + " bytes" : "");
        }
    }
}