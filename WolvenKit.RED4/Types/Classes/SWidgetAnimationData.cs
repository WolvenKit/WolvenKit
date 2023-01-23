using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SWidgetAnimationData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("playbackOptions")] 
		public inkanimPlaybackOptions PlaybackOptions
		{
			get => GetPropertyValue<inkanimPlaybackOptions>();
			set => SetPropertyValue<inkanimPlaybackOptions>(value);
		}

		[Ordinal(2)] 
		[RED("lockWhenActive")] 
		public CBool LockWhenActive
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("animProxy")] 
		public CHandle<inkanimProxy> AnimProxy
		{
			get => GetPropertyValue<CHandle<inkanimProxy>>();
			set => SetPropertyValue<CHandle<inkanimProxy>>(value);
		}

		[Ordinal(4)] 
		[RED("onFinish")] 
		public CName OnFinish
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("onStart")] 
		public CName OnStart
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("onPasue")] 
		public CName OnPasue
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("onResume")] 
		public CName OnResume
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("onStartLoop")] 
		public CName OnStartLoop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("onEndLoop")] 
		public CName OnEndLoop
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SWidgetAnimationData()
		{
			PlaybackOptions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
