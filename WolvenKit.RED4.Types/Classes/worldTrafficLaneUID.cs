using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficLaneUID : RedBaseClass
	{
		private CUInt64 _nodeRefHash;
		private CUInt16 _laneNumber;
		private CUInt16 _seqNumber;
		private CBool _isReversed;

		[Ordinal(0)] 
		[RED("nodeRefHash")] 
		public CUInt64 NodeRefHash
		{
			get => GetProperty(ref _nodeRefHash);
			set => SetProperty(ref _nodeRefHash, value);
		}

		[Ordinal(1)] 
		[RED("laneNumber")] 
		public CUInt16 LaneNumber
		{
			get => GetProperty(ref _laneNumber);
			set => SetProperty(ref _laneNumber, value);
		}

		[Ordinal(2)] 
		[RED("seqNumber")] 
		public CUInt16 SeqNumber
		{
			get => GetProperty(ref _seqNumber);
			set => SetProperty(ref _seqNumber, value);
		}

		[Ordinal(3)] 
		[RED("isReversed")] 
		public CBool IsReversed
		{
			get => GetProperty(ref _isReversed);
			set => SetProperty(ref _isReversed, value);
		}
	}
}
