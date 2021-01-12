using System;
using System.Collections.Generic;
using System.IO;
using ProtoBuf;
using WolvenKit.Common;

namespace WolvenKit.W3Strings
{
    [ProtoContract]
    public class W3StringManager
    {
        #region Proto
        [ProtoMember(1)]
        public Dictionary<uint, ProtoList<W3StringBlock1>> ProtoLines
        {
            get
            {
                var ret = new Dictionary<uint, ProtoList<W3StringBlock1>>();
                if (Lines != null)
                {
                    foreach (var line in Lines)
                    {
                        var bloc = new ProtoList<W3StringBlock1>();
                        bloc.innerlist = line.Value;
                        ret.Add(line.Key,bloc);
                    }
                }
                return ret;
            }
            set
            {
                if(Lines == null)
                    Lines = new Dictionary<uint, List<W3StringBlock1>>();
                Lines.Clear();
                foreach (var protoLine in ProtoLines)
                {
                    Lines.Add(protoLine.Key,protoLine.Value.innerlist);
                }
            }
        }
        [ProtoMember(2)]
        private List<ProtoList<string>> ProtiomportedStrings
        {
            get
            {
                var ret = new List<ProtoList<string>>();
                if (importedStrings != null)
                {
                    foreach (var protostring in importedStrings)
                    {
                        var bloc = new ProtoList<string>();
                        bloc.innerlist = protostring;
                        ret.Add(bloc);
                    }
                }
                return ret;
            }
            set
            {
                if(importedStrings == null)
                    importedStrings = new List<List<string>>();
                importedStrings.Clear();
                foreach (var protostring in ProtiomportedStrings)
                {
                    importedStrings.Add(protostring.innerlist);
                }
            }
        }
        #endregion

        [ProtoMember(3)]
        public Dictionary<uint, List<W3StringBlock1>> Lines { get; private set; }
        [ProtoMember(4)]
        public Dictionary<uint, bool> Keys { get; private set; }
        [ProtoMember(5)]
        public string Language { get; private set; }

        private List<List<string>> importedStrings = new List<List<string>>();

        public static string SerializationVersion => "1.0";

        public void Load(string newlanguage, string path, bool onlyIfLanguageChanged = false)
        {
            if (onlyIfLanguageChanged && Language == newlanguage)
                return;

            Language = newlanguage;
            Lines = new Dictionary<uint, List<W3StringBlock1>>();
            Keys = new Dictionary<uint, bool>();

            var exedir = path;
            var content = Path.Combine(exedir, @"..\..\content\");
            foreach (var dir in GetdirectoriesDebug(content, "content*"))
            {
                var strs = Directory.GetFiles(dir, Language + ".w3strings");
                foreach (var file in strs)
                {
                    OpenFile(file);
                }
            }

            var patch = Path.Combine(exedir, @"..\..\content\");
            foreach (var dir in GetdirectoriesDebug(patch, "patch*"))
            {
                var strs = Directory.GetFiles(dir, Language + ".w3strings");
                foreach (var file in strs)
                {
                    OpenFile(file);
                }
            }

            var dlc = Path.Combine(exedir, @"..\..\DLC\");
            try
            {
                foreach (var dir in Directory.GetDirectories(dlc))
                {
                    var strs = GetdirectoriesDebug(dir, Language + ".w3strings", SearchOption.AllDirectories);
                    foreach (var file in strs)
                    {
                        OpenFile(file);
                    }
                }
            }
            catch(DirectoryNotFoundException)
            {
                Directory.CreateDirectory(dlc);
            }
        }

        private void OpenFile(string filename)
        {
            var file = new W3StringFile();
            try
            {
                var stream = new BinaryReader(new FileStream(filename, FileMode.Open, FileAccess.Read));
                file.Read(stream);
                stream.Close();
            }
            catch (Exception)
            {
                return;
            }

            foreach (var item in file.block1)
            {
                if (!Lines.ContainsKey(item.str_id))
                {
                    Lines.Add(item.str_id, new List<W3StringBlock1>());
                }
                Lines[item.str_id].Add(item);
            }


            foreach (var item in file.block2)
            {
                if (!Keys.ContainsKey(item.str_id))
                {
                    Keys.Add(item.str_id, true);
                }
            }
        }

        public string GetString(uint id)
        {
            if (Lines != null  && Lines.ContainsKey(id))
            {
                var list = Lines[id];
                return list[list.Count - 1].str;
            }

            return null;
        }

        public void SaveImportedStrings(List<List<string>> strings)
        {
            foreach (var str in strings)
                importedStrings.Add(str);
        }

        public List<List<string>> GetImportedStrings()
        {
            return importedStrings;
        }

        public void ClearImportedStrings()
        {
            importedStrings.Clear();
        }

        public void Test()
        {
            importedStrings.Add(new List<string>() { "0", "0", "0" });
        }

        public string[] GetdirectoriesDebug(string s, string k,SearchOption so = SearchOption.TopDirectoryOnly)
        {
            return Directory.GetDirectories(s, k,so);
        }
    }
}