using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DamageDigitLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _critWidget;
		private inkTextWidgetReference _headshotWidget;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<inkWidget> _panelWidget;
		private wCHandle<inkTextWidget> _textWidget;
		private wCHandle<DamageDigitsGameController> _gameController;
		private CBool _active;
		private CBool _successful;
		private CBool _successfulCritical;
		private CBool _showingBothDigits;
		private CFloat _distanceModifier;
		private CFloat _calculatedDistanceHeightBias;
		private CFloat _stickingDistanceHeightBias;
		private CBool _stickToTarget;
		private CBool _forceStickToTarget;
		private CHandle<inkScreenProjection> _projection;
		private CHandle<inkanimDefinition> _showPositiveAnimDef;
		private CHandle<inkanimTransparencyInterpolator> _showPositiveAnimFadeInInterpolator;
		private CHandle<inkanimTransparencyInterpolator> _showPositiveAnimFadeOutInterpolator;
		private CHandle<inkanimMarginInterpolator> _showPositiveAnimMarginInterpolator;
		private CHandle<inkanimScaleInterpolator> _showPositiveAnimScaleInterpolator;
		private CHandle<inkanimDefinition> _showNegativeAnimDef;
		private CHandle<inkanimTransparencyInterpolator> _showNegativeAnimFadeInInterpolator;
		private CHandle<inkanimTransparencyInterpolator> _showNegativeAnimFadeOutInterpolator;
		private CHandle<inkanimMarginInterpolator> _showNegativeAnimMarginInterpolator;
		private CHandle<inkanimScaleInterpolator> _showNegativeAnimScaleInterpolator;
		private Vector4 _animStickTargetOffset;
		private CFloat _animTimeFadeIn;
		private CFloat _animTimeFadeOut;
		private CFloat _animBothTimeFadeIn;
		private CFloat _animBothTimeFadeOut;
		private CFloat _animTimeDelay;
		private CFloat _animTimeCritDelay;
		private CFloat _animBothTimeDelay;
		private CFloat _animBothTimeCritDelay;
		private CFloat _animStartHeight;
		private CFloat _animAngleMin1;
		private CFloat _animAngleMin2;
		private CFloat _animAngleMax1;
		private CFloat _animAngleMax2;
		private CFloat _animBothAngleMin1;
		private CFloat _animBothAngleMin2;
		private CFloat _animBothAngleMax1;
		private CFloat _animBothAngleMax2;
		private CFloat _animDistanceMin;
		private CFloat _animDistanceMax;
		private CFloat _animDistanceMin_Crit;
		private CFloat _animDistanceMax_Crit;
		private CFloat _animBothOffsetX;
		private CFloat _animBothOffsetY;
		private CFloat _animBothStickingOffsetY;
		private CFloat _animStickTargetWorldZOffset;
		private CFloat _animStickingOffsetY;
		private CFloat _animDistanceModifierMinDistance;
		private CFloat _animDistanceModifierMaxDistance;
		private CFloat _animDistanceModifierMinValue;
		private CFloat _animDistanceModifierMaxValue;
		private CFloat _animDistanceHeightBias;
		private CFloat _animStickingDistanceHeightBias;
		private CFloat _animPositiveOpacity;
		private CFloat _animNegativeOpacity;
		private CFloat _animDynamicDuration;
		private CFloat _animDynamicDelay;
		private CFloat _animDynamicCritDuration;
		private CFloat _animDynamicCritDelay;

		[Ordinal(1)] 
		[RED("critWidget")] 
		public inkTextWidgetReference CritWidget
		{
			get
			{
				if (_critWidget == null)
				{
					_critWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "critWidget", cr2w, this);
				}
				return _critWidget;
			}
			set
			{
				if (_critWidget == value)
				{
					return;
				}
				_critWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("headshotWidget")] 
		public inkTextWidgetReference HeadshotWidget
		{
			get
			{
				if (_headshotWidget == null)
				{
					_headshotWidget = (inkTextWidgetReference) CR2WTypeManager.Create("inkTextWidgetReference", "headshotWidget", cr2w, this);
				}
				return _headshotWidget;
			}
			set
			{
				if (_headshotWidget == value)
				{
					return;
				}
				_headshotWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rootWidget")] 
		public wCHandle<inkWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "rootWidget", cr2w, this);
				}
				return _rootWidget;
			}
			set
			{
				if (_rootWidget == value)
				{
					return;
				}
				_rootWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("panelWidget")] 
		public wCHandle<inkWidget> PanelWidget
		{
			get
			{
				if (_panelWidget == null)
				{
					_panelWidget = (wCHandle<inkWidget>) CR2WTypeManager.Create("whandle:inkWidget", "panelWidget", cr2w, this);
				}
				return _panelWidget;
			}
			set
			{
				if (_panelWidget == value)
				{
					return;
				}
				_panelWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("textWidget")] 
		public wCHandle<inkTextWidget> TextWidget
		{
			get
			{
				if (_textWidget == null)
				{
					_textWidget = (wCHandle<inkTextWidget>) CR2WTypeManager.Create("whandle:inkTextWidget", "textWidget", cr2w, this);
				}
				return _textWidget;
			}
			set
			{
				if (_textWidget == value)
				{
					return;
				}
				_textWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("gameController")] 
		public wCHandle<DamageDigitsGameController> GameController
		{
			get
			{
				if (_gameController == null)
				{
					_gameController = (wCHandle<DamageDigitsGameController>) CR2WTypeManager.Create("whandle:DamageDigitsGameController", "gameController", cr2w, this);
				}
				return _gameController;
			}
			set
			{
				if (_gameController == value)
				{
					return;
				}
				_gameController = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("active")] 
		public CBool Active
		{
			get
			{
				if (_active == null)
				{
					_active = (CBool) CR2WTypeManager.Create("Bool", "active", cr2w, this);
				}
				return _active;
			}
			set
			{
				if (_active == value)
				{
					return;
				}
				_active = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("successful")] 
		public CBool Successful
		{
			get
			{
				if (_successful == null)
				{
					_successful = (CBool) CR2WTypeManager.Create("Bool", "successful", cr2w, this);
				}
				return _successful;
			}
			set
			{
				if (_successful == value)
				{
					return;
				}
				_successful = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("successfulCritical")] 
		public CBool SuccessfulCritical
		{
			get
			{
				if (_successfulCritical == null)
				{
					_successfulCritical = (CBool) CR2WTypeManager.Create("Bool", "successfulCritical", cr2w, this);
				}
				return _successfulCritical;
			}
			set
			{
				if (_successfulCritical == value)
				{
					return;
				}
				_successfulCritical = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("showingBothDigits")] 
		public CBool ShowingBothDigits
		{
			get
			{
				if (_showingBothDigits == null)
				{
					_showingBothDigits = (CBool) CR2WTypeManager.Create("Bool", "showingBothDigits", cr2w, this);
				}
				return _showingBothDigits;
			}
			set
			{
				if (_showingBothDigits == value)
				{
					return;
				}
				_showingBothDigits = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("distanceModifier")] 
		public CFloat DistanceModifier
		{
			get
			{
				if (_distanceModifier == null)
				{
					_distanceModifier = (CFloat) CR2WTypeManager.Create("Float", "distanceModifier", cr2w, this);
				}
				return _distanceModifier;
			}
			set
			{
				if (_distanceModifier == value)
				{
					return;
				}
				_distanceModifier = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("calculatedDistanceHeightBias")] 
		public CFloat CalculatedDistanceHeightBias
		{
			get
			{
				if (_calculatedDistanceHeightBias == null)
				{
					_calculatedDistanceHeightBias = (CFloat) CR2WTypeManager.Create("Float", "calculatedDistanceHeightBias", cr2w, this);
				}
				return _calculatedDistanceHeightBias;
			}
			set
			{
				if (_calculatedDistanceHeightBias == value)
				{
					return;
				}
				_calculatedDistanceHeightBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("stickingDistanceHeightBias")] 
		public CFloat StickingDistanceHeightBias
		{
			get
			{
				if (_stickingDistanceHeightBias == null)
				{
					_stickingDistanceHeightBias = (CFloat) CR2WTypeManager.Create("Float", "stickingDistanceHeightBias", cr2w, this);
				}
				return _stickingDistanceHeightBias;
			}
			set
			{
				if (_stickingDistanceHeightBias == value)
				{
					return;
				}
				_stickingDistanceHeightBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("stickToTarget")] 
		public CBool StickToTarget
		{
			get
			{
				if (_stickToTarget == null)
				{
					_stickToTarget = (CBool) CR2WTypeManager.Create("Bool", "stickToTarget", cr2w, this);
				}
				return _stickToTarget;
			}
			set
			{
				if (_stickToTarget == value)
				{
					return;
				}
				_stickToTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("forceStickToTarget")] 
		public CBool ForceStickToTarget
		{
			get
			{
				if (_forceStickToTarget == null)
				{
					_forceStickToTarget = (CBool) CR2WTypeManager.Create("Bool", "forceStickToTarget", cr2w, this);
				}
				return _forceStickToTarget;
			}
			set
			{
				if (_forceStickToTarget == value)
				{
					return;
				}
				_forceStickToTarget = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("projection")] 
		public CHandle<inkScreenProjection> Projection
		{
			get
			{
				if (_projection == null)
				{
					_projection = (CHandle<inkScreenProjection>) CR2WTypeManager.Create("handle:inkScreenProjection", "projection", cr2w, this);
				}
				return _projection;
			}
			set
			{
				if (_projection == value)
				{
					return;
				}
				_projection = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("showPositiveAnimDef")] 
		public CHandle<inkanimDefinition> ShowPositiveAnimDef
		{
			get
			{
				if (_showPositiveAnimDef == null)
				{
					_showPositiveAnimDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "showPositiveAnimDef", cr2w, this);
				}
				return _showPositiveAnimDef;
			}
			set
			{
				if (_showPositiveAnimDef == value)
				{
					return;
				}
				_showPositiveAnimDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("showPositiveAnimFadeInInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeInInterpolator
		{
			get
			{
				if (_showPositiveAnimFadeInInterpolator == null)
				{
					_showPositiveAnimFadeInInterpolator = (CHandle<inkanimTransparencyInterpolator>) CR2WTypeManager.Create("handle:inkanimTransparencyInterpolator", "showPositiveAnimFadeInInterpolator", cr2w, this);
				}
				return _showPositiveAnimFadeInInterpolator;
			}
			set
			{
				if (_showPositiveAnimFadeInInterpolator == value)
				{
					return;
				}
				_showPositiveAnimFadeInInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("showPositiveAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowPositiveAnimFadeOutInterpolator
		{
			get
			{
				if (_showPositiveAnimFadeOutInterpolator == null)
				{
					_showPositiveAnimFadeOutInterpolator = (CHandle<inkanimTransparencyInterpolator>) CR2WTypeManager.Create("handle:inkanimTransparencyInterpolator", "showPositiveAnimFadeOutInterpolator", cr2w, this);
				}
				return _showPositiveAnimFadeOutInterpolator;
			}
			set
			{
				if (_showPositiveAnimFadeOutInterpolator == value)
				{
					return;
				}
				_showPositiveAnimFadeOutInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
		[RED("showPositiveAnimMarginInterpolator")] 
		public CHandle<inkanimMarginInterpolator> ShowPositiveAnimMarginInterpolator
		{
			get
			{
				if (_showPositiveAnimMarginInterpolator == null)
				{
					_showPositiveAnimMarginInterpolator = (CHandle<inkanimMarginInterpolator>) CR2WTypeManager.Create("handle:inkanimMarginInterpolator", "showPositiveAnimMarginInterpolator", cr2w, this);
				}
				return _showPositiveAnimMarginInterpolator;
			}
			set
			{
				if (_showPositiveAnimMarginInterpolator == value)
				{
					return;
				}
				_showPositiveAnimMarginInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(21)] 
		[RED("showPositiveAnimScaleInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ShowPositiveAnimScaleInterpolator
		{
			get
			{
				if (_showPositiveAnimScaleInterpolator == null)
				{
					_showPositiveAnimScaleInterpolator = (CHandle<inkanimScaleInterpolator>) CR2WTypeManager.Create("handle:inkanimScaleInterpolator", "showPositiveAnimScaleInterpolator", cr2w, this);
				}
				return _showPositiveAnimScaleInterpolator;
			}
			set
			{
				if (_showPositiveAnimScaleInterpolator == value)
				{
					return;
				}
				_showPositiveAnimScaleInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(22)] 
		[RED("showNegativeAnimDef")] 
		public CHandle<inkanimDefinition> ShowNegativeAnimDef
		{
			get
			{
				if (_showNegativeAnimDef == null)
				{
					_showNegativeAnimDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "showNegativeAnimDef", cr2w, this);
				}
				return _showNegativeAnimDef;
			}
			set
			{
				if (_showNegativeAnimDef == value)
				{
					return;
				}
				_showNegativeAnimDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(23)] 
		[RED("showNegativeAnimFadeInInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeInInterpolator
		{
			get
			{
				if (_showNegativeAnimFadeInInterpolator == null)
				{
					_showNegativeAnimFadeInInterpolator = (CHandle<inkanimTransparencyInterpolator>) CR2WTypeManager.Create("handle:inkanimTransparencyInterpolator", "showNegativeAnimFadeInInterpolator", cr2w, this);
				}
				return _showNegativeAnimFadeInInterpolator;
			}
			set
			{
				if (_showNegativeAnimFadeInInterpolator == value)
				{
					return;
				}
				_showNegativeAnimFadeInInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("showNegativeAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowNegativeAnimFadeOutInterpolator
		{
			get
			{
				if (_showNegativeAnimFadeOutInterpolator == null)
				{
					_showNegativeAnimFadeOutInterpolator = (CHandle<inkanimTransparencyInterpolator>) CR2WTypeManager.Create("handle:inkanimTransparencyInterpolator", "showNegativeAnimFadeOutInterpolator", cr2w, this);
				}
				return _showNegativeAnimFadeOutInterpolator;
			}
			set
			{
				if (_showNegativeAnimFadeOutInterpolator == value)
				{
					return;
				}
				_showNegativeAnimFadeOutInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("showNegativeAnimMarginInterpolator")] 
		public CHandle<inkanimMarginInterpolator> ShowNegativeAnimMarginInterpolator
		{
			get
			{
				if (_showNegativeAnimMarginInterpolator == null)
				{
					_showNegativeAnimMarginInterpolator = (CHandle<inkanimMarginInterpolator>) CR2WTypeManager.Create("handle:inkanimMarginInterpolator", "showNegativeAnimMarginInterpolator", cr2w, this);
				}
				return _showNegativeAnimMarginInterpolator;
			}
			set
			{
				if (_showNegativeAnimMarginInterpolator == value)
				{
					return;
				}
				_showNegativeAnimMarginInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("showNegativeAnimScaleInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ShowNegativeAnimScaleInterpolator
		{
			get
			{
				if (_showNegativeAnimScaleInterpolator == null)
				{
					_showNegativeAnimScaleInterpolator = (CHandle<inkanimScaleInterpolator>) CR2WTypeManager.Create("handle:inkanimScaleInterpolator", "showNegativeAnimScaleInterpolator", cr2w, this);
				}
				return _showNegativeAnimScaleInterpolator;
			}
			set
			{
				if (_showNegativeAnimScaleInterpolator == value)
				{
					return;
				}
				_showNegativeAnimScaleInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("animStickTargetOffset")] 
		public Vector4 AnimStickTargetOffset
		{
			get
			{
				if (_animStickTargetOffset == null)
				{
					_animStickTargetOffset = (Vector4) CR2WTypeManager.Create("Vector4", "animStickTargetOffset", cr2w, this);
				}
				return _animStickTargetOffset;
			}
			set
			{
				if (_animStickTargetOffset == value)
				{
					return;
				}
				_animStickTargetOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("animTimeFadeIn")] 
		public CFloat AnimTimeFadeIn
		{
			get
			{
				if (_animTimeFadeIn == null)
				{
					_animTimeFadeIn = (CFloat) CR2WTypeManager.Create("Float", "animTimeFadeIn", cr2w, this);
				}
				return _animTimeFadeIn;
			}
			set
			{
				if (_animTimeFadeIn == value)
				{
					return;
				}
				_animTimeFadeIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("animTimeFadeOut")] 
		public CFloat AnimTimeFadeOut
		{
			get
			{
				if (_animTimeFadeOut == null)
				{
					_animTimeFadeOut = (CFloat) CR2WTypeManager.Create("Float", "animTimeFadeOut", cr2w, this);
				}
				return _animTimeFadeOut;
			}
			set
			{
				if (_animTimeFadeOut == value)
				{
					return;
				}
				_animTimeFadeOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("animBothTimeFadeIn")] 
		public CFloat AnimBothTimeFadeIn
		{
			get
			{
				if (_animBothTimeFadeIn == null)
				{
					_animBothTimeFadeIn = (CFloat) CR2WTypeManager.Create("Float", "animBothTimeFadeIn", cr2w, this);
				}
				return _animBothTimeFadeIn;
			}
			set
			{
				if (_animBothTimeFadeIn == value)
				{
					return;
				}
				_animBothTimeFadeIn = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
		[RED("animBothTimeFadeOut")] 
		public CFloat AnimBothTimeFadeOut
		{
			get
			{
				if (_animBothTimeFadeOut == null)
				{
					_animBothTimeFadeOut = (CFloat) CR2WTypeManager.Create("Float", "animBothTimeFadeOut", cr2w, this);
				}
				return _animBothTimeFadeOut;
			}
			set
			{
				if (_animBothTimeFadeOut == value)
				{
					return;
				}
				_animBothTimeFadeOut = value;
				PropertySet(this);
			}
		}

		[Ordinal(32)] 
		[RED("animTimeDelay")] 
		public CFloat AnimTimeDelay
		{
			get
			{
				if (_animTimeDelay == null)
				{
					_animTimeDelay = (CFloat) CR2WTypeManager.Create("Float", "animTimeDelay", cr2w, this);
				}
				return _animTimeDelay;
			}
			set
			{
				if (_animTimeDelay == value)
				{
					return;
				}
				_animTimeDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(33)] 
		[RED("animTimeCritDelay")] 
		public CFloat AnimTimeCritDelay
		{
			get
			{
				if (_animTimeCritDelay == null)
				{
					_animTimeCritDelay = (CFloat) CR2WTypeManager.Create("Float", "animTimeCritDelay", cr2w, this);
				}
				return _animTimeCritDelay;
			}
			set
			{
				if (_animTimeCritDelay == value)
				{
					return;
				}
				_animTimeCritDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(34)] 
		[RED("animBothTimeDelay")] 
		public CFloat AnimBothTimeDelay
		{
			get
			{
				if (_animBothTimeDelay == null)
				{
					_animBothTimeDelay = (CFloat) CR2WTypeManager.Create("Float", "animBothTimeDelay", cr2w, this);
				}
				return _animBothTimeDelay;
			}
			set
			{
				if (_animBothTimeDelay == value)
				{
					return;
				}
				_animBothTimeDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(35)] 
		[RED("animBothTimeCritDelay")] 
		public CFloat AnimBothTimeCritDelay
		{
			get
			{
				if (_animBothTimeCritDelay == null)
				{
					_animBothTimeCritDelay = (CFloat) CR2WTypeManager.Create("Float", "animBothTimeCritDelay", cr2w, this);
				}
				return _animBothTimeCritDelay;
			}
			set
			{
				if (_animBothTimeCritDelay == value)
				{
					return;
				}
				_animBothTimeCritDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("animStartHeight")] 
		public CFloat AnimStartHeight
		{
			get
			{
				if (_animStartHeight == null)
				{
					_animStartHeight = (CFloat) CR2WTypeManager.Create("Float", "animStartHeight", cr2w, this);
				}
				return _animStartHeight;
			}
			set
			{
				if (_animStartHeight == value)
				{
					return;
				}
				_animStartHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
		[RED("animAngleMin1")] 
		public CFloat AnimAngleMin1
		{
			get
			{
				if (_animAngleMin1 == null)
				{
					_animAngleMin1 = (CFloat) CR2WTypeManager.Create("Float", "animAngleMin1", cr2w, this);
				}
				return _animAngleMin1;
			}
			set
			{
				if (_animAngleMin1 == value)
				{
					return;
				}
				_animAngleMin1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(38)] 
		[RED("animAngleMin2")] 
		public CFloat AnimAngleMin2
		{
			get
			{
				if (_animAngleMin2 == null)
				{
					_animAngleMin2 = (CFloat) CR2WTypeManager.Create("Float", "animAngleMin2", cr2w, this);
				}
				return _animAngleMin2;
			}
			set
			{
				if (_animAngleMin2 == value)
				{
					return;
				}
				_animAngleMin2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(39)] 
		[RED("animAngleMax1")] 
		public CFloat AnimAngleMax1
		{
			get
			{
				if (_animAngleMax1 == null)
				{
					_animAngleMax1 = (CFloat) CR2WTypeManager.Create("Float", "animAngleMax1", cr2w, this);
				}
				return _animAngleMax1;
			}
			set
			{
				if (_animAngleMax1 == value)
				{
					return;
				}
				_animAngleMax1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(40)] 
		[RED("animAngleMax2")] 
		public CFloat AnimAngleMax2
		{
			get
			{
				if (_animAngleMax2 == null)
				{
					_animAngleMax2 = (CFloat) CR2WTypeManager.Create("Float", "animAngleMax2", cr2w, this);
				}
				return _animAngleMax2;
			}
			set
			{
				if (_animAngleMax2 == value)
				{
					return;
				}
				_animAngleMax2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(41)] 
		[RED("animBothAngleMin1")] 
		public CFloat AnimBothAngleMin1
		{
			get
			{
				if (_animBothAngleMin1 == null)
				{
					_animBothAngleMin1 = (CFloat) CR2WTypeManager.Create("Float", "animBothAngleMin1", cr2w, this);
				}
				return _animBothAngleMin1;
			}
			set
			{
				if (_animBothAngleMin1 == value)
				{
					return;
				}
				_animBothAngleMin1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("animBothAngleMin2")] 
		public CFloat AnimBothAngleMin2
		{
			get
			{
				if (_animBothAngleMin2 == null)
				{
					_animBothAngleMin2 = (CFloat) CR2WTypeManager.Create("Float", "animBothAngleMin2", cr2w, this);
				}
				return _animBothAngleMin2;
			}
			set
			{
				if (_animBothAngleMin2 == value)
				{
					return;
				}
				_animBothAngleMin2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
		[RED("animBothAngleMax1")] 
		public CFloat AnimBothAngleMax1
		{
			get
			{
				if (_animBothAngleMax1 == null)
				{
					_animBothAngleMax1 = (CFloat) CR2WTypeManager.Create("Float", "animBothAngleMax1", cr2w, this);
				}
				return _animBothAngleMax1;
			}
			set
			{
				if (_animBothAngleMax1 == value)
				{
					return;
				}
				_animBothAngleMax1 = value;
				PropertySet(this);
			}
		}

		[Ordinal(44)] 
		[RED("animBothAngleMax2")] 
		public CFloat AnimBothAngleMax2
		{
			get
			{
				if (_animBothAngleMax2 == null)
				{
					_animBothAngleMax2 = (CFloat) CR2WTypeManager.Create("Float", "animBothAngleMax2", cr2w, this);
				}
				return _animBothAngleMax2;
			}
			set
			{
				if (_animBothAngleMax2 == value)
				{
					return;
				}
				_animBothAngleMax2 = value;
				PropertySet(this);
			}
		}

		[Ordinal(45)] 
		[RED("animDistanceMin")] 
		public CFloat AnimDistanceMin
		{
			get
			{
				if (_animDistanceMin == null)
				{
					_animDistanceMin = (CFloat) CR2WTypeManager.Create("Float", "animDistanceMin", cr2w, this);
				}
				return _animDistanceMin;
			}
			set
			{
				if (_animDistanceMin == value)
				{
					return;
				}
				_animDistanceMin = value;
				PropertySet(this);
			}
		}

		[Ordinal(46)] 
		[RED("animDistanceMax")] 
		public CFloat AnimDistanceMax
		{
			get
			{
				if (_animDistanceMax == null)
				{
					_animDistanceMax = (CFloat) CR2WTypeManager.Create("Float", "animDistanceMax", cr2w, this);
				}
				return _animDistanceMax;
			}
			set
			{
				if (_animDistanceMax == value)
				{
					return;
				}
				_animDistanceMax = value;
				PropertySet(this);
			}
		}

		[Ordinal(47)] 
		[RED("animDistanceMin_Crit")] 
		public CFloat AnimDistanceMin_Crit
		{
			get
			{
				if (_animDistanceMin_Crit == null)
				{
					_animDistanceMin_Crit = (CFloat) CR2WTypeManager.Create("Float", "animDistanceMin_Crit", cr2w, this);
				}
				return _animDistanceMin_Crit;
			}
			set
			{
				if (_animDistanceMin_Crit == value)
				{
					return;
				}
				_animDistanceMin_Crit = value;
				PropertySet(this);
			}
		}

		[Ordinal(48)] 
		[RED("animDistanceMax_Crit")] 
		public CFloat AnimDistanceMax_Crit
		{
			get
			{
				if (_animDistanceMax_Crit == null)
				{
					_animDistanceMax_Crit = (CFloat) CR2WTypeManager.Create("Float", "animDistanceMax_Crit", cr2w, this);
				}
				return _animDistanceMax_Crit;
			}
			set
			{
				if (_animDistanceMax_Crit == value)
				{
					return;
				}
				_animDistanceMax_Crit = value;
				PropertySet(this);
			}
		}

		[Ordinal(49)] 
		[RED("animBothOffsetX")] 
		public CFloat AnimBothOffsetX
		{
			get
			{
				if (_animBothOffsetX == null)
				{
					_animBothOffsetX = (CFloat) CR2WTypeManager.Create("Float", "animBothOffsetX", cr2w, this);
				}
				return _animBothOffsetX;
			}
			set
			{
				if (_animBothOffsetX == value)
				{
					return;
				}
				_animBothOffsetX = value;
				PropertySet(this);
			}
		}

		[Ordinal(50)] 
		[RED("animBothOffsetY")] 
		public CFloat AnimBothOffsetY
		{
			get
			{
				if (_animBothOffsetY == null)
				{
					_animBothOffsetY = (CFloat) CR2WTypeManager.Create("Float", "animBothOffsetY", cr2w, this);
				}
				return _animBothOffsetY;
			}
			set
			{
				if (_animBothOffsetY == value)
				{
					return;
				}
				_animBothOffsetY = value;
				PropertySet(this);
			}
		}

		[Ordinal(51)] 
		[RED("animBothStickingOffsetY")] 
		public CFloat AnimBothStickingOffsetY
		{
			get
			{
				if (_animBothStickingOffsetY == null)
				{
					_animBothStickingOffsetY = (CFloat) CR2WTypeManager.Create("Float", "animBothStickingOffsetY", cr2w, this);
				}
				return _animBothStickingOffsetY;
			}
			set
			{
				if (_animBothStickingOffsetY == value)
				{
					return;
				}
				_animBothStickingOffsetY = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("animStickTargetWorldZOffset")] 
		public CFloat AnimStickTargetWorldZOffset
		{
			get
			{
				if (_animStickTargetWorldZOffset == null)
				{
					_animStickTargetWorldZOffset = (CFloat) CR2WTypeManager.Create("Float", "animStickTargetWorldZOffset", cr2w, this);
				}
				return _animStickTargetWorldZOffset;
			}
			set
			{
				if (_animStickTargetWorldZOffset == value)
				{
					return;
				}
				_animStickTargetWorldZOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("animStickingOffsetY")] 
		public CFloat AnimStickingOffsetY
		{
			get
			{
				if (_animStickingOffsetY == null)
				{
					_animStickingOffsetY = (CFloat) CR2WTypeManager.Create("Float", "animStickingOffsetY", cr2w, this);
				}
				return _animStickingOffsetY;
			}
			set
			{
				if (_animStickingOffsetY == value)
				{
					return;
				}
				_animStickingOffsetY = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("animDistanceModifierMinDistance")] 
		public CFloat AnimDistanceModifierMinDistance
		{
			get
			{
				if (_animDistanceModifierMinDistance == null)
				{
					_animDistanceModifierMinDistance = (CFloat) CR2WTypeManager.Create("Float", "animDistanceModifierMinDistance", cr2w, this);
				}
				return _animDistanceModifierMinDistance;
			}
			set
			{
				if (_animDistanceModifierMinDistance == value)
				{
					return;
				}
				_animDistanceModifierMinDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("animDistanceModifierMaxDistance")] 
		public CFloat AnimDistanceModifierMaxDistance
		{
			get
			{
				if (_animDistanceModifierMaxDistance == null)
				{
					_animDistanceModifierMaxDistance = (CFloat) CR2WTypeManager.Create("Float", "animDistanceModifierMaxDistance", cr2w, this);
				}
				return _animDistanceModifierMaxDistance;
			}
			set
			{
				if (_animDistanceModifierMaxDistance == value)
				{
					return;
				}
				_animDistanceModifierMaxDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
		[RED("animDistanceModifierMinValue")] 
		public CFloat AnimDistanceModifierMinValue
		{
			get
			{
				if (_animDistanceModifierMinValue == null)
				{
					_animDistanceModifierMinValue = (CFloat) CR2WTypeManager.Create("Float", "animDistanceModifierMinValue", cr2w, this);
				}
				return _animDistanceModifierMinValue;
			}
			set
			{
				if (_animDistanceModifierMinValue == value)
				{
					return;
				}
				_animDistanceModifierMinValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(57)] 
		[RED("animDistanceModifierMaxValue")] 
		public CFloat AnimDistanceModifierMaxValue
		{
			get
			{
				if (_animDistanceModifierMaxValue == null)
				{
					_animDistanceModifierMaxValue = (CFloat) CR2WTypeManager.Create("Float", "animDistanceModifierMaxValue", cr2w, this);
				}
				return _animDistanceModifierMaxValue;
			}
			set
			{
				if (_animDistanceModifierMaxValue == value)
				{
					return;
				}
				_animDistanceModifierMaxValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(58)] 
		[RED("animDistanceHeightBias")] 
		public CFloat AnimDistanceHeightBias
		{
			get
			{
				if (_animDistanceHeightBias == null)
				{
					_animDistanceHeightBias = (CFloat) CR2WTypeManager.Create("Float", "animDistanceHeightBias", cr2w, this);
				}
				return _animDistanceHeightBias;
			}
			set
			{
				if (_animDistanceHeightBias == value)
				{
					return;
				}
				_animDistanceHeightBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(59)] 
		[RED("animStickingDistanceHeightBias")] 
		public CFloat AnimStickingDistanceHeightBias
		{
			get
			{
				if (_animStickingDistanceHeightBias == null)
				{
					_animStickingDistanceHeightBias = (CFloat) CR2WTypeManager.Create("Float", "animStickingDistanceHeightBias", cr2w, this);
				}
				return _animStickingDistanceHeightBias;
			}
			set
			{
				if (_animStickingDistanceHeightBias == value)
				{
					return;
				}
				_animStickingDistanceHeightBias = value;
				PropertySet(this);
			}
		}

		[Ordinal(60)] 
		[RED("animPositiveOpacity")] 
		public CFloat AnimPositiveOpacity
		{
			get
			{
				if (_animPositiveOpacity == null)
				{
					_animPositiveOpacity = (CFloat) CR2WTypeManager.Create("Float", "animPositiveOpacity", cr2w, this);
				}
				return _animPositiveOpacity;
			}
			set
			{
				if (_animPositiveOpacity == value)
				{
					return;
				}
				_animPositiveOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(61)] 
		[RED("animNegativeOpacity")] 
		public CFloat AnimNegativeOpacity
		{
			get
			{
				if (_animNegativeOpacity == null)
				{
					_animNegativeOpacity = (CFloat) CR2WTypeManager.Create("Float", "animNegativeOpacity", cr2w, this);
				}
				return _animNegativeOpacity;
			}
			set
			{
				if (_animNegativeOpacity == value)
				{
					return;
				}
				_animNegativeOpacity = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("animDynamicDuration")] 
		public CFloat AnimDynamicDuration
		{
			get
			{
				if (_animDynamicDuration == null)
				{
					_animDynamicDuration = (CFloat) CR2WTypeManager.Create("Float", "animDynamicDuration", cr2w, this);
				}
				return _animDynamicDuration;
			}
			set
			{
				if (_animDynamicDuration == value)
				{
					return;
				}
				_animDynamicDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("animDynamicDelay")] 
		public CFloat AnimDynamicDelay
		{
			get
			{
				if (_animDynamicDelay == null)
				{
					_animDynamicDelay = (CFloat) CR2WTypeManager.Create("Float", "animDynamicDelay", cr2w, this);
				}
				return _animDynamicDelay;
			}
			set
			{
				if (_animDynamicDelay == value)
				{
					return;
				}
				_animDynamicDelay = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("animDynamicCritDuration")] 
		public CFloat AnimDynamicCritDuration
		{
			get
			{
				if (_animDynamicCritDuration == null)
				{
					_animDynamicCritDuration = (CFloat) CR2WTypeManager.Create("Float", "animDynamicCritDuration", cr2w, this);
				}
				return _animDynamicCritDuration;
			}
			set
			{
				if (_animDynamicCritDuration == value)
				{
					return;
				}
				_animDynamicCritDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("animDynamicCritDelay")] 
		public CFloat AnimDynamicCritDelay
		{
			get
			{
				if (_animDynamicCritDelay == null)
				{
					_animDynamicCritDelay = (CFloat) CR2WTypeManager.Create("Float", "animDynamicCritDelay", cr2w, this);
				}
				return _animDynamicCritDelay;
			}
			set
			{
				if (_animDynamicCritDelay == value)
				{
					return;
				}
				_animDynamicCritDelay = value;
				PropertySet(this);
			}
		}

		public DamageDigitLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
