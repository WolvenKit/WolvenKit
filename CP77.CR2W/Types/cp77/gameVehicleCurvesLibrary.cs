using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameVehicleCurvesLibrary : entEntity
	{
		[Ordinal(0)]  [RED("bikeCurves")] public CArray<rRef<vehicleBikeCurveSet>> BikeCurves { get; set; }
		[Ordinal(1)]  [RED("commonCurves")] public CArray<rRef<gameVehicleCommonCurveSet>> CommonCurves { get; set; }
		[Ordinal(2)]  [RED("curves")] public CArray<rRef<gameVehicleCurveSet>> Curves { get; set; }

		public gameVehicleCurvesLibrary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
