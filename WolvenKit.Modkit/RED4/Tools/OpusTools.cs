using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.Json;
using Splat;
using WolvenKit.Common;
using WolvenKit.Common.FNV1A;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive;

namespace WolvenKit.Modkit.RED4.Opus
{
    public class OpusTools
    {
        private readonly ICyberGameArchive _soundBanks;
        private readonly DirectoryInfo _modFolder;
        private readonly DirectoryInfo _rawFolder;
        public OpusInfo Info { get; set; }
        private readonly bool _isModded;

        public OpusTools(string modFolder, string rawFolder, bool useMod = false) //audio_2_soundbanks.archive
        {
            var archiveManager = Locator.Current.GetService<IArchiveManager>();
            if (archiveManager != null)
            {
                _soundBanks = archiveManager.Archives.Items
                    .Cast<Archive>()
                    .FirstOrDefault(_ => _.Name.Equals($"{EVanillaArchives.audio_2_soundbanks}.archive"));
            }

            _modFolder = new DirectoryInfo(modFolder);
            _rawFolder = new DirectoryInfo(rawFolder);
            _isModded = useMod;
            if (!Directory.Exists(Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks")))
            {
                Directory.CreateDirectory(Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks"));
            }

            if (!Directory.Exists(_rawFolder.FullName))
            {
                Directory.CreateDirectory(_rawFolder.FullName);
            }

            if (_isModded)
            {
                var infoFile = Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks\\sfx_container.opusinfo");
                if (File.Exists(infoFile))
                {
                    var ms = new MemoryStream(File.ReadAllBytes(infoFile));
                    var br = new BinaryReader(ms);
                    ms.Position = 0;

                    if (BitConverter.ToString(br.ReadBytes(3)) != "53-4E-44")
                    {
                        _isModded = false;
                    }
                    else
                    {
                        Info = new OpusInfo(ms);
                    }
                }
                else
                {
                    _isModded = false;
                }
            }
            if (!_isModded)
            {
                var hash = FNV1A64HashAlgorithm.HashString("base\\sound\\soundbanks\\sfx_container.opusinfo");
                var ms = new MemoryStream();
                if (_soundBanks.Files.ContainsKey(hash))
                {
                    ModTools.ExtractSingleToStream(_soundBanks, hash, ms);
                    Info = new OpusInfo(ms);
                }
                else
                {
                    Info = new OpusInfo();
                }
            }
        }

        public bool ExportOpusUsingHash(uint opusHash)
        {
            if (!_isModded)
            {
                for (uint i = 0; i < Info.OpusCount; i++)
                {
                    if (Info.OpusHashes[i] == opusHash)
                    {
                        var containerHash = FNV1A64HashAlgorithm.HashString("base\\sound\\soundbanks\\sfx_container_" + Info.PackIndices[i] + ".opuspak");
                        var ms = new MemoryStream();
                        ModTools.ExtractSingleToStream(_soundBanks, containerHash, ms);
                        Info.WriteOpusFromPak(ms, _rawFolder, i);
                        return true;
                    }
                    if (Info.OpusCount == i + 1)
                    {
                        return false;
                    }
                }
            }
            else
            {
                for (uint i = 0; i < Info.OpusCount; i++)
                {
                    if (Info.OpusHashes[i] == opusHash)
                    {
                        var pakFile = Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks\\sfx_container_" + Info.PackIndices[i] + ".opuspak");
                        if (File.Exists(pakFile))
                        {
                            var ms = new MemoryStream(File.ReadAllBytes(pakFile));
                            Info.WriteOpusFromPak(ms, _rawFolder, i);
                            return true;
                        }
                        else
                        {
                            return false;
                        }
                    }
                    if (Info.OpusCount == i + 1)
                    {
                        return false;
                    }
                }
            }
            return false;
        }

        public bool DumpAllOpusInfo()
        {
            var s = JsonSerializer.Serialize(Info, new JsonSerializerOptions { WriteIndented = true });
            File.WriteAllText(Path.Combine(_rawFolder.FullName, "sfx_container.opusinfo.json"), s);
            return true;
        }

        public bool ImportWavs(params string[] wavFiles)
        {
            if (wavFiles.Length < 1)
            {
                return false;
            }

            var foundids = new List<uint>();
            foreach (var wav in wavFiles)
            {
                try
                {
                    var idddd = Convert.ToUInt32(Path.GetFileNameWithoutExtension(wav));
                    foundids.Add(idddd);
                }
                catch (Exception ex){Locator.Current.GetService<ILoggerService>().Error(ex);}
            }

            var validids = new List<uint>();
            for (var i = 0; i < foundids.Count; i++)
            {
                for (var e = 0; e < Info.OpusCount; e++)
                {
                    if (Info.OpusHashes[e] == foundids[i])
                    {
                        validids.Add(foundids[i]);
                        break;
                    }
                }
            }
            if (validids.Count < 1)
            {
                return false;
            }

            var modStreams = new Stream[Info.PackIndices[Info.OpusCount - 1] + 1];

            for (var i = 0; i < validids.Count; i++)
            {
                var name = Path.Combine(_rawFolder.FullName, Convert.ToString(validids[i]) + ".opus");
                var proc = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "opus-tools\\opusenc.exe"))
                {
                    WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Arguments = $" \"{name.Replace("opus", "wav")}\" \"{name}\" --serial 42 --quiet --padding 0 --vbr --comp 10 --framesize 20 ",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                };
                using (var p = Process.Start(proc))
                {
                    p.WaitForExit();
                }

                var procnew = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "opus-tools\\opusdec.exe"))
                {
                    WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Arguments = $" \"{name}\" \"{name.Replace("opus", "wav")}\"",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                };
                using (var p = Process.Start(procnew))
                {
                    p.WaitForExit();
                }

                var procn = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "opus-tools\\opusenc.exe"))
                {
                    WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                    Arguments = $" \"{name.Replace("opus", "wav")}\" \"{name}\" --serial 42 --quiet --padding 0 --vbr --comp 10 --framesize 20 ",
                    UseShellExecute = false,
                    RedirectStandardOutput = true,
                    CreateNoWindow = true,
                };
                using (var p = Process.Start(procn))
                {
                    p.WaitForExit();
                }

