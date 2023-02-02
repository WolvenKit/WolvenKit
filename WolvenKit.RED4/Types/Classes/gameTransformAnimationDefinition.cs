using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimationDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("autoStart")] 
		public CBool AutoStart
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("autoStartDelay")] 
		public CFloat AutoStartDelay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("timesToPlay")] 
		public CUInt32 TimesToPlay
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("looping")] 
		public CBool Looping
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("timeScale")] 
		public CFloat TimeScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("reverse")] 
		public CBool Reverse
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("timeline")] 
		public gameTransformAnimationTimeline Timeline
		{
			get => GetPropertyValue<gameTransformAnimationTimeline>();
			set => SetPropertyValue<gameTransformAnimationTimeline>(value);
		}

		public gameTransformAnimationDefinition()
		{
			TimesToPlay = 1;
			TimeScale = 1.000000F;
			Timeline = new() { Items = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
