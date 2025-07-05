using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PreventionSystemHackerLoop : gameScriptableSystem
	{
		[Ordinal(0)] 
		[RED("firstVehicle")] 
		public CWeakHandle<vehicleBaseObject> FirstVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(1)] 
		[RED("state")] 
		public CEnum<EPreventionHackLoopState> State
		{
			get => GetPropertyValue<CEnum<EPreventionHackLoopState>>();
			set => SetPropertyValue<CEnum<EPreventionHackLoopState>>(value);
		}

		[Ordinal(2)] 
		[RED("shouldHackLoopBeEnabledOnThisStar")] 
		public CBool ShouldHackLoopBeEnabledOnThisStar
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("showingHackingPopUp")] 
		public CBool ShowingHackingPopUp
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("currentVehicle")] 
		public CWeakHandle<vehicleBaseObject> CurrentVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(5)] 
		[RED("previousVehicle")] 
		public CWeakHandle<vehicleBaseObject> PreviousVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(6)] 
		[RED("curentHackDelayId")] 
		public gameDelayID CurentHackDelayId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(7)] 
		[RED("futureDelayedUpdateDelayId")] 
		public gameDelayID FutureDelayedUpdateDelayId
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(8)] 
		[RED("hackedVehicles")] 
		public CArray<CHandle<VehiclePreventionHackState>> HackedVehicles
		{
			get => GetPropertyValue<CArray<CHandle<VehiclePreventionHackState>>>();
			set => SetPropertyValue<CArray<CHandle<VehiclePreventionHackState>>>(value);
		}

		[Ordinal(9)] 
		[RED("otherProgressBar")] 
		public CWeakHandle<UploadFromNPCToPlayerListener> OtherProgressBar
		{
			get => GetPropertyValue<CWeakHandle<UploadFromNPCToPlayerListener>>();
			set => SetPropertyValue<CWeakHandle<UploadFromNPCToPlayerListener>>(value);
		}

		[Ordinal(10)] 
		[RED("waitingForUpdate")] 
		public CBool WaitingForUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public PreventionSystemHackerLoop()
		{
			CurentHackDelayId = new gameDelayID();
			FutureDelayedUpdateDelayId = new gameDelayID();
			HackedVehicles = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
