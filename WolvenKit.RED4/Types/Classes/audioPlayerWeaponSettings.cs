using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
		[RED("padVibrationGain")] 
		public CFloat PadVibrationGain
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("padVibrationReloadGain")] 
		public CFloat PadVibrationReloadGain
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("tails")] 
		public CName Tails
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(19)] 
		[RED("shellCasingsSettings")] 
		public CName ShellCasingsSettings
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("animEventOverrides")] 
		public CHandle<audioWeaponEventOverrides> AnimEventOverrides
		{
			get => GetPropertyValue<CHandle<audioWeaponEventOverrides>>();
			set => SetPropertyValue<CHandle<audioWeaponEventOverrides>>(value);
		}

		[Ordinal(21)] 
		[RED("quickMeleeHitEvent")] 
		public CName QuickMeleeHitEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(22)] 
		[RED("initEvent")] 
		public CName InitEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("shutdownEvent")] 
		public CName ShutdownEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("aimEnterSound")] 
		public CName AimEnterSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("aimExitSound")] 
		public CName AimExitSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(26)] 
		[RED("dryFireSound")] 
		public CName DryFireSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(27)] 
		[RED("reloadSound")] 
		public CName ReloadSound
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(28)] 
		[RED("triggerEffectSingle")] 
		public CName TriggerEffectSingle
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(29)] 
		[RED("triggerEffectAiming")] 
		public CName TriggerEffectAiming
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(30)] 
		[RED("triggerEffectAuto")] 
		public CName TriggerEffectAuto
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public audioPlayerWeaponSettings()
		{
			WeaponHandlingSettings = new audioWeaponHandlingSettings();
			FireModeSounds = new audioWeaponFireModeSounds();
			TimeLimitForAutoFireSingleShot = 0.250000F;
			PadVibrationGain = 1.000000F;
			PadVibrationReloadGain = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
