using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class Crosshair_Melee_Knife : gameuiCrosshairBaseGameController
	{
		[Ordinal(29)] 
		[RED("targetColorChange")] 
		public inkWidgetReference TargetColorChange
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("leftPart")] 
		public inkWidgetReference LeftPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("rightPart")] 
		public inkWidgetReference RightPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(32)] 
		[RED("topPart")] 
		public inkWidgetReference TopPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(33)] 
		[RED("botPart")] 
		public inkWidgetReference BotPart
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(34)] 
		[RED("chargeBar")] 
		public CWeakHandle<inkCanvasWidget> ChargeBar
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		[Ordinal(35)] 
		[RED("chargeBarFG")] 
		public CWeakHandle<inkRectangleWidget> ChargeBarFG
		{
			get => GetPropertyValue<CWeakHandle<inkRectangleWidget>>();
			set => SetPropertyValue<CWeakHandle<inkRectangleWidget>>(value);
		}

		[Ordinal(36)] 
		[RED("throwingKnifeResourcePoolListener")] 
		public CHandle<ThrowingKnifeResourcePoolListener> ThrowingKnifeResourcePoolListener
		{
			get => GetPropertyValue<CHandle<ThrowingKnifeResourcePoolListener>>();
			set => SetPropertyValue<CHandle<ThrowingKnifeResourcePoolListener>>(value);
		}

		[Ordinal(37)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(38)] 
		[RED("weaponBBID")] 
		public CHandle<redCallbackObject> WeaponBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(39)] 
		[RED("meleeWeaponState")] 
		public CEnum<gamePSMMeleeWeapon> MeleeWeaponState
		{
			get => GetPropertyValue<CEnum<gamePSMMeleeWeapon>>();
			set => SetPropertyValue<CEnum<gamePSMMeleeWeapon>>(value);
		}

		[Ordinal(40)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(41)] 
		[RED("animOptions")] 
		public inkanimPlaybackOptions AnimOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(42)] 
		[RED("isCrosshairAnimationOpen")] 
		public CBool IsCrosshairAnimationOpen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(43)] 
		[RED("preloaderThinL")] 
		public CWeakHandle<inkImageWidget> PreloaderThinL
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(44)] 
		[RED("preloaderThinR")] 
		public CWeakHandle<inkImageWidget> PreloaderThinR
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(45)] 
		[RED("preloaderThickL")] 
		public CWeakHandle<inkImageWidget> PreloaderThickL
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(46)] 
		[RED("preloaderThickR")] 
		public CWeakHandle<inkImageWidget> PreloaderThickR
		{
			get => GetPropertyValue<CWeakHandle<inkImageWidget>>();
			set => SetPropertyValue<CWeakHandle<inkImageWidget>>(value);
		}

		[Ordinal(47)] 
		[RED("preloader")] 
		public CWeakHandle<inkCanvasWidget> Preloader
		{
			get => GetPropertyValue<CWeakHandle<inkCanvasWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCanvasWidget>>(value);
		}

		public Crosshair_Melee_Knife()
		{
			TargetColorChange = new inkWidgetReference();
			LeftPart = new inkWidgetReference();
			RightPart = new inkWidgetReference();
			TopPart = new inkWidgetReference();
			BotPart = new inkWidgetReference();
			WeaponID = new entEntityID();
			AnimOptions = new inkanimPlaybackOptions { CustomTimeDilation = 1.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
