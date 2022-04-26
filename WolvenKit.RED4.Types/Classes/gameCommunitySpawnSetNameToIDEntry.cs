using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameCommunitySpawnSetNameToIDEntry : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("communityId")] 
		public gameCommunityID CommunityId
		{
			get => GetPropertyValue<gameCommunityID>();
			set => SetPropertyValue<gameCommunityID>(value);
		}

		[Ordinal(1)] 
		[RED("nameReference")] 
		public CName NameReference
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public gameCommunitySpawnSetNameToIDEntry()
		{
			CommunityId = new() { EntityId = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
