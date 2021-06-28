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
			get => GetProperty(ref _arrowFrontWidget);
			set => SetProperty(ref _arrowFrontWidget, value);
		}

		[Ordinal(4)] 
		[RED("wrapper")] 
		public inkCompoundWidgetReference Wrapper
		{
			get => GetProperty(ref _wrapper);
			set => SetProperty(ref _wrapper, value);
		}

		[Ordinal(5)] 
		[RED("stealthIndicatorDeadZoneAngle")] 
		public CFloat StealthIndicatorDeadZoneAngle
		{
			get => GetProperty(ref _stealthIndicatorDeadZoneAngle);
			set => SetProperty(ref _stealthIndicatorDeadZoneAngle, value);
		}

		[Ordinal(6)] 
		[RED("slowestFlashTime")] 
		public CFloat SlowestFlashTime
		{
			get => GetProperty(ref _slowestFlashTime);
			set => SetProperty(ref _slowestFlashTime, value);
		}

		[Ordinal(7)] 
		[RED("rootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(8)] 
		[RED("lastValue")] 
		public CFloat LastValue
		{
			get => GetProperty(ref _lastValue);
			set => SetProperty(ref _lastValue, value);
		}

		[Ordinal(9)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetProperty(ref _animProxy);
			set => SetProperty(ref _animProxy, value);
		}

		[Ordinal(10)] 
		[RED("flashAnimProxy")] 
		public CHandle<inkanimProxy> FlashAnimProxy
		{
			get => GetProperty(ref _flashAnimProxy);
			set => SetProperty(ref _flashAnimProxy, value);
		}

		[Ordinal(11)] 
		[RED("scaleAnimDef")] 
		public CHandle<inkanimDefinition> ScaleAnimDef
		{
			get => GetProperty(ref _scaleAnimDef);
			set => SetProperty(ref _scaleAnimDef, value);
		}

		public gameuiStealthIndicatorPartLogicController(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
