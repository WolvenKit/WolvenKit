using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CEvaluatorColorStartEnd : IEvaluatorColor
	{
		private CColor _start;
		private CColor _end;

		[Ordinal(0)] 
		[RED("start")] 
		public CColor Start
		{
			get => GetProperty(ref _start);
			set => SetProperty(ref _start, value);
		}

		[Ordinal(1)] 
		[RED("end")] 
		public CColor End
		{
			get => GetProperty(ref _end);
			set => SetProperty(ref _end, value);
		}
	}
}
