using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CrosshairGameController_Launcher : gameuiCrosshairBaseGameController
	{
		[Ordinal(27)] 
		[RED("weaponBBID")] 
		public CHandle<redCallbackObject> WeaponBBID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("animationProxy")] 
		public CHandle<inkanimProxy> AnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(29)] 
		[RED("Cori_S")] 
		public inkCanvasWidgetReference Cori_S
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(30)] 
		[RED("Cori_M")] 
		public inkCanvasWidgetReference Cori_M
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(31)] 
		[RED("rightStickX")] 
		public CFloat RightStickX
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(32)] 
		[RED("rightStickY")] 
		public CFloat RightStickY
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(33)] 
		[RED("currentState")] 
		public CEnum<gamePSMLeftHandCyberware> CurrentState
		{
			get => GetPropertyValue<CEnum<gamePSMLeftHandCyberware>>();
			set => SetPropertyValue<CEnum<gamePSMLeftHandCyberware>>(value);
		}

		public CrosshairGameController_Launcher()
		{
			Cori_S = new inkCanvasWidgetReference();
			Cori_M = new inkCanvasWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
