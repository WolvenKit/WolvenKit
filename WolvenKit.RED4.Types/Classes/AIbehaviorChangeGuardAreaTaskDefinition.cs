using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorChangeGuardAreaTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIArgumentMapping> _guardAreaNodeRef;

		[Ordinal(1)] 
		[RED("guardAreaNodeRef")] 
		public CHandle<AIArgumentMapping> GuardAreaNodeRef
		{
			get => GetProperty(ref _guardAreaNodeRef);
			set => SetProperty(ref _guardAreaNodeRef, value);
		}
	}
}
