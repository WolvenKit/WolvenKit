using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questPrefetchStreaming_NodeTypeV2 : questIWorldDataManagerNodeType
	{
		private NodeRef _prefetchPositionRef;
		private CBool _useStreamingOcclusion;
		private CFloat _maxDistance;

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

		public questPrefetchStreaming_NodeTypeV2(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
