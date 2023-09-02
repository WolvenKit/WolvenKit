using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleDoorInteractionStateChange : ActionBool
	{
		[Ordinal(25)] 
		[RED("door")] 
		public CEnum<vehicleEVehicleDoor> Door
		{
			get => GetPropertyValue<CEnum<vehicleEVehicleDoor>>();
			set => SetPropertyValue<CEnum<vehicleEVehicleDoor>>(value);
		}

		[Ordinal(26)] 
		[RED("newState")] 
		public CEnum<vehicleVehicleDoorInteractionState> NewState
		{
			get => GetPropertyValue<CEnum<vehicleVehicleDoorInteractionState>>();
			set => SetPropertyValue<CEnum<vehicleVehicleDoorInteractionState>>(value);
		}

		[Ordinal(27)] 
		[RED("source")] 
		public CString Source
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public VehicleDoorInteractionStateChange()
		{
			RequesterID = new entEntityID();
			InteractionChoice = new gameinteractionsChoice { CaptionParts = new gameinteractionsChoiceCaption { Parts = new() }, Data = new(), ChoiceMetaData = new gameinteractionsChoiceMetaData { Type = new gameinteractionsChoiceTypeWrapper() }, LookAtDescriptor = new gameinteractionsChoiceLookAtDescriptor { Offset = new Vector3(), OrbId = new gameinteractionsOrbID() } };
			ActionWidgetPackage = new SActionWidgetPackage { DependendActions = new() };
			CanTriggerStim = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
