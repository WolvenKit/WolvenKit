using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AccumulatedDamageDigitLogicController : inkWidgetLogicController
	{
		private inkTextWidgetReference _critWidget;
		private inkTextWidgetReference _headshotWidget;
		private wCHandle<inkWidget> _rootWidget;
		private wCHandle<inkWidget> _panelWidget;
		private wCHandle<inkTextWidget> _textWidget;
		private wCHandle<gameObject> _owner;
		private wCHandle<DamageDigitsGameController> _gameController;
		private CBool _active;
		private CBool _successful;
		private CBool _successfulCritical;
		private CFloat _damageAccumulated;
		private CBool _showingBothDigits;
		private CBool _stickToTarget;
		private CBool _currentlySticking;
		private CHandle<inkScreenProjection> _projection;
		private CHandle<inkanimProxy> _showAnimProxy;
		private CHandle<inkanimProxy> _critAnimProxy;
		private CHandle<inkanimProxy> _blinkProxy;
		private CHandle<inkanimProxy> _headshotAnimProxy;
		private CFloat _distanceModifier;
		private CFloat _calculatedDistanceHeightBias;
		private CFloat _stickingDistanceHeightBias;
		private inkMargin _projectionInterpolationOffset;
		private inkMargin _projectionInterpolationOffsetTotal;
		private CFloat _projectionInterpolationProgress;
		private CBool _projectionFreezePosition;
		private CBool _positionUpdated;
		private CFloat _currentEngineTime;
		private CFloat _lastEngineTime;
		private CInt32 _arrayPosition;
		private CHandle<inkanimDefinition> _showPositiveAnimDef;
		private CHandle<inkanimTransparencyInterpolator> _showPositiveAnimFadeInInterpolator;
		private CHandle<inkanimTransparencyInterpolator> _showPositiveAnimFadeOutInterpolator;
		private CHandle<inkanimMarginInterpolator> _showPositiveAnimMarginInterpolator;
		private CHandle<inkanimScaleInterpolator> _showPositiveAnimScaleUpInterpolator;
		private CHandle<inkanimScaleInterpolator> _showPositiveAnimScaleDownInterpolator;
		private CHandle<inkanimDefinition> _showNegativeAnimDef;
		private CHandle<inkanimTransparencyInterpolator> _showNegativeAnimFadeInInterpolator;
		private CHandle<inkanimTransparencyInterpolator> _showNegativeAnimFadeOutInterpolator;
		private CHandle<inkanimMarginInterpolator> _showNegativeAnimMarginInterpolator;
		private CHandle<inkanimDefinition> _showCritAnimDef;
		private CHandle<inkanimTransparencyInterpolator> _showCritAnimFadeOutInterpolator;
		private Vector4 _animStickTargetOffset;
		private CFloat _animTimeFadeIn;
		private CFloat _animTimeFadeOut;
		private CFloat _animBothTimeFadeIn;
		private CFloat _animBothTimeFadeOut;
		private CFloat _animTimeDelay;
		private CFloat _animBothTimeDelay;
		private CFloat _animStartHeight;
		private CFloat _animEndHeight;
		private CFloat _animPopScale;
		private CFloat _animPopEndScale;
		private CFloat _animPopInDuration;
		private CFloat _animPopOutDuration;
		private CFloat _animBothOffsetX;
		private CFloat _animBothOffsetY;
		private CFloat _animBothStickingOffsetY;
		private CFloat _animTimeCritDelay;
		private CFloat _animBothTimeCritDelay;
		private CFloat _animTimeCritFade;
		private CFloat _animBothTimeCritFade;
		private CFloat _animMaxScreenDistanceFromLast;
		private CFloat _animScreenInterpolationTime;
		private CFloat _animMinScreenDistanceFromLast;
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
		private CFloat _animDynamicFadeInDuration;

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
		[RED("owner")] 
		public wCHandle<gameObject> Owner
		{
			get
			{
				if (_owner == null)
				{
					_owner = (wCHandle<gameObject>) CR2WTypeManager.Create("whandle:gameObject", "owner", cr2w, this);
				}
				return _owner;
			}
			set
			{
				if (_owner == value)
				{
					return;
				}
				_owner = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
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

		[Ordinal(8)] 
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

		[Ordinal(9)] 
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

		[Ordinal(10)] 
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

		[Ordinal(11)] 
		[RED("damageAccumulated")] 
		public CFloat DamageAccumulated
		{
			get
			{
				if (_damageAccumulated == null)
				{
					_damageAccumulated = (CFloat) CR2WTypeManager.Create("Float", "damageAccumulated", cr2w, this);
				}
				return _damageAccumulated;
			}
			set
			{
				if (_damageAccumulated == value)
				{
					return;
				}
				_damageAccumulated = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
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

		[Ordinal(13)] 
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

		[Ordinal(14)] 
		[RED("currentlySticking")] 
		public CBool CurrentlySticking
		{
			get
			{
				if (_currentlySticking == null)
				{
					_currentlySticking = (CBool) CR2WTypeManager.Create("Bool", "currentlySticking", cr2w, this);
				}
				return _currentlySticking;
			}
			set
			{
				if (_currentlySticking == value)
				{
					return;
				}
				_currentlySticking = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
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

		[Ordinal(16)] 
		[RED("showAnimProxy")] 
		public CHandle<inkanimProxy> ShowAnimProxy
		{
			get
			{
				if (_showAnimProxy == null)
				{
					_showAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "showAnimProxy", cr2w, this);
				}
				return _showAnimProxy;
			}
			set
			{
				if (_showAnimProxy == value)
				{
					return;
				}
				_showAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(17)] 
		[RED("critAnimProxy")] 
		public CHandle<inkanimProxy> CritAnimProxy
		{
			get
			{
				if (_critAnimProxy == null)
				{
					_critAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "critAnimProxy", cr2w, this);
				}
				return _critAnimProxy;
			}
			set
			{
				if (_critAnimProxy == value)
				{
					return;
				}
				_critAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(18)] 
		[RED("blinkProxy")] 
		public CHandle<inkanimProxy> BlinkProxy
		{
			get
			{
				if (_blinkProxy == null)
				{
					_blinkProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "blinkProxy", cr2w, this);
				}
				return _blinkProxy;
			}
			set
			{
				if (_blinkProxy == value)
				{
					return;
				}
				_blinkProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(19)] 
		[RED("headshotAnimProxy")] 
		public CHandle<inkanimProxy> HeadshotAnimProxy
		{
			get
			{
				if (_headshotAnimProxy == null)
				{
					_headshotAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "headshotAnimProxy", cr2w, this);
				}
				return _headshotAnimProxy;
			}
			set
			{
				if (_headshotAnimProxy == value)
				{
					return;
				}
				_headshotAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(20)] 
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

		[Ordinal(21)] 
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

		[Ordinal(22)] 
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

		[Ordinal(23)] 
		[RED("projectionInterpolationOffset")] 
		public inkMargin ProjectionInterpolationOffset
		{
			get
			{
				if (_projectionInterpolationOffset == null)
				{
					_projectionInterpolationOffset = (inkMargin) CR2WTypeManager.Create("inkMargin", "projectionInterpolationOffset", cr2w, this);
				}
				return _projectionInterpolationOffset;
			}
			set
			{
				if (_projectionInterpolationOffset == value)
				{
					return;
				}
				_projectionInterpolationOffset = value;
				PropertySet(this);
			}
		}

		[Ordinal(24)] 
		[RED("projectionInterpolationOffsetTotal")] 
		public inkMargin ProjectionInterpolationOffsetTotal
		{
			get
			{
				if (_projectionInterpolationOffsetTotal == null)
				{
					_projectionInterpolationOffsetTotal = (inkMargin) CR2WTypeManager.Create("inkMargin", "projectionInterpolationOffsetTotal", cr2w, this);
				}
				return _projectionInterpolationOffsetTotal;
			}
			set
			{
				if (_projectionInterpolationOffsetTotal == value)
				{
					return;
				}
				_projectionInterpolationOffsetTotal = value;
				PropertySet(this);
			}
		}

		[Ordinal(25)] 
		[RED("projectionInterpolationProgress")] 
		public CFloat ProjectionInterpolationProgress
		{
			get
			{
				if (_projectionInterpolationProgress == null)
				{
					_projectionInterpolationProgress = (CFloat) CR2WTypeManager.Create("Float", "projectionInterpolationProgress", cr2w, this);
				}
				return _projectionInterpolationProgress;
			}
			set
			{
				if (_projectionInterpolationProgress == value)
				{
					return;
				}
				_projectionInterpolationProgress = value;
				PropertySet(this);
			}
		}

		[Ordinal(26)] 
		[RED("projectionFreezePosition")] 
		public CBool ProjectionFreezePosition
		{
			get
			{
				if (_projectionFreezePosition == null)
				{
					_projectionFreezePosition = (CBool) CR2WTypeManager.Create("Bool", "projectionFreezePosition", cr2w, this);
				}
				return _projectionFreezePosition;
			}
			set
			{
				if (_projectionFreezePosition == value)
				{
					return;
				}
				_projectionFreezePosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(27)] 
		[RED("positionUpdated")] 
		public CBool PositionUpdated
		{
			get
			{
				if (_positionUpdated == null)
				{
					_positionUpdated = (CBool) CR2WTypeManager.Create("Bool", "positionUpdated", cr2w, this);
				}
				return _positionUpdated;
			}
			set
			{
				if (_positionUpdated == value)
				{
					return;
				}
				_positionUpdated = value;
				PropertySet(this);
			}
		}

		[Ordinal(28)] 
		[RED("currentEngineTime")] 
		public CFloat CurrentEngineTime
		{
			get
			{
				if (_currentEngineTime == null)
				{
					_currentEngineTime = (CFloat) CR2WTypeManager.Create("Float", "currentEngineTime", cr2w, this);
				}
				return _currentEngineTime;
			}
			set
			{
				if (_currentEngineTime == value)
				{
					return;
				}
				_currentEngineTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(29)] 
		[RED("lastEngineTime")] 
		public CFloat LastEngineTime
		{
			get
			{
				if (_lastEngineTime == null)
				{
					_lastEngineTime = (CFloat) CR2WTypeManager.Create("Float", "lastEngineTime", cr2w, this);
				}
				return _lastEngineTime;
			}
			set
			{
				if (_lastEngineTime == value)
				{
					return;
				}
				_lastEngineTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(30)] 
		[RED("arrayPosition")] 
		public CInt32 ArrayPosition
		{
			get
			{
				if (_arrayPosition == null)
				{
					_arrayPosition = (CInt32) CR2WTypeManager.Create("Int32", "arrayPosition", cr2w, this);
				}
				return _arrayPosition;
			}
			set
			{
				if (_arrayPosition == value)
				{
					return;
				}
				_arrayPosition = value;
				PropertySet(this);
			}
		}

		[Ordinal(31)] 
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

		[Ordinal(32)] 
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

		[Ordinal(33)] 
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

		[Ordinal(34)] 
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

		[Ordinal(35)] 
		[RED("showPositiveAnimScaleUpInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ShowPositiveAnimScaleUpInterpolator
		{
			get
			{
				if (_showPositiveAnimScaleUpInterpolator == null)
				{
					_showPositiveAnimScaleUpInterpolator = (CHandle<inkanimScaleInterpolator>) CR2WTypeManager.Create("handle:inkanimScaleInterpolator", "showPositiveAnimScaleUpInterpolator", cr2w, this);
				}
				return _showPositiveAnimScaleUpInterpolator;
			}
			set
			{
				if (_showPositiveAnimScaleUpInterpolator == value)
				{
					return;
				}
				_showPositiveAnimScaleUpInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(36)] 
		[RED("showPositiveAnimScaleDownInterpolator")] 
		public CHandle<inkanimScaleInterpolator> ShowPositiveAnimScaleDownInterpolator
		{
			get
			{
				if (_showPositiveAnimScaleDownInterpolator == null)
				{
					_showPositiveAnimScaleDownInterpolator = (CHandle<inkanimScaleInterpolator>) CR2WTypeManager.Create("handle:inkanimScaleInterpolator", "showPositiveAnimScaleDownInterpolator", cr2w, this);
				}
				return _showPositiveAnimScaleDownInterpolator;
			}
			set
			{
				if (_showPositiveAnimScaleDownInterpolator == value)
				{
					return;
				}
				_showPositiveAnimScaleDownInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(37)] 
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

		[Ordinal(38)] 
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

		[Ordinal(39)] 
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

		[Ordinal(40)] 
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

		[Ordinal(41)] 
		[RED("showCritAnimDef")] 
		public CHandle<inkanimDefinition> ShowCritAnimDef
		{
			get
			{
				if (_showCritAnimDef == null)
				{
					_showCritAnimDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "showCritAnimDef", cr2w, this);
				}
				return _showCritAnimDef;
			}
			set
			{
				if (_showCritAnimDef == value)
				{
					return;
				}
				_showCritAnimDef = value;
				PropertySet(this);
			}
		}

		[Ordinal(42)] 
		[RED("showCritAnimFadeOutInterpolator")] 
		public CHandle<inkanimTransparencyInterpolator> ShowCritAnimFadeOutInterpolator
		{
			get
			{
				if (_showCritAnimFadeOutInterpolator == null)
				{
					_showCritAnimFadeOutInterpolator = (CHandle<inkanimTransparencyInterpolator>) CR2WTypeManager.Create("handle:inkanimTransparencyInterpolator", "showCritAnimFadeOutInterpolator", cr2w, this);
				}
				return _showCritAnimFadeOutInterpolator;
			}
			set
			{
				if (_showCritAnimFadeOutInterpolator == value)
				{
					return;
				}
				_showCritAnimFadeOutInterpolator = value;
				PropertySet(this);
			}
		}

		[Ordinal(43)] 
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

		[Ordinal(44)] 
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

		[Ordinal(45)] 
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

		[Ordinal(46)] 
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

		[Ordinal(47)] 
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

		[Ordinal(48)] 
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

		[Ordinal(49)] 
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

		[Ordinal(50)] 
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

		[Ordinal(51)] 
		[RED("animEndHeight")] 
		public CFloat AnimEndHeight
		{
			get
			{
				if (_animEndHeight == null)
				{
					_animEndHeight = (CFloat) CR2WTypeManager.Create("Float", "animEndHeight", cr2w, this);
				}
				return _animEndHeight;
			}
			set
			{
				if (_animEndHeight == value)
				{
					return;
				}
				_animEndHeight = value;
				PropertySet(this);
			}
		}

		[Ordinal(52)] 
		[RED("animPopScale")] 
		public CFloat AnimPopScale
		{
			get
			{
				if (_animPopScale == null)
				{
					_animPopScale = (CFloat) CR2WTypeManager.Create("Float", "animPopScale", cr2w, this);
				}
				return _animPopScale;
			}
			set
			{
				if (_animPopScale == value)
				{
					return;
				}
				_animPopScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(53)] 
		[RED("animPopEndScale")] 
		public CFloat AnimPopEndScale
		{
			get
			{
				if (_animPopEndScale == null)
				{
					_animPopEndScale = (CFloat) CR2WTypeManager.Create("Float", "animPopEndScale", cr2w, this);
				}
				return _animPopEndScale;
			}
			set
			{
				if (_animPopEndScale == value)
				{
					return;
				}
				_animPopEndScale = value;
				PropertySet(this);
			}
		}

		[Ordinal(54)] 
		[RED("animPopInDuration")] 
		public CFloat AnimPopInDuration
		{
			get
			{
				if (_animPopInDuration == null)
				{
					_animPopInDuration = (CFloat) CR2WTypeManager.Create("Float", "animPopInDuration", cr2w, this);
				}
				return _animPopInDuration;
			}
			set
			{
				if (_animPopInDuration == value)
				{
					return;
				}
				_animPopInDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(55)] 
		[RED("animPopOutDuration")] 
		public CFloat AnimPopOutDuration
		{
			get
			{
				if (_animPopOutDuration == null)
				{
					_animPopOutDuration = (CFloat) CR2WTypeManager.Create("Float", "animPopOutDuration", cr2w, this);
				}
				return _animPopOutDuration;
			}
			set
			{
				if (_animPopOutDuration == value)
				{
					return;
				}
				_animPopOutDuration = value;
				PropertySet(this);
			}
		}

		[Ordinal(56)] 
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

		[Ordinal(57)] 
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

		[Ordinal(58)] 
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

		[Ordinal(59)] 
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

		[Ordinal(60)] 
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

		[Ordinal(61)] 
		[RED("animTimeCritFade")] 
		public CFloat AnimTimeCritFade
		{
			get
			{
				if (_animTimeCritFade == null)
				{
					_animTimeCritFade = (CFloat) CR2WTypeManager.Create("Float", "animTimeCritFade", cr2w, this);
				}
				return _animTimeCritFade;
			}
			set
			{
				if (_animTimeCritFade == value)
				{
					return;
				}
				_animTimeCritFade = value;
				PropertySet(this);
			}
		}

		[Ordinal(62)] 
		[RED("animBothTimeCritFade")] 
		public CFloat AnimBothTimeCritFade
		{
			get
			{
				if (_animBothTimeCritFade == null)
				{
					_animBothTimeCritFade = (CFloat) CR2WTypeManager.Create("Float", "animBothTimeCritFade", cr2w, this);
				}
				return _animBothTimeCritFade;
			}
			set
			{
				if (_animBothTimeCritFade == value)
				{
					return;
				}
				_animBothTimeCritFade = value;
				PropertySet(this);
			}
		}

		[Ordinal(63)] 
		[RED("animMaxScreenDistanceFromLast")] 
		public CFloat AnimMaxScreenDistanceFromLast
		{
			get
			{
				if (_animMaxScreenDistanceFromLast == null)
				{
					_animMaxScreenDistanceFromLast = (CFloat) CR2WTypeManager.Create("Float", "animMaxScreenDistanceFromLast", cr2w, this);
				}
				return _animMaxScreenDistanceFromLast;
			}
			set
			{
				if (_animMaxScreenDistanceFromLast == value)
				{
					return;
				}
				_animMaxScreenDistanceFromLast = value;
				PropertySet(this);
			}
		}

		[Ordinal(64)] 
		[RED("animScreenInterpolationTime")] 
		public CFloat AnimScreenInterpolationTime
		{
			get
			{
				if (_animScreenInterpolationTime == null)
				{
					_animScreenInterpolationTime = (CFloat) CR2WTypeManager.Create("Float", "animScreenInterpolationTime", cr2w, this);
				}
				return _animScreenInterpolationTime;
			}
			set
			{
				if (_animScreenInterpolationTime == value)
				{
					return;
				}
				_animScreenInterpolationTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(65)] 
		[RED("animMinScreenDistanceFromLast")] 
		public CFloat AnimMinScreenDistanceFromLast
		{
			get
			{
				if (_animMinScreenDistanceFromLast == null)
				{
					_animMinScreenDistanceFromLast = (CFloat) CR2WTypeManager.Create("Float", "animMinScreenDistanceFromLast", cr2w, this);
				}
				return _animMinScreenDistanceFromLast;
			}
			set
			{
				if (_animMinScreenDistanceFromLast == value)
				{
					return;
				}
				_animMinScreenDistanceFromLast = value;
				PropertySet(this);
			}
		}

		[Ordinal(66)] 
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

		[Ordinal(67)] 
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

		[Ordinal(68)] 
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

		[Ordinal(69)] 
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

		[Ordinal(70)] 
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

		[Ordinal(71)] 
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

		[Ordinal(72)] 
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

		[Ordinal(73)] 
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

		[Ordinal(74)] 
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

		[Ordinal(75)] 
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

		[Ordinal(76)] 
		[RED("animDynamicFadeInDuration")] 
		public CFloat AnimDynamicFadeInDuration
		{
			get
			{
				if (_animDynamicFadeInDuration == null)
				{
					_animDynamicFadeInDuration = (CFloat) CR2WTypeManager.Create("Float", "animDynamicFadeInDuration", cr2w, this);
				}
				return _animDynamicFadeInDuration;
			}
			set
			{
				if (_animDynamicFadeInDuration == value)
				{
					return;
				}
				_animDynamicFadeInDuration = value;
				PropertySet(this);
			}
		}

		public AccumulatedDamageDigitLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
