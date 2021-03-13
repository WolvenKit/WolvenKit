using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameCombinedStatModifierData : gameStatModifierData
	{
		[Ordinal(2)] [RED("refStatType")] public CEnum<gamedataStatType> RefStatType { get; set; }
		[Ordinal(3)] [RED("operation")] public CEnum<gameCombinedStatOperation> Operation { get; set; }
		[Ordinal(4)] [RED("refObject")] public CEnum<gameStatObjectsRelation> RefObject { get; set; }
		[Ordinal(5)] [RED("value")] public CFloat Value { get; set; }

		public gameCombinedStatModifierData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
