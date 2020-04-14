using System;
using System.IO;
using System.Linq;

namespace WolvenKit.Wwise.Wwise
{

    public class PacketWebFile
    {
        public uint _offset = 0;
        public uint _absolute_granule = 0;
        public bool _no_granule = false;
        public ushort _size;

        public PacketWebFile(BinaryReader wem, uint offset, bool no_granule)
        {
            _offset = offset;
            _absolute_granule = 0;
            _no_granule = no_granule;
            _size = wem.ReadUInt16();

            if(!no_granule)
            {
                _absolute_granule = wem.ReadUInt32();
            }
        }

        public uint get_offset()
        {
            return _offset + get_header_size();
        }

        public uint get_header_size()
        {
            if (_no_granule)
                return 2;
            else
                return 6;
        }

        public uint get_next_offset()
        {
            return get_offset() + _size;
        }
    }

    public class WemFile
    {
        //Header data
        public string riff_head = "";
        public uint riff_size = 0;
        public string wave_head = "";

        public uint chunk_offset = 0;

        public uint fmt_offset = 0;
        public uint fmt_size = 0;
        public uint cue_offset = 0;
        public uint cue_size = 0;
        public uint LIST_offset = 0;
        public uint LIST_size = 0;
        public uint smpl_offset = 0;
        public uint smpl_size = 0;
        public uint vorb_offset = 0;
        public uint vorb_size = 0;
        public uint data_offset = 0;
        public uint data_size = 0;

        //FMT - TODO: Move to separate file
        public ushort codecid = 0;
        public ushort channels = 0;
        public uint sample_rate = 0;
        public uint avg_bytes_per_second = 0;
        public ushort block_alignment = 0;
        public ushort bps = 0;
        public ushort extra_fmt_length = 0;
        public ushort ext_unk = 0;
        public uint subtype = 0;

        //CUE - TODO: Move to separate file
        public uint cue_count = 0;
        public uint cue_id = 0;
        public uint cue_position = 0;
        public uint cue_datachunkid = 0;
        public uint cue_chunkstart = 0;
        public uint cue_blockstart = 0;
        public uint cue_sampleoffset = 0;

        //LIST - TODO: Move to separate file
        public string adtlbuf = "";
        public byte[] LIST_remain = new byte[0];

        //SMPL - TODO: Move to separate file
        public uint loop_count = 0;
        public uint loop_start = 0;
        public uint loop_end = 0;

        //Vorb data
        public bool no_granule = false;
        public uint mod_signal = 0;
        public bool mod_packets = false;
        public uint fmt_unk_field32_1 = 0;
        public uint fmt_unk_field32_2 = 0;

        public bool fake_vorb = false;

        //Other data
        public uint sample_count = 0;
        public uint setup_packet_offset = 0;
        public uint first_audio_packet_offset = 0;
        public uint fmt_unk_field32_3 = 0;
        public uint fmt_unk_field32_4 = 0;
        public uint fmt_unk_field32_5 = 0;
        public bool header_triad_present = false;
        public bool old_packet_headers = false;
        public uint uid = 0;
        public byte blocksize_0_pow = 0;
        public byte blocksize_1_pow = 0;

        public byte[] pre_data = new byte[0];
        public byte[] data_setup = new byte[0];
        public byte[] data = new byte[0];

        public byte[] buffer;

        public PacketWebFile packet;

        public WemFile()
        {

        }

        public void merge_headers(WemFile original)
        {
            using (var bw = new BinaryWriter(new MemoryStream(buffer)))
            {
                if (!fake_vorb)
                    throw new Exception("Not supported");

                riff_size = 0;
                subtype = original.subtype;

                bw.Write(riff_head);
                bw.Write(riff_size);
                bw.Write(wave_head);

                bw.Write("fmt ");
                bw.Write(fmt_size);
                bw.Write(codecid);
                bw.Write(channels);
                bw.Write(sample_rate);
                bw.Write(avg_bytes_per_second);
                bw.Write(block_alignment);
                bw.Write(bps);
                bw.Write(extra_fmt_length);
                bw.Write(ext_unk);
                bw.Write(subtype);
                bw.Write(sample_count);
                bw.Write(mod_signal);
                bw.Write(fmt_unk_field32_1);
                bw.Write(fmt_unk_field32_2);
                bw.Write(pre_data.Length);
                bw.Write(pre_data.Length + (first_audio_packet_offset - setup_packet_offset));
                bw.Write(fmt_unk_field32_3);
                bw.Write(fmt_unk_field32_4);
                bw.Write(fmt_unk_field32_5);
                bw.Write(uid);
                bw.Write(blocksize_0_pow);
                bw.Write(blocksize_1_pow);

                if (cue_offset != 0)
                {
                    bw.Write("cue ");
                    bw.Write(cue_size);
                    bw.Write(cue_count);
                    bw.Write(cue_id);
                    bw.Write(cue_position);
                    bw.Write(cue_datachunkid);
                    bw.Write(cue_chunkstart);
                    bw.Write(cue_blockstart);
                    bw.Write(cue_sampleoffset);
                }

            }
        }

