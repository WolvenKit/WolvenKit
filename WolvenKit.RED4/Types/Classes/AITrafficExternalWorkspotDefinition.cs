using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AITrafficExternalWorkspotDefinition : worldTrafficSpotDefinition
	{
		[Ordinal(2)] 
		[RED("nearestPointEntry")] 
		public CBool NearestPointEntry
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("globalWorkspotNodeRef")] 
		public NodeRef GlobalWorkspotNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		public AITrafficExternalWorkspotDefinition()
		{
			Direction = Enums.worldTrafficSpotDirection.Both;
			NearestPointEntry = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
