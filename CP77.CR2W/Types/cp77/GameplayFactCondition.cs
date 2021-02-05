using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GameplayFactCondition : GameplayConditionBase
	{
		[Ordinal(1)]  [RED("factName")] public CName FactName { get; set; }
		[Ordinal(2)]  [RED("value")] public CInt32 Value { get; set; }
		[Ordinal(3)]  [RED("comparisonType")] public CEnum<ECompareOp> ComparisonType { get; set; }
		[Ordinal(4)]  [RED("description")] public CString Description { get; set; }

		public GameplayFactCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
