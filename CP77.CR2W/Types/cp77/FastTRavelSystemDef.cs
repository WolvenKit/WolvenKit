using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FastTRavelSystemDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("DestinationPoint")] public gamebbScriptID_Variant DestinationPoint { get; set; }
		[Ordinal(1)] [RED("StartingPoint")] public gamebbScriptID_Variant StartingPoint { get; set; }
		[Ordinal(2)] [RED("FastTravelLoadingScreenFinished")] public gamebbScriptID_Bool FastTravelLoadingScreenFinished { get; set; }

		public FastTRavelSystemDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
