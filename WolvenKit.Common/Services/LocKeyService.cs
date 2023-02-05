using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using WolvenKit.Core.Extensions;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Services
{
    public class LocKeyService : ILocKeyService
    {
        private readonly Dictionary<string, Dictionary<ulong, localizationPersistenceOnScreenEntry>> _primaryKeys = new();
        private readonly Dictionary<string, Dictionary<string, localizationPersistenceOnScreenEntry>> _secondaryKeys = new();

        private readonly Red4ParserService _parser;
        private readonly IArchiveManager _archive;

        public string Language { get; set; } = "en-us";

        public LocKeyService(Red4ParserService parser, IArchiveManager archive)
        {
            _parser = parser;
            _archive = archive;
        }

        public void LoadCurrentLanguage() => (_primaryKeys[Language], _secondaryKeys[Language]) = Load("base\\localization\\en-us\\onscreens\\onscreens_final.json");

        public (Dictionary<ulong, localizationPersistenceOnScreenEntry>,
            Dictionary<string, localizationPersistenceOnScreenEntry>)
            Load(ResourcePath depotPath)
        {
            var primary = new Dictionary<ulong, localizationPersistenceOnScreenEntry>();
            var secondary = new Dictionary<string, localizationPersistenceOnScreenEntry>();
            var file = _archive.Lookup(depotPath.GetRedHash());
            if (file.HasValue && file.Value is IGameFile fe)
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
                            ArgumentNullException.ThrowIfNull(entry);

                            primary[entry.PrimaryKey] = entry;
                            secondary[entry.SecondaryKey] = entry;
                        }
                    }
                }
            }
            return (primary, secondary);
        }

        public List<string> GetSecondaryKeys()
        {
            if (!_secondaryKeys.ContainsKey(Language))
            {
                LoadCurrentLanguage();
            }
            return _secondaryKeys[Language].Keys.ToList();
        }

        public List<localizationPersistenceOnScreenEntry> GetEntries()
        {
            if (!_secondaryKeys.ContainsKey(Language))
            {
                LoadCurrentLanguage();
            }
            return _secondaryKeys[Language].Values.ToList();
        }

        public localizationPersistenceOnScreenEntry? GetEntry(ulong key)
        {
            if (!_primaryKeys.ContainsKey(Language))
            {
                LoadCurrentLanguage();
            }

            if (_primaryKeys.TryGetValue(Language, out var outerdict))
            {
                if (outerdict.TryGetValue(key, out var innerdict))
                {
                    return innerdict;
                }
            }
            return null;
        }

        public localizationPersistenceOnScreenEntry? GetEntry(string key)
        {
            if (!_secondaryKeys.ContainsKey(Language))
            {
                LoadCurrentLanguage();
            }

            if (_secondaryKeys.TryGetValue(Language, out var outerdict))
            {
                if (outerdict.TryGetValue(key, out var innerdict))
                {
                    return innerdict;
                }
            }
            return null;
        }

        public string? GetFemaleVariant(ulong key) => GetEntry(key)?.FemaleVariant;

        public string? GetFemaleVariant(string key) => GetEntry(key)?.FemaleVariant;

        public string? GetMaleVariant(ulong key) => GetEntry(key)?.MaleVariant;

        public string? GetMaleVariant(string key) => GetEntry(key)?.MaleVariant;
    }
}
