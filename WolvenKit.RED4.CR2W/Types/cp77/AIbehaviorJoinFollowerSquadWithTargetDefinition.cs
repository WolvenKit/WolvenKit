using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorJoinFollowerSquadWithTargetDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _follower;

		[Ordinal(1)] 
		[RED("follower")] 
		public CHandle<AIArgumentMapping> Follower
		{
			get => GetProperty(ref _follower);
			set => SetProperty(ref _follower, value);
		}

		public AIbehaviorJoinFollowerSquadWithTargetDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
