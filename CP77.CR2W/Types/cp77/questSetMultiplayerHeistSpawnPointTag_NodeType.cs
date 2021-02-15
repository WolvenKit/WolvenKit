using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetMultiplayerHeistSpawnPointTag_NodeType : questIMultiplayerHeistNodeType
	{
		[Ordinal(0)] [RED("spawnPointTag")] public CName SpawnPointTag { get; set; }

		public questSetMultiplayerHeistSpawnPointTag_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
