using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameSItemStackRequirementData : CVariable
	{
		[Ordinal(0)] [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }
		[Ordinal(1)] [RED("requiredValue")] public CFloat RequiredValue { get; set; }

		public gameSItemStackRequirementData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
