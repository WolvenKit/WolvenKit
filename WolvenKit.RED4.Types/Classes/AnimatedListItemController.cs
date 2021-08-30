using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AnimatedListItemController : inkListItemController
	{
		private CName _animOutName;
		private CName _animPulseName;
		private inkWidgetReference _animTargetHover;
		private inkWidgetReference _animTargetPulse;
		private CFloat _normalRootOpacity;
		private CFloat _hoverRootOpacity;
		private CWeakHandle<inkCompoundWidget> _rootWidget;
		private CWeakHandle<inkWidget> _animTarget_Hover;
		private CWeakHandle<inkWidget> _animTarget_Pulse;
		private CHandle<inkanimDefinition> _animHover;
		private CHandle<inkanimDefinition> _animPulse;
		private CHandle<inkanimProxy> _animHoverProxy;
		private CHandle<inkanimProxy> _animPulseProxy;
		private inkanimPlaybackOptions _animPulseOptions;

		[Ordinal(16)] 
		[RED("animOutName")] 
		public CName AnimOutName
		{
			get => GetProperty(ref _animOutName);
			set => SetProperty(ref _animOutName, value);
		}

		[Ordinal(17)] 
		[RED("animPulseName")] 
		public CName AnimPulseName
		{
			get => GetProperty(ref _animPulseName);
			set => SetProperty(ref _animPulseName, value);
		}

		[Ordinal(18)] 
		[RED("animTargetHover")] 
		public inkWidgetReference AnimTargetHover
		{
			get => GetProperty(ref _animTargetHover);
			set => SetProperty(ref _animTargetHover, value);
		}

		[Ordinal(19)] 
		[RED("animTargetPulse")] 
		public inkWidgetReference AnimTargetPulse
		{
			get => GetProperty(ref _animTargetPulse);
			set => SetProperty(ref _animTargetPulse, value);
		}

		[Ordinal(20)] 
		[RED("normalRootOpacity")] 
		public CFloat NormalRootOpacity
		{
			get => GetProperty(ref _normalRootOpacity);
			set => SetProperty(ref _normalRootOpacity, value);
		}

		[Ordinal(21)] 
		[RED("hoverRootOpacity")] 
		public CFloat HoverRootOpacity
		{
			get => GetProperty(ref _hoverRootOpacity);
			set => SetProperty(ref _hoverRootOpacity, value);
		}

		[Ordinal(22)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetProperty(ref _rootWidget);
			set => SetProperty(ref _rootWidget, value);
		}

		[Ordinal(23)] 
		[RED("animTarget_Hover")] 
		public CWeakHandle<inkWidget> AnimTarget_Hover
		{
			get => GetProperty(ref _animTarget_Hover);
			set => SetProperty(ref _animTarget_Hover, value);
		}

		[Ordinal(24)] 
		[RED("animTarget_Pulse")] 
		public CWeakHandle<inkWidget> AnimTarget_Pulse
		{
			get => GetProperty(ref _animTarget_Pulse);
			set => SetProperty(ref _animTarget_Pulse, value);
		}

		[Ordinal(25)] 
		[RED("animHover")] 
		public CHandle<inkanimDefinition> AnimHover
		{
			get => GetProperty(ref _animHover);
			set => SetProperty(ref _animHover, value);
		}

		[Ordinal(26)] 
		[RED("animPulse")] 
		public CHandle<inkanimDefinition> AnimPulse
		{
			get => GetProperty(ref _animPulse);
			set => SetProperty(ref _animPulse, value);
		}

		[Ordinal(27)] 
		[RED("animHoverProxy")] 
		public CHandle<inkanimProxy> AnimHoverProxy
		{
			get => GetProperty(ref _animHoverProxy);
			set => SetProperty(ref _animHoverProxy, value);
		}

		[Ordinal(28)] 
		[RED("animPulseProxy")] 
		public CHandle<inkanimProxy> AnimPulseProxy
		{
			get => GetProperty(ref _animPulseProxy);
			set => SetProperty(ref _animPulseProxy, value);
		}

		[Ordinal(29)] 
		[RED("animPulseOptions")] 
		public inkanimPlaybackOptions AnimPulseOptions
		{
			get => GetProperty(ref _animPulseOptions);
			set => SetProperty(ref _animPulseOptions, value);
		}

		public AnimatedListItemController()
		{
			_animOutName = "MenuButtonFadeOut";
			_animPulseName = "MenuButtonPulse";
			_normalRootOpacity = 1.000000F;
			_hoverRootOpacity = 1.000000F;
		}
	}
}
