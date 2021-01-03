using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class InventoryTooltipData_StatData : CVariable
	{
		[Ordinal(0)]  [RED("currentValue")] public CInt32 CurrentValue { get; set; }
		[Ordinal(1)]  [RED("currentValueF")] public CFloat CurrentValueF { get; set; }
		[Ordinal(2)]  [RED("diffValue")] public CInt32 DiffValue { get; set; }
		[Ordinal(3)]  [RED("diffValueF")] public CFloat DiffValueF { get; set; }
		[Ordinal(4)]  [RED("maxStatValue")] public CInt32 MaxStatValue { get; set; }
		[Ordinal(5)]  [RED("maxStatValueF")] public CFloat MaxStatValueF { get; set; }
		[Ordinal(6)]  [RED("minStatValue")] public CInt32 MinStatValue { get; set; }
		[Ordinal(7)]  [RED("minStatValueF")] public CFloat MinStatValueF { get; set; }
		[Ordinal(8)]  [RED("statName")] public CString StatName { get; set; }
		[Ordinal(9)]  [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }
		[Ordinal(10)]  [RED("state")] public CEnum<EInventoryDataStatDisplayType> State { get; set; }

		public InventoryTooltipData_StatData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
