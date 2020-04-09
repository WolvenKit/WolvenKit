using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VGMToolbox.format.auditing;

namespace WolvenKit.Wwise.WEM
{
    class WemFile
    {
        //Header data
        public string riff_head = "";
        public UInt32 riff_size = 0;
        public string wave_head = "";

        public UInt32 chunk_offset = 0;

        public UInt32 fmt_offset = 0;
        public UInt32 fmt_size = 0;
        public UInt32 cue_offset = 0;
        public UInt32 cue_size = 0;
        public UInt32 LIST_offset = 0;
        public UInt32 LIST_size = 0;
        public UInt32 smpl_offset = 0;
        public UInt32 smpl_size = 0;
        public UInt32 vorb_offset = 0;
        public UInt32 vorb_size = 0;
        public UInt32 data_offset = 0;
        public UInt32 data_size = 0;

        //FMT - TODO: Move to separate file
        public UInt16 codecid = 0;
        public UInt16 channels = 0;
        public UInt32 sample_rate = 0;
        public UInt32 avg_bytes_per_second = 0;
        public UInt16 block_alignment = 0;
        public UInt16 bps = 0;
        public UInt16 extra_fmt_length = 0;
        public UInt16 ext_unk = 0;
        public UInt32 subtype = 0;

        //CUE - TODO: Move to separate file
        public UInt32 cue_count = 0;
        public UInt32 cue_id = 0;
        public UInt32 cue_position = 0;
        public UInt32 cue_datachunkid = 0;
        public UInt32 cue_chunkstart = 0;
        public UInt32 cue_blockstart = 0;
        public UInt32 cue_sampleoffset = 0;

        //LIST - TODO: Move to separate file
        public string adtlbuf = "";
        public byte[] LIST_remain = new byte[0];

        //SMPL - TODO: Move to separate file
        public UInt32 loop_count = 0;
        public UInt32 loop_start = 0;
        public UInt32 loop_end = 0;

        //Vorb data
        public bool no_granule = false;
        public UInt32 mod_signal = 0;
        public bool mod_packets = false;
        public UInt32 fmt_unk_field32_1 = 0;
        public UInt32 fmt_unk_field32_2 = 0;

        public bool fake_vorb = false;

        //Other data
        public UInt32 sample_count = 0;
        public UInt32 setup_packet_offset = 0;
        public UInt32 first_audio_packet_offset = 0;
        public UInt32 fmt_unk_field32_3 = 0;
        public UInt32 fmt_unk_field32_4 = 0;
        public UInt32 fmt_unk_field32_5 = 0;
        public bool header_triad_present = false;
        public bool old_packet_headers = false;
        public UInt32 uid = 0;
        public byte blocksize_0_pow = 0;
        public byte blocksize_1_pow = 0;

        public byte[] pre_data = new byte[0];
        public byte[] data_setup = new byte[0];
        public byte[] data = new byte[0];

        public MemoryStream buffer;

        public Packet packet;

        public WemFile()
        {

        }

        public void merge_headers(WemFile original)
        {

        }

        public void Merge_Datas(WemFile original)
        {

        }

        public void Calculate_Riff_Size(BinaryWriter bw)
        {
            using (var br = new BinaryWriter(buffer))
            {
                bw.BaseStream.Seek(4, SeekOrigin.Begin);
                bw.Write((UInt32)(bw.BaseStream.Length - 8));
            }
        }

