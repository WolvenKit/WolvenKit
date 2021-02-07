using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMuppetAbilities : CVariable
	{
		[Ordinal(0)]  [RED("canLook")] public gameMuppetAbility CanLook { get; set; }
		[Ordinal(1)]  [RED("canMove")] public gameMuppetAbility CanMove { get; set; }
		[Ordinal(2)]  [RED("canCrouch")] public gameMuppetAbility CanCrouch { get; set; }
		[Ordinal(3)]  [RED("canSprint")] public gameMuppetAbility CanSprint { get; set; }
		[Ordinal(4)]  [RED("canSwitchWeapon")] public gameMuppetAbility CanSwitchWeapon { get; set; }
		[Ordinal(5)]  [RED("canHoldWeapon")] public gameMuppetAbility CanHoldWeapon { get; set; }
		[Ordinal(6)]  [RED("canShoot")] public gameMuppetAbility CanShoot { get; set; }
		[Ordinal(7)]  [RED("canAimDownSight")] public gameMuppetAbility CanAimDownSight { get; set; }

		public gameMuppetAbilities(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
