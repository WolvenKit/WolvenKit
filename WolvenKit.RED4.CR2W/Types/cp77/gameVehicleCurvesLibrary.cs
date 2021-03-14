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
			get
			{
				if (_curves == null)
				{
					_curves = (CArray<rRef<gameVehicleCurveSet>>) CR2WTypeManager.Create("array:rRef:gameVehicleCurveSet", "curves", cr2w, this);
				}
				return _curves;
			}
			set
			{
				if (_curves == value)
				{
					return;
				}
				_curves = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("commonCurves")] 
		public CArray<rRef<gameVehicleCommonCurveSet>> CommonCurves
		{
			get
			{
				if (_commonCurves == null)
				{
					_commonCurves = (CArray<rRef<gameVehicleCommonCurveSet>>) CR2WTypeManager.Create("array:rRef:gameVehicleCommonCurveSet", "commonCurves", cr2w, this);
				}
				return _commonCurves;
			}
			set
			{
				if (_commonCurves == value)
				{
					return;
				}
				_commonCurves = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("bikeCurves")] 
		public CArray<rRef<vehicleBikeCurveSet>> BikeCurves
		{
			get
			{
				if (_bikeCurves == null)
				{
					_bikeCurves = (CArray<rRef<vehicleBikeCurveSet>>) CR2WTypeManager.Create("array:rRef:vehicleBikeCurveSet", "bikeCurves", cr2w, this);
				}
				return _bikeCurves;
			}
			set
			{
				if (_bikeCurves == value)
				{
					return;
				}
				_bikeCurves = value;
				PropertySet(this);
			}
		}

		public gameVehicleCurvesLibrary(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
