using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectFilter_NotObstructed : gameEffectObjectSingleFilter
	{
		private CFloat _forwardOffset;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(0)] 
		[RED("forwardOffset")] 
		public CFloat ForwardOffset
		{
			get => GetProperty(ref _forwardOffset);
			set => SetProperty(ref _forwardOffset, value);
		}

		[Ordinal(1)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}
	}
}
