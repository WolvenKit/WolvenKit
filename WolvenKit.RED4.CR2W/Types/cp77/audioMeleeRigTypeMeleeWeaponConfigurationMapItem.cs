using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeRigTypeMeleeWeaponConfigurationMapItem : CVariable
	{
		private CName _name;
		private CName _meleeWeaponConfiguration;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("meleeWeaponConfiguration")] 
		public CName MeleeWeaponConfiguration
		{
			get => GetProperty(ref _meleeWeaponConfiguration);
			set => SetProperty(ref _meleeWeaponConfiguration, value);
		}

		public audioMeleeRigTypeMeleeWeaponConfigurationMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
