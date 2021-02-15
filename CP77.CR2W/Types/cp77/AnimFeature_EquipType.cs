using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_EquipType : animAnimFeature
	{
		[Ordinal(0)] [RED("firstEquip")] public CBool FirstEquip { get; set; }
		[Ordinal(1)] [RED("equipDuration")] public CFloat EquipDuration { get; set; }
		[Ordinal(2)] [RED("unequipDuration")] public CFloat UnequipDuration { get; set; }

		public AnimFeature_EquipType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
