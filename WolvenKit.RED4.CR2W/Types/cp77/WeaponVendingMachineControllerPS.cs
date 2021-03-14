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

		[Ordinal(111)] 
		[RED("weaponVendingMachineSetup")] 
		public WeaponVendingMachineSetup WeaponVendingMachineSetup
		{
			get
			{
				if (_weaponVendingMachineSetup == null)
				{
					_weaponVendingMachineSetup = (WeaponVendingMachineSetup) CR2WTypeManager.Create("WeaponVendingMachineSetup", "weaponVendingMachineSetup", cr2w, this);
				}
				return _weaponVendingMachineSetup;
			}
			set
			{
				if (_weaponVendingMachineSetup == value)
				{
					return;
				}
				_weaponVendingMachineSetup = value;
				PropertySet(this);
			}
		}

		[Ordinal(112)] 
		[RED("weaponVendingMachineSFX")] 
		public WeaponVendingMachineSFX WeaponVendingMachineSFX
		{
			get
			{
				if (_weaponVendingMachineSFX == null)
				{
					_weaponVendingMachineSFX = (WeaponVendingMachineSFX) CR2WTypeManager.Create("WeaponVendingMachineSFX", "weaponVendingMachineSFX", cr2w, this);
				}
				return _weaponVendingMachineSFX;
			}
			set
			{
				if (_weaponVendingMachineSFX == value)
				{
					return;
				}
				_weaponVendingMachineSFX = value;
				PropertySet(this);
			}
		}

		public WeaponVendingMachineControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
