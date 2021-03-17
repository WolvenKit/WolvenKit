using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameVehicleCurvesLibrary : entEntity
	{
		private CArray<rRef<gameVehicleCurveSet>> _curves;
		private CArray<rRef<gameVehicleCommonCurveSet>> _commonCurves;
		private CArray<rRef<vehicleBikeCurveSet>> _bikeCurves;

		[Ordinal(2)] 
		[RED("curves")] 
		public CArray<rRef<gameVehicleCurveSet>> Curves
		{
			get => GetProperty(ref _curves);
			set => SetProperty(ref _curves, value);
		}

		[Ordinal(3)] 
		[RED("commonCurves")] 
		public CArray<rRef<gameVehicleCommonCurveSet>> CommonCurves
		{
			get => GetProperty(ref _commonCurves);
			set => SetProperty(ref _commonCurves, value);
		}

		[Ordinal(4)] 
		[RED("bikeCurves")] 
		public CArray<rRef<vehicleBikeCurveSet>> BikeCurves
		{
			get => GetProperty(ref _bikeCurves);
			set => SetProperty(ref _bikeCurves, value);
		}

		public gameVehicleCurvesLibrary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
