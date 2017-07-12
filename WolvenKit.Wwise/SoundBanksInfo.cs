using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace WolvenKit.Cache
{
    public class SoundBanksInfo
    {
        public string PlatForm;
        public string SchemaVersion;
        public Dictionary<string, string> RootPaths = new Dictionary<string, string>();
        //<DialogueEvents />
        public List<SoundBankFile> StreamedFiles = new List<SoundBankFile>(); 
        public List<SoundBank> Banks = new List<SoundBank>(); 
        
        public SoundBanksInfo(string fileName)
        {
            XDocument file = XDocument.Load(fileName);
            PlatForm = file.Root?.Attribute("Platform")?.Value;
            SchemaVersion = file.Root?.Attribute("SchemaVersion")?.Value;
            file.Root?.Element("RootPaths")?.Elements().ToList().ForEach(x=> RootPaths.Add(x.Name.LocalName,x.Value));
            file.Root?.Element("StreamedFiles")?.Elements().ToList().ForEach(x => StreamedFiles.Add(new SoundBankFile(x)));
            file.Root?.Element("SoundBanks")?.Elements().ToList().ForEach(x => Banks.Add(new SoundBank(x)));
        }

        public void Save(string path)
        {
            //TODO: Save with the new files. This needs to be designed well so we can add new sounds easily.
        }

        public void AddStreamedFile(params string[] Files)
        {
            //TODO: Figure this out
        }

        public void AddBank()
        {
            //TODO: Complete this.
        }

        public void CreatePlaylist(params string[] Files)
        {
            //TODO: Figure this out.
        }
    }

    public class SoundBankFile
    {
        public string Id;
        public string Language;
        public string ShortName;
        public string Path;

        public SoundBankFile(XElement elem)
        {
            Id = elem.Attribute("Id")?.Value;
            Language = elem.Attribute("Language")?.Value;
            ShortName = elem.Element("ShortName")?.Value;
            Path = elem.Element("Path")?.Value;
        }

    }

    public class SoundBank
    {
        public string Id;
        public string Language;
        public string ShortName;
        public string Path;
        public Dictionary<string, string> IncludedEvents = new Dictionary<string, string>();
        //	<IncludedDialogueEvents />
        public List<SoundBankFile> ReferencedStreamedFiles = new List<SoundBankFile>();
        public List<SoundBankFile> IncludedFullFiles = new List<SoundBankFile>();
        public List<SoundBankFile> IncludedPrefetchFiles = new List<SoundBankFile>();
        // <ExternalSources />

        public SoundBank(XElement elem)
        {
            Id = elem.Attribute("Id")?.Value;
            Language = elem.Attribute("Language")?.Value;
            ShortName = elem.Element("ShortName")?.Value;
            Path = elem.Element("Path")?.Value;
            elem.Element("IncludedEvents")?.Elements("Event").ToList().ForEach(x=> IncludedEvents.Add(x.Attribute("Id")?.Value ?? "",x.Attribute("Name")?.Value));
            //	<IncludedDialogueEvents />
            elem.Element("ReferencedStreamedFiles")?.Elements().ToList().ForEach(x => ReferencedStreamedFiles.Add(new SoundBankFile(x)));
            elem.Element("IncludedFullFiles")?.Elements().ToList().ForEach(x => IncludedFullFiles.Add(new SoundBankFile(x)));
            elem.Element("IncludedPrefetchFiles")?.Elements().ToList().ForEach(x => IncludedPrefetchFiles.Add(new SoundBankFile(x)));
            // <ExternalSources />
        }
    }
}
