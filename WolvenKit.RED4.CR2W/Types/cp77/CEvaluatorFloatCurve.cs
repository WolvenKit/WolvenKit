using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorFloatCurve : IEvaluatorFloat
	{
		private curveData<CFloat> _curves;
		private CUInt32 _numberOfCurveSamples;

		[Ordinal(0)] 
		[RED("curves")] 
		public curveData<CFloat> Curves
		{
			get
			{
				if (_curves == null)
				{
					_curves = (curveData<CFloat>) CR2WTypeManager.Create("curveData:Float", "curves", cr2w, this);
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

		[Ordinal(1)] 
		[RED("numberOfCurveSamples")] 
		public CUInt32 NumberOfCurveSamples
		{
			get
			{
				if (_numberOfCurveSamples == null)
				{
					_numberOfCurveSamples = (CUInt32) CR2WTypeManager.Create("Uint32", "numberOfCurveSamples", cr2w, this);
				}
				return _numberOfCurveSamples;
			}
			set
			{
				if (_numberOfCurveSamples == value)
				{
					return;
				}
				_numberOfCurveSamples = value;
				PropertySet(this);
			}
		}

		public CEvaluatorFloatCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
