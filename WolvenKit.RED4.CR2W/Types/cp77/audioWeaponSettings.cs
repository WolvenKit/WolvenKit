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
			get
			{
				if (_bulletType == null)
				{
					_bulletType = (CEnum<audioWeaponBulletType>) CR2WTypeManager.Create("audioWeaponBulletType", "bulletType", cr2w, this);
				}
				return _bulletType;
			}
			set
			{
				if (_bulletType == value)
				{
					return;
				}
				_bulletType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("shellCasingType")] 
		public CEnum<audioWeaponShellCasingType> ShellCasingType
		{
			get
			{
				if (_shellCasingType == null)
				{
					_shellCasingType = (CEnum<audioWeaponShellCasingType>) CR2WTypeManager.Create("audioWeaponShellCasingType", "shellCasingType", cr2w, this);
				}
				return _shellCasingType;
			}
			set
			{
				if (_shellCasingType == value)
				{
					return;
				}
				_shellCasingType = value;
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

		[Ordinal(4)] 
		[RED("singleShotInSandevistan")] 
		public CBool SingleShotInSandevistan
		{
			get
			{
				if (_singleShotInSandevistan == null)
				{
					_singleShotInSandevistan = (CBool) CR2WTypeManager.Create("Bool", "singleShotInSandevistan", cr2w, this);
				}
				return _singleShotInSandevistan;
			}
			set
			{
				if (_singleShotInSandevistan == value)
				{
					return;
				}
				_singleShotInSandevistan = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("chargeStartSound")] 
		public CName ChargeStartSound
		{
			get
			{
				if (_chargeStartSound == null)
				{
					_chargeStartSound = (CName) CR2WTypeManager.Create("CName", "chargeStartSound", cr2w, this);
				}
				return _chargeStartSound;
			}
			set
			{
				if (_chargeStartSound == value)
				{
					return;
				}
				_chargeStartSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("chargeReadySound")] 
		public CName ChargeReadySound
		{
			get
			{
				if (_chargeReadySound == null)
				{
					_chargeReadySound = (CName) CR2WTypeManager.Create("CName", "chargeReadySound", cr2w, this);
				}
				return _chargeReadySound;
			}
			set
			{
				if (_chargeReadySound == value)
				{
					return;
				}
				_chargeReadySound = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("chargeOverchargeSound")] 
		public CName ChargeOverchargeSound
		{
			get
			{
				if (_chargeOverchargeSound == null)
				{
					_chargeOverchargeSound = (CName) CR2WTypeManager.Create("CName", "chargeOverchargeSound", cr2w, this);
				}
				return _chargeOverchargeSound;
			}
			set
			{
				if (_chargeOverchargeSound == value)
				{
					return;
				}
				_chargeOverchargeSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("chargeDischargeSound")] 
		public CName ChargeDischargeSound
		{
			get
			{
				if (_chargeDischargeSound == null)
				{
					_chargeDischargeSound = (CName) CR2WTypeManager.Create("CName", "chargeDischargeSound", cr2w, this);
				}
				return _chargeDischargeSound;
			}
			set
			{
				if (_chargeDischargeSound == value)
				{
					return;
				}
				_chargeDischargeSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("fireModeSounds")] 
		public audioWeaponFireModeSounds FireModeSounds
		{
			get
			{
				if (_fireModeSounds == null)
				{
					_fireModeSounds = (audioWeaponFireModeSounds) CR2WTypeManager.Create("audioWeaponFireModeSounds", "fireModeSounds", cr2w, this);
				}
				return _fireModeSounds;
			}
			set
			{
				if (_fireModeSounds == value)
				{
					return;
				}
				_fireModeSounds = value;
				PropertySet(this);
			}
		}

		public audioWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
