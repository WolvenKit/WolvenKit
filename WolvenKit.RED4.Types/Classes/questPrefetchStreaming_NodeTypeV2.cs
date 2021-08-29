using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questPrefetchStreaming_NodeTypeV2 : questIWorldDataManagerNodeType
	{
		private NodeRef _prefetchPositionRef;
		private CBool _useStreamingOcclusion;
		private CFloat _maxDistance;
		private CBool _forceEnable;

		[Ordinal(0)] 
		[RED("prefetchPositionRef")] 
		public NodeRef PrefetchPositionRef
		{
			get => GetProperty(ref _prefetchPositionRef);
			set => SetProperty(ref _prefetchPositionRef, value);
		}

		[Ordinal(1)] 
		[RED("useStreamingOcclusion")] 
		public CBool UseStreamingOcclusion
		{
			get => GetProperty(ref _useStreamingOcclusion);
			set => SetProperty(ref _useStreamingOcclusion, value);
		}

		[Ordinal(2)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetProperty(ref _maxDistance);
			set => SetProperty(ref _maxDistance, value);
		}

		[Ordinal(3)] 
		[RED("forceEnable")] 
		public CBool ForceEnable
		{
			get => GetProperty(ref _forceEnable);
			set => SetProperty(ref _forceEnable, value);
		}
	}
}
