using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class audioPlayerWeaponSettings : audioWeaponSettings
	{
		[Ordinal(10)] 
		[RED("fireSound")] 
		public CName FireSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(11)] 
		[RED("preFireSound")] 
		public CName PreFireSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("burstFireSound")] 
		public CName BurstFireSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("autoFireSound")] 
		public CName AutoFireSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(14)] 
		[RED("autoFireStop")] 
		public CName AutoFireStop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(15)] 
		[RED("timeLimitForAutoFireSingleShot")] 
		public CFloat TimeLimitForAutoFireSingleShot
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(16)] 
		[RED("tails")] 
		public CName Tails
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("shellCasingsSettings")] 
		public CName ShellCasingsSettings
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(18)] 
		[RED("weaponTailOverrides")] 
		public CHandle<audioWeaponTailOverrides> WeaponTailOverrides
		{
			get => GetPropertyValue<CHandle<audioWeaponTailOverrides>>();
			set => SetPropertyValue<CHandle<audioWeaponTailOverrides>>(value);
		}

		[Ordinal(19)] 
		[RED("quickMeleeHitEvent")] 
		public CName QuickMeleeHitEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("initEvent")] 
		public CName InitEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("shutdownEvent")] 
		public CName ShutdownEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("aimEnterSound")] 
		public CName AimEnterSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("aimExitSound")] 
		public CName AimExitSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("dryFireSound")] 
		public CName DryFireSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioPlayerWeaponSettings()
		{
			WeaponHandlingSettings = new();
			FireModeSounds = new();
			TimeLimitForAutoFireSingleShot = 0.250000F;
		}
	}
}
