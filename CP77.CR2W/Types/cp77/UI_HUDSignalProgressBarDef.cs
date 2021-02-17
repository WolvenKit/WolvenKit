using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_HUDSignalProgressBarDef : gamebbScriptDefinition
	{
		[Ordinal(0)] [RED("TimerID")] public gamebbScriptID_Variant TimerID { get; set; }
		[Ordinal(1)] [RED("State")] public gamebbScriptID_Uint32 State { get; set; }
		[Ordinal(2)] [RED("Progress")] public gamebbScriptID_Float Progress { get; set; }
		[Ordinal(3)] [RED("SignalStrength")] public gamebbScriptID_Float SignalStrength { get; set; }
		[Ordinal(4)] [RED("IsInRange")] public gamebbScriptID_Bool IsInRange { get; set; }

		public UI_HUDSignalProgressBarDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
