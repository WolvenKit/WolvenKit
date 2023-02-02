using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communityPatrolInitializer : communitySpawnInitializer
	{
		[Ordinal(0)] 
		[RED("patrolRole")] 
		public CHandle<AIPatrolRole> PatrolRole
		{
			get => GetPropertyValue<CHandle<AIPatrolRole>>();
			set => SetPropertyValue<CHandle<AIPatrolRole>>(value);
		}

		public communityPatrolInitializer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
