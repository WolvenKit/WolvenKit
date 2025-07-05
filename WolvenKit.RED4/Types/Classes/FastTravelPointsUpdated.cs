using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class FastTravelPointsUpdated : redEvent
	{
		[Ordinal(0)] 
		[RED("updateTrackingAlternative")] 
		public CBool UpdateTrackingAlternative
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public FastTravelPointsUpdated()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
