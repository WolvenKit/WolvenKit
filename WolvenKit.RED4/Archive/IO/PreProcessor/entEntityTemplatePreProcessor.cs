using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO.PreProcessor;

public class entEntityTemplatePreProcessor : IPreProcessor
{
    private readonly ILoggerService? _loggerService;

    public entEntityTemplatePreProcessor(ILoggerService? loggerService) => _loggerService = loggerService;

    public void Process(RedBaseClass cls)
    {
        if (cls is not entEntityTemplate entEntityTemplate)
        {
            return;
        }

        var rp = new RedPackage { Chunks = new List<RedBaseClass>() };

        uint flags = 0;
        if (entEntityTemplate.CompiledData != null)
        {
            flags = entEntityTemplate.CompiledData.Buffer.Flags;
        }

        if (entEntityTemplate.Entity is { Chunk: { } })
        {
            rp.Chunks.Add(entEntityTemplate.Entity);
        }

        if (entEntityTemplate.Components != null)
        {
            foreach (var component in entEntityTemplate.Components)
            {
                ArgumentNullException.ThrowIfNull(component);

                rp.Chunks.Add(component);
            }
        }

        if (rp.Chunks.Count > 0)
        {
            entEntityTemplate.CompiledData = new DataBuffer { Data = rp, Buffer = { Parent = entEntityTemplate, Flags = flags } };
        }
    }
}