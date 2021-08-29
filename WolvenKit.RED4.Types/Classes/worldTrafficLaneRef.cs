using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldTrafficLaneRef : RedBaseClass
	{
		private NodeRef _nodeRef;
		private CUInt16 _laneNumber;
		private CBool _isReversed;

		[Ordinal(0)] 
		[RED("nodeRef")] 
		public NodeRef NodeRef
		{
			get => GetProperty(ref _nodeRef);
			set => SetProperty(ref _nodeRef, value);
		}

		[Ordinal(1)] 
		[RED("laneNumber")] 
		public CUInt16 LaneNumber
		{
			get => GetProperty(ref _laneNumber);
			set => SetProperty(ref _laneNumber, value);
		}

		[Ordinal(2)] 
		[RED("isReversed")] 
		public CBool IsReversed
		{
			get => GetProperty(ref _isReversed);
			set => SetProperty(ref _isReversed, value);
		}
	}
}
