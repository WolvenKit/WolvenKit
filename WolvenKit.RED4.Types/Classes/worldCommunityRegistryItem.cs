using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldCommunityRegistryItem : RedBaseClass
	{
		private CArray<worldCommunityEntryInitialState> _entriesInitialState;
		private CHandle<communityCommunityTemplateData> _template;
		private gameCommunityID _communityId;
		private CBool _communityIsBackground;

		[Ordinal(0)] 
		[RED("entriesInitialState")] 
		public CArray<worldCommunityEntryInitialState> EntriesInitialState
		{
			get => GetProperty(ref _entriesInitialState);
			set => SetProperty(ref _entriesInitialState, value);
		}

		[Ordinal(1)] 
		[RED("template")] 
		public CHandle<communityCommunityTemplateData> Template
		{
			get => GetProperty(ref _template);
			set => SetProperty(ref _template, value);
		}

		[Ordinal(2)] 
		[RED("communityId")] 
		public gameCommunityID CommunityId
		{
			get => GetProperty(ref _communityId);
			set => SetProperty(ref _communityId, value);
		}

		[Ordinal(3)] 
		[RED("communityIsBackground")] 
		public CBool CommunityIsBackground
		{
			get => GetProperty(ref _communityIsBackground);
			set => SetProperty(ref _communityIsBackground, value);
		}
	}
}
