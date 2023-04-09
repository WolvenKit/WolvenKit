using WolvenKit.Core.Interfaces;
using WolvenKit.RED4.Archive.Buffer;
using WolvenKit.RED4.Types;

namespace WolvenKit.RED4.Archive.IO.PreProcessor;

public class appearanceAppearanceDefinitionPreProcessor : IPreProcessor
{
    private readonly ILoggerService? _loggerService;

    public appearanceAppearanceDefinitionPreProcessor(ILoggerService? loggerService) => _loggerService = loggerService;

    public void Process(RedBaseClass cls)
    {
        var appearanceAppearanceDefinition = (appearanceAppearanceDefinition)cls;

        if (appearanceAppearanceDefinition.Components is { Count: > 0 } &&
            appearanceAppearanceDefinition.CompiledData?.Buffer.Data == null)
        {
            appearanceAppearanceDefinition.CompiledData = new SerializationDeferredDataBuffer
            {
                Buffer =
                {
                    Data = new RedPackage(),
                    Parent = appearanceAppearanceDefinition
                }
            };
        }
    }
}