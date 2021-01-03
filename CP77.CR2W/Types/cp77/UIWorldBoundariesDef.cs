using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UIWorldBoundariesDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("IsPlayerCloseToBoundary")] public gamebbScriptID_Bool IsPlayerCloseToBoundary { get; set; }
		[Ordinal(1)]  [RED("IsPlayerGoingDeeper")] public gamebbScriptID_Bool IsPlayerGoingDeeper { get; set; }

		public UIWorldBoundariesDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
