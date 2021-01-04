using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldCommunityRegistryNode : worldNode
	{
		[Ordinal(0)]  [RED("communitiesData")] public CArray<worldCommunityRegistryItem> CommunitiesData { get; set; }
		[Ordinal(1)]  [RED("crowdCreationRegistry")] public CHandle<gameCrowdCreationDataRegistry> CrowdCreationRegistry { get; set; }
		[Ordinal(2)]  [RED("representsCrowd")] public CBool RepresentsCrowd { get; set; }
		[Ordinal(3)]  [RED("spawnSetNameToCommunityID")] public gameCommunitySpawnSetNameToID SpawnSetNameToCommunityID { get; set; }
		[Ordinal(4)]  [RED("workspotsPersistentData")] public CArray<AISpotPersistentData> WorkspotsPersistentData { get; set; }

		public worldCommunityRegistryNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
