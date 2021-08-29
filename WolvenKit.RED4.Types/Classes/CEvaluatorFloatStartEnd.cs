using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CEvaluatorFloatStartEnd : IEvaluatorFloat
	{
		private CFloat _start;
		private CFloat _end;

		[Ordinal(0)] 
		[RED("start")] 
		public CFloat Start
		{
			get => GetProperty(ref _start);
			set => SetProperty(ref _start, value);
		}

		[Ordinal(1)] 
		[RED("end")] 
		public CFloat End
		{
			get => GetProperty(ref _end);
			set => SetProperty(ref _end, value);
		}
	}
}
