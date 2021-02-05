using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryQuickHack : CVariable
	{
		[Ordinal(0)]  [RED("actionName")] public CName ActionName { get; set; }
		[Ordinal(1)]  [RED("titleLocKey")] public CString TitleLocKey { get; set; }
		[Ordinal(2)]  [RED("targetType")] public CString TargetType { get; set; }
		[Ordinal(3)]  [RED("quickHackRecordID")] public TweakDBID QuickHackRecordID { get; set; }
		[Ordinal(4)]  [RED("quality")] public CInt32 Quality { get; set; }

		public gameTelemetryQuickHack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
