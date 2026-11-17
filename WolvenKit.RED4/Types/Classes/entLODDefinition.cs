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
		[RED("vehicleDecorationDistanceLODs", 4)] 
		public CStatic<CFloat> VehicleDecorationDistanceLODs
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
			BackgroundDistanceLODs = new(4);
			RegularDistanceLODs = new(4);
			CinematicDistanceLODs = new(4);
			VehicleDistanceLODs = new(4);
			CinematicVehicleDistanceLODs = new(4);
			VehicleInteriorDistanceLODs = new(4);
			VehicleDecorationDistanceLODs = new(4);
			ConsoleDistanceLODs = new(4);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
