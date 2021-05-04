using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCommunityRegistryItem : CVariable
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

		public worldCommunityRegistryItem(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
