using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class UI_HUDProgressBarDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("TimerID")] public gamebbScriptID_Variant TimerID { get; set; }
		[Ordinal(1)] [RED("Header")] public gamebbScriptID_String Header { get; set; }
		[Ordinal(2)] [RED("Active")] public gamebbScriptID_Bool Active { get; set; }
		[Ordinal(3)] [RED("Progress")] public gamebbScriptID_Float Progress { get; set; }

		public UI_HUDProgressBarDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
