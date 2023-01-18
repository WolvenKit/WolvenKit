using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameController_Mantis_Blade : gameuiCrosshairBaseGameController
	{
		[Ordinal(18)] 
		[RED("weaponBBID")] 
		public CHandle<redCallbackObject> WeaponBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(19)] 
		[RED("meleeWeaponState")] 
		public CEnum<gamePSMMeleeWeapon> MeleeWeaponState
		{
			get => GetPropertyValue<CEnum<gamePSMMeleeWeapon>>();
			set => SetPropertyValue<CEnum<gamePSMMeleeWeapon>>(value);
		}

		[Ordinal(20)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("holdAnim")] 
		public CHandle<inkanimProxy> HoldAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(22)] 
		[RED("aimAnim")] 
		public CHandle<inkanimProxy> AimAnim
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public CrosshairGameController_Mantis_Blade()
		{
			TargetColorChange = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
