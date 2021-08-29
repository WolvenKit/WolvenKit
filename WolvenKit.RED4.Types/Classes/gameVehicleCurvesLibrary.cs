using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameVehicleCurvesLibrary : entEntity
	{
		private CArray<CResourceReference<gameVehicleCurveSet>> _curves;
		private CArray<CResourceReference<gameVehicleCommonCurveSet>> _commonCurves;
		private CArray<CResourceReference<vehicleBikeCurveSet>> _bikeCurves;

		[Ordinal(2)] 
		[RED("curves")] 
		public CArray<CResourceReference<gameVehicleCurveSet>> Curves
		{
			get => GetProperty(ref _curves);
			set => SetProperty(ref _curves, value);
		}

		[Ordinal(3)] 
		[RED("commonCurves")] 
		public CArray<CResourceReference<gameVehicleCommonCurveSet>> CommonCurves
		{
			get => GetProperty(ref _commonCurves);
			set => SetProperty(ref _commonCurves, value);
		}

		[Ordinal(4)] 
		[RED("bikeCurves")] 
		public CArray<CResourceReference<vehicleBikeCurveSet>> BikeCurves
		{
			get => GetProperty(ref _bikeCurves);
			set => SetProperty(ref _bikeCurves, value);
		}
	}
}
