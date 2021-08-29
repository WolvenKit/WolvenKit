using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIMoveToCoverCommand : AIMoveCommand
	{
		private NodeRef _coverNodeRef;
		private CEnum<ECoverSpecialAction> _specialAction;

		[Ordinal(7)] 
		[RED("coverNodeRef")] 
		public NodeRef CoverNodeRef
		{
			get => GetProperty(ref _coverNodeRef);
			set => SetProperty(ref _coverNodeRef, value);
		}

		[Ordinal(8)] 
		[RED("specialAction")] 
		public CEnum<ECoverSpecialAction> SpecialAction
		{
			get => GetProperty(ref _specialAction);
			set => SetProperty(ref _specialAction, value);
		}
	}
}
