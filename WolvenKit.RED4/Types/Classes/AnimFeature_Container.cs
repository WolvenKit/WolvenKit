using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AnimFeature_Container : animAnimFeature
	{
		[Ordinal(0)] 
		[RED("opened")] 
		public CBool Opened
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("transitionDuration")] 
		public CFloat TransitionDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AnimFeature_Container()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
