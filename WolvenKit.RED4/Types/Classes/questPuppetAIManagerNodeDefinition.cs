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
			Id = 65535;
			Entries = new() { new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
