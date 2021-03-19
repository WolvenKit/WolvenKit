using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorChangeGuardAreaTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _guardAreaNodeRef;

		[Ordinal(1)] 
		[RED("guardAreaNodeRef")] 
		public CHandle<AIArgumentMapping> GuardAreaNodeRef
		{
			get => GetProperty(ref _guardAreaNodeRef);
			set => SetProperty(ref _guardAreaNodeRef, value);
		}

		public AIbehaviorChangeGuardAreaTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
