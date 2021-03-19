using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSelectCombatTargetTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _target;
		private CBool _targetClosest;

		[Ordinal(1)] 
		[RED("target")] 
		public CHandle<AIArgumentMapping> Target
		{
			get => GetProperty(ref _target);
			set => SetProperty(ref _target, value);
		}

		[Ordinal(2)] 
		[RED("targetClosest")] 
		public CBool TargetClosest
		{
			get => GetProperty(ref _targetClosest);
			set => SetProperty(ref _targetClosest, value);
		}

		public AIbehaviorSelectCombatTargetTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
