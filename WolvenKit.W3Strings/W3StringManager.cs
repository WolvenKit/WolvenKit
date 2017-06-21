using System;
using System.Collections.Generic;
using System.IO;

namespace WolvenKit.W3Strings
{
    public class W3StringManager
    {
        public Dictionary<uint, List<W3StringBlock1>> Lines { get; private set; }
        public Dictionary<uint, bool> Keys { get; private set; }
        public string Language { get; private set; }

        private List<List<string>> importedStrings = new List<List<string>>();

        public void Load(string newlanguage, string path, bool onlyIfLanguageChanged = false)
        {
            if (onlyIfLanguageChanged && Language == newlanguage)
                return;

            Language = newlanguage;
            Lines = new Dictionary<uint, List<W3StringBlock1>>();
            Keys = new Dictionary<uint, bool>();

            var exedir = path;
            var content = Path.Combine(exedir, @"..\..\content\");
            foreach (var dir in Directory.GetDirectories(content, "content*"))
            {
                var strs = Directory.GetFiles(dir, Language + ".w3strings");
                foreach (var file in strs)
                {
                    OpenFile(file);
                }
            }

            var patch = Path.Combine(exedir, @"..\..\content\");
            foreach (var dir in Directory.GetDirectories(patch, "patch*"))
            {
                var strs = Directory.GetFiles(dir, Language + ".w3strings");
                foreach (var file in strs)
                {
                    OpenFile(file);
                }
            }

            var dlc = Path.Combine(exedir, @"..\..\DLC\");
            foreach (var dir in Directory.GetDirectories(dlc))
            {
                var strs = Directory.GetFiles(dir, Language + ".w3strings", SearchOption.AllDirectories);
                foreach (var file in strs)
                {
                    OpenFile(file);
                }
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
                //MessageBox.Show(string.Format("There was an error trying to open {0}.", filename), "Opening file failed.");
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
            if (Lines.ContainsKey(id))
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
    }
}