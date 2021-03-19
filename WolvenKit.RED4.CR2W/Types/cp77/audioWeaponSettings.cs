using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioWeaponSettings : audioAudioMetadata
	{
		private CEnum<audioWeaponBulletType> _bulletType;
		private CEnum<audioWeaponShellCasingType> _shellCasingType;
		private audioWeaponHandlingSettings _weaponHandlingSettings;
		private CBool _singleShotInSandevistan;
		private CName _chargeStartSound;
		private CName _chargeReadySound;
		private CName _chargeOverchargeSound;
		private CName _chargeDischargeSound;
		private audioWeaponFireModeSounds _fireModeSounds;

		[Ordinal(1)] 
		[RED("bulletType")] 
		public CEnum<audioWeaponBulletType> BulletType
		{
			get => GetProperty(ref _bulletType);
			set => SetProperty(ref _bulletType, value);
		}

		[Ordinal(2)] 
		[RED("shellCasingType")] 
		public CEnum<audioWeaponShellCasingType> ShellCasingType
		{
			get => GetProperty(ref _shellCasingType);
			set => SetProperty(ref _shellCasingType, value);
		}

		[Ordinal(3)] 
		[RED("weaponHandlingSettings")] 
		public audioWeaponHandlingSettings WeaponHandlingSettings
		{
			get => GetProperty(ref _weaponHandlingSettings);
			set => SetProperty(ref _weaponHandlingSettings, value);
		}

		[Ordinal(4)] 
		[RED("singleShotInSandevistan")] 
		public CBool SingleShotInSandevistan
		{
			get => GetProperty(ref _singleShotInSandevistan);
			set => SetProperty(ref _singleShotInSandevistan, value);
		}

		[Ordinal(5)] 
		[RED("chargeStartSound")] 
		public CName ChargeStartSound
		{
			get => GetProperty(ref _chargeStartSound);
			set => SetProperty(ref _chargeStartSound, value);
		}

		[Ordinal(6)] 
		[RED("chargeReadySound")] 
		public CName ChargeReadySound
		{
			get => GetProperty(ref _chargeReadySound);
			set => SetProperty(ref _chargeReadySound, value);
		}

		[Ordinal(7)] 
		[RED("chargeOverchargeSound")] 
		public CName ChargeOverchargeSound
		{
			get => GetProperty(ref _chargeOverchargeSound);
			set => SetProperty(ref _chargeOverchargeSound, value);
		}

		[Ordinal(8)] 
		[RED("chargeDischargeSound")] 
		public CName ChargeDischargeSound
		{
			get => GetProperty(ref _chargeDischargeSound);
			set => SetProperty(ref _chargeDischargeSound, value);
		}

		[Ordinal(9)] 
		[RED("fireModeSounds")] 
		public audioWeaponFireModeSounds FireModeSounds
		{
			get => GetProperty(ref _fireModeSounds);
			set => SetProperty(ref _fireModeSounds, value);
		}

		public audioWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
