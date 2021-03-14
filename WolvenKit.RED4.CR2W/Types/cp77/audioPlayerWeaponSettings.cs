using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class audioPlayerWeaponSettings : audioWeaponSettings
	{
		private CName _fireSound;
		private CName _preFireSound;
		private CName _burstFireSound;
		private CName _autoFireSound;
		private CName _autoFireStop;
		private CFloat _timeLimitForAutoFireSingleShot;
		private CName _tails;
		private CName _shellCasingsSettings;
		private CHandle<audioWeaponTailOverrides> _weaponTailOverrides;
		private CName _quickMeleeHitEvent;
		private CName _initEvent;
		private CName _shutdownEvent;
		private CName _aimEnterSound;
		private CName _aimExitSound;
		private CName _dryFireSound;

		[Ordinal(10)] 
		[RED("fireSound")] 
		public CName FireSound
		{
			get
			{
				if (_fireSound == null)
				{
					_fireSound = (CName) CR2WTypeManager.Create("CName", "fireSound", cr2w, this);
				}
				return _fireSound;
			}
			set
			{
				if (_fireSound == value)
				{
					return;
				}
				_fireSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("preFireSound")] 
		public CName PreFireSound
		{
			get
			{
				if (_preFireSound == null)
				{
					_preFireSound = (CName) CR2WTypeManager.Create("CName", "preFireSound", cr2w, this);
				}
				return _preFireSound;
			}
			set
			{
				if (_preFireSound == value)
				{
					return;
				}
				_preFireSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("burstFireSound")] 
		public CName BurstFireSound
		{
			get
			{
				if (_burstFireSound == null)
				{
					_burstFireSound = (CName) CR2WTypeManager.Create("CName", "burstFireSound", cr2w, this);
				}
				return _burstFireSound;
			}
			set
			{
				if (_burstFireSound == value)
				{
					return;
				}
				_burstFireSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("autoFireSound")] 
		public CName AutoFireSound
		{
			get
			{
				if (_autoFireSound == null)
				{
					_autoFireSound = (CName) CR2WTypeManager.Create("CName", "autoFireSound", cr2w, this);
				}
				return _autoFireSound;
			}
			set
			{
				if (_autoFireSound == value)
				{
					return;
				}
				_autoFireSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("autoFireStop")] 
		public CName AutoFireStop
		{
			get
			{
				if (_autoFireStop == null)
				{
					_autoFireStop = (CName) CR2WTypeManager.Create("CName", "autoFireStop", cr2w, this);
				}
				return _autoFireStop;
			}
			set
			{
				if (_autoFireStop == value)
				{
					return;
				}
				_autoFireStop = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("timeLimitForAutoFireSingleShot")] 
		public CFloat TimeLimitForAutoFireSingleShot
		{
			get
			{
				if (_timeLimitForAutoFireSingleShot == null)
				{
					_timeLimitForAutoFireSingleShot = (CFloat) CR2WTypeManager.Create("Float", "timeLimitForAutoFireSingleShot", cr2w, this);
				}
				return _timeLimitForAutoFireSingleShot;
			}
			set
			{
				if (_timeLimitForAutoFireSingleShot == value)
				{
					return;
				}
				_timeLimitForAutoFireSingleShot = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("tails")] 
		public CName Tails
		{
			get
			{
				if (_tails == null)
				{
					_tails = (CName) CR2WTypeManager.Create("CName", "tails", cr2w, this);
				}
				return _tails;
			}
			set
			{
				if (_tails == value)
				{
					return;
				}
				_tails = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("shellCasingsSettings")] 
		public CName ShellCasingsSettings
		{
			get
			{
				if (_shellCasingsSettings == null)
				{
					_shellCasingsSettings = (CName) CR2WTypeManager.Create("CName", "shellCasingsSettings", cr2w, this);
				}
				return _shellCasingsSettings;
			}
			set
			{
				if (_shellCasingsSettings == value)
				{
					return;
				}
				_shellCasingsSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("weaponTailOverrides")] 
		public CHandle<audioWeaponTailOverrides> WeaponTailOverrides
		{
			get
			{
				if (_weaponTailOverrides == null)
				{
					_weaponTailOverrides = (CHandle<audioWeaponTailOverrides>) CR2WTypeManager.Create("handle:audioWeaponTailOverrides", "weaponTailOverrides", cr2w, this);
				}
				return _weaponTailOverrides;
			}
			set
			{
				if (_weaponTailOverrides == value)
				{
					return;
				}
				_weaponTailOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("quickMeleeHitEvent")] 
		public CName QuickMeleeHitEvent
		{
			get
			{
				if (_quickMeleeHitEvent == null)
				{
					_quickMeleeHitEvent = (CName) CR2WTypeManager.Create("CName", "quickMeleeHitEvent", cr2w, this);
				}
				return _quickMeleeHitEvent;
			}
			set
			{
				if (_quickMeleeHitEvent == value)
				{
					return;
				}
				_quickMeleeHitEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("initEvent")] 
		public CName InitEvent
		{
			get
			{
				if (_initEvent == null)
				{
					_initEvent = (CName) CR2WTypeManager.Create("CName", "initEvent", cr2w, this);
				}
				return _initEvent;
			}
			set
			{
				if (_initEvent == value)
				{
					return;
				}
				_initEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("shutdownEvent")] 
		public CName ShutdownEvent
		{
			get
			{
				if (_shutdownEvent == null)
				{
					_shutdownEvent = (CName) CR2WTypeManager.Create("CName", "shutdownEvent", cr2w, this);
				}
				return _shutdownEvent;
			}
			set
			{
				if (_shutdownEvent == value)
				{
					return;
				}
				_shutdownEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("aimEnterSound")] 
		public CName AimEnterSound
		{
			get
			{
				if (_aimEnterSound == null)
				{
					_aimEnterSound = (CName) CR2WTypeManager.Create("CName", "aimEnterSound", cr2w, this);
				}
				return _aimEnterSound;
			}
			set
			{
				if (_aimEnterSound == value)
				{
					return;
				}
				_aimEnterSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("aimExitSound")] 
		public CName AimExitSound
		{
			get
			{
				if (_aimExitSound == null)
				{
					_aimExitSound = (CName) CR2WTypeManager.Create("CName", "aimExitSound", cr2w, this);
				}
				return _aimExitSound;
			}
			set
			{
				if (_aimExitSound == value)
				{
					return;
				}
				_aimExitSound = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("dryFireSound")] 
		public CName DryFireSound
		{
			get
			{
				if (_dryFireSound == null)
				{
					_dryFireSound = (CName) CR2WTypeManager.Create("CName", "dryFireSound", cr2w, this);
				}
				return _dryFireSound;
			}
			set
			{
				if (_dryFireSound == value)
				{
					return;
				}
				_dryFireSound = value;
				PropertySet(this);
			}
		}

		public audioPlayerWeaponSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
