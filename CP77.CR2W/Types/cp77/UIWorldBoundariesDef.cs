using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UIWorldBoundariesDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("IsPlayerCloseToBoundary")] public gamebbScriptID_Bool IsPlayerCloseToBoundary { get; set; }
		[Ordinal(1)]  [RED("IsPlayerGoingDeeper")] public gamebbScriptID_Bool IsPlayerGoingDeeper { get; set; }

		public UIWorldBoundariesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
