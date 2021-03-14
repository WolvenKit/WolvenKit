using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioMeleeWeaponSettings : audioAudioMetadata
	{
		private audioMeleeAttackSettings _quickAttackSettings;
		private audioMeleeAttackSettings _strongAttackSettings;
		private audioWeaponHandlingSettings _weaponHandlingSettings;

		[Ordinal(1)] 
		[RED("quickAttackSettings")] 
		public audioMeleeAttackSettings QuickAttackSettings
		{
			get
			{
				if (_quickAttackSettings == null)
				{
					_quickAttackSettings = (audioMeleeAttackSettings) CR2WTypeManager.Create("audioMeleeAttackSettings", "quickAttackSettings", cr2w, this);
				}
				return _quickAttackSettings;
			}
			set
			{
				if (_quickAttackSettings == value)
				{
					return;
				}
				_quickAttackSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("strongAttackSettings")] 
		public audioMeleeAttackSettings StrongAttackSettings
		{
			get
			{
				if (_strongAttackSettings == null)
				{
					_strongAttackSettings = (audioMeleeAttackSettings) CR2WTypeManager.Create("audioMeleeAttackSettings", "strongAttackSettings", cr2w, this);
				}
				return _strongAttackSettings;
			}
			set
			{
				if (_strongAttackSettings == value)
				{
					return;
				}
				_strongAttackSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("weaponHandlingSettings")] 
		public audioWeaponHandlingSettings WeaponHandlingSettings
		{
			get
			{
				if (_weaponHandlingSettings == null)
				{
					_weaponHandlingSettings = (audioWeaponHandlingSettings) CR2WTypeManager.Create("audioWeaponHandlingSettings", "weaponHandlingSettings", cr2w, this);
				}
				return _weaponHandlingSettings;
			}
			set
			{
				if (_weaponHandlingSettings == value)
				{
					return;
				}
				_weaponHandlingSettings = value;
				PropertySet(this);
			}
		}

		public audioMeleeWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
