using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkTextOffsetAnimationController : inkTextAnimationController
	{
		[Ordinal(8)] 
		[RED("timeToSkip")] 
		public CFloat TimeToSkip
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public inkTextOffsetAnimationController()
		{
			PlayOnInitialize = true;
			UseDefaultAnimation = true;
			EndValue = 1.000000F;
			TimeToSkip = 0.050000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
