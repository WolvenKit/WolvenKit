using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameTelemetryQuickHack : CVariable
	{
		[Ordinal(0)]  [RED("actionName")] public CName ActionName { get; set; }
		[Ordinal(1)]  [RED("quality")] public CInt32 Quality { get; set; }
		[Ordinal(2)]  [RED("quickHackRecordID")] public TweakDBID QuickHackRecordID { get; set; }
		[Ordinal(3)]  [RED("targetType")] public CString TargetType { get; set; }
		[Ordinal(4)]  [RED("titleLocKey")] public CString TitleLocKey { get; set; }

		public gameTelemetryQuickHack(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
