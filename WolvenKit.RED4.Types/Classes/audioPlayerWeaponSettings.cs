using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioPlayerWeaponSettings : audioWeaponSettings
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
			get => GetProperty(ref _fireSound);
			set => SetProperty(ref _fireSound, value);
		}

		[Ordinal(11)] 
		[RED("preFireSound")] 
		public CName PreFireSound
		{
			get => GetProperty(ref _preFireSound);
			set => SetProperty(ref _preFireSound, value);
		}

		[Ordinal(12)] 
		[RED("burstFireSound")] 
		public CName BurstFireSound
		{
			get => GetProperty(ref _burstFireSound);
			set => SetProperty(ref _burstFireSound, value);
		}

		[Ordinal(13)] 
		[RED("autoFireSound")] 
		public CName AutoFireSound
		{
			get => GetProperty(ref _autoFireSound);
			set => SetProperty(ref _autoFireSound, value);
		}

		[Ordinal(14)] 
		[RED("autoFireStop")] 
		public CName AutoFireStop
		{
			get => GetProperty(ref _autoFireStop);
			set => SetProperty(ref _autoFireStop, value);
		}

		[Ordinal(15)] 
		[RED("timeLimitForAutoFireSingleShot")] 
		public CFloat TimeLimitForAutoFireSingleShot
		{
			get => GetProperty(ref _timeLimitForAutoFireSingleShot);
			set => SetProperty(ref _timeLimitForAutoFireSingleShot, value);
		}

		[Ordinal(16)] 
		[RED("tails")] 
		public CName Tails
		{
			get => GetProperty(ref _tails);
			set => SetProperty(ref _tails, value);
		}

		[Ordinal(17)] 
		[RED("shellCasingsSettings")] 
		public CName ShellCasingsSettings
		{
			get => GetProperty(ref _shellCasingsSettings);
			set => SetProperty(ref _shellCasingsSettings, value);
		}

		[Ordinal(18)] 
		[RED("weaponTailOverrides")] 
		public CHandle<audioWeaponTailOverrides> WeaponTailOverrides
		{
			get => GetProperty(ref _weaponTailOverrides);
			set => SetProperty(ref _weaponTailOverrides, value);
		}

		[Ordinal(19)] 
		[RED("quickMeleeHitEvent")] 
		public CName QuickMeleeHitEvent
		{
			get => GetProperty(ref _quickMeleeHitEvent);
			set => SetProperty(ref _quickMeleeHitEvent, value);
		}

		[Ordinal(20)] 
		[RED("initEvent")] 
		public CName InitEvent
		{
			get => GetProperty(ref _initEvent);
			set => SetProperty(ref _initEvent, value);
		}

		[Ordinal(21)] 
		[RED("shutdownEvent")] 
		public CName ShutdownEvent
		{
			get => GetProperty(ref _shutdownEvent);
			set => SetProperty(ref _shutdownEvent, value);
		}

		[Ordinal(22)] 
		[RED("aimEnterSound")] 
		public CName AimEnterSound
		{
			get => GetProperty(ref _aimEnterSound);
			set => SetProperty(ref _aimEnterSound, value);
		}

		[Ordinal(23)] 
		[RED("aimExitSound")] 
		public CName AimExitSound
		{
			get => GetProperty(ref _aimExitSound);
			set => SetProperty(ref _aimExitSound, value);
		}

		[Ordinal(24)] 
		[RED("dryFireSound")] 
		public CName DryFireSound
		{
			get => GetProperty(ref _dryFireSound);
			set => SetProperty(ref _dryFireSound, value);
		}

		public audioPlayerWeaponSettings()
		{
			_timeLimitForAutoFireSingleShot = 0.250000F;
		}
	}
}
