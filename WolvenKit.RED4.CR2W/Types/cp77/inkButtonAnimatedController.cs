using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkButtonAnimatedController : inkButtonController
	{
		private inkWidgetReference _animTargetHover;
		private inkWidgetReference _animTargetPulse;
		private CFloat _normalRootOpacity;
		private CFloat _hoverRootOpacity;
		private wCHandle<inkCompoundWidget> _rootWidget;
		private wCHandle<inkWidget> _animTarget_Hover;
		private wCHandle<inkWidget> _animTarget_Pulse;
		private CHandle<inkanimDefinition> _animHover;
		private CHandle<inkanimDefinition> _animPulse;
		private CHandle<inkanimProxy> _animHoverProxy;
		private CHandle<inkanimProxy> _animPulseProxy;
		private inkanimPlaybackOptions _animPulseOptions;

		[Ordinal(10)] 
		[RED("animTargetHover")] 
		public inkWidgetReference AnimTargetHover
		{
			get => GetProperty(ref _animTargetHover);
			set => SetProperty(ref _animTargetHover, value);
		}

		[Ordinal(11)] 
		[RED("animTargetPulse")] 
		public inkWidgetReference AnimTargetPulse
		{
			get => GetProperty(ref _animTargetPulse);
			set => SetProperty(ref _animTargetPulse, value);
		}

		[Ordinal(12)] 
		[RED("normalRootOpacity")] 
		public CFloat NormalRootOpacity
		{
			get => GetProperty(ref _normalRootOpacity);
			set => SetProperty(ref _normalRootOpacity, value);
		}

		[Ordinal(13)] 
		[RED("hoverRootOpacity")] 
		public CFloat HoverRootOpacity
		{
			get => GetProperty(ref _hoverRootOpacity);
			set => SetProperty(ref _hoverRootOpacity, value);
		}

		[Ordinal(14)] 
		[RED("rootWidget")] 
		public wCHandle<inkCompoundWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(15)] 
		[RED("animTarget_Hover")] 
		public wCHandle<inkWidget> AnimTarget_Hover
		{
			get => GetProperty(ref _animTarget_Hover);
			set => SetProperty(ref _animTarget_Hover, value);
		}

		[Ordinal(16)] 
		[RED("animTarget_Pulse")] 
		public wCHandle<inkWidget> AnimTarget_Pulse
		{
			get => GetProperty(ref _animTarget_Pulse);
			set => SetProperty(ref _animTarget_Pulse, value);
		}

		[Ordinal(17)] 
		[RED("animHover")] 
		public CHandle<inkanimDefinition> AnimHover
		{
			get => GetProperty(ref _animHover);
			set => SetProperty(ref _animHover, value);
		}

		[Ordinal(18)] 
		[RED("animPulse")] 
		public CHandle<inkanimDefinition> AnimPulse
		{
			get => GetProperty(ref _animPulse);
			set => SetProperty(ref _animPulse, value);
		}

		[Ordinal(19)] 
		[RED("animHoverProxy")] 
		public CHandle<inkanimProxy> AnimHoverProxy
		{
			get => GetProperty(ref _animHoverProxy);
			set => SetProperty(ref _animHoverProxy, value);
		}

		[Ordinal(20)] 
		[RED("animPulseProxy")] 
		public CHandle<inkanimProxy> AnimPulseProxy
		{
			get => GetProperty(ref _animPulseProxy);
			set => SetProperty(ref _animPulseProxy, value);
		}

		[Ordinal(21)] 
		[RED("animPulseOptions")] 
		public inkanimPlaybackOptions AnimPulseOptions
		{
			get => GetProperty(ref _animPulseOptions);
			set => SetProperty(ref _animPulseOptions, value);
		}

		public inkButtonAnimatedController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
