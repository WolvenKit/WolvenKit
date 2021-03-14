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
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("meleeWeaponConfiguration")] 
		public CName MeleeWeaponConfiguration
		{
			get
			{
				if (_meleeWeaponConfiguration == null)
				{
					_meleeWeaponConfiguration = (CName) CR2WTypeManager.Create("CName", "meleeWeaponConfiguration", cr2w, this);
				}
				return _meleeWeaponConfiguration;
			}
			set
			{
				if (_meleeWeaponConfiguration == value)
				{
					return;
				}
				_meleeWeaponConfiguration = value;
				PropertySet(this);
			}
		}

		public audioMeleeRigTypeMeleeWeaponConfigurationMapItem(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
