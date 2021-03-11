using System;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Linq;

namespace WolvenKit.Wwise
{
    public class SoundBank
    {
        #region Fields

        public List<Tuple<string, string>> ExternalSources = new List<Tuple<string, string>>();
        public string Id;
        public Dictionary<string, string> IncludedEvents = new Dictionary<string, string>();
        public List<SoundBankFile> IncludedFullFiles = new List<SoundBankFile>();
        public List<SoundBankFile> IncludedPrefetchFiles = new List<SoundBankFile>();
        public string Language;
        public string Path;

        //	<IncludedDialogueEvents />
        public List<SoundBankFile> ReferencedStreamedFiles = new List<SoundBankFile>();

        public string ShortName;

        #endregion Fields

        #region Constructors

        public SoundBank()
        {
        }

        public SoundBank(XElement elem)
        {
            Id = elem.Attribute("Id")?.Value;
            Language = elem.Attribute("Language")?.Value;
            ShortName = elem.Element("ShortName")?.Value;
            Path = elem.Element("Path")?.Value;
            elem.Element("IncludedEvents")?.Elements("Event").ToList().ForEach(x => IncludedEvents.Add(x.Attribute("Id")?.Value ?? "", x.Attribute("Name")?.Value));
            //	<IncludedDialogueEvents />
            elem.Element("ReferencedStreamedFiles")?.Elements().ToList().ForEach(x => ReferencedStreamedFiles.Add(new SoundBankFile(x)));
            elem.Element("IncludedFullFiles")?.Elements().ToList().ForEach(x => IncludedFullFiles.Add(new SoundBankFile(x)));
            elem.Element("IncludedPrefetchFiles")?.Elements().ToList().ForEach(x => IncludedPrefetchFiles.Add(new SoundBankFile(x)));
            elem.Element("ExternalSources")?.Elements().ToList().ForEach(x => ExternalSources.Add(new Tuple<string, string>(x.Attribute("Id").Value, x.Attribute("Name").Value)));
        }

        #endregion Constructors

        #region Properties

        public XElement xElement
        {
            get
            {
                var elem = new XElement("SoundBank", new XAttribute("Id", Id), new XAttribute("Language", Language));
                elem.Add(new XElement("ShortName", ShortName));
                elem.Add(new XElement("Path", Path));
                elem.Add(new XElement("IncludedEvents", IncludedEvents.Select(x => new XElement("Event", new XAttribute("Id", x.Key), new XAttribute("Name", x.Value)))));
                elem.Add(new XElement("IncludedDialogueEvents"));
                elem.Add(new XElement("ReferencedStreamedFiles", ReferencedStreamedFiles.Select(x => x.xElement)));
                elem.Add(new XElement("IncludedFullFiles", IncludedFullFiles.Select(x => x.xElement)));
                elem.Add(new XElement("IncludedPrefetchFiles", IncludedPrefetchFiles.Select(x => x.xElement)));
                elem.Add(new XElement("ExternalSources", ExternalSources.Select(x => new XElement("Source", new XAttribute("Id", x.Item1), new XAttribute("Name", x.Item2)))));
                return elem;
            }
        }

        #endregion Properties
    }

    public class SoundBankFile
    {
        #region Fields

        public string Id;
        public string Language;
        public string Path;
        public string PrefetchMilliseconds;
        public string ShortName;

        #endregion Fields

        #region Constructors

        public SoundBankFile()
        {
        }

        public SoundBankFile(XElement elem)
        {
            Id = elem.Attribute("Id")?.Value;
            Language = elem.Attribute("Language")?.Value;
            ShortName = elem.Element("ShortName")?.Value;
            PrefetchMilliseconds = elem.Attribute("PrefetchMilliseconds")?.Value;
            Path = elem.Element("Path")?.Value;
        }

        #endregion Constructors

        #region Properties

        public XElement xElement
        {
            get
            {
                var elem = new XElement("File");
                if (Id != null)
                    elem.Add(new XAttribute("Id", Id));
                if (Language != null)
                    elem.Add(new XAttribute("Language", Language));
                if (PrefetchMilliseconds != null)
                    elem.Add(new XAttribute("PrefetchMilliseconds", PrefetchMilliseconds));
                if (!string.IsNullOrEmpty(ShortName))
                    elem.Add(new XElement("ShortName", ShortName));
                if (!string.IsNullOrEmpty(Path))
                    elem.Add(new XElement("Path", Path));
                return elem;
            }
        }

        #endregion Properties
    }

    public class SoundBanksInfoXML
    {
        #region Fields

        public List<SoundBank> Banks = new List<SoundBank>();
        public string PlatForm;
        public Dictionary<string, string> RootPaths = new Dictionary<string, string>();
        public string SchemaVersion;

        //<DialogueEvents />
        public List<SoundBankFile> StreamedFiles = new List<SoundBankFile>();

        #endregion Fields



        #region Constructors

        public SoundBanksInfoXML(string fileName)
        {
            XDocument file = XDocument.Load(fileName);
            PlatForm = file.Root?.Attribute("Platform")?.Value;
            SchemaVersion = file.Root?.Attribute("SchemaVersion")?.Value;
            file.Root?.Element("RootPaths")?.Elements().ToList().ForEach(x => RootPaths.Add(x.Name.LocalName, x.Value));
            file.Root?.Element("StreamedFiles")?.Elements().ToList().ForEach(x => StreamedFiles.Add(new SoundBankFile(x)));
            file.Root?.Element("SoundBanks")?.Elements().ToList().ForEach(x => Banks.Add(new SoundBank(x)));
        }

        #endregion Constructors

        #region Methods

        public void AddBank()
        {
            //TODO: Complete this.
        }

        public void AddStreamedFile(params string[] Files)
        {
            //TODO: Complete this.
        }

        public void CreatePlaylist(params string[] Files)
        {
            //TODO: Figure this out.
        }

        public void Save(string path)
        {
            var root = new XElement("SoundBanksInfo", new XAttribute("Platform", PlatForm), new XAttribute("SchemaVersion", SchemaVersion));
            root.Add(new XElement("RootPaths", RootPaths.Select(x => new XElement(x.Key, x.Value))));
            root.Add(new XElement("DialogueEvents"));
            root.Add(new XElement("StreamedFiles", StreamedFiles.Select(x => x.xElement)));
            root.Add(new XElement("SoundBanks", Banks.Select(x => x.xElement)));
            XDocument doc = new XDocument(new XDeclaration("1.0", "utf-8", "yes"), root);
            doc.Save(path);
        }

        #endregion Methods
    }
}
