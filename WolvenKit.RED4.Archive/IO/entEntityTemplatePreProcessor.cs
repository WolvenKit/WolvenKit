using System.Collections.Generic;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO
{
    public class entEntityTemplatePreProcessor : IPreProcessor
    {
        public void Process(RedBaseClass cls)
        {
            if (cls is not entEntityTemplate entEntityTemplate)
            {
                return;
            }

            var rp = new RedPackage { Chunks = new List<RedBaseClass>() };

            if (entEntityTemplate.Entity is { Chunk: { } })
            {
                rp.Chunks.Add(entEntityTemplate.Entity);
            }

            if (entEntityTemplate.Components != null)
            {
                foreach (var component in entEntityTemplate.Components)
                {
                    rp.Chunks.Add(component);
                }
            }

            if (rp.Chunks.Count > 0)
            {
                entEntityTemplate.CompiledData = new DataBuffer { Data = rp, Buffer = { Parent = entEntityTemplate } };
            }
        }
    }
}
