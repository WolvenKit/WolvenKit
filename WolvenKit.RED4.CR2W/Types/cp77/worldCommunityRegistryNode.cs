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
			get
			{
				if (_spawnSetNameToCommunityID == null)
				{
					_spawnSetNameToCommunityID = (gameCommunitySpawnSetNameToID) CR2WTypeManager.Create("gameCommunitySpawnSetNameToID", "spawnSetNameToCommunityID", cr2w, this);
				}
				return _spawnSetNameToCommunityID;
			}
			set
			{
				if (_spawnSetNameToCommunityID == value)
				{
					return;
				}
				_spawnSetNameToCommunityID = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("crowdCreationRegistry")] 
		public CHandle<gameCrowdCreationDataRegistry> CrowdCreationRegistry
		{
			get
			{
				if (_crowdCreationRegistry == null)
				{
					_crowdCreationRegistry = (CHandle<gameCrowdCreationDataRegistry>) CR2WTypeManager.Create("handle:gameCrowdCreationDataRegistry", "crowdCreationRegistry", cr2w, this);
				}
				return _crowdCreationRegistry;
			}
			set
			{
				if (_crowdCreationRegistry == value)
				{
					return;
				}
				_crowdCreationRegistry = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("communitiesData")] 
		public CArray<worldCommunityRegistryItem> CommunitiesData
		{
			get
			{
				if (_communitiesData == null)
				{
					_communitiesData = (CArray<worldCommunityRegistryItem>) CR2WTypeManager.Create("array:worldCommunityRegistryItem", "communitiesData", cr2w, this);
				}
				return _communitiesData;
			}
			set
			{
				if (_communitiesData == value)
				{
					return;
				}
				_communitiesData = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("workspotsPersistentData")] 
		public CArray<AISpotPersistentData> WorkspotsPersistentData
		{
			get
			{
				if (_workspotsPersistentData == null)
				{
					_workspotsPersistentData = (CArray<AISpotPersistentData>) CR2WTypeManager.Create("array:AISpotPersistentData", "workspotsPersistentData", cr2w, this);
				}
				return _workspotsPersistentData;
			}
			set
			{
				if (_workspotsPersistentData == value)
				{
					return;
				}
				_workspotsPersistentData = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("representsCrowd")] 
		public CBool RepresentsCrowd
		{
			get
			{
				if (_representsCrowd == null)
				{
					_representsCrowd = (CBool) CR2WTypeManager.Create("Bool", "representsCrowd", cr2w, this);
				}
				return _representsCrowd;
			}
			set
			{
				if (_representsCrowd == value)
				{
					return;
				}
				_representsCrowd = value;
				PropertySet(this);
			}
		}

		public worldCommunityRegistryNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
