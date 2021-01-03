using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questCharacterState_PuppetSubType : questICharacterConditionSubType
	{
		[Ordinal(0)]  [RED("highLevelComparisonType")] public CEnum<questEComparisonTypeEquality> HighLevelComparisonType { get; set; }
		[Ordinal(1)]  [RED("highLevelState")] public CInt32 HighLevelState { get; set; }
		[Ordinal(2)]  [RED("puppetRef")] public gameEntityReference PuppetRef { get; set; }
		[Ordinal(3)]  [RED("stanceComparisonType")] public CEnum<questEComparisonTypeEquality> StanceComparisonType { get; set; }
		[Ordinal(4)]  [RED("stanceState")] public CInt32 StanceState { get; set; }
		[Ordinal(5)]  [RED("upperBodyComparisonType")] public CEnum<questEComparisonTypeEquality> UpperBodyComparisonType { get; set; }
		[Ordinal(6)]  [RED("upperBodyState")] public CInt32 UpperBodyState { get; set; }

		public questCharacterState_PuppetSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
