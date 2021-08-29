using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AssignRestrictMovementAreaTask : AIbehaviortaskScript
	{
		private CHandle<AIArgumentMapping> _restrictMovementAreaRef;

		[Ordinal(0)] 
		[RED("restrictMovementAreaRef")] 
		public CHandle<AIArgumentMapping> RestrictMovementAreaRef
		{
			get => GetProperty(ref _restrictMovementAreaRef);
			set => SetProperty(ref _restrictMovementAreaRef, value);
		}
	}
}
