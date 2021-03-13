using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCommunityTemplate_NodeType : questSpawnManagerNodeType
	{
		[Ordinal(1)] [RED("spawnerReference")] public NodeRef SpawnerReference { get; set; }
		[Ordinal(2)] [RED("communityEntryName")] public CName CommunityEntryName { get; set; }
		[Ordinal(3)] [RED("communityEntryPhaseName")] public CName CommunityEntryPhaseName { get; set; }

		public questCommunityTemplate_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
