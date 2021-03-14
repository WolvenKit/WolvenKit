using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CEvaluatorVectorMultiCurve : IEvaluatorVector
	{
		private multiChannelCurve<CFloat> _curves;
		private CUInt32 _numberOfCurveSamples;

		[Ordinal(2)] 
		[RED("curves")] 
		public multiChannelCurve<CFloat> Curves
		{
			get
			{
				if (_curves == null)
				{
					_curves = (multiChannelCurve<CFloat>) CR2WTypeManager.Create("multiChannelCurve:Float", "curves", cr2w, this);
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

		public CEvaluatorVectorMultiCurve(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
