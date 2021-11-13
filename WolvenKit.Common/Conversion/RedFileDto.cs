using System.Collections.Generic;
using System.Linq;
using WolvenKit.Common.Model;
using WolvenKit.Common.Tools;
using WolvenKit.RED4.Archive.CR2W;
using WolvenKit.RED4.CR2W;

namespace WolvenKit.Common.Conversion
{
    public class RedFileDto
    {
        public const string Magic = "w2rc";

        public Dictionary<int,RedExportDto> Chunks { get; set; } = new();

        public List<RedBufferDto> Buffers { get; set; } = new();

        public bool ShouldSerializeBuffers() => Buffers is { Count: > 0 };

        public RedFileDto()
        {

        }

        public RedFileDto(IWolvenkitFile cr2w)
        {
            Chunks = cr2w.Chunks.ToDictionary(_ => _.ChunkIndex, _ => new RedExportDto(_));
            Buffers = cr2w.Buffers.Select(_ => new RedBufferDto(_)).ToList();
        }

        public CR2WFile ToW2rc()
        {
            var cr2w = new CR2WFile
            {
                Buffers = Buffers
                    .OrderBy(_ => _.Index)
                    .Select(_ => _.ToRedBuffer())
                    .ToList()
            };

            // chunks
            // order so that parent chunks get created first
            var groupedChunks = Chunks.GroupBy(_ => _.Value.ParentIndex);
            foreach (IGrouping<int, KeyValuePair<int, RedExportDto>> groupedChunk in groupedChunks)
            {
                foreach (var (chunkIndex, chunk) in groupedChunk.OrderBy(_ => _.Key))
                {
                    chunk.CreateChunkInFile(cr2w, chunkIndex);
                }
            }

            return cr2w;
        }
    }
}
