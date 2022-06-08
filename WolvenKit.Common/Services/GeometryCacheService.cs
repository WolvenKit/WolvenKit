using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Splat;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.Common.Services
{
    public class GeometryCacheService
    {
        private readonly Dictionary<ulong, Dictionary<ulong, GeometryCacheEntry>> _entries = new();

        private readonly Red4ParserService _parser;
        private readonly IArchiveManager _archive;

        private bool _isLoaded;

        public GeometryCacheService()
        {
            _parser = Locator.Current.GetService<Red4ParserService>();
            _archive = Locator.Current.GetService<IArchiveManager>();
        }

        public void Load()
        {
            _isLoaded = true;
            var file = _archive.Lookup(10378000475152730580);
            if (file.HasValue && file.Value is IGameFile fe)
            {
                using var stream = new MemoryStream();
                fe.Extract(stream);
                using var reader = new BinaryReader(stream);
                var cr2wFile = _parser.ReadRed4File(reader);

                if (cr2wFile.RootChunk is physicsGeometryCache pgc)
                {
                    var totalEntryIndex = 0;
                    for (var sectorIndex = 0; sectorIndex < pgc.BufferTableSectors.Count; sectorIndex++)
                    {
                        var sectorHash = pgc.SectorEntries[sectorIndex].SectorHash;
                        if (!_entries.ContainsKey(sectorHash))
                        {
                            _entries[sectorHash] = new();
                        }

                        if (pgc.BufferTableSectors[sectorIndex].Data is not GeometryCacheBuffer gcb)
                        {
                            continue;
                        }

                        for (var entryIndex = 0; entryIndex < gcb.Entries.Count; entryIndex++)
                        {
                            var entry = pgc.SectorGeometries[totalEntryIndex];
                            ulong entryHash = 0;
                            for (var i = 0; i < 8; i++)
                            {
                                entryHash |= (ulong)entry.Ta[i] << (i * 8);
                            }
                            _entries[sectorHash][entryHash] = gcb.Entries[entryIndex];
                            totalEntryIndex++;
                        }
                    }

                    if (!_entries.ContainsKey(0))
                    {
                        _entries[0] = new();
                    }

                    if (pgc.AlwaysLoadedSectorDDB.Data is not GeometryCacheBuffer algcb)
                    {
                        return;
                    }

                    foreach (var als in algcb.Entries)
                    {
                        var entry = pgc.SectorGeometries[totalEntryIndex];
                        ulong entryHash = 0;
                        for (var i = 0; i < 8; i++)
                        {
                            entryHash |= (ulong)entry.Ta[i] << (i * 8);
                        }
                        _entries[0][entryHash] = als;
                        totalEntryIndex++;
                    }
                }
            }
        }

        public GeometryCacheEntry GetEntry(ulong sectorHash, ulong entryHash)
        {
            if (!_isLoaded)
            {
                Load();
            }
            if (!_entries.ContainsKey(sectorHash))
            {
                return null;
            }
            return _entries[sectorHash].ContainsKey(entryHash)
                ? _entries[sectorHash][entryHash]
                : _entries[0].ContainsKey(entryHash) ? _entries[0][entryHash] : null;
        }
    }
}
