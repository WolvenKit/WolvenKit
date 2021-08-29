using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class FastTravelPointsUpdated : redEvent
	{
		private CBool _updateTrackingAlternative;

		[Ordinal(0)] 
		[RED("updateTrackingAlternative")] 
		public CBool UpdateTrackingAlternative
		{
			get => GetProperty(ref _updateTrackingAlternative);
			set => SetProperty(ref _updateTrackingAlternative, value);
		}
	}
}
