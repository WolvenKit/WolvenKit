using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameStatModifierDetailedData : CVariable
	{
		[Ordinal(0)] [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }
		[Ordinal(1)] [RED("value")] public CFloat Value { get; set; }
		[Ordinal(2)] [RED("modifierType")] public CEnum<gameStatModifierType> ModifierType { get; set; }

		public gameStatModifierDetailedData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
