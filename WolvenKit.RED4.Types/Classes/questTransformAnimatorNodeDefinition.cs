using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questTransformAnimatorNodeDefinition : questSignalStoppingNodeDefinition
	{
		private gameEntityReference _objectRef;
		private CName _animationName;
		private CHandle<questTransformAnimatorNode_ActionType> _action;

		[Ordinal(2)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(3)] 
		[RED("animationName")] 
		public CName AnimationName
		{
			get => GetProperty(ref _animationName);
			set => SetProperty(ref _animationName, value);
		}

		[Ordinal(4)] 
		[RED("action")] 
		public CHandle<questTransformAnimatorNode_ActionType> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}
	}
}
