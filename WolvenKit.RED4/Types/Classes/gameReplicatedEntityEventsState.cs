using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameReplicatedEntityEventsState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("items")] 
		public CArray<gameReplicatedEntityEvent> Items
		{
			get => GetPropertyValue<CArray<gameReplicatedEntityEvent>>();
			set => SetPropertyValue<CArray<gameReplicatedEntityEvent>>(value);
		}

		[Ordinal(1)] 
		[RED("lastAppliedActionsTime")] 
		public netTime LastAppliedActionsTime
		{
			get => GetPropertyValue<netTime>();
			set => SetPropertyValue<netTime>(value);
		}

		public gameReplicatedEntityEventsState()
		{
			Items = new();
			LastAppliedActionsTime = new netTime();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
