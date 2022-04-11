using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIMoveToCoverCommand : AIMoveCommand
	{
		[Ordinal(7)] 
		[RED("coverNodeRef")] 
		public NodeRef CoverNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(8)] 
		[RED("specialAction")] 
		public CEnum<ECoverSpecialAction> SpecialAction
		{
			get => GetPropertyValue<CEnum<ECoverSpecialAction>>();
			set => SetPropertyValue<CEnum<ECoverSpecialAction>>(value);
		}
	}
}
