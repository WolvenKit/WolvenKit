using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldCommunityRegistryNode : worldNode
	{
		[Ordinal(4)] 
		[RED("spawnSetNameToCommunityID")] 
		public gameCommunitySpawnSetNameToID SpawnSetNameToCommunityID
		{
			get => GetPropertyValue<gameCommunitySpawnSetNameToID>();
			set => SetPropertyValue<gameCommunitySpawnSetNameToID>(value);
		}

		[Ordinal(5)] 
		[RED("crowdCreationRegistry")] 
		public CHandle<gameCrowdCreationDataRegistry> CrowdCreationRegistry
		{
			get => GetPropertyValue<CHandle<gameCrowdCreationDataRegistry>>();
			set => SetPropertyValue<CHandle<gameCrowdCreationDataRegistry>>(value);
		}

		[Ordinal(6)] 
		[RED("communitiesData")] 
		public CArray<worldCommunityRegistryItem> CommunitiesData
		{
			get => GetPropertyValue<CArray<worldCommunityRegistryItem>>();
			set => SetPropertyValue<CArray<worldCommunityRegistryItem>>(value);
		}

		[Ordinal(7)] 
		[RED("workspotsPersistentData")] 
		public CArray<AISpotPersistentData> WorkspotsPersistentData
		{
			get => GetPropertyValue<CArray<AISpotPersistentData>>();
			set => SetPropertyValue<CArray<AISpotPersistentData>>(value);
		}

		[Ordinal(8)] 
		[RED("representsCrowd")] 
		public CBool RepresentsCrowd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public worldCommunityRegistryNode()
		{
			SpawnSetNameToCommunityID = new gameCommunitySpawnSetNameToID { Entries = new() };
			CommunitiesData = new();
			WorkspotsPersistentData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
