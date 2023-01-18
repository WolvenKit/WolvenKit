using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIUseWorkspotCommand : AIBaseUseWorkspotCommand
	{
		[Ordinal(11)] 
		[RED("workspotNode")] 
		public NodeRef WorkspotNode
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(12)] 
		[RED("jumpToEntry")] 
		public CBool JumpToEntry
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(13)] 
		[RED("entryId")] 
		public workWorkEntryId EntryId
		{
			get => GetPropertyValue<workWorkEntryId>();
			set => SetPropertyValue<workWorkEntryId>(value);
		}

		[Ordinal(14)] 
		[RED("entryTag")] 
		public CName EntryTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public AIUseWorkspotCommand()
		{
			WorkExcludedGestures = new();
			InfiniteSequenceEntryId = new() { Id = 4294967295 };
			EntryId = new() { Id = 4294967295 };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
