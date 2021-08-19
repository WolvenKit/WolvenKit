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

		public questPrefetchStreaming_NodeTypeV2(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
