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
			get => GetProperty(ref _quickAttackSettings);
			set => SetProperty(ref _quickAttackSettings, value);
		}

		[Ordinal(2)] 
		[RED("strongAttackSettings")] 
		public audioMeleeAttackSettings StrongAttackSettings
		{
			get => GetProperty(ref _strongAttackSettings);
			set => SetProperty(ref _strongAttackSettings, value);
		}

		[Ordinal(3)] 
		[RED("weaponHandlingSettings")] 
		public audioWeaponHandlingSettings WeaponHandlingSettings
		{
			get => GetProperty(ref _weaponHandlingSettings);
			set => SetProperty(ref _weaponHandlingSettings, value);
		}

		public audioMeleeWeaponSettings(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
