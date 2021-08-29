using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISpiderbotCheckIfFriendlyMoved : AIAutonomousConditions
	{
		private CHandle<AIArgumentMapping> _maxAllowedDelta;

		[Ordinal(0)] 
		[RED("maxAllowedDelta")] 
		public CHandle<AIArgumentMapping> MaxAllowedDelta
		{
			get => GetProperty(ref _maxAllowedDelta);
			set => SetProperty(ref _maxAllowedDelta, value);
		}
	}
}
