using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questLegacy_NodeType : questSpawnManagerNodeType
	{
		[Ordinal(1)] [RED("spawnerReference")] public NodeRef SpawnerReference { get; set; }
		[Ordinal(2)] [RED("communityEntryName")] public CName CommunityEntryName { get; set; }
		[Ordinal(3)] [RED("communityEntryPhaseName")] public CName CommunityEntryPhaseName { get; set; }

		public questLegacy_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
