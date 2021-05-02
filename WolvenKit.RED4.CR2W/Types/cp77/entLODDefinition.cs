using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entLODDefinition : ISerializable
	{
		private CStatic<CFloat> _backgroundDistanceLODs;
		private CStatic<CFloat> _regularDistanceLODs;
		private CStatic<CFloat> _cinematicDistanceLODs;
		private CStatic<CFloat> _vehicleDistanceLODs;
		private CStatic<CFloat> _cinematicVehicleDistanceLODs;

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

		public entLODDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
