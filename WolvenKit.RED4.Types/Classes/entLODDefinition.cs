using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entLODDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("backgroundDistanceLODs", 4)] 
		public CStatic<CFloat> BackgroundDistanceLODs
		{
			get => GetPropertyValue<CStatic<CFloat>>();
			set => SetPropertyValue<CStatic<CFloat>>(value);
		}

		[Ordinal(1)] 
		[RED("regularDistanceLODs", 4)] 
		public CStatic<CFloat> RegularDistanceLODs
		{
			get => GetPropertyValue<CStatic<CFloat>>();
			set => SetPropertyValue<CStatic<CFloat>>(value);
		}

		[Ordinal(2)] 
		[RED("cinematicDistanceLODs", 4)] 
		public CStatic<CFloat> CinematicDistanceLODs
		{
			get => GetPropertyValue<CStatic<CFloat>>();
			set => SetPropertyValue<CStatic<CFloat>>(value);
		}

		[Ordinal(3)] 
		[RED("vehicleDistanceLODs", 4)] 
		public CStatic<CFloat> VehicleDistanceLODs
		{
			get => GetPropertyValue<CStatic<CFloat>>();
			set => SetPropertyValue<CStatic<CFloat>>(value);
		}

		[Ordinal(4)] 
		[RED("cinematicVehicleDistanceLODs", 4)] 
		public CStatic<CFloat> CinematicVehicleDistanceLODs
		{
			get => GetPropertyValue<CStatic<CFloat>>();
			set => SetPropertyValue<CStatic<CFloat>>(value);
		}

		[Ordinal(5)] 
		[RED("vehicleInteriorDistanceLODs", 4)] 
		public CStatic<CFloat> VehicleInteriorDistanceLODs
		{
			get => GetPropertyValue<CStatic<CFloat>>();
			set => SetPropertyValue<CStatic<CFloat>>(value);
		}

		[Ordinal(6)] 
		[RED("largeVehicleInteriorDistanceLODs", 4)] 
		public CStatic<CFloat> LargeVehicleInteriorDistanceLODs
		{
			get => GetPropertyValue<CStatic<CFloat>>();
			set => SetPropertyValue<CStatic<CFloat>>(value);
		}

		[Ordinal(7)] 
		[RED("consoleDistanceLODs", 4)] 
		public CStatic<CFloat> ConsoleDistanceLODs
		{
			get => GetPropertyValue<CStatic<CFloat>>();
			set => SetPropertyValue<CStatic<CFloat>>(value);
		}

		public entLODDefinition()
		{
			BackgroundDistanceLODs = new(0);
			RegularDistanceLODs = new(0);
			CinematicDistanceLODs = new(0);
			VehicleDistanceLODs = new(0);
			CinematicVehicleDistanceLODs = new(0);
			VehicleInteriorDistanceLODs = new(0);
			LargeVehicleInteriorDistanceLODs = new(0);
			ConsoleDistanceLODs = new(0);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
