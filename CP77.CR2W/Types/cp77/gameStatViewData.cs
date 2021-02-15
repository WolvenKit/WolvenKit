using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameStatViewData : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<gamedataStatType> Type { get; set; }
		[Ordinal(1)] [RED("statName")] public CString StatName { get; set; }
		[Ordinal(2)] [RED("value")] public CInt32 Value { get; set; }
		[Ordinal(3)] [RED("diffValue")] public CInt32 DiffValue { get; set; }
		[Ordinal(4)] [RED("isMaxValue")] public CBool IsMaxValue { get; set; }
		[Ordinal(5)] [RED("valueF")] public CFloat ValueF { get; set; }
		[Ordinal(6)] [RED("diffValueF")] public CFloat DiffValueF { get; set; }
		[Ordinal(7)] [RED("statMinValueF")] public CFloat StatMinValueF { get; set; }
		[Ordinal(8)] [RED("statMaxValueF")] public CFloat StatMaxValueF { get; set; }
		[Ordinal(9)] [RED("canBeCompared")] public CBool CanBeCompared { get; set; }
		[Ordinal(10)] [RED("isCompared")] public CBool IsCompared { get; set; }
		[Ordinal(11)] [RED("statMinValue")] public CInt32 StatMinValue { get; set; }
		[Ordinal(12)] [RED("statMaxValue")] public CInt32 StatMaxValue { get; set; }

		public gameStatViewData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
