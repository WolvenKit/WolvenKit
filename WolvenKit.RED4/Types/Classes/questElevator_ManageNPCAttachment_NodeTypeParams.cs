using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questElevator_ManageNPCAttachment_NodeTypeParams : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("elevatorRef")] 
		public NodeRef ElevatorRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("npcRef")] 
		public gameEntityReference NpcRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("action")] 
		public CEnum<questElevator_ManageNPCAttachment_NodeTypeParamsAction> Action
		{
			get => GetPropertyValue<CEnum<questElevator_ManageNPCAttachment_NodeTypeParamsAction>>();
			set => SetPropertyValue<CEnum<questElevator_ManageNPCAttachment_NodeTypeParamsAction>>(value);
		}

		public questElevator_ManageNPCAttachment_NodeTypeParams()
		{
			NpcRef = new() { Names = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
