using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_QueryBox : gameEffectObjectProvider
	{
		private CHandle<physicsFilterData> _filterData;
		private gameEffectInputParameter_Vector _inputPosition;

		[Ordinal(0)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}

		[Ordinal(1)] 
		[RED("inputPosition")] 
		public gameEffectInputParameter_Vector InputPosition
		{
			get => GetProperty(ref _inputPosition);
			set => SetProperty(ref _inputPosition, value);
		}
	}
}
