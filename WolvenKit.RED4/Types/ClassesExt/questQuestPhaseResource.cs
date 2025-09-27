namespace WolvenKit.RED4.Types;

public partial class questQuestPhaseResource
{
    partial void PostConstruct()
    {
        Graph ??= new CHandle<graphGraphDefinition>() { Chunk = new questGraphDefinition() };
    }
}
