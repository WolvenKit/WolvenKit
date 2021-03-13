using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questEntityManagerSetStat_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(1)] [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)] [RED("statType")] public CEnum<gamedataStatType> StatType { get; set; }
		[Ordinal(3)] [RED("value")] public CFloat Value { get; set; }
		[Ordinal(4)] [RED("setExactValue")] public CBool SetExactValue { get; set; }

		public questEntityManagerSetStat_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
