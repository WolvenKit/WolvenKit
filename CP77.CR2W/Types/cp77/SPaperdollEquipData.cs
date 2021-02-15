using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SPaperdollEquipData : CVariable
	{
		[Ordinal(0)] [RED("equipArea")] public gameSEquipArea EquipArea { get; set; }
		[Ordinal(1)] [RED("slotIndex")] public CInt32 SlotIndex { get; set; }
		[Ordinal(2)] [RED("placementSlot")] public TweakDBID PlacementSlot { get; set; }
		[Ordinal(3)] [RED("equipped")] public CBool Equipped { get; set; }

		public SPaperdollEquipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
