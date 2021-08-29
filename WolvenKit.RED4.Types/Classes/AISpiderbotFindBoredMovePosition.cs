using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AISpiderbotFindBoredMovePosition : AIFindPositionAroundSelf
	{
		private CHandle<AIArgumentMapping> _maxWanderDistance;

		[Ordinal(6)] 
		[RED("maxWanderDistance")] 
		public CHandle<AIArgumentMapping> MaxWanderDistance
		{
			get => GetProperty(ref _maxWanderDistance);
			set => SetProperty(ref _maxWanderDistance, value);
		}
	}
}
