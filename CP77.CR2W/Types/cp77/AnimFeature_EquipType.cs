using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_EquipType : animAnimFeature
	{
		[Ordinal(0)]  [RED("equipDuration")] public CFloat EquipDuration { get; set; }
		[Ordinal(1)]  [RED("firstEquip")] public CBool FirstEquip { get; set; }
		[Ordinal(2)]  [RED("unequipDuration")] public CFloat UnequipDuration { get; set; }

		public AnimFeature_EquipType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
