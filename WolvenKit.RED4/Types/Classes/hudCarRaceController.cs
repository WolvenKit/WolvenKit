using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class hudCarRaceController : gameuiHUDGameController
	{
		[Ordinal(9)] 
		[RED("Countdown")] 
		public inkCanvasWidgetReference Countdown
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(10)] 
		[RED("PositionCounter")] 
		public inkCanvasWidgetReference PositionCounter
		{
			get => GetPropertyValue<inkCanvasWidgetReference>();
			set => SetPropertyValue<inkCanvasWidgetReference>(value);
		}

		[Ordinal(11)] 
		[RED("RacePosition")] 
		public inkTextWidgetReference RacePosition
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(12)] 
		[RED("RaceTime")] 
		public inkTextWidgetReference RaceTime
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(13)] 
		[RED("RaceCheckpoint")] 
		public inkTextWidgetReference RaceCheckpoint
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(14)] 
		[RED("maxPosition")] 
		public CInt32 MaxPosition
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("maxCheckpoint")] 
		public CInt32 MaxCheckpoint
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("playerPosition")] 
		public CInt32 PlayerPosition
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(17)] 
		[RED("minute")] 
		public CInt32 Minute
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(18)] 
		[RED("activeVehicleUIBlackboard")] 
		public CWeakHandle<gameIBlackboard> ActiveVehicleUIBlackboard
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(19)] 
		[RED("activeVehicle")] 
		public CWeakHandle<vehicleBaseObject> ActiveVehicle
		{
			get => GetPropertyValue<CWeakHandle<vehicleBaseObject>>();
			set => SetPropertyValue<CWeakHandle<vehicleBaseObject>>(value);
		}

		[Ordinal(20)] 
		[RED("raceStartEngineTime")] 
		public EngineTime RaceStartEngineTime
		{
			get => GetPropertyValue<EngineTime>();
			set => SetPropertyValue<EngineTime>(value);
		}

		[Ordinal(21)] 
		[RED("factCallbackID")] 
		public CUInt32 FactCallbackID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public hudCarRaceController()
		{
			Countdown = new();
			PositionCounter = new();
			RacePosition = new();
			RaceTime = new();
			RaceCheckpoint = new();
			RaceStartEngineTime = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
