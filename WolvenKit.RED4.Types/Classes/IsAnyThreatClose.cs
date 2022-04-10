using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class IsAnyThreatClose : AIAutonomousConditions
	{
		[Ordinal(0)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public IsAnyThreatClose()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
