using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameController_Mantis_Blade : gameuiCrosshairBaseGameController
	{
		[Ordinal(27)] 
		[RED("weaponBBID")] 
		public CHandle<redCallbackObject> WeaponBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("meleeWeaponState")] 
		public CEnum<gamePSMMeleeWeapon> MeleeWeaponState
		{
			get => GetPropertyValue<CEnum<gamePSMMeleeWeapon>>();
			set => SetPropertyValue<CEnum<gamePSMMeleeWeapon>>(value);
		}

		[Ordinal(29)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("holdAnim")] 
		public CHandle<inkanimProxy> HoldAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(31)] 
		[RED("aimAnim")] 
		public CHandle<inkanimProxy> AimAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(32)] 
		[RED("isInHoldState")] 
		public CBool IsInHoldState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(33)] 
		[RED("meleeLeapAttackObjectTagger")] 
		public CHandle<MeleeLeapAttackObjectTagger> MeleeLeapAttackObjectTagger
		{
			get => GetPropertyValue<CHandle<MeleeLeapAttackObjectTagger>>();
			set => SetPropertyValue<CHandle<MeleeLeapAttackObjectTagger>>(value);
		}

		public CrosshairGameController_Mantis_Blade()
		{
			TargetColorChange = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
