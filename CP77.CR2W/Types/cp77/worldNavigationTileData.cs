using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class worldNavigationTileData : CVariable
	{
		[Ordinal(0)]  [RED("agentSize")] public CEnum<NavGenAgentSize> AgentSize { get; set; }
		[Ordinal(1)]  [RED("offMeshConnections")] public worldOffMeshConnectionsData OffMeshConnections { get; set; }
		[Ordinal(2)]  [RED("regenerable")] public CBool Regenerable { get; set; }
		[Ordinal(3)]  [RED("tileLayer")] public CInt32 TileLayer { get; set; }
		[Ordinal(4)]  [RED("tileX")] public CInt32 TileX { get; set; }
		[Ordinal(5)]  [RED("tileY")] public CInt32 TileY { get; set; }
		[Ordinal(6)]  [RED("tilesBuffer")] public DataBuffer TilesBuffer { get; set; }

		public worldNavigationTileData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
