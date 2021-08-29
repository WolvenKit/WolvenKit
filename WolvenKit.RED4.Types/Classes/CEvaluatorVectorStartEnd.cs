using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CEvaluatorVectorStartEnd : IEvaluatorVector
	{
		private Vector4 _start;
		private Vector4 _end;

		[Ordinal(2)] 
		[RED("start")] 
		public Vector4 Start
		{
			get => GetProperty(ref _start);
			set => SetProperty(ref _start, value);
		}

		[Ordinal(3)] 
		[RED("end")] 
		public Vector4 End
		{
			get => GetProperty(ref _end);
			set => SetProperty(ref _end, value);
		}
	}
}
