using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DelamainTaxiComponent : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("taxiStateFact")] 
		public CName TaxiStateFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(6)] 
		[RED("taxiSeatFact")] 
		public CName TaxiSeatFact
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("gameInstance")] 
		public ScriptGameInstance GameInstance
		{
			get => GetPropertyValue<ScriptGameInstance>();
			set => SetPropertyValue<ScriptGameInstance>(value);
		}

		[Ordinal(8)] 
		[RED("delamainTaxiSystem")] 
		public CWeakHandle<DelamainTaxiSystem> DelamainTaxiSystem
		{
			get => GetPropertyValue<CWeakHandle<DelamainTaxiSystem>>();
			set => SetPropertyValue<CWeakHandle<DelamainTaxiSystem>>(value);
		}

		[Ordinal(9)] 
		[RED("autoDriveSystem")] 
		public CWeakHandle<AutoDriveSystem> AutoDriveSystem
		{
			get => GetPropertyValue<CWeakHandle<AutoDriveSystem>>();
			set => SetPropertyValue<CWeakHandle<AutoDriveSystem>>(value);
		}

		[Ordinal(10)] 
		[RED("currentState")] 
		public CEnum<DelamainTaxiState> CurrentState
		{
			get => GetPropertyValue<CEnum<DelamainTaxiState>>();
			set => SetPropertyValue<CEnum<DelamainTaxiState>>(value);
		}

		[Ordinal(11)] 
		[RED("callbackID")] 
		public CUInt32 CallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(12)] 
		[RED("vehicleSpeedCallbackID")] 
		public CHandle<redCallbackObject> VehicleSpeedCallbackID
		{
			get => GetPropertyValue<CHandle<redCallbackObject>>();
			set => SetPropertyValue<CHandle<redCallbackObject>>(value);
		}

		[Ordinal(13)] 
		[RED("isActiveCab")] 
		public CBool IsActiveCab
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public DelamainTaxiComponent()
		{
			TaxiStateFact = "delamain_taxi_state";
			TaxiSeatFact = "delamain_taxi_seat";
			GameInstance = new ScriptGameInstance();
			IsActiveCab = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
