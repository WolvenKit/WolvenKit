using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTransformAnimationSkipEvent : gameTransformAnimationEvent
	{
		[Ordinal(1)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("skipToEnd")] 
		public CBool SkipToEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("forcePlay")] 
		public CBool ForcePlay
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameTransformAnimationSkipEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
