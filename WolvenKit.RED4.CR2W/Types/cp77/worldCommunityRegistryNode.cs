using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCommunityRegistryNode : worldNode
	{
		private gameCommunitySpawnSetNameToID _spawnSetNameToCommunityID;
		private CHandle<gameCrowdCreationDataRegistry> _crowdCreationRegistry;
		private CArray<worldCommunityRegistryItem> _communitiesData;
		private CArray<AISpotPersistentData> _workspotsPersistentData;
		private CBool _representsCrowd;

		[Ordinal(4)] 
		[RED("spawnSetNameToCommunityID")] 
		public gameCommunitySpawnSetNameToID SpawnSetNameToCommunityID
		{
			get => GetProperty(ref _spawnSetNameToCommunityID);
			set => SetProperty(ref _spawnSetNameToCommunityID, value);
		}

		[Ordinal(5)] 
		[RED("crowdCreationRegistry")] 
		public CHandle<gameCrowdCreationDataRegistry> CrowdCreationRegistry
		{
			get => GetProperty(ref _crowdCreationRegistry);
			set => SetProperty(ref _crowdCreationRegistry, value);
		}

		[Ordinal(6)] 
		[RED("communitiesData")] 
		public CArray<worldCommunityRegistryItem> CommunitiesData
		{
			get => GetProperty(ref _communitiesData);
			set => SetProperty(ref _communitiesData, value);
		}

		[Ordinal(7)] 
		[RED("workspotsPersistentData")] 
		public CArray<AISpotPersistentData> WorkspotsPersistentData
		{
			get => GetProperty(ref _workspotsPersistentData);
			set => SetProperty(ref _workspotsPersistentData, value);
		}

		[Ordinal(8)] 
		[RED("representsCrowd")] 
		public CBool RepresentsCrowd
		{
			get => GetProperty(ref _representsCrowd);
			set => SetProperty(ref _representsCrowd, value);
		}

		public worldCommunityRegistryNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
