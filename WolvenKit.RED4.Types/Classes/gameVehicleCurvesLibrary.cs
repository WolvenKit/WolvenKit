using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameVehicleCurvesLibrary : entEntity
	{
		[Ordinal(2)] 
		[RED("curves")] 
		public CArray<CResourceReference<gameVehicleCurveSet>> Curves
		{
			get => GetPropertyValue<CArray<CResourceReference<gameVehicleCurveSet>>>();
			set => SetPropertyValue<CArray<CResourceReference<gameVehicleCurveSet>>>(value);
		}

		[Ordinal(3)] 
		[RED("commonCurves")] 
		public CArray<CResourceReference<gameVehicleCommonCurveSet>> CommonCurves
		{
			get => GetPropertyValue<CArray<CResourceReference<gameVehicleCommonCurveSet>>>();
			set => SetPropertyValue<CArray<CResourceReference<gameVehicleCommonCurveSet>>>(value);
		}

		[Ordinal(4)] 
		[RED("bikeCurves")] 
		public CArray<CResourceReference<vehicleBikeCurveSet>> BikeCurves
		{
			get => GetPropertyValue<CArray<CResourceReference<vehicleBikeCurveSet>>>();
			set => SetPropertyValue<CArray<CResourceReference<vehicleBikeCurveSet>>>(value);
		}

		public gameVehicleCurvesLibrary()
		{
			Curves = new();
			CommonCurves = new();
			BikeCurves = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
