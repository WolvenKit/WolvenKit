using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAnimParamSlotsOption : CVariable
	{
		[Ordinal(0)] [RED("slotID")] public TweakDBID SlotID { get; set; }
		[Ordinal(1)] [RED("paramName")] public CName ParamName { get; set; }
		[Ordinal(2)] [RED("function")] public CEnum<entAnimParamSlotFunction> Function { get; set; }

		public gameAnimParamSlotsOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