                if (File.Exists(name))
                {
                    for (var e = 0; e < Info.OpusCount; e++)
                    {
                        if (validids[i] == Info.OpusHashes[e])
                        {
                            int pakIdx = Info.PackIndices[e];
                            if (modStreams[pakIdx] == null)
                            {
                                var pakName = "base\\sound\\soundbanks\\sfx_container_" + pakIdx + ".opuspak";
                                if (_isModded && File.Exists(Path.Combine(_modFolder.FullName, pakName)))
                                {
                                    modStreams[pakIdx] = new MemoryStream(File.ReadAllBytes(Path.Combine(_modFolder.FullName, pakName)));
                                }
                                else
                                {
                                    var containerHash = FNV1A64HashAlgorithm.HashString(pakName);
                                    modStreams[pakIdx] = new MemoryStream();
                                    ModTools.ExtractSingleToStream(_soundBanks, containerHash, modStreams[pakIdx]);
                                }
                            }
                            Info.WriteOpusToPak(new MemoryStream(File.ReadAllBytes(name)), ref modStreams[pakIdx], validids[i], new MemoryStream(File.ReadAllBytes(name.Replace("opus", "wav"))));
                        }
                    }
                }
            }

            var writeinfo = false;
            for (var i = 0; i < modStreams.Length; i++)
            {
                if (modStreams[i] != null)
                {
                    var pakName = "base\\sound\\soundbanks\\sfx_container_" + i + ".opuspak";
                    var temp = modStreams[i];
                    temp.Position = 0;
                    var bytes = new byte[temp.Length];
                    temp.Read(bytes, 0, Convert.ToInt32(temp.Length));
                    File.WriteAllBytes(Path.Combine(_modFolder.FullName, pakName), bytes);
                    writeinfo = true;
                }
            }
            if (writeinfo)
            {
                Info.WriteOpusInfo(new DirectoryInfo(Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks")));

                return true;
            }

            return false;
        }
    }

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
            public uint[] MemberHashes { get; set; }
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

        public OpusInfo()
        {
            OpusCount = 0;
        }

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

        public void WriteOpusFromPak(Stream opuspak, DirectoryInfo outdir, uint index)
        {
            var br = new BinaryReader(opuspak);
            opuspak.Position = OpusOffsets[index] + RiffOpusOffsets[index];
            var bytes = br.ReadBytes(Convert.ToInt32(OpusStreamLengths[index] - RiffOpusOffsets[index]));
            var name = OpusHashes[index] + ".opus";
            var path = Path.Combine(outdir.FullName, name);
            File.WriteAllBytes(path, bytes);

            var proc = new ProcessStartInfo(Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "opus-tools\\opusdec.exe"))
            {
                WorkingDirectory = AppDomain.CurrentDomain.BaseDirectory,
                Arguments = $" \"{path}\" \"{path.Replace("opus", "wav")}\"",
                UseShellExecute = false,
                RedirectStandardOutput = true,
                CreateNoWindow = true,
            };
            using (var p = Process.Start(proc))
            {
                p.WaitForExit();
            }
        }

        public void WriteOpusToPak(MemoryStream opus, ref Stream pak, uint hash, MemoryStream wav)
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
            for (var i = 0; i < indices.Count; i++)
            {
                var temp = Convert.ToUInt32(ms.Position);
                if (hash == OpusHashes[indices[i]])
                {
                    pak.Position = OpusOffsets[indices[i]] + 8;
                    var bytes = br.ReadBytes(RiffOpusOffsets[indices[i]] - 12);
                    bw.Write(new byte[] { 0x52, 0x49, 0x46, 0x46 }); //RIFF
                    bw.Write(Convert.ToUInt32(wav.Length - 44 + RiffOpusOffsets[indices[i]] - 8));
                    bw.Write(bytes);
                    bw.Write(Convert.ToUInt32(wav.Length - 44));
                    bw.Write(opus.ToArray());

                    WavStreamLengths[indices[i]] = Convert.ToUInt32(wav.Length - 44 + RiffOpusOffsets[indices[i]]);
                    OpusStreamLengths[indices[i]] = Convert.ToUInt32(opus.Length + RiffOpusOffsets[indices[i]]);
                    OpusOffsets[indices[i]] = Convert.ToUInt32(temp);
                }
                else
                {
                    pak.Position = OpusOffsets[indices[i]];
                    var bytes = br.ReadBytes(Convert.ToInt32(OpusStreamLengths[indices[i]]));
                    bw.Write(bytes);
                    OpusOffsets[indices[i]] = Convert.ToUInt32(temp);
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

            for (var i = 0; i < GroupObjs.Count; i++)
            {
                bw.Write(GroupObjs[i].Hash);
                bw.Write(GroupObjs[i].MemberCount);
                for (var e = 0; e < GroupObjs[i].MemberCount; e++)
                {
                    bw.Write(GroupObjs[i].MemberHashes[e]);
                }
            }
            File.WriteAllBytes(Path.Combine(dir.FullName, "sfx_container.opusinfo"), ms.ToArray());
        }
    }
}
