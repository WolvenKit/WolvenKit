using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_EquipUnequipItem : animAnimFeature
	{
		[Ordinal(0)]  [RED("firstEquip")] public CBool FirstEquip { get; set; }
		[Ordinal(1)]  [RED("itemState")] public CInt32 ItemState { get; set; }
		[Ordinal(2)]  [RED("itemType")] public CInt32 ItemType { get; set; }
		[Ordinal(3)]  [RED("stateTransitionDuration")] public CFloat StateTransitionDuration { get; set; }

		public animAnimFeature_EquipUnequipItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
