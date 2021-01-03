using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class UI_HUDProgressBarDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("Active")] public gamebbScriptID_Bool Active { get; set; }
		[Ordinal(1)]  [RED("Header")] public gamebbScriptID_String Header { get; set; }
		[Ordinal(2)]  [RED("Progress")] public gamebbScriptID_Float Progress { get; set; }
		[Ordinal(3)]  [RED("TimerID")] public gamebbScriptID_Variant TimerID { get; set; }

		public UI_HUDProgressBarDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
