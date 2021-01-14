using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipDataRequirements : IScriptable
	{
		[Ordinal(0)]  [RED("anyStatColor")] public CString AnyStatColor { get; set; }
		[Ordinal(1)]  [RED("anyStatLocKey")] public CString AnyStatLocKey { get; set; }
		[Ordinal(2)]  [RED("anyStatName")] public CString AnyStatName { get; set; }
		[Ordinal(3)]  [RED("anyStatValue")] public CInt32 AnyStatValue { get; set; }
		[Ordinal(4)]  [RED("isAnyStatRequirementNotMet")] public CBool IsAnyStatRequirementNotMet { get; set; }
		[Ordinal(5)]  [RED("isLevelRequirementNotMet")] public CBool IsLevelRequirementNotMet { get; set; }
		[Ordinal(6)]  [RED("isReflexRequirementNotMet")] public CBool IsReflexRequirementNotMet { get; set; }
		[Ordinal(7)]  [RED("isSmartlinkRequirementNotMet")] public CBool IsSmartlinkRequirementNotMet { get; set; }
		[Ordinal(8)]  [RED("isStrengthRequirementNotMet")] public CBool IsStrengthRequirementNotMet { get; set; }
		[Ordinal(9)]  [RED("requiredLevel")] public CInt32 RequiredLevel { get; set; }
		[Ordinal(10)]  [RED("strengthOrReflexStatName")] public CString StrengthOrReflexStatName { get; set; }
		[Ordinal(11)]  [RED("strengthOrReflexValue")] public CInt32 StrengthOrReflexValue { get; set; }

		public MinimalItemTooltipDataRequirements(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
