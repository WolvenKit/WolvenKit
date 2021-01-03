using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameStatViewData : CVariable
	{
		[Ordinal(0)]  [RED("canBeCompared")] public CBool CanBeCompared { get; set; }
		[Ordinal(1)]  [RED("diffValue")] public CInt32 DiffValue { get; set; }
		[Ordinal(2)]  [RED("diffValueF")] public CFloat DiffValueF { get; set; }
		[Ordinal(3)]  [RED("isCompared")] public CBool IsCompared { get; set; }
		[Ordinal(4)]  [RED("isMaxValue")] public CBool IsMaxValue { get; set; }
		[Ordinal(5)]  [RED("statMaxValue")] public CInt32 StatMaxValue { get; set; }
		[Ordinal(6)]  [RED("statMaxValueF")] public CFloat StatMaxValueF { get; set; }
		[Ordinal(7)]  [RED("statMinValue")] public CInt32 StatMinValue { get; set; }
		[Ordinal(8)]  [RED("statMinValueF")] public CFloat StatMinValueF { get; set; }
		[Ordinal(9)]  [RED("statName")] public CString StatName { get; set; }
		[Ordinal(10)]  [RED("type")] public CEnum<gamedataStatType> Type { get; set; }
		[Ordinal(11)]  [RED("value")] public CInt32 Value { get; set; }
		[Ordinal(12)]  [RED("valueF")] public CFloat ValueF { get; set; }

		public gameStatViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
