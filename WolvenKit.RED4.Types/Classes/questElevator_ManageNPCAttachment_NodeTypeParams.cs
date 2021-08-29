using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questElevator_ManageNPCAttachment_NodeTypeParams : RedBaseClass
	{
		private NodeRef _elevatorRef;
		private gameEntityReference _npcRef;
		private CEnum<questElevator_ManageNPCAttachment_NodeTypeParamsAction> _action;

		[Ordinal(0)] 
		[RED("elevatorRef")] 
		public NodeRef ElevatorRef
		{
			get => GetProperty(ref _elevatorRef);
			set => SetProperty(ref _elevatorRef, value);
		}

		[Ordinal(1)] 
		[RED("npcRef")] 
		public gameEntityReference NpcRef
		{
			get => GetProperty(ref _npcRef);
			set => SetProperty(ref _npcRef, value);
		}

		[Ordinal(2)] 
		[RED("action")] 
		public CEnum<questElevator_ManageNPCAttachment_NodeTypeParamsAction> Action
		{
			get => GetProperty(ref _action);
			set => SetProperty(ref _action, value);
		}
	}
}
