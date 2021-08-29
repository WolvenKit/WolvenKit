using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questJournalNodeDefinition : questDisableableNodeDefinition
	{
		private CHandle<questIJournal_NodeType> _type;

		[Ordinal(2)] 
		[RED("type")] 
		public CHandle<questIJournal_NodeType> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}
	}
}
