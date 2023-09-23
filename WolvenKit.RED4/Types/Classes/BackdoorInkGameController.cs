using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class BackdoorInkGameController : MasterDeviceInkGameControllerBase
	{
		[Ordinal(20)] 
		[RED("IdleGroup")] 
		public inkWidgetReference IdleGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(21)] 
		[RED("ConnectedGroup")] 
		public inkWidgetReference ConnectedGroup
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(22)] 
		[RED("IntroAnimationName")] 
		public CName IntroAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(23)] 
		[RED("IdleAnimationName")] 
		public CName IdleAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(24)] 
		[RED("GlitchAnimationName")] 
		public CName GlitchAnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(25)] 
		[RED("RunningAnimation")] 
		public CHandle<inkanimProxy> RunningAnimation
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(26)] 
		[RED("onGlitchingListener")] 
		public CHandle<redCallbackObject> OnGlitchingListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(27)] 
		[RED("onIsInDefaultStateListener")] 
		public CHandle<redCallbackObject> OnIsInDefaultStateListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(28)] 
		[RED("onShutdownModuleListener")] 
		public CHandle<redCallbackObject> OnShutdownModuleListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(29)] 
		[RED("onBootModuleListener")] 
		public CHandle<redCallbackObject> OnBootModuleListener
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		public BackdoorInkGameController()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