        public void Merge_Datas(WemFile original)
        {
            using (var bw = new BinaryWriter(new MemoryStream(buffer)))
            {

            }
        }

        /// <summary>
        /// Writes the RIFF size to the buffer
        /// </summary>
        public void Calculate_Riff_Size()
        {
            using (var bw = new BinaryWriter(new MemoryStream(buffer)))
            {
                bw.BaseStream.Seek(4, SeekOrigin.Begin);
                bw.Write((uint)(bw.BaseStream.Length - 8));
            }
        }

        /// <summary>
        /// Load the file's data
        /// Initializes the buffer as well
        /// </summary>
        /// <param name="path">The file to load</param>
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
                if (wave_head != "WAVE")
                    throw new Exception("Invalid file! No WAVE header tag!");

                chunk_offset = 12;

                while (chunk_offset < riff_size)
                {
                    br.BaseStream.Seek(chunk_offset, SeekOrigin.Begin);

                    if (chunk_offset + 8 > riff_size)
                        throw new Exception("Truncated chunk header");  

                    var type = br.ReadChars(4);
                    var size = br.ReadUInt32();

                    switch (new String(type))
                    {
                        case "fmt ":
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

                if (Array.IndexOf(new uint[] { 0, 0x28, 0x2A, 0x2C, 0x32, 0x34 }, vorb_size) == -1)
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

                    if (Array.IndexOf(new uint[] { 0x28, 0x18, 0x12 }, fmt_size) > -1)
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

                if (bps != 0)
                    throw new Exception("BPS is not 0");

                extra_fmt_length = br.ReadUInt16();

                if (extra_fmt_length != (fmt_size - 0x12))
                    throw new Exception("Bad extra fmt length!");

                if ((fmt_size - 0x12) >= 2)
                    ext_unk = br.ReadUInt16();

                if ((fmt_size - 0x12) >= 6)
                    subtype = br.ReadUInt32();

                //Read CUE
                if (cue_offset != 0)
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
                if (LIST_offset != 0)
                {
                    br.BaseStream.Seek(LIST_offset, SeekOrigin.Begin);
                    adtlbuf = new String(br.ReadChars(4));

                    if (adtlbuf != "adtl")
                        throw new Exception("List is not adtl!");

                    LIST_remain = br.ReadBytes((int)(LIST_size - 4));
                }

                //Read sample
                if (smpl_offset != 0)
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

                if (vorb_size == 0x28 || vorb_size == 0x2C)
                {
                    header_triad_present = true;
                    old_packet_headers = true;
                }
                else if (Array.Exists(new uint[] { 0, 0x2A, 0x32, 0x34 }, e => e == vorb_size))
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
            buffer = File.ReadAllBytes(path);
        }

        /// <summary>
        /// Setup the packet of the wem file
        /// </summary>
        /// <param name="br">The file's binaryreader</param>
        public void setup_packet(BinaryReader br)
        {
            packet = new PacketWebFile(br, data_offset + setup_packet_offset, no_granule);
        }

        /// <summary>
        /// Generate CUE section for wav files
        /// </summary>
        public void Generate()
        {
            using (var bw = new BinaryWriter(new MemoryStream(buffer)))
            {
                riff_size = 0;

                bw.Write(riff_head);
                bw.Write(riff_size);
                bw.Write(wave_head);

                bw.Write("fmt ");
                bw.Write(fmt_size);
                bw.Write(codecid);
                bw.Write(channels);
                bw.Write(sample_rate);
                bw.Write(avg_bytes_per_second);
                bw.Write(block_alignment);
                bw.Write(bps);

                if (extra_fmt_length != 0)
                    bw.Write(extra_fmt_length);

                //if(extra_fmt != 0)
                // bw.Write(extra_fmt)

                bw.Write("cue ");
                bw.Write(28); // cue chunk size
                bw.Write(1); // cue count
                bw.Write(1); // cue id 
                bw.Write(0); // cue position
                bw.Write("data"); // chunk id
                bw.Write(0); // chunk start
                bw.Write(0); // block start
                bw.Write(0); // sample offset

                bw.Write("data");
                bw.Write(data_size + (data_size * 0));
                bw.Write(data);
            }
        }

        /// <summary>
        /// Write the file to specified path
        /// </summary>
        /// <param name="path">Path to write to</param>
        public void WriteToFile(string path)
        {
            using (var bw = new BinaryWriter(new FileStream(path, FileMode.Create)))
            {
                bw.Write(buffer.ToArray());
            }
        }
    }
}
