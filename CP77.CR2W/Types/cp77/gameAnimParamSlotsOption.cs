using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameAnimParamSlotsOption : CVariable
	{
		[Ordinal(0)]  [RED("function")] public CEnum<entAnimParamSlotFunction> Function { get; set; }
		[Ordinal(1)]  [RED("paramName")] public CName ParamName { get; set; }
		[Ordinal(2)]  [RED("slotID")] public TweakDBID SlotID { get; set; }

		public gameAnimParamSlotsOption(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
