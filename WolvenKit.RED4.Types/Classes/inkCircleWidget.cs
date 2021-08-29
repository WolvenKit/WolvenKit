using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class inkCircleWidget : inkBaseShapeWidget
	{
		private CUInt32 _segmentsNumber;

		[Ordinal(20)] 
		[RED("segmentsNumber")] 
		public CUInt32 SegmentsNumber
		{
			get => GetProperty(ref _segmentsNumber);
			set => SetProperty(ref _segmentsNumber, value);
		}
	}
}
