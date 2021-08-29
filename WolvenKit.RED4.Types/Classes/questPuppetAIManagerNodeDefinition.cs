using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPuppetAIManagerNodeDefinition : questDisableableNodeDefinition
	{
		private CArray<questPuppetAIManagerNodeDefinitionEntry> _entries;

		[Ordinal(2)] 
		[RED("entries")] 
		public CArray<questPuppetAIManagerNodeDefinitionEntry> Entries
		{
			get => GetProperty(ref _entries);
			set => SetProperty(ref _entries, value);
		}
	}
}
