using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class EFirstEquipData : CVariable
	{
		[Ordinal(0)] [RED("weaponID")] public TweakDBID WeaponID { get; set; }
		[Ordinal(1)] [RED("hasPlayedFirstEquip")] public CBool HasPlayedFirstEquip { get; set; }

		public EFirstEquipData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
