using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class inkCircleWidget : inkBaseShapeWidget
	{
		[Ordinal(20)] 
		[RED("segmentsNumber")] 
		public CUInt32 SegmentsNumber
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public inkCircleWidget()
		{
			SegmentsNumber = 20;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
