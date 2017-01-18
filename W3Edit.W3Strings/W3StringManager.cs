using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3Edit.W3Strings
{
    public class W3StringManager
    {
        private Dictionary<UInt32, List<W3StringBlock1>> allLines;
        private Dictionary<UInt32, bool> allKeys;
        private string language;

        public Dictionary<UInt32, List<W3StringBlock1>> Lines { get { return allLines; } }
        public Dictionary<UInt32, bool> Keys { get { return allKeys; } }
        public string Language { get { return language; } }

        public void Load(string newlanguage, string path, bool onlyIfLanguageChanged=false)
        {
            if (onlyIfLanguageChanged && language == newlanguage)
                return;

            language = newlanguage;
            allLines = new Dictionary<uint, List<W3StringBlock1>>();
            allKeys = new Dictionary<uint, bool>();

            var exedir = path;
            var content = Path.Combine(exedir, @"..\..\content\");
            foreach (var dir in Directory.GetDirectories(content, "content*"))
            {
                var strs = Directory.GetFiles(dir, language + ".w3strings");
                foreach (var file in strs)
                {
                    OpenFile(file);
                }
            }

            var patch = Path.Combine(exedir, @"..\..\content\");
            foreach (var dir in Directory.GetDirectories(patch, "patch*"))
            {
                var strs = Directory.GetFiles(dir, language + ".w3strings");
                foreach (var file in strs)
                {
                    OpenFile(file);
                }
            }

            var dlc = Path.Combine(exedir, @"..\..\DLC\");
            foreach (var dir in Directory.GetDirectories(dlc))
            {
                var strs = Directory.GetFiles(dir, language + ".w3strings", SearchOption.AllDirectories);
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
                if (!allLines.ContainsKey(item.str_id))
                {
                    allLines.Add(item.str_id, new List<W3StringBlock1>());
                }
                allLines[item.str_id].Add(item);
            }


            foreach (var item in file.block2)
            {
                if (!allKeys.ContainsKey(item.str_id))
                {
                    allKeys.Add(item.str_id, true);
                }
            }
        }

        public string GetString(UInt32 id)
        {
            if (allLines.ContainsKey(id))
            {
                var list = allLines[id];
                return list[list.Count - 1].str;
            }

            return null;
        }
    }
}
