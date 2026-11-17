using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GyroRestrictionsDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("MeleeWeaponRestrictedForPatterns")] 
		public gamebbScriptID_Bool MeleeWeaponRestrictedForPatterns
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(1)] 
		[RED("FullPatternRestriction")] 
		public gamebbScriptID_Bool FullPatternRestriction
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(2)] 
		[RED("NonThrowableWeaponRestriction")] 
		public gamebbScriptID_Bool NonThrowableWeaponRestriction
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(3)] 
		[RED("ThrowableWeaponRestriction")] 
		public gamebbScriptID_Bool ThrowableWeaponRestriction
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(4)] 
		[RED("DodgePlayerStateRestriction")] 
		public gamebbScriptID_Bool DodgePlayerStateRestriction
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(5)] 
		[RED("DodgeStatRestriction")] 
		public gamebbScriptID_Bool DodgeStatRestriction
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(6)] 
		[RED("MeleeAttackPlayerStateRestriction")] 
		public gamebbScriptID_Bool MeleeAttackPlayerStateRestriction
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(7)] 
		[RED("ActivateGyroAimingForRangedWeapons")] 
		public gamebbScriptID_Bool ActivateGyroAimingForRangedWeapons
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(8)] 
		[RED("ActivateGyroAimingForAiming")] 
		public gamebbScriptID_Bool ActivateGyroAimingForAiming
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(9)] 
		[RED("SettingsPatternMatchingMeleeEnabled")] 
		public gamebbScriptID_Bool SettingsPatternMatchingMeleeEnabled
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(10)] 
		[RED("IsInsideOfChargePattern")] 
		public gamebbScriptID_Bool IsInsideOfChargePattern
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(11)] 
		[RED("IsShootingWithRangedWeapon")] 
		public gamebbScriptID_Bool IsShootingWithRangedWeapon
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public GyroRestrictionsDef()
		{
			MeleeWeaponRestrictedForPatterns = new gamebbScriptID_Bool();
			FullPatternRestriction = new gamebbScriptID_Bool();
			NonThrowableWeaponRestriction = new gamebbScriptID_Bool();
			ThrowableWeaponRestriction = new gamebbScriptID_Bool();
			DodgePlayerStateRestriction = new gamebbScriptID_Bool();
			DodgeStatRestriction = new gamebbScriptID_Bool();
			MeleeAttackPlayerStateRestriction = new gamebbScriptID_Bool();
			ActivateGyroAimingForRangedWeapons = new gamebbScriptID_Bool();
			ActivateGyroAimingForAiming = new gamebbScriptID_Bool();
			SettingsPatternMatchingMeleeEnabled = new gamebbScriptID_Bool();
			IsInsideOfChargePattern = new gamebbScriptID_Bool();
			IsShootingWithRangedWeapon = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
