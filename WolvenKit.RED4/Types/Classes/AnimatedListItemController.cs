using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimatedListItemController : inkListItemController
	{
		[Ordinal(19)] 
		[RED("animOutName")] 
		public CName AnimOutName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(20)] 
		[RED("animPulseName")] 
		public CName AnimPulseName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(21)] 
		[RED("animTargetHover")] 
		public inkWidgetReference AnimTargetHover
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("animTargetPulse")] 
		public inkWidgetReference AnimTargetPulse
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(23)] 
		[RED("normalRootOpacity")] 
		public CFloat NormalRootOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(24)] 
		[RED("hoverRootOpacity")] 
		public CFloat HoverRootOpacity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(25)] 
		[RED("rootWidget")] 
		public CWeakHandle<inkCompoundWidget> RootWidget
		{
			get => GetPropertyValue<CWeakHandle<inkCompoundWidget>>();
			set => SetPropertyValue<CWeakHandle<inkCompoundWidget>>(value);
		}

		[Ordinal(26)] 
		[RED("animTarget_Hover")] 
		public CWeakHandle<inkWidget> AnimTarget_Hover
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(27)] 
		[RED("animTarget_Pulse")] 
		public CWeakHandle<inkWidget> AnimTarget_Pulse
		{
			get => GetPropertyValue<CWeakHandle<inkWidget>>();
			set => SetPropertyValue<CWeakHandle<inkWidget>>(value);
		}

		[Ordinal(28)] 
		[RED("animHover")] 
		public CHandle<inkanimDefinition> AnimHover
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(29)] 
		[RED("animPulse")] 
		public CHandle<inkanimDefinition> AnimPulse
		{
			get => GetPropertyValue<CHandle<inkanimDefinition>>();
			set => SetPropertyValue<CHandle<inkanimDefinition>>(value);
		}

		[Ordinal(30)] 
		[RED("animHoverProxy")] 
		public CHandle<inkanimProxy> AnimHoverProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(31)] 
		[RED("animPulseProxy")] 
		public CHandle<inkanimProxy> AnimPulseProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(32)] 
		[RED("animPulseOptions")] 
		public inkanimPlaybackOptions AnimPulseOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		public AnimatedListItemController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
