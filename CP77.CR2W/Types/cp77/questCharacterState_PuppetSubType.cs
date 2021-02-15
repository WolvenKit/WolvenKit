using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questCharacterState_PuppetSubType : questICharacterConditionSubType
	{
		[Ordinal(0)] [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(1)] [RED("upperBodyComparisonType")] public CEnum<questEComparisonTypeEquality> UpperBodyComparisonType { get; set; }
		[Ordinal(2)] [RED("upperBodyState")] public CInt32 UpperBodyState { get; set; }
		[Ordinal(3)] [RED("highLevelComparisonType")] public CEnum<questEComparisonTypeEquality> HighLevelComparisonType { get; set; }
		[Ordinal(4)] [RED("highLevelState")] public CInt32 HighLevelState { get; set; }
		[Ordinal(5)] [RED("stanceComparisonType")] public CEnum<questEComparisonTypeEquality> StanceComparisonType { get; set; }
		[Ordinal(6)] [RED("stanceState")] public CInt32 StanceState { get; set; }

		public questCharacterState_PuppetSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
