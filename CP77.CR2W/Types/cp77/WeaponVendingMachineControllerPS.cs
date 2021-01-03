using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class WeaponVendingMachineControllerPS : VendingMachineControllerPS
	{
		[Ordinal(0)]  [RED("weaponVendingMachineSFX")] public WeaponVendingMachineSFX WeaponVendingMachineSFX { get; set; }
		[Ordinal(1)]  [RED("weaponVendingMachineSetup")] public WeaponVendingMachineSetup WeaponVendingMachineSetup { get; set; }

		public WeaponVendingMachineControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
