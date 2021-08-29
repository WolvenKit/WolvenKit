using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetInteractionVisualizerOverride : questIInteractiveObjectManagerNodeType
	{
		private NodeRef _objectRef;
		private CBool _applyOverride;
		private CBool _removeAfterSingleUse;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("applyOverride")] 
		public CBool ApplyOverride
		{
			get => GetProperty(ref _applyOverride);
			set => SetProperty(ref _applyOverride, value);
		}

		[Ordinal(2)] 
		[RED("removeAfterSingleUse")] 
		public CBool RemoveAfterSingleUse
		{
			get => GetProperty(ref _removeAfterSingleUse);
			set => SetProperty(ref _removeAfterSingleUse, value);
		}
	}
}
