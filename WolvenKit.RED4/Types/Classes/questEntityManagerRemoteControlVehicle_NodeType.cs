using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questEntityManagerRemoteControlVehicle_NodeType : questIEntityManager_NodeType
	{
		[Ordinal(0)] 
		[RED("parentRef")] 
		public gameEntityReference ParentRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("shouldUnseatPassengers")] 
		public CBool ShouldUnseatPassengers
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("shouldModifyInteractionState")] 
		public CBool ShouldModifyInteractionState
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questEntityManagerRemoteControlVehicle_NodeType()
		{
			ParentRef = new gameEntityReference { Names = new() };
			Enable = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
