using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ForceWalkEvents : LocomotionGroundEvents
	{
		[Ordinal(6)] 
		[RED("storedSpeedValue")] 
		public CFloat StoredSpeedValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ForceWalkEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
