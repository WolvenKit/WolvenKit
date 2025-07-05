using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class STransformAnimationSkipEventData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("skipToEnd")] 
		public CBool SkipToEnd
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public STransformAnimationSkipEventData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
