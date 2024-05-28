using System.Collections.Generic;
using System.IO;
using System.Linq;
using CommunityToolkit.Mvvm.ComponentModel;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Services
{
    public partial class LocKeyService : ObservableObject, ILocKeyService
    {
        private readonly Dictionary<EGameLanguage, Dictionary<ulong, localizationPersistenceOnScreenEntry>> _primaryKeys = new();

        private readonly Red4ParserService _parser;
        private readonly IArchiveManager _archive;

        [ObservableProperty] 
        private EGameLanguage _language = EGameLanguage.en_us;

        public LocKeyService(Red4ParserService parser, IArchiveManager archive)
        {
            _parser = parser;
            _archive = archive;
        }

        public bool LoadCurrentLanguage() => LoadLanguage(Language);

        public bool LoadLanguage(EGameLanguage language)
        {
            var gameLanguageCode = Language.ToString().Replace('_', '-');

            _primaryKeys[language] = new Dictionary<ulong, localizationPersistenceOnScreenEntry>();

            var success = InternalLoadLanguage($@"base\localization\{gameLanguageCode}\onscreens\onscreens_final.json");
            InternalLoadLanguage($@"ep1\localization\{gameLanguageCode}\onscreens\onscreens_final.json");

            return success;

            bool InternalLoadLanguage(ResourcePath depotPath)
            {
                var file = _archive.Lookup(depotPath.GetRedHash());
                if (file is { HasValue: true, Value: { } fe })
                {
                    using var stream = new MemoryStream();
                    fe.Extract(stream);
                    using var reader = new BinaryReader(stream);
                    var cr2wFile = _parser.ReadRed4File(reader);

                    if (cr2wFile?.RootChunk is JsonResource json)
                    {
                        if (json.Root.Chunk is localizationPersistenceOnScreenEntries os)
                        {
                            foreach (var entry in os.Entries)
                            {
                                _primaryKeys[language][entry.PrimaryKey] = entry;
                            }

                            return true;
                        }
                    }
                }
                return false;
            }
        }

        private bool IsLoaded() => _primaryKeys.ContainsKey(Language) || LoadCurrentLanguage();

        public List<string> GetSecondaryKeys()
        {
            if (!IsLoaded())
            {
                return new List<string>();
            }
            return _primaryKeys[Language].Values.Select(x => x.SecondaryKey.GetString()).ToList();
        }

        public IEnumerable<localizationPersistenceOnScreenEntry> GetEntries()
        {
            if (!IsLoaded())
            {
                return new List<localizationPersistenceOnScreenEntry>();
            }
            return _primaryKeys[Language].Values;
        }

        public localizationPersistenceOnScreenEntry? GetEntry(ulong key)
        {
            if (!IsLoaded())
            {
                return null;
            }

            return _primaryKeys[Language].TryGetValue(key, out var value) ? value : null;
        }

        public localizationPersistenceOnScreenEntry? GetEntry(string key)
        {
            if (!IsLoaded())
            {
                return null;
            }

            return _primaryKeys[Language].Values.FirstOrDefault(x => x.SecondaryKey == key);
        }

        public string? GetFemaleVariant(ulong key) => GetEntry(key)?.FemaleVariant;

        public string? GetFemaleVariant(string key) => GetEntry(key)?.FemaleVariant;

        public string? GetMaleVariant(ulong key) => GetEntry(key)?.MaleVariant;

        public string? GetMaleVariant(string key) => GetEntry(key)?.MaleVariant;
    }
}
