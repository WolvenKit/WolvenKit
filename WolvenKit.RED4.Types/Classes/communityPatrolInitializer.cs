using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communityPatrolInitializer : communitySpawnInitializer
	{
		private CHandle<AIPatrolRole> _patrolRole;

		[Ordinal(0)] 
		[RED("patrolRole")] 
		public CHandle<AIPatrolRole> PatrolRole
		{
			get => GetProperty(ref _patrolRole);
			set => SetProperty(ref _patrolRole, value);
		}
	}
}
