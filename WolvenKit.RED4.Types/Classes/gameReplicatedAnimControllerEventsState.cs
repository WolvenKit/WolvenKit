using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameReplicatedAnimControllerEventsState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("items")] 
		public CArray<gameReplicatedAnimEvent> Items
		{
			get => GetPropertyValue<CArray<gameReplicatedAnimEvent>>();
			set => SetPropertyValue<CArray<gameReplicatedAnimEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("lastAppliedActionsTime")] 
		public netTime LastAppliedActionsTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		public gameReplicatedAnimControllerEventsState()
		{
			Items = new();
			LastAppliedActionsTime = new();
		}
	}
}
