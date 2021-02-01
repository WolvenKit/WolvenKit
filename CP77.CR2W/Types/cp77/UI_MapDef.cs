using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_MapDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("currentLocation")] public gamebbScriptID_String CurrentLocation { get; set; }
		[Ordinal(1)]  [RED("currentLocationEnumName")] public gamebbScriptID_String CurrentLocationEnumName { get; set; }
		[Ordinal(2)]  [RED("currentState")] public gamebbScriptID_String CurrentState { get; set; }
		[Ordinal(3)]  [RED("newLocationDiscovered")] public gamebbScriptID_Bool NewLocationDiscovered { get; set; }

		public UI_MapDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
