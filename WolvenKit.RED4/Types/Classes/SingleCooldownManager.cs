using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SingleCooldownManager : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("sprite")] 
		public inkImageWidgetReference Sprite
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("spriteBg")] 
		public inkImageWidgetReference SpriteBg
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<ECooldownGameControllerMode> Type
		{
			get => GetPropertyValue<CEnum<ECooldownGameControllerMode>>();
			set => SetPropertyValue<CEnum<ECooldownGameControllerMode>>(value);
		}

		[Ordinal(5)] 
		[RED("name")] 
		public inkTextWidgetReference Name
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(7)] 
		[RED("timeRemaining")] 
		public inkTextWidgetReference TimeRemaining
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(8)] 
		[RED("stackCount")] 
		public inkTextWidgetReference StackCount
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(9)] 
		[RED("fill")] 
		public inkRectangleWidgetReference Fill
		{
			get => GetPropertyValue<inkRectangleWidgetReference>();
			set => SetPropertyValue<inkRectangleWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("outroDuration")] 
		public CFloat OutroDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("fullSizeValue")] 
		public Vector2 FullSizeValue
		{
			get => GetPropertyValue<Vector2>();
			set => SetPropertyValue<Vector2>(value);
		}

		[Ordinal(12)] 
		[RED("initialDuration")] 
		public CFloat InitialDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(13)] 
		[RED("state")] 
		public CEnum<ECooldownIndicatorState> State
		{
			get => GetPropertyValue<CEnum<ECooldownIndicatorState>>();
			set => SetPropertyValue<CEnum<ECooldownIndicatorState>>(value);
		}

		[Ordinal(14)] 
		[RED("pool")] 
		public inkCompoundWidgetReference Pool
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(15)] 
		[RED("grid")] 
		public inkCompoundWidgetReference Grid
		{
			get => GetPropertyValue<inkCompoundWidgetReference>();
			set => SetPropertyValue<inkCompoundWidgetReference>(value);
		}

		[Ordinal(16)] 
		[RED("currentAnimProxy")] 
		public CHandle<inkanimProxy> CurrentAnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(17)] 
		[RED("buffData")] 
		public UIBuffInfo BuffData
		{
			get => GetPropertyValue<UIBuffInfo>();
			set => SetPropertyValue<UIBuffInfo>(value);
		}

		[Ordinal(18)] 
		[RED("defaultTimeRemainingText")] 
		public CString DefaultTimeRemainingText
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(19)] 
		[RED("excludedStatusEffect")] 
		public TweakDBID ExcludedStatusEffect
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(20)] 
		[RED("C_EXCLUDED_STATUS_EFFECT_NAME")] 
		public CString C_EXCLUDED_STATUS_EFFECT_NAME
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public SingleCooldownManager()
		{
			Sprite = new inkImageWidgetReference();
			SpriteBg = new inkImageWidgetReference();
			Icon = new inkImageWidgetReference();
			Name = new inkTextWidgetReference();
			Desc = new inkTextWidgetReference();
			TimeRemaining = new inkTextWidgetReference();
			StackCount = new inkTextWidgetReference();
			Fill = new inkRectangleWidgetReference();
			FullSizeValue = new Vector2();
			Pool = new inkCompoundWidgetReference();
			Grid = new inkCompoundWidgetReference();
			BuffData = new UIBuffInfo();
			C_EXCLUDED_STATUS_EFFECT_NAME = "BaseStatusEffect.AlcoholDebuff";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
