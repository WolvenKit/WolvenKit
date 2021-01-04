using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class MinimalItemTooltipStatData : IScriptable
	{
		[Ordinal(0)]  [RED("diff")] public CFloat Diff { get; set; }
		[Ordinal(1)]  [RED("displayPlus")] public CBool DisplayPlus { get; set; }
		[Ordinal(2)]  [RED("isPercentage")] public CBool IsPercentage { get; set; }
		[Ordinal(3)]  [RED("roundValue")] public CBool RoundValue { get; set; }
		[Ordinal(4)]  [RED("statName")] public CString StatName { get; set; }
		[Ordinal(5)]  [RED("type")] public CEnum<gamedataStatType> Type { get; set; }
		[Ordinal(6)]  [RED("value")] public CFloat Value { get; set; }

		public MinimalItemTooltipStatData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
