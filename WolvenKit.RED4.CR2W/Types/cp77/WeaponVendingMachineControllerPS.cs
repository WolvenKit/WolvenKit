using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class WeaponVendingMachineControllerPS : VendingMachineControllerPS
	{
		private WeaponVendingMachineSetup _weaponVendingMachineSetup;
		private WeaponVendingMachineSFX _weaponVendingMachineSFX;

		[Ordinal(112)] 
		[RED("weaponVendingMachineSetup")] 
		public WeaponVendingMachineSetup WeaponVendingMachineSetup
		{
			get => GetProperty(ref _weaponVendingMachineSetup);
			set => SetProperty(ref _weaponVendingMachineSetup, value);
		}

		[Ordinal(113)] 
		[RED("weaponVendingMachineSFX")] 
		public WeaponVendingMachineSFX WeaponVendingMachineSFX
		{
			get => GetProperty(ref _weaponVendingMachineSFX);
			set => SetProperty(ref _weaponVendingMachineSFX, value);
		}

		public WeaponVendingMachineControllerPS(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
