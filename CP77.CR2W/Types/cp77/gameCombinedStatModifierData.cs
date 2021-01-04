using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameCombinedStatModifierData : gameStatModifierData
	{
		[Ordinal(0)]  [RED("operation")] public CEnum<gameCombinedStatOperation> Operation { get; set; }
		[Ordinal(1)]  [RED("refObject")] public CEnum<gameStatObjectsRelation> RefObject { get; set; }
		[Ordinal(2)]  [RED("refStatType")] public CEnum<gamedataStatType> RefStatType { get; set; }
		[Ordinal(3)]  [RED("value")] public CFloat Value { get; set; }

		public gameCombinedStatModifierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
