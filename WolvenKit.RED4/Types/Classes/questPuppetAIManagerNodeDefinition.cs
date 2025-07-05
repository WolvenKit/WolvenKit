using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPuppetAIManagerNodeDefinition : questDisableableNodeDefinition
	{
		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<questPuppetAIManagerNodeDefinitionEntry> Entries
		{
			get => GetPropertyValue<CArray<questPuppetAIManagerNodeDefinitionEntry>>();
			set => SetPropertyValue<CArray<questPuppetAIManagerNodeDefinitionEntry>>(value);
		}

		public questPuppetAIManagerNodeDefinition()
		{
			Sockets = new();
			Id = ushort.MaxValue;
			Entries = new() { new questPuppetAIManagerNodeDefinitionEntry() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
