using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PickUpEvents : CarriedObjectEvents
	{
		[Ordinal(9)] 
		[RED("stateMachineInstanceData")] 
		public gamestateMachineStateMachineInstanceData StateMachineInstanceData
		{
			get => GetPropertyValue<gamestateMachineStateMachineInstanceData>();
			set => SetPropertyValue<gamestateMachineStateMachineInstanceData>(value);
		}

		[Ordinal(10)] 
		[RED("noCameraControlApplied")] 
		public CBool NoCameraControlApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(11)] 
		[RED("noMovementApplied")] 
		public CBool NoMovementApplied
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PickUpEvents()
		{
			StyleName = "CarriedObject.Style";
			ForceStyleName = "CarriedObject.ForcedStyle";
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
