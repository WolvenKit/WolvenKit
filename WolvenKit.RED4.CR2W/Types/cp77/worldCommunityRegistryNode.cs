using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class worldCommunityRegistryNode : worldNode
	{
		[Ordinal(4)] [RED("spawnSetNameToCommunityID")] public gameCommunitySpawnSetNameToID SpawnSetNameToCommunityID { get; set; }
		[Ordinal(5)] [RED("crowdCreationRegistry")] public CHandle<gameCrowdCreationDataRegistry> CrowdCreationRegistry { get; set; }
		[Ordinal(6)] [RED("communitiesData")] public CArray<worldCommunityRegistryItem> CommunitiesData { get; set; }
		[Ordinal(7)] [RED("workspotsPersistentData")] public CArray<AISpotPersistentData> WorkspotsPersistentData { get; set; }
		[Ordinal(8)] [RED("representsCrowd")] public CBool RepresentsCrowd { get; set; }

		public worldCommunityRegistryNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
