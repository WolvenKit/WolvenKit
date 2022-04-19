using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questForbiddenTrigger_NodeType : questIVehicleManagerNodeType
	{
		[Ordinal(0)] 
		[RED("triggerNodeRef")] 
		public NodeRef TriggerNodeRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("activate")] 
		public CBool Activate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("dismount")] 
		public CBool Dismount
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questForbiddenTrigger_NodeType()
		{
			Activate = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
