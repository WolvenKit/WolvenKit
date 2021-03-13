using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponVendingMachineControllerPS : VendingMachineControllerPS
	{
		[Ordinal(111)] [RED("weaponVendingMachineSetup")] public WeaponVendingMachineSetup WeaponVendingMachineSetup { get; set; }
		[Ordinal(112)] [RED("weaponVendingMachineSFX")] public WeaponVendingMachineSFX WeaponVendingMachineSFX { get; set; }

		public WeaponVendingMachineControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
