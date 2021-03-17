using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ProgressBarSimpleWidgetLogicController : inkWidgetLogicController
	{
		private CFloat _width;
		private CFloat _height;
		private CFloat _currentValue;
		private CFloat _previousValue;
		private CFloat _maxCNBarFlashSize;
		private inkWidgetReference _fullBar;
		private inkWidgetReference _changePBar;
		private inkWidgetReference _changeNBar;
		private inkWidgetReference _emptyBar;
		private inkWidgetReference _barCap;
		private CBool _showBarCap;
		private CFloat _animDuration;
		private CHandle<inkanimProxy> _full_anim_proxy;
		private CHandle<inkanimDefinition> _full_anim;
		private CHandle<inkanimProxy> _empty_anim_proxy;
		private CHandle<inkanimDefinition> _empty_anim;
		private CHandle<inkanimProxy> _changeP_anim_proxy;
		private CHandle<inkanimDefinition> _changeP_anim;
		private CHandle<inkanimProxy> _changeN_anim_proxy;
		private CHandle<inkanimDefinition> _changeN_anim;
		private CHandle<inkanimProxy> _barCap_anim_proxy;
		private CHandle<inkanimDefinition> _barCap_anim;
		private wCHandle<inkCompoundWidget> _rootWidget;

		[Ordinal(1)] 
		[RED("width")] 
		public CFloat Width
		{
			get => GetProperty(ref _width);
			set => SetProperty(ref _width, value);
		}

		[Ordinal(2)] 
		[RED("height")] 
		public CFloat Height
		{
			get => GetProperty(ref _height);
			set => SetProperty(ref _height, value);
		}

		[Ordinal(3)] 
		[RED("currentValue")] 
		public CFloat CurrentValue
		{
			get => GetProperty(ref _currentValue);
			set => SetProperty(ref _currentValue, value);
		}

		[Ordinal(4)] 
		[RED("previousValue")] 
		public CFloat PreviousValue
		{
			get => GetProperty(ref _previousValue);
			set => SetProperty(ref _previousValue, value);
		}

		[Ordinal(5)] 
		[RED("MaxCNBarFlashSize")] 
		public CFloat MaxCNBarFlashSize
		{
			get => GetProperty(ref _maxCNBarFlashSize);
			set => SetProperty(ref _maxCNBarFlashSize, value);
		}

		[Ordinal(6)] 
		[RED("fullBar")] 
		public inkWidgetReference FullBar
		{
			get => GetProperty(ref _fullBar);
			set => SetProperty(ref _fullBar, value);
		}

		[Ordinal(7)] 
		[RED("changePBar")] 
		public inkWidgetReference ChangePBar
		{
			get => GetProperty(ref _changePBar);
			set => SetProperty(ref _changePBar, value);
		}

		[Ordinal(8)] 
		[RED("changeNBar")] 
		public inkWidgetReference ChangeNBar
		{
			get => GetProperty(ref _changeNBar);
			set => SetProperty(ref _changeNBar, value);
		}

		[Ordinal(9)] 
		[RED("emptyBar")] 
		public inkWidgetReference EmptyBar
		{
			get => GetProperty(ref _emptyBar);
			set => SetProperty(ref _emptyBar, value);
		}

		[Ordinal(10)] 
		[RED("barCap")] 
		public inkWidgetReference BarCap
		{
			get => GetProperty(ref _barCap);
			set => SetProperty(ref _barCap, value);
		}

		[Ordinal(11)] 
		[RED("showBarCap")] 
		public CBool ShowBarCap
		{
			get => GetProperty(ref _showBarCap);
			set => SetProperty(ref _showBarCap, value);
		}

		[Ordinal(12)] 
		[RED("animDuration")] 
		public CFloat AnimDuration
		{
			get => GetProperty(ref _animDuration);
			set => SetProperty(ref _animDuration, value);
		}

		[Ordinal(13)] 
		[RED("full_anim_proxy")] 
		public CHandle<inkanimProxy> Full_anim_proxy
		{
			get => GetProperty(ref _full_anim_proxy);
			set => SetProperty(ref _full_anim_proxy, value);
		}

		[Ordinal(14)] 
		[RED("full_anim")] 
		public CHandle<inkanimDefinition> Full_anim
		{
			get => GetProperty(ref _full_anim);
			set => SetProperty(ref _full_anim, value);
		}

		[Ordinal(15)] 
		[RED("empty_anim_proxy")] 
		public CHandle<inkanimProxy> Empty_anim_proxy
		{
			get => GetProperty(ref _empty_anim_proxy);
			set => SetProperty(ref _empty_anim_proxy, value);
		}

		[Ordinal(16)] 
		[RED("empty_anim")] 
		public CHandle<inkanimDefinition> Empty_anim
		{
			get => GetProperty(ref _empty_anim);
			set => SetProperty(ref _empty_anim, value);
		}

		[Ordinal(17)] 
		[RED("changeP_anim_proxy")] 
		public CHandle<inkanimProxy> ChangeP_anim_proxy
		{
			get => GetProperty(ref _changeP_anim_proxy);
			set => SetProperty(ref _changeP_anim_proxy, value);
		}

		[Ordinal(18)] 
		[RED("changeP_anim")] 
		public CHandle<inkanimDefinition> ChangeP_anim
		{
			get => GetProperty(ref _changeP_anim);
			set => SetProperty(ref _changeP_anim, value);
		}

		[Ordinal(19)] 
		[RED("changeN_anim_proxy")] 
		public CHandle<inkanimProxy> ChangeN_anim_proxy
		{
			get => GetProperty(ref _changeN_anim_proxy);
			set => SetProperty(ref _changeN_anim_proxy, value);
		}

		[Ordinal(20)] 
		[RED("changeN_anim")] 
		public CHandle<inkanimDefinition> ChangeN_anim
		{
			get => GetProperty(ref _changeN_anim);
			set => SetProperty(ref _changeN_anim, value);
		}

		[Ordinal(21)] 
		[RED("barCap_anim_proxy")] 
		public CHandle<inkanimProxy> BarCap_anim_proxy
		{
			get => GetProperty(ref _barCap_anim_proxy);
			set => SetProperty(ref _barCap_anim_proxy, value);
		}

		[Ordinal(22)] 
		[RED("barCap_anim")] 
		public CHandle<inkanimDefinition> BarCap_anim
		{
			get => GetProperty(ref _barCap_anim);
			set => SetProperty(ref _barCap_anim, value);
		}

		[Ordinal(23)] 
		[RED("rootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		public ProgressBarSimpleWidgetLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