        public void LoadFromFile(string path)
        {
            using (var br = new BinaryReader(new FileStream(path, FileMode.Open)))
            {
                riff_head = new String(br.ReadChars(4));
                if (riff_head != "RIFF")
                    throw new Exception("Invalid file! No RIFF header tag!");
                riff_size = br.ReadUInt32() + 8;
                if (br.BaseStream.Length < riff_size)
                    throw new Exception("Truncated RIFF!");
                wave_head = new String(br.ReadChars(4));
                if (riff_head != "WAVE")
                    throw new Exception("Invalid file! No WAVE header tag!");
                
                chunk_offset = 12;

                while(chunk_offset < riff_size)
                {
                    br.BaseStream.Seek(chunk_offset, SeekOrigin.Begin);

                    if (chunk_offset + 8 > riff_size)
                        throw new Exception("Truncated chunk header");

                    var type = new String(br.ReadChars(4));
                    var size = br.ReadUInt32();

                    switch(type)
                    {
                        case "fmt":
                        {
                            fmt_offset = chunk_offset + 8;
                            fmt_size = size;
                            break;
                        }
                        case "cue":
                        {
                            cue_offset = chunk_offset + 8;
                            cue_size = size;
                            break;
                        }
                        case "LIST":
                        {
                            LIST_offset = chunk_offset + 8;
                            LIST_offset = size;
                            break;
                        }
                        case "smpl":
                        {
                            smpl_offset = chunk_offset + 8;
                            smpl_size = size;
                            break;
                        }
                        case "vorb":
                        {
                            vorb_offset = chunk_offset + 8;
                            vorb_size = size;
                            break;
                        }
                        case "data":
                        {
                            data_offset = chunk_offset + 8;
                            data_size = size;
                            break;
                        }
                        default:
                            throw new Exception("Unknown chunk with type: " + type + "!");
                    }
                    chunk_offset += (8 + size);
                }

                if (chunk_offset > riff_size)
                    throw new Exception("Truncated chunk");

                if (fmt_offset == 0 || data_offset == 0)
                    throw new Exception("No fmt and data chunks found!");

                if (Array.IndexOf(new UInt32[] { 0, 0x28, 0x2A, 0x2C, 0x32, 0x34 }, vorb_size) == -1)
                    throw new Exception("Bad vorb size!");

                if (vorb_offset == 0)
                {
                    if (fmt_size != 0x42)
                    {
                        throw new Exception("fmt size must be 0x42 if no vorb");
                    }
                    else
                    {
                        vorb_offset = fmt_offset + 0x18; //FAKE
                        fake_vorb = true;
                    }
                }
                else
                {
                    throw new Exception("Not supported!");

                    if (Array.IndexOf(new UInt32[] { 0x28, 0x18, 0x12 }, fmt_size) > -1)
                    {
                        throw new Exception("Bad fmt size!");
                    }
                }

                br.BaseStream.Seek(fmt_offset, SeekOrigin.Begin);

                codecid = br.ReadUInt16();

                if (codecid != 0xFFFF)
                    throw new Exception("Bad codec  id!");

                channels = br.ReadUInt16();
                sample_rate = br.ReadUInt32();
                avg_bytes_per_second = br.ReadUInt32();
                block_alignment = br.ReadUInt16();

                if (block_alignment != 0)
                    throw new Exception("Bad block alignment!");

                bps = br.ReadUInt16();

                if(bps != 0)
                    throw new Exception("BPS is not 0");

                extra_fmt_length = br.ReadUInt16();

                if (extra_fmt_length != (fmt_size - 0x12))
                    throw new Exception("Bad extra fmt length!");

                if ((fmt_size - 0x12) >= 2)
                    ext_unk = br.ReadUInt16();

                if ((fmt_size - 0x12) >= 6)
                    subtype = br.ReadUInt32();
                    
                //Read CUE
                if(cue_offset != 0)
                {
                    br.BaseStream.Seek(cue_offset, SeekOrigin.Begin);
                    cue_count = br.ReadUInt32();
                    cue_id = br.ReadUInt32();
                    cue_position = br.ReadUInt32();
                    cue_datachunkid = br.ReadUInt32();
                    cue_chunkstart = br.ReadUInt32();
                    cue_blockstart = br.ReadUInt32();
                    cue_sampleoffset = br.ReadUInt32();
                }

                //Read LIST
                if(LIST_offset != 0)
                {
                    br.BaseStream.Seek(LIST_offset, SeekOrigin.Begin);
                    adtlbuf = new String(br.ReadChars(4));

                    if (adtlbuf != "adtl")
                        throw new Exception("List is not adtl!");

                    LIST_remain = br.ReadBytes((int)(LIST_size - 4));
                }

                //Read sample
                if(smpl_offset != 0)
                {
                    br.BaseStream.Seek(smpl_offset, SeekOrigin.Begin);

                    loop_count = br.ReadUInt32();

                    if (loop_count != 1)
                        throw new Exception("Not an one loop!");

                    br.BaseStream.Seek(smpl_offset + 0x2C, SeekOrigin.Begin);
                    loop_count = br.ReadUInt32();
                    loop_count = br.ReadUInt32();
                }

                br.BaseStream.Seek(vorb_offset, SeekOrigin.Begin);
                sample_count = br.ReadUInt32();

                if (vorb_size == 0 || vorb_size == 0x2A)
                {
                    no_granule = true;
                    br.BaseStream.Seek(vorb_offset + 0x4, SeekOrigin.Begin);
                    mod_signal = br.ReadUInt32();

                    if (Array.IndexOf(new uint[] { 0x4A, 0x4B, 0x69, 0x70 }, mod_signal) > -1)
                        mod_packets = true;

                    fmt_unk_field32_1 = br.ReadUInt32();
                    fmt_unk_field32_2 = br.ReadUInt32();

                    br.BaseStream.Seek(vorb_offset + 0x10, SeekOrigin.Begin);
                }
                else
                    br.BaseStream.Seek(vorb_offset + 0x18, SeekOrigin.Begin);

                setup_packet_offset = br.ReadUInt32();
                first_audio_packet_offset = br.ReadUInt32();
                fmt_unk_field32_3 = br.ReadUInt32();
                fmt_unk_field32_4 = br.ReadUInt32();
                fmt_unk_field32_5 = br.ReadUInt32();

                if (vorb_size == 0 || vorb_size == 0x2A)
                    br.BaseStream.Seek(vorb_offset + 0x24, SeekOrigin.Begin);
                else if (vorb_size == 0x32 || vorb_size == 0x34)
                    br.BaseStream.Seek(vorb_offset + 0x2C, SeekOrigin.Begin);

                if(vorb_size == 0x28 || vorb_size == 0x2C)
                {
                    header_triad_present = true;
                    old_packet_headers = true;
                }
                else if(Array.Exists(new uint[] { 0, 0x2A, 0x32, 0x34 }, e => e == vorb_size))
                {
                    uid = br.ReadUInt32();
                    blocksize_0_pow = br.ReadByte();
                    blocksize_1_pow = br.ReadByte();
                }

                if (loop_count != 0)
                {
                    if (loop_end == 0)
                        loop_end = sample_count;
                    else
                        loop_end += 1;
                    if (loop_start >= sample_count || loop_end > sample_count || loop_start > loop_end)
                        throw new Exception("Loops out of range");
                }

                if (Array.Exists(new uint[] { 4, 3, 0x33, 0x37, 0x3b, 0x3f }, e => e == subtype))
                    return;

                setup_packet(br);

                br.BaseStream.Seek(data_offset, SeekOrigin.Begin);
                pre_data = br.ReadBytes((int)setup_packet_offset);
                data_setup = br.ReadBytes((int)first_audio_packet_offset);
                data = br.ReadBytes((int)(br.BaseStream.Length - br.BaseStream.Position));

                if (pre_data.Length + data_setup.Length + data.Length != br.BaseStream.Length)
                    throw new Exception("Bad data!");
            }
            buffer = new MemoryStream((int)new FileInfo(path).Length);
        }

        public void setup_packet(BinaryReader br)
        {
            packet = new Packet(br, data_offset + setup_packet_offset, no_granule);
        }

        public void WriteToFile(string path)
        {
            using(var br = new BinaryWriter(new FileStream(path, FileMode.Create)))
            {

            }
        }
    }
}
