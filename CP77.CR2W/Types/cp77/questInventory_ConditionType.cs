using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class questInventory_ConditionType : questIObjectConditionType
	{
		[Ordinal(0)]  [RED("comparisonType")] public CEnum<EComparisonType> ComparisonType { get; set; }
		[Ordinal(1)]  [RED("isPlayer")] public CBool IsPlayer { get; set; }
		[Ordinal(2)]  [RED("itemID")] public TweakDBID ItemID { get; set; }
		[Ordinal(3)]  [RED("itemTag")] public CName ItemTag { get; set; }
		[Ordinal(4)]  [RED("objectRef")] public gameEntityReference ObjectRef { get; set; }
		[Ordinal(5)]  [RED("quantity")] public CUInt32 Quantity { get; set; }

		public questInventory_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
