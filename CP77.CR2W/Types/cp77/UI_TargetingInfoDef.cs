using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class UI_TargetingInfoDef : gamebbScriptDefinition
	{
		[Ordinal(0)]  [RED("CurrentObstructedTarget")] public gamebbScriptID_EntityID CurrentObstructedTarget { get; set; }
		[Ordinal(1)]  [RED("CurrentVisibleTarget")] public gamebbScriptID_EntityID CurrentVisibleTarget { get; set; }
		[Ordinal(2)]  [RED("ObstructedTargetAttitude")] public gamebbScriptID_Int32 ObstructedTargetAttitude { get; set; }
		[Ordinal(3)]  [RED("ObstructedTargetDistance")] public gamebbScriptID_Float ObstructedTargetDistance { get; set; }
		[Ordinal(4)]  [RED("VisibleTargetAttitude")] public gamebbScriptID_Int32 VisibleTargetAttitude { get; set; }
		[Ordinal(5)]  [RED("VisibleTargetDistance")] public gamebbScriptID_Float VisibleTargetDistance { get; set; }

		public UI_TargetingInfoDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
