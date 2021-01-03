using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class FastTRavelSystemDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("DestinationPoint")] public gamebbScriptID_Variant DestinationPoint { get; set; }
		[Ordinal(1)]  [RED("FastTravelLoadingScreenFinished")] public gamebbScriptID_Bool FastTravelLoadingScreenFinished { get; set; }
		[Ordinal(2)]  [RED("StartingPoint")] public gamebbScriptID_Variant StartingPoint { get; set; }

		public FastTRavelSystemDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
