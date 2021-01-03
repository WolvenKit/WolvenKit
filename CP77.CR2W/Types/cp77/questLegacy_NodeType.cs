using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questLegacy_NodeType : questSpawnManagerNodeType
	{
		[Ordinal(0)]  [RED("communityEntryName")] public CName CommunityEntryName { get; set; }
		[Ordinal(1)]  [RED("communityEntryPhaseName")] public CName CommunityEntryPhaseName { get; set; }
		[Ordinal(2)]  [RED("spawnerReference")] public NodeRef SpawnerReference { get; set; }

		public questLegacy_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
