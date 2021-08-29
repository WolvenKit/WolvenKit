using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficSyncPointDefinition : RedBaseClass
	{
		private CArray<NodeRef> _laneRefs;
		private CArray<CFloat> _lanePositions;
		private CFloat _length;

		[Ordinal(0)] 
		[RED("laneRefs")] 
		public CArray<NodeRef> LaneRefs
		{
			get => GetProperty(ref _laneRefs);
			set => SetProperty(ref _laneRefs, value);
		}

		[Ordinal(1)] 
		[RED("lanePositions")] 
		public CArray<CFloat> LanePositions
		{
			get => GetProperty(ref _lanePositions);
			set => SetProperty(ref _lanePositions, value);
		}

		[Ordinal(2)] 
		[RED("length")] 
		public CFloat Length
		{
			get => GetProperty(ref _length);
			set => SetProperty(ref _length, value);
		}
	}
}
