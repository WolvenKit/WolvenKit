using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CEvaluatorColorMultiCurve : IEvaluatorColor
	{
		private MultiChannelCurve<CFloat> _curves;
		private CUInt32 _numberOfCurveSamples;

		[Ordinal(0)] 
		[RED("curves")] 
		public MultiChannelCurve<CFloat> Curves
		{
			get => GetProperty(ref _curves);
			set => SetProperty(ref _curves, value);
		}

		[Ordinal(1)] 
		[RED("numberOfCurveSamples")] 
		public CUInt32 NumberOfCurveSamples
		{
			get => GetProperty(ref _numberOfCurveSamples);
			set => SetProperty(ref _numberOfCurveSamples, value);
		}

		public CEvaluatorColorMultiCurve()
		{
			_numberOfCurveSamples = 16;
		}
	}
}
