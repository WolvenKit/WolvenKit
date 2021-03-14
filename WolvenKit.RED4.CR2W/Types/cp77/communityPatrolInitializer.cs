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
			get
			{
				if (_patrolRole == null)
				{
					_patrolRole = (CHandle<AIPatrolRole>) CR2WTypeManager.Create("handle:AIPatrolRole", "patrolRole", cr2w, this);
				}
				return _patrolRole;
			}
			set
			{
				if (_patrolRole == value)
				{
					return;
				}
				_patrolRole = value;
				PropertySet(this);
			}
		}

		public communityPatrolInitializer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
