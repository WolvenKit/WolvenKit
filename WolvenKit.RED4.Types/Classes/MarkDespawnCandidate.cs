using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MarkDespawnCandidate : AIbehaviortaskScript
	{
		[Ordinal(0)] 
		[RED("onDeactivation")] 
		public CBool OnDeactivation
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MarkDespawnCandidate()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
