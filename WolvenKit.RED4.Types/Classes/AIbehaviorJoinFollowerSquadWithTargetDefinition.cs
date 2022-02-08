using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorJoinFollowerSquadWithTargetDefinition : AIbehaviorTaskDefinition
	{
		[Ordinal(1)] 
		[RED("follower")] 
		public CHandle<AIArgumentMapping> Follower
		{
			get => GetPropertyValue<CHandle<AIArgumentMapping>>();
			set => SetPropertyValue<CHandle<AIArgumentMapping>>(value);
		}
	}
}
