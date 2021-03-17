using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animSmoothFloatClamp : CVariable
	{
		private CFloat _min;
		private CFloat _max;
		private curveData<CFloat> _marginEaseOutCurve;

		[Ordinal(0)] 
		[RED("min")] 
		public CFloat Min
		{
			get => GetProperty(ref _min);
			set => SetProperty(ref _min, value);
		}

		[Ordinal(1)] 
		[RED("max")] 
		public CFloat Max
		{
			get => GetProperty(ref _max);
			set => SetProperty(ref _max, value);
		}

		[Ordinal(2)] 
		[RED("marginEaseOutCurve")] 
		public curveData<CFloat> MarginEaseOutCurve
		{
			get => GetProperty(ref _marginEaseOutCurve);
			set => SetProperty(ref _marginEaseOutCurve, value);
		}

		public animSmoothFloatClamp(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
