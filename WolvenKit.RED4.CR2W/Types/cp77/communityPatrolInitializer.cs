using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class communityPatrolInitializer : communitySpawnInitializer
	{
		private CHandle<AIPatrolRole> _patrolRole;

		[Ordinal(0)] 
		[RED("patrolRole")] 
		public CHandle<AIPatrolRole> PatrolRole
		{
			get => GetProperty(ref _patrolRole);
			set => SetProperty(ref _patrolRole, value);
		}

		public communityPatrolInitializer(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
