using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePreventionSystemDebugData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("totalCrimeScore")] 
		public CFloat TotalCrimeScore
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("heatStage")] 
		public CInt32 HeatStage
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("heatThreshold")] 
		public CFloat HeatThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("heatMultiplierDistrict")] 
		public CFloat HeatMultiplierDistrict
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("heatMultiplierQuest")] 
		public CFloat HeatMultiplierQuest
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("totalVehiclesCount")] 
		public CInt32 TotalVehiclesCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("totalAVsCount")] 
		public CInt32 TotalAVsCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(7)] 
		[RED("totalBlockadesCount")] 
		public CInt32 TotalBlockadesCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(8)] 
		[RED("totalNPCCount")] 
		public CInt32 TotalNPCCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("currentVehicleTicketCount")] 
		public CInt32 CurrentVehicleTicketCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(10)] 
		[RED("maxVehicleTicketCount")] 
		public CInt32 MaxVehicleTicketCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(11)] 
		[RED("maxTacNPCCount")] 
		public CInt32 MaxTacNPCCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(12)] 
		[RED("engagedVehiclesCount")] 
		public CInt32 EngagedVehiclesCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(13)] 
		[RED("engagedVehiclesLimit")] 
		public CInt32 EngagedVehiclesLimit
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(14)] 
		[RED("supportVehiclesCount")] 
		public CInt32 SupportVehiclesCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(15)] 
		[RED("supportVehiclesLimit")] 
		public CInt32 SupportVehiclesLimit
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("maxAVPlayerDistance")] 
		public CFloat MaxAVPlayerDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(17)] 
		[RED("lastAVRequestedSpawnPosition")] 
		public Vector3 LastAVRequestedSpawnPosition
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}

		[Ordinal(18)] 
		[RED("totalNPCLimit")] 
		public CInt32 TotalNPCLimit
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("externalNPCCount")] 
		public CInt32 ExternalNPCCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(20)] 
		[RED("fallbackNPCCount")] 
		public CInt32 FallbackNPCCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(21)] 
		[RED("registeredPendingTickets")] 
		public CInt32 RegisteredPendingTickets
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(22)] 
		[RED("awaitedAVSpawnPointsRequestID")] 
		public CUInt32 AwaitedAVSpawnPointsRequestID
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(23)] 
		[RED("lastKnownPosition")] 
		public Vector4 LastKnownPosition
		{
			get => GetPropertyValue<Vector4>();
			set => SetPropertyValue<Vector4>(value);
		}

		[Ordinal(24)] 
		[RED("heatChangeReason")] 
		public CString HeatChangeReason
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(25)] 
		[RED("systemEnabled")] 
		public CBool SystemEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(26)] 
		[RED("systemLockEventSources")] 
		public CArray<CString> SystemLockEventSources
		{
			get => GetPropertyValue<CArray<CString>>();
			set => SetPropertyValue<CArray<CString>>(value);
		}

		public gamePreventionSystemDebugData()
		{
			TotalCrimeScore = -1.000000F;
			HeatStage = -1;
			HeatThreshold = -1.000000F;
			HeatMultiplierDistrict = -1.000000F;
			HeatMultiplierQuest = -1.000000F;
			TotalVehiclesCount = -1;
			TotalAVsCount = -1;
			TotalBlockadesCount = -1;
			TotalNPCCount = -1;
			CurrentVehicleTicketCount = -1;
			MaxVehicleTicketCount = -1;
			MaxTacNPCCount = -1;
			EngagedVehiclesCount = -1;
			EngagedVehiclesLimit = -1;
			SupportVehiclesCount = -1;
			SupportVehiclesLimit = -1;
			MaxAVPlayerDistance = -1.000000F;
			LastAVRequestedSpawnPosition = new Vector3();
			TotalNPCLimit = -1;
			ExternalNPCCount = -1;
			FallbackNPCCount = -1;
			RegisteredPendingTickets = -1;
			LastKnownPosition = new Vector4();
			HeatChangeReason = "-";
			SystemEnabled = true;
			SystemLockEventSources = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
