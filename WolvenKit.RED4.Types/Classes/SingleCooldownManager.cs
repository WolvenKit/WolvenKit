using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SingleCooldownManager : inkWidgetLogicController
	{
		private inkImageWidgetReference _sprite;
		private inkImageWidgetReference _spriteBg;
		private inkImageWidgetReference _icon;
		private CEnum<ECooldownGameControllerMode> _type;
		private inkTextWidgetReference _name;
		private inkTextWidgetReference _desc;
		private inkTextWidgetReference _timeRemaining;
		private inkTextWidgetReference _stackCount;
		private inkRectangleWidgetReference _fill;
		private CFloat _outroDuration;
		private Vector2 _fullSizeValue;
		private CFloat _initialDuration;
		private CEnum<ECooldownIndicatorState> _state;
		private inkCompoundWidgetReference _pool;
		private inkCompoundWidgetReference _grid;
		private CHandle<inkanimProxy> _currentAnimProxy;
		private UIBuffInfo _buffData;
		private CString _defaultTimeRemainingText;
		private TweakDBID _excludedStatusEffect;
		private CString _c_EXCLUDED_STATUS_EFFECT_NAME;

		[Ordinal(1)] 
		[RED("sprite")] 
		public inkImageWidgetReference Sprite
		{
			get => GetProperty(ref _sprite);
			set => SetProperty(ref _sprite, value);
		}

		[Ordinal(2)] 
		[RED("spriteBg")] 
		public inkImageWidgetReference SpriteBg
		{
			get => GetProperty(ref _spriteBg);
			set => SetProperty(ref _spriteBg, value);
		}

		[Ordinal(3)] 
		[RED("icon")] 
		public inkImageWidgetReference Icon
		{
			get => GetProperty(ref _icon);
			set => SetProperty(ref _icon, value);
		}

		[Ordinal(4)] 
		[RED("type")] 
		public CEnum<ECooldownGameControllerMode> Type
		{
			get => GetProperty(ref _type);
			set => SetProperty(ref _type, value);
		}

		[Ordinal(5)] 
		[RED("name")] 
		public inkTextWidgetReference Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(6)] 
		[RED("desc")] 
		public inkTextWidgetReference Desc
		{
			get => GetProperty(ref _desc);
			set => SetProperty(ref _desc, value);
		}

		[Ordinal(7)] 
		[RED("timeRemaining")] 
		public inkTextWidgetReference TimeRemaining
		{
			get => GetProperty(ref _timeRemaining);
			set => SetProperty(ref _timeRemaining, value);
		}

		[Ordinal(8)] 
		[RED("stackCount")] 
		public inkTextWidgetReference StackCount
		{
			get => GetProperty(ref _stackCount);
			set => SetProperty(ref _stackCount, value);
		}

		[Ordinal(9)] 
		[RED("fill")] 
		public inkRectangleWidgetReference Fill
		{
			get => GetProperty(ref _fill);
			set => SetProperty(ref _fill, value);
		}

		[Ordinal(10)] 
		[RED("outroDuration")] 
		public CFloat OutroDuration
		{
			get => GetProperty(ref _outroDuration);
			set => SetProperty(ref _outroDuration, value);
		}

		[Ordinal(11)] 
		[RED("fullSizeValue")] 
		public Vector2 FullSizeValue
		{
			get => GetProperty(ref _fullSizeValue);
			set => SetProperty(ref _fullSizeValue, value);
		}

		[Ordinal(12)] 
		[RED("initialDuration")] 
		public CFloat InitialDuration
		{
			get => GetProperty(ref _initialDuration);
			set => SetProperty(ref _initialDuration, value);
		}

		[Ordinal(13)] 
		[RED("state")] 
		public CEnum<ECooldownIndicatorState> State
		{
			get => GetProperty(ref _state);
			set => SetProperty(ref _state, value);
		}

		[Ordinal(14)] 
		[RED("pool")] 
		public inkCompoundWidgetReference Pool
		{
			get => GetProperty(ref _pool);
			set => SetProperty(ref _pool, value);
		}

		[Ordinal(15)] 
		[RED("grid")] 
		public inkCompoundWidgetReference Grid
		{
			get => GetProperty(ref _grid);
			set => SetProperty(ref _grid, value);
		}

		[Ordinal(16)] 
		[RED("currentAnimProxy")] 
		public CHandle<inkanimProxy> CurrentAnimProxy
		{
			get => GetProperty(ref _currentAnimProxy);
			set => SetProperty(ref _currentAnimProxy, value);
		}

		[Ordinal(17)] 
		[RED("buffData")] 
		public UIBuffInfo BuffData
		{
			get => GetProperty(ref _buffData);
			set => SetProperty(ref _buffData, value);
		}

		[Ordinal(18)] 
		[RED("defaultTimeRemainingText")] 
		public CString DefaultTimeRemainingText
		{
			get => GetProperty(ref _defaultTimeRemainingText);
			set => SetProperty(ref _defaultTimeRemainingText, value);
		}

		[Ordinal(19)] 
		[RED("excludedStatusEffect")] 
		public TweakDBID ExcludedStatusEffect
		{
			get => GetProperty(ref _excludedStatusEffect);
			set => SetProperty(ref _excludedStatusEffect, value);
		}

		[Ordinal(20)] 
		[RED("C_EXCLUDED_STATUS_EFFECT_NAME")] 
		public CString C_EXCLUDED_STATUS_EFFECT_NAME
		{
			get => GetProperty(ref _c_EXCLUDED_STATUS_EFFECT_NAME);
			set => SetProperty(ref _c_EXCLUDED_STATUS_EFFECT_NAME, value);
		}
	}
}
