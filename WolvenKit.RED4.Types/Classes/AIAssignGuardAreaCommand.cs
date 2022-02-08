using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIAssignGuardAreaCommand : AICommand
	{
		[Ordinal(4)] 
		[RED("restrictMovementAreaRef")] 
		public NodeRef RestrictMovementAreaRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}
	}
}
