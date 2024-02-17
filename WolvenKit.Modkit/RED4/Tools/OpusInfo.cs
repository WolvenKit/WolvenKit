using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace WolvenKit.Modkit.RED4.Opus
{
    public class OpusInfo
    {
        //  S       N       D   ?....
        public byte[] Header { get; } = { 0x53, 0x4E, 0x44, 0x20, 0x02, 0x00, 0x00, 0xF0, 0x00, 0x00, 0x00, 0x00 };

        public uint OpusCount { get; set; }
        public uint GroupingObjSize4x { get; set; }
        public uint[] OpusHashes { get; set; }
        public ushort[] PackIndices { get; set; }
        public uint[] OpusOffsets { get; set; }
        public ushort[] RiffOpusOffsets { get; set; }
        public uint[] OpusStreamLengths { get; set; }
        public uint[] WavStreamLengths { get; set; }
        public List<Group> GroupObjs { get; set; }

        public class Group
        {
            public uint Hash { get; set; }
            public uint MemberCount { get; set; }
            public uint[]? MemberHashes { get; set; }
        }

        public OpusInfo(Stream ms)
        {
            ms.Position = 0;
            var br = new BinaryReader(ms);
            Header = br.ReadBytes(12);

            ms.Position = 0xc;
            OpusCount = br.ReadUInt32();
            GroupingObjSize4x = br.ReadUInt32();

            OpusHashes = new uint[OpusCount];
            for (var i = 0; i < OpusCount; i++)
            {
                OpusHashes[i] = br.ReadUInt32();
            }

            PackIndices = new ushort[OpusCount];
            for (var i = 0; i < OpusCount; i++)
            {
                PackIndices[i] = br.ReadUInt16();
            }

            OpusOffsets = new uint[OpusCount];
            for (var i = 0; i < OpusCount; i++)
            {
                OpusOffsets[i] = br.ReadUInt32();
            }

            RiffOpusOffsets = new ushort[OpusCount];
            for (var i = 0; i < OpusCount; i++)
            {
                RiffOpusOffsets[i] = br.ReadUInt16();
            }

            OpusStreamLengths = new uint[OpusCount];
            for (var i = 0; i < OpusCount; i++)
            {
                OpusStreamLengths[i] = br.ReadUInt32();
            }

            WavStreamLengths = new uint[OpusCount];
            for (var i = 0; i < OpusCount; i++)
            {
                WavStreamLengths[i] = br.ReadUInt32();
            }
            GroupObjs = new List<Group>();
            while (ms.Position < ms.Length)
            {
                var group = new Group
                {
                    Hash = br.ReadUInt32(),
                    MemberCount = br.ReadUInt32()
                };
                group.MemberHashes = new uint[group.MemberCount];
                for (uint i = 0; i < group.MemberCount; i++)
                {
                    group.MemberHashes[i] = br.ReadUInt32();
                }
                GroupObjs.Add(group);
            }
        }

        //public OpusInfo() => OpusCount = 0;

        public void WriteAllOpusFromPaks(Stream[] opuspaks, DirectoryInfo outdir) // thou shall not be used
        {
            var brs = new BinaryReader[opuspaks.Length];
            for (var i = 0; i < opuspaks.Length; i++)
            {
                brs[i] = new BinaryReader(opuspaks[i]);
            }
            for (uint i = 0; i < OpusCount; i++)
            {
                opuspaks[PackIndices[i]].Position = OpusOffsets[i] + RiffOpusOffsets[i];
                var bytes = brs[PackIndices[i]].ReadBytes(Convert.ToInt32(OpusStreamLengths[i] - RiffOpusOffsets[i]));
                var name = OpusHashes[i] + ".opus";
                File.WriteAllBytes(Path.Combine(outdir.FullName, name), bytes);
            }
        }

        public void WriteOpusFromPak(Stream opuspak, DirectoryInfo outDir, uint index)
        {
            var br = new BinaryReader(opuspak);
            opuspak.Position = OpusOffsets[index] + RiffOpusOffsets[index];
            var bytes = br.ReadBytes(Convert.ToInt32(OpusStreamLengths[index] - RiffOpusOffsets[index]));
            var name = OpusHashes[index] + ".opus";
            var path = Path.Combine(outDir.FullName, name);
            File.WriteAllBytes(path, bytes);

            var proc = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "opus-tools\\opusdec.exe"))
            {
                WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                Arguments = $" \"{path}\" \"{path.Replace("opus", "wav")}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
            };
            using var p = Process.Start(proc);
            p?.WaitForExit();
        }

        public void WriteOpusToPak(MemoryStream opus, Stream pak, uint hash, MemoryStream wav)
        {
            var br = new BinaryReader(pak);
            pak.Position = 0;
            var index = 0;
            for (var i = 0; i < OpusCount; i++)
            {
                if (hash == OpusHashes[i])
                {
                    index = i;
                }
            }
            int pakIdx = PackIndices[index];
            var indices = new List<int>();
            for (var i = 0; i < OpusCount; i++)
            {
                if (pakIdx == PackIndices[i])
                {
                    indices.Add(i);
                }
            }

            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);
            ms.Position = 0;
            foreach (var i in indices)
            {
                var temp = Convert.ToUInt32(ms.Position);
                if (hash == OpusHashes[i])
                {
                    pak.Position = OpusOffsets[i] + 8;
                    var bytes = br.ReadBytes(RiffOpusOffsets[i] - 12);
                    bw.Write("RIFF"u8.ToArray()); //RIFF
                    bw.Write(Convert.ToUInt32(wav.Length - 44 + RiffOpusOffsets[i] - 8));
                    bw.Write(bytes);
                    bw.Write(Convert.ToUInt32(wav.Length - 44));
                    bw.Write(opus.ToArray());

                    WavStreamLengths[i] = Convert.ToUInt32(wav.Length - 44 + RiffOpusOffsets[i]);
                    OpusStreamLengths[i] = Convert.ToUInt32(opus.Length + RiffOpusOffsets[i]);
                    OpusOffsets[i] = Convert.ToUInt32(temp);
                }
                else
                {
                    pak.Position = OpusOffsets[i];
                    var bytes = br.ReadBytes(Convert.ToInt32(OpusStreamLengths[i]));
                    bw.Write(bytes);
                    OpusOffsets[i] = Convert.ToUInt32(temp);
                }
            }

            pak = ms;
            //File.WriteAllBytes(@"C:\Users\Abhinav\Desktop\mod\sfx_container_1280.opuspak",ms.ToArray());
        }

        public void WriteOpusInfo(DirectoryInfo dir)
        {
            var ms = new MemoryStream();
            var bw = new BinaryWriter(ms);

            bw.Write(Header);
            bw.Write(OpusCount);
            bw.Write(GroupingObjSize4x);
            for (var i = 0; i < OpusCount; i++)
            {
                bw.Write(OpusHashes[i]);
            }
            for (var i = 0; i < OpusCount; i++)
            {
                bw.Write(PackIndices[i]);
            }
            for (var i = 0; i < OpusCount; i++)
            {
                bw.Write(OpusOffsets[i]);
            }
            for (var i = 0; i < OpusCount; i++)
            {
                bw.Write(RiffOpusOffsets[i]);
            }
            for (var i = 0; i < OpusCount; i++)
            {
                bw.Write(OpusStreamLengths[i]);
            }
            for (var i = 0; i < OpusCount; i++)
            {
                bw.Write(WavStreamLengths[i]);
            }

            foreach (var g in GroupObjs)
            {
                bw.Write(g.Hash);
                bw.Write(g.MemberCount);
                for (var e = 0; e < g.MemberCount; e++)
                {
                    if (g.MemberHashes is not null)
                    {
                        bw.Write(g.MemberHashes[e]);
                    }
                }
            }
            File.WriteAllBytes(Path.Combine(dir.FullName, "sfx_container.opusinfo"), ms.ToArray());
        }
    }
}
