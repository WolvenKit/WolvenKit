using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiStealthIndicatorPartLogicController : gameuiBaseDirectionalIndicatorPartLogicController
	{
		private inkImageWidgetReference _arrowFrontWidget;
		private inkCompoundWidgetReference _wrapper;
		private CFloat _stealthIndicatorDeadZoneAngle;
		private CFloat _slowestFlashTime;
		private wCHandle<inkCompoundWidget> _rootWidget;
		private CFloat _lastValue;
		private CHandle<inkanimProxy> _animProxy;
		private CHandle<inkanimProxy> _flashAnimProxy;
		private CHandle<inkanimDefinition> _scaleAnimDef;

		[Ordinal(3)] 
		[RED("arrowFrontWidget")] 
		public inkImageWidgetReference ArrowFrontWidget
		{
			get
			{
				if (_arrowFrontWidget == null)
				{
					_arrowFrontWidget = (inkImageWidgetReference) CR2WTypeManager.Create("inkImageWidgetReference", "arrowFrontWidget", cr2w, this);
				}
				return _arrowFrontWidget;
			}
			set
			{
				if (_arrowFrontWidget == value)
				{
					return;
				}
				_arrowFrontWidget = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("wrapper")] 
		public inkCompoundWidgetReference Wrapper
		{
			get
			{
				if (_wrapper == null)
				{
					_wrapper = (inkCompoundWidgetReference) CR2WTypeManager.Create("inkCompoundWidgetReference", "wrapper", cr2w, this);
				}
				return _wrapper;
			}
			set
			{
				if (_wrapper == value)
				{
					return;
				}
				_wrapper = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("stealthIndicatorDeadZoneAngle")] 
		public CFloat StealthIndicatorDeadZoneAngle
		{
			get
			{
				if (_stealthIndicatorDeadZoneAngle == null)
				{
					_stealthIndicatorDeadZoneAngle = (CFloat) CR2WTypeManager.Create("Float", "stealthIndicatorDeadZoneAngle", cr2w, this);
				}
				return _stealthIndicatorDeadZoneAngle;
			}
			set
			{
				if (_stealthIndicatorDeadZoneAngle == value)
				{
					return;
				}
				_stealthIndicatorDeadZoneAngle = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("slowestFlashTime")] 
		public CFloat SlowestFlashTime
		{
			get
			{
				if (_slowestFlashTime == null)
				{
					_slowestFlashTime = (CFloat) CR2WTypeManager.Create("Float", "slowestFlashTime", cr2w, this);
				}
				return _slowestFlashTime;
			}
			set
			{
				if (_slowestFlashTime == value)
				{
					return;
				}
				_slowestFlashTime = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("rootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get
			{
				if (_rootWidget == null)
				{
					_rootWidget = (wCHandle<inkCompoundWidget>) CR2WTypeManager.Create("whandle:inkCompoundWidget", "rootWidget", cr2w, this);
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

		[Ordinal(8)] 
		[RED("lastValue")] 
		public CFloat LastValue
		{
			get
			{
				if (_lastValue == null)
				{
					_lastValue = (CFloat) CR2WTypeManager.Create("Float", "lastValue", cr2w, this);
				}
				return _lastValue;
			}
			set
			{
				if (_lastValue == value)
				{
					return;
				}
				_lastValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get
			{
				if (_animProxy == null)
				{
					_animProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "animProxy", cr2w, this);
				}
				return _animProxy;
			}
			set
			{
				if (_animProxy == value)
				{
					return;
				}
				_animProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("flashAnimProxy")] 
		public CHandle<inkanimProxy> FlashAnimProxy
		{
			get
			{
				if (_flashAnimProxy == null)
				{
					_flashAnimProxy = (CHandle<inkanimProxy>) CR2WTypeManager.Create("handle:inkanimProxy", "flashAnimProxy", cr2w, this);
				}
				return _flashAnimProxy;
			}
			set
			{
				if (_flashAnimProxy == value)
				{
					return;
				}
				_flashAnimProxy = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("scaleAnimDef")] 
		public CHandle<inkanimDefinition> ScaleAnimDef
		{
			get
			{
				if (_scaleAnimDef == null)
				{
					_scaleAnimDef = (CHandle<inkanimDefinition>) CR2WTypeManager.Create("handle:inkanimDefinition", "scaleAnimDef", cr2w, this);
				}
				return _scaleAnimDef;
			}
			set
			{
				if (_scaleAnimDef == value)
				{
					return;
				}
				_scaleAnimDef = value;
				PropertySet(this);
			}
		}

		public gameuiStealthIndicatorPartLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
