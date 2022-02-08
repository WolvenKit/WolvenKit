using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class PickUpEvents : CarriedObjectEvents
	{
		[Ordinal(9)] 
		[RED("stateMachineInstanceData")] 
		public gamestateMachineStateMachineInstanceData StateMachineInstanceData
		{
			get => GetPropertyValue<gamestateMachineStateMachineInstanceData>();
			set => SetPropertyValue<gamestateMachineStateMachineInstanceData>(value);
		}

		public PickUpEvents()
		{
			StyleName = "CarriedObject.Style";
			ForceStyleName = "CarriedObject.ForcedStyle";
			StateMachineInstanceData = new();
		}
	}
}
