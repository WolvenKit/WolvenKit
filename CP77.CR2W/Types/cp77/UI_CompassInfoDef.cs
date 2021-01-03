using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UI_CompassInfoDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("EastOffset")] public gamebbScriptID_Float EastOffset { get; set; }
		[Ordinal(1)]  [RED("NorthOffset")] public gamebbScriptID_Float NorthOffset { get; set; }
		[Ordinal(2)]  [RED("Pins")] public gamebbScriptID_Variant Pins { get; set; }
		[Ordinal(3)]  [RED("SouthOffset")] public gamebbScriptID_Float SouthOffset { get; set; }
		[Ordinal(4)]  [RED("WestOffset")] public gamebbScriptID_Float WestOffset { get; set; }

		public UI_CompassInfoDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
