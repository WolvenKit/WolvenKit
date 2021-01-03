using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class GameplayFactCondition : GameplayConditionBase
	{
		[Ordinal(0)]  [RED("comparisonType")] public CEnum<ECompareOp> ComparisonType { get; set; }
		[Ordinal(1)]  [RED("description")] public CString Description { get; set; }
		[Ordinal(2)]  [RED("factName")] public CName FactName { get; set; }
		[Ordinal(3)]  [RED("value")] public CInt32 Value { get; set; }

		public GameplayFactCondition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
