using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorJoinFollowerSquadWithTargetDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _follower;

		[Ordinal(1)] 
		[RED("follower")] 
		public CHandle<AIArgumentMapping> Follower
		{
			get => GetProperty(ref _follower);
			set => SetProperty(ref _follower, value);
		}
	}
}
