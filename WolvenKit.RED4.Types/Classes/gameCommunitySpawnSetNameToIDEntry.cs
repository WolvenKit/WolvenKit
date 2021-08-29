using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameCommunitySpawnSetNameToIDEntry : RedBaseClass
	{
		private gameCommunityID _communityId;
		private CName _nameReference;

		[Ordinal(0)] 
		[RED("communityId")] 
		public gameCommunityID CommunityId
		{
			get => GetProperty(ref _communityId);
			set => SetProperty(ref _communityId, value);
		}

		[Ordinal(1)] 
		[RED("nameReference")] 
		public CName NameReference
		{
			get => GetProperty(ref _nameReference);
			set => SetProperty(ref _nameReference, value);
		}
	}
}
