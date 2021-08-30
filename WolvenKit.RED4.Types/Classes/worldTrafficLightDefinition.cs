using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficLightDefinition : RedBaseClass
	{
		private CFloat _positionOnLane;
		private CUInt32 _groupIdx;
		private CFloat _extent;
		private CArray<worldTrafficLightStage> _timeline;

		[Ordinal(0)] 
		[RED("positionOnLane")] 
		public CFloat PositionOnLane
		{
			get => GetProperty(ref _positionOnLane);
			set => SetProperty(ref _positionOnLane, value);
		}

		[Ordinal(1)] 
		[RED("groupIdx")] 
		public CUInt32 GroupIdx
		{
			get => GetProperty(ref _groupIdx);
			set => SetProperty(ref _groupIdx, value);
		}

		[Ordinal(2)] 
		[RED("extent")] 
		public CFloat Extent
		{
			get => GetProperty(ref _extent);
			set => SetProperty(ref _extent, value);
		}

		[Ordinal(3)] 
		[RED("timeline")] 
		public CArray<worldTrafficLightStage> Timeline
		{
			get => GetProperty(ref _timeline);
			set => SetProperty(ref _timeline, value);
		}

		public worldTrafficLightDefinition()
		{
			_groupIdx = 4294967295;
		}
	}
}
