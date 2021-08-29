using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questHackingManager_NodeTypeParams : RedBaseClass
	{
		private NodeRef _objectRef;
		private CArray<CHandle<questHackingManager_ActionType>> _actions;

		[Ordinal(0)] 
		[RED("objectRef")] 
		public NodeRef ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(1)] 
		[RED("actions")] 
		public CArray<CHandle<questHackingManager_ActionType>> Actions
		{
			get => GetProperty(ref _actions);
			set => SetProperty(ref _actions, value);
		}
	}
}
