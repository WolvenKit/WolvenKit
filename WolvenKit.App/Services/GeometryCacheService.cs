using System;
using System.Collections.Generic;
using System.IO;
using WolvenKit.App.Helpers;
using WolvenKit.App.Models;
using WolvenKit.Common;
using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.CR2W;
using WolvenKit.RED4.Types;

namespace WolvenKit.App.Services
{
    public class GeometryCacheService
    {
        private readonly Dictionary<ulong, Dictionary<ulong, SimpleGeometryCacheEntry>> _entries = new();

        private readonly Red4ParserService _parser;
        private readonly IArchiveManager _archive;

        private readonly CName _cachePath = (CName)@"base\worlds\03_night_city\sectors\_generated\collisions\03_night_city.geometry_cache";
        private bool _isLoaded;

        public GeometryCacheService(IArchiveManager archive, Red4ParserService parser)
        {
            _archive = archive;
            _parser = parser;
        }

        public void Load()
        {
            _isLoaded = true;
            var file = _archive.Lookup(_cachePath.GetRedHash());
            if (file.HasValue && file.Value is IGameFile fe)
            {
                using var stream = new MemoryStream();
                fe.Extract(stream);
                using var reader = new BinaryReader(stream);
                var cr2wFile = _parser.ReadRed4File(reader, false);

                if (cr2wFile?.RootChunk is physicsGeometryCache pgc)
                {
                    var totalEntryIndex = 0;
                    for (var sectorIndex = 0; sectorIndex < pgc.BufferTableSectors.Count; sectorIndex++)
                    {
                        if (pgc.SectorEntries == null || pgc.SectorEntries.Count <= sectorIndex || pgc.SectorEntries[sectorIndex] == null)
                        {
                            throw new ArgumentNullException();
                        }

                        var sectorHash = pgc.SectorEntries[sectorIndex]!.SectorHash;
                        if (!_entries.ContainsKey(sectorHash))
                        {
                            _entries[sectorHash] = new();
                        }

                        if (pgc.BufferTableSectors == null || pgc.BufferTableSectors.Count <= sectorIndex || pgc.BufferTableSectors[sectorIndex] == null)
                        {
                            throw new ArgumentNullException();
                        }

                        var gcb = GeometryCacheReaderLite.ReadBuffer(pgc.BufferTableSectors[sectorIndex]!.Buffer);

                        for (var entryIndex = 0; entryIndex < gcb.Entries.Count; entryIndex++)
                        {
                            if (pgc.SectorGeometries == null || pgc.SectorGeometries.Count <= totalEntryIndex || pgc.SectorGeometries[totalEntryIndex] == null)
                            {
                                throw new ArgumentNullException();
                            }

                            var entry = pgc.SectorGeometries[totalEntryIndex]!;
                            ulong entryHash = 0;
                            for (var i = 0; i < 8; i++)
                            {
                                entryHash |= (ulong)entry.Ta[i] << (i * 8);
                            }

                            if (gcb.Entries == null || gcb.Entries.Count <= entryIndex)
                            {
                                throw new ArgumentNullException();
                            }

                            _entries[sectorHash][entryHash] = gcb.Entries[entryIndex]!;
                            totalEntryIndex++;
                        }
                    }

                    if (!_entries.ContainsKey(0))
                    {
                        _entries[0] = new();
                    }

                    var algcb = GeometryCacheReaderLite.ReadBuffer(pgc.AlwaysLoadedSectorDDB.Buffer);

                    foreach (var als in algcb.Entries)
                    {
                        if (pgc.SectorGeometries == null || pgc.SectorGeometries.Count <= totalEntryIndex || pgc.SectorGeometries[totalEntryIndex] == null)
                        {
                            throw new ArgumentNullException();
                        }

                        var entry = pgc.SectorGeometries[totalEntryIndex];
                        ulong entryHash = 0;
                        for (var i = 0; i < 8; i++)
                        {
                            entryHash |= (ulong)entry!.Ta[i] << (i * 8);
                        }
                        _entries[0][entryHash] = als;
                        totalEntryIndex++;
                    }
                }
            }
        }

        public SimpleGeometryCacheEntry? GetEntry(ulong sectorHash, ulong entryHash)
        {
            if (!_isLoaded)
            {
                Load();
            }
            if (!_entries.ContainsKey(sectorHash))
            {
                return null;
            }
            if (_entries[sectorHash].ContainsKey(entryHash))
            {
                return _entries[sectorHash][entryHash];
            }
            if (_entries[0].ContainsKey(entryHash))
            {
                return _entries[0][entryHash];
            }
            return null;
        }
    }
}
