using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class entLODDefinition : ISerializable
	{
		private CStatic<CFloat> _backgroundDistanceLODs;
		private CStatic<CFloat> _regularDistanceLODs;
		private CStatic<CFloat> _cinematicDistanceLODs;
		private CStatic<CFloat> _vehicleDistanceLODs;
		private CStatic<CFloat> _cinematicVehicleDistanceLODs;
		private CStatic<CFloat> _vehicleInteriorDistanceLODs;
		private CStatic<CFloat> _largeVehicleInteriorDistanceLODs;
		private CStatic<CFloat> _consoleDistanceLODs;

		[Ordinal(0)] 
		[RED("backgroundDistanceLODs", 4)] 
		public CStatic<CFloat> BackgroundDistanceLODs
		{
			get => GetProperty(ref _backgroundDistanceLODs);
			set => SetProperty(ref _backgroundDistanceLODs, value);
		}

		[Ordinal(1)] 
		[RED("regularDistanceLODs", 4)] 
		public CStatic<CFloat> RegularDistanceLODs
		{
			get => GetProperty(ref _regularDistanceLODs);
			set => SetProperty(ref _regularDistanceLODs, value);
		}

		[Ordinal(2)] 
		[RED("cinematicDistanceLODs", 4)] 
		public CStatic<CFloat> CinematicDistanceLODs
		{
			get => GetProperty(ref _cinematicDistanceLODs);
			set => SetProperty(ref _cinematicDistanceLODs, value);
		}

		[Ordinal(3)] 
		[RED("vehicleDistanceLODs", 4)] 
		public CStatic<CFloat> VehicleDistanceLODs
		{
			get => GetProperty(ref _vehicleDistanceLODs);
			set => SetProperty(ref _vehicleDistanceLODs, value);
		}

		[Ordinal(4)] 
		[RED("cinematicVehicleDistanceLODs", 4)] 
		public CStatic<CFloat> CinematicVehicleDistanceLODs
		{
			get => GetProperty(ref _cinematicVehicleDistanceLODs);
			set => SetProperty(ref _cinematicVehicleDistanceLODs, value);
		}

		[Ordinal(5)] 
		[RED("vehicleInteriorDistanceLODs", 4)] 
		public CStatic<CFloat> VehicleInteriorDistanceLODs
		{
			get => GetProperty(ref _vehicleInteriorDistanceLODs);
			set => SetProperty(ref _vehicleInteriorDistanceLODs, value);
		}

		[Ordinal(6)] 
		[RED("largeVehicleInteriorDistanceLODs", 4)] 
		public CStatic<CFloat> LargeVehicleInteriorDistanceLODs
		{
			get => GetProperty(ref _largeVehicleInteriorDistanceLODs);
			set => SetProperty(ref _largeVehicleInteriorDistanceLODs, value);
		}

		[Ordinal(7)] 
		[RED("consoleDistanceLODs", 4)] 
		public CStatic<CFloat> ConsoleDistanceLODs
		{
			get => GetProperty(ref _consoleDistanceLODs);
			set => SetProperty(ref _consoleDistanceLODs, value);
		}
	}
}
