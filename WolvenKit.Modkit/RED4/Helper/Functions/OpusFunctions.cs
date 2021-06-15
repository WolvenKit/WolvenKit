using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;
using Newtonsoft.Json;
using WolvenKit.RED4.CR2W.Archive;
using WolvenKit.Common.FNV1A;

namespace WolvenKit.Modkit.RED4.Opus
{
    public class OpusTools
    {
        private readonly Archive _soundBanks;
        private readonly DirectoryInfo _modFolder;
        private readonly DirectoryInfo _rawFolder;
        private OpusInfo _info;
        private readonly bool _isModded;
        public OpusTools(Archive soundbanks, string modFolder, string rawFolder,bool useMod = false) //audio_2_soundbanks.archive
        {
            _soundBanks = soundbanks;
            _modFolder = new DirectoryInfo(modFolder);
            _rawFolder = new DirectoryInfo(rawFolder);
            _isModded = useMod;
            if (_isModded)
            {
                string infoFile = Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks\\sfx_container.opusinfo");
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
                        _info = new OpusInfo(ms);
                    }
                }
                else
                    _isModded = false;
            }
            if (!_isModded)
            {
                ulong hash = FNV1A64HashAlgorithm.HashString("base\\sound\\soundbanks\\sfx_container.opusinfo");
                var ms = new MemoryStream();
                ModTools.ExtractSingleToStream(_soundBanks, hash, ms);
                _info = new OpusInfo(ms);
            }
        }
        public bool ExportOpusUsingHash(UInt32 opusHash)
        {
            if (!_isModded)
            {
                for (UInt32 i = 0; i < _info.OpusCount; i++)
                {
                    if (_info.OpusHashes[i] == opusHash)
                    {
                        ulong containerHash = FNV1A64HashAlgorithm.HashString("base\\sound\\soundbanks\\sfx_container_" + _info.PackIndices[i] + ".opuspak");
                        var ms = new MemoryStream();
                        ModTools.ExtractSingleToStream(_soundBanks, containerHash, ms);
                        _info.WriteOpusFromPak(ms, _rawFolder, i);
                        return true;
                    }
                    if (_info.OpusCount == i + 1)
                        return false;
                }
            }
            else
            {
                for (UInt32 i = 0; i < _info.OpusCount; i++)
                {
                    if (_info.OpusHashes[i] == opusHash)
                    {
                        string pakFile = Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks\\sfx_container_" + _info.PackIndices[i] + ".opuspak");
                        if (File.Exists(pakFile))
                        {
                            var ms = new MemoryStream(File.ReadAllBytes(pakFile));
                            _info.WriteOpusFromPak(ms, _rawFolder, i);
                            return true;
                        }
                        else
                            return false;
                    }
                    if (_info.OpusCount == i + 1)
                        return false;
                }
            }
            return false;
        }
        public bool DumpAllOpusInfo()
        {
            string s = JsonConvert.SerializeObject(_info, Formatting.Indented);
            File.WriteAllText(Path.Combine(_rawFolder.FullName, "sfx_container.opusinfo.json"), s);
            return true;
        }
        public bool ImportWavs()
        {
            var wavFiles = Directory.GetFiles(_rawFolder.FullName, "*.wav");
            if (wavFiles.Length < 1)
                return false;
            List<UInt32> foundids = new List<UInt32>();
            foreach (string wav in wavFiles)
            {
                try
                {
                    UInt32 idddd = Convert.ToUInt32(Path.GetFileNameWithoutExtension(wav));
                    foundids.Add(idddd);
                }
                catch{ }
            }

            List<UInt32> validids = new List<UInt32>();
            for (int i = 0; i < foundids.Count; i++)
            {
                for (int e = 0; e < _info.OpusCount; e++)
                {
                    if (_info.OpusHashes[e] == foundids[i])
                    {
                        validids.Add(foundids[i]);
                        break;
                    }
                }
            }
            if (validids.Count < 1)
                return false;

            Stream[] modStreams = new Stream[_info.PackIndices[_info.OpusCount - 1] + 1];

            for (int i = 0; i < validids.Count; i++)
            {
                string name = Path.Combine(_rawFolder.FullName, Convert.ToString(validids[i]) + ".opus");
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
                    for (int e = 0; e < _info.OpusCount; e++)
                    {
                        if (validids[i] == _info.OpusHashes[e])
                        {
                            int pakIdx = _info.PackIndices[e];
                            if(modStreams[pakIdx] == null)
                            {
                                string pakName = "base\\sound\\soundbanks\\sfx_container_" + pakIdx + ".opuspak";
                                if (_isModded && File.Exists(Path.Combine(_modFolder.FullName, pakName)))
                                    modStreams[pakIdx] = new MemoryStream(File.ReadAllBytes(Path.Combine(_modFolder.FullName, pakName)));
                                else
                                {
                                    ulong containerHash = FNV1A64HashAlgorithm.HashString(pakName);
                                    modStreams[pakIdx] = new MemoryStream();
                                    ModTools.ExtractSingleToStream(_soundBanks, containerHash, modStreams[pakIdx]);
                                }
                            }
                            _info.WriteOpusToPak(new MemoryStream(File.ReadAllBytes(name)), ref modStreams[pakIdx], validids[i], new MemoryStream(File.ReadAllBytes(name.Replace("opus", "wav"))));
                        }
                    }
                }
            }

            bool writeinfo = false;
            for (int i = 0; i < modStreams.Length; i++)
            {
                if(modStreams[i] != null)
                {
                    string pakName = "base\\sound\\soundbanks\\sfx_container_" + i + ".opuspak";
                    var temp = modStreams[i];
                    temp.Position = 0;
                    byte[] bytes = new byte[temp.Length];
                    temp.Read(bytes, 0, Convert.ToInt32(temp.Length));
                    File.WriteAllBytes(Path.Combine(_modFolder.FullName, pakName), bytes);
                    writeinfo = true;
                }
            }
            if (writeinfo)
            {
                _info.WriteOpusInfo(new DirectoryInfo(Path.Combine(_modFolder.FullName, "base\\sound\\soundbanks")));

                return true;
            }

            return false;
        }
    }
    class OpusInfo
    {
        //  S       N       D   ?....
        public byte[] Header { get; } = { 0x53, 0x4E, 0x44, 0x20, 0x02, 0x00, 0x00, 0xF0, 0x00, 0x00, 0x00, 0x00 };
        public UInt32 OpusCount { get; set; }
        public UInt32 GroupingObjSize4x { get; set; }
        public UInt32[] OpusHashes { get; set; }
        public UInt16[] PackIndices { get; set; }
        public UInt32[] OpusOffsets { get; set; }
        public UInt16[] RiffOpusOffsets { get; set; }
        public UInt32[] OpusStreamLengths { get; set; }
        public UInt32[] WavStreamLengths { get; set; }
        public List<Group> GroupObjs { get; set; }
        public class Group
        {
            public UInt32 Hash { get; set; }
            public UInt32 MemberCount { get; set; }
            public UInt32[] MemberHashes { get; set; }
        }
        public OpusInfo(Stream ms)
        {
            ms.Position = 0;
            BinaryReader br = new BinaryReader(ms);
            Header = br.ReadBytes(12);

            ms.Position = 0xc;
            OpusCount = br.ReadUInt32();
            GroupingObjSize4x = br.ReadUInt32();

            OpusHashes = new UInt32[OpusCount];
            for (int i = 0; i < OpusCount; i++)
            {
                OpusHashes[i] = br.ReadUInt32();
            }

            PackIndices = new UInt16[OpusCount];
            for (int i = 0; i < OpusCount; i++)
            {
                PackIndices[i] = br.ReadUInt16();
            }

            OpusOffsets = new UInt32[OpusCount];
            for (int i = 0; i < OpusCount; i++)
            {
                OpusOffsets[i] = br.ReadUInt32();
            }

            RiffOpusOffsets = new UInt16[OpusCount];
            for (int i = 0; i < OpusCount; i++)
            {
                RiffOpusOffsets[i] = br.ReadUInt16();
            }

            OpusStreamLengths = new UInt32[OpusCount];
            for (int i = 0; i < OpusCount; i++)
            {
                OpusStreamLengths[i] = br.ReadUInt32();
            }

            WavStreamLengths = new UInt32[OpusCount];
            for (int i = 0; i < OpusCount; i++)
            {
                WavStreamLengths[i] = br.ReadUInt32();
            }
            GroupObjs = new List<Group>();
            while (ms.Position < ms.Length)
            {
                Group group = new Group();
                group.Hash = br.ReadUInt32();
                group.MemberCount = br.ReadUInt32();
                group.MemberHashes = new UInt32[group.MemberCount];
                for (UInt32 i = 0; i < group.MemberCount; i++)
                {
                    group.MemberHashes[i] = br.ReadUInt32();
                }
                GroupObjs.Add(group);
            }
        }
        public void WriteAllOpusFromPaks(Stream[] opuspaks, DirectoryInfo outdir) // thou shall not be used
        {
            BinaryReader[] brs = new BinaryReader[opuspaks.Length];
            for (int i = 0; i < opuspaks.Length; i++)
            {
                brs[i] = new BinaryReader(opuspaks[i]);
            }
            for (UInt32 i = 0; i < OpusCount; i++)
            {
                opuspaks[PackIndices[i]].Position = OpusOffsets[i] + RiffOpusOffsets[i];
                byte[] bytes = brs[PackIndices[i]].ReadBytes(Convert.ToInt32(OpusStreamLengths[i] - RiffOpusOffsets[i]));
                string name = OpusHashes[i] + ".opus";
                File.WriteAllBytes(Path.Combine(outdir.FullName, name), bytes);
            }
        }
        public void WriteOpusFromPak(Stream opuspak, DirectoryInfo outdir,UInt32 index)
        {
            BinaryReader br = new BinaryReader(opuspak);
            opuspak.Position = OpusOffsets[index] + RiffOpusOffsets[index];
            byte[] bytes = br.ReadBytes(Convert.ToInt32(OpusStreamLengths[index] - RiffOpusOffsets[index]));
            string name = OpusHashes[index] + ".opus";
            string path = Path.Combine(outdir.FullName, name);
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
        public void WriteOpusToPak(MemoryStream opus, ref Stream pak, UInt32 hash, MemoryStream wav)
        {
            BinaryReader br = new BinaryReader(pak);
            pak.Position = 0;
            int index = 0;
            for (int i = 0; i < OpusCount; i++)
            {
                if (hash == OpusHashes[i])
                    index = i;
            }
            int pakIdx = PackIndices[index];
            List<int> indices = new List<int>();
            for (int i = 0; i < OpusCount; i++)
            {
                if (pakIdx == PackIndices[i])
                    indices.Add(i);
            }

            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);
            ms.Position = 0;
            for (int i = 0; i < indices.Count; i++)
            {
                UInt32 temp = Convert.ToUInt32(ms.Position);
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
            MemoryStream ms = new MemoryStream();
            BinaryWriter bw = new BinaryWriter(ms);

            bw.Write(Header);
            bw.Write(OpusCount);
            bw.Write(GroupingObjSize4x);
            for (int i = 0; i < OpusCount; i++)
            {
                bw.Write(OpusHashes[i]);
            }
            for (int i = 0; i < OpusCount; i++)
            {
                bw.Write(PackIndices[i]);
            }
            for (int i = 0; i < OpusCount; i++)
            {
                bw.Write(OpusOffsets[i]);
            }
            for (int i = 0; i < OpusCount; i++)
            {
                bw.Write(RiffOpusOffsets[i]);
            }
            for (int i = 0; i < OpusCount; i++)
            {
                bw.Write(OpusStreamLengths[i]);
            }
            for (int i = 0; i < OpusCount; i++)
            {
                bw.Write(WavStreamLengths[i]);
            }

            for (int i = 0; i < GroupObjs.Count; i++)
            {
                bw.Write(GroupObjs[i].Hash);
                bw.Write(GroupObjs[i].MemberCount);
                for (int e = 0; e < GroupObjs[i].MemberCount; e++)
                {
                    bw.Write(GroupObjs[i].MemberHashes[e]);
                }
            }
            File.WriteAllBytes(Path.Combine(dir.FullName, "sfx_container.opusinfo"), ms.ToArray());
        }
    }
}
