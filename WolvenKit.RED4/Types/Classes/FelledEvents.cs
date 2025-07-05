using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FelledEvents : LocomotionGroundEvents
	{
		[Ordinal(6)] 
		[RED("animFeatureFelled")] 
		public CHandle<AnimFeature_Felled> AnimFeatureFelled
		{
			get => GetPropertyValue<CHandle<AnimFeature_Felled>>();
			set => SetPropertyValue<CHandle<AnimFeature_Felled>>(value);
		}

		public FelledEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
