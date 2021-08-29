using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIAssignGuardAreaCommand : AICommand
	{
		private NodeRef _restrictMovementAreaRef;

		[Ordinal(4)] 
		[RED("restrictMovementAreaRef")] 
		public NodeRef RestrictMovementAreaRef
		{
			get => GetProperty(ref _restrictMovementAreaRef);
			set => SetProperty(ref _restrictMovementAreaRef, value);
		}
	}
}
