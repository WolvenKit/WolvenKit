using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CheckEquippedWeaponType : AIItemHandlingCondition
	{
		[Ordinal(0)] [RED("weaponTypeToCheck")] public CName WeaponTypeToCheck { get; set; }

		public CheckEquippedWeaponType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
