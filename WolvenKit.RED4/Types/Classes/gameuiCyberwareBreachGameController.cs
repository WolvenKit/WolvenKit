using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameuiCyberwareBreachGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] 
		[RED("strokeHealthDepleation")] 
		public inkWidgetReference StrokeHealthDepleation
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("adjustedScreenPosition")] 
		public Vector2 AdjustedScreenPosition
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(4)] 
		[RED("maxHealth")] 
		public CFloat MaxHealth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("currentHealth")] 
		public CFloat CurrentHealth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("lastHealth")] 
		public CFloat LastHealth
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("currentSway")] 
		public Vector2 CurrentSway
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(8)] 
		[RED("breachCanvasWRef")] 
		public inkWidgetReference BreachCanvasWRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("strokeFgRef")] 
		public inkBorderWidgetReference StrokeFgRef
		{
			get => GetPropertyValue<inkBorderWidgetReference>();
			set => SetPropertyValue<inkBorderWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("strokeBgRef")] 
		public inkBorderWidgetReference StrokeBgRef
		{
			get => GetPropertyValue<inkBorderWidgetReference>();
			set => SetPropertyValue<inkBorderWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("waveStrokeRef")] 
		public inkBorderWidgetReference WaveStrokeRef
		{
			get => GetPropertyValue<inkBorderWidgetReference>();
			set => SetPropertyValue<inkBorderWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("fillRef")] 
		public inkWidgetReference FillRef
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("textScaleWidgetRef")] 
		public inkCompoundWidgetReference TextScaleWidgetRef
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("xTextRef")] 
		public inkTextWidgetReference XTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("yTextRef")] 
		public inkTextWidgetReference YTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("errorTextRef")] 
		public inkTextWidgetReference ErrorTextRef
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(17)] 
		[RED("strokeThicknessPercent")] 
		public CFloat StrokeThicknessPercent
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(18)] 
		[RED("minThickness")] 
		public CFloat MinThickness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(19)] 
		[RED("maxThickness")] 
		public CFloat MaxThickness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(20)] 
		[RED("minTextScale")] 
		public CFloat MinTextScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(21)] 
		[RED("maxTextScale")] 
		public CFloat MaxTextScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(22)] 
		[RED("maxRadius")] 
		public CFloat MaxRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(23)] 
		[RED("minRadiusForFluff")] 
		public CFloat MinRadiusForFluff
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("previousAlmostTimeout")] 
		public CBool PreviousAlmostTimeout
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(25)] 
		[RED("cwBreachCallbackHandle")] 
		public CHandle<redCallbackObject> CwBreachCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(26)] 
		[RED("weaponSwayCallbackHandle")] 
		public CHandle<redCallbackObject> WeaponSwayCallbackHandle
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(27)] 
		[RED("introAnimationProxy")] 
		public CHandle<inkanimProxy> IntroAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(28)] 
		[RED("showAnimationProxy")] 
		public CHandle<inkanimProxy> ShowAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(29)] 
		[RED("timeoutAnimationProxy")] 
		public CHandle<inkanimProxy> TimeoutAnimationProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		public gameuiCyberwareBreachGameController()
		{
			StrokeHealthDepleation = new inkWidgetReference();
			AdjustedScreenPosition = new Vector2();
			MaxHealth = 1.000000F;
			CurrentHealth = 1.000000F;
			LastHealth = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
