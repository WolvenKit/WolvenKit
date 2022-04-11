using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class communityPatrolInitializer : communitySpawnInitializer
	{
		[Ordinal(0)] 
		[RED("patrolRole")] 
		public CHandle<AIPatrolRole> PatrolRole
		{
			get => GetPropertyValue<CHandle<AIPatrolRole>>();
			set => SetPropertyValue<CHandle<AIPatrolRole>>(value);
		}
	}
}
