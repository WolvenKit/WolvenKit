using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameEffectObjectProvider_PhysicalRay : gameEffectObjectProvider
	{
		private gameEffectInputParameter_Vector _inputPosition;
		private gameEffectInputParameter_Vector _inputForward;
		private gameEffectInputParameter_Float _inputRange;
		private gameEffectOutputParameter_Vector _outputRaycastEnd;
		private CHandle<physicsFilterData> _filterData;

		[Ordinal(0)] 
		[RED("inputPosition")] 
		public gameEffectInputParameter_Vector InputPosition
		{
			get => GetProperty(ref _inputPosition);
			set => SetProperty(ref _inputPosition, value);
		}

		[Ordinal(1)] 
		[RED("inputForward")] 
		public gameEffectInputParameter_Vector InputForward
		{
			get => GetProperty(ref _inputForward);
			set => SetProperty(ref _inputForward, value);
		}

		[Ordinal(2)] 
		[RED("inputRange")] 
		public gameEffectInputParameter_Float InputRange
		{
			get => GetProperty(ref _inputRange);
			set => SetProperty(ref _inputRange, value);
		}

		[Ordinal(3)] 
		[RED("outputRaycastEnd")] 
		public gameEffectOutputParameter_Vector OutputRaycastEnd
		{
			get => GetProperty(ref _outputRaycastEnd);
			set => SetProperty(ref _outputRaycastEnd, value);
		}

		[Ordinal(4)] 
		[RED("filterData")] 
		public CHandle<physicsFilterData> FilterData
		{
			get => GetProperty(ref _filterData);
			set => SetProperty(ref _filterData, value);
		}
	}
}
