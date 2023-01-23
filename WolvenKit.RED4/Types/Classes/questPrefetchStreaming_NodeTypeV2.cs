using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questPrefetchStreaming_NodeTypeV2 : questIWorldDataManagerNodeType
	{
		[Ordinal(0)] 
		[RED("prefetchPositionRef")] 
		public NodeRef PrefetchPositionRef
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("useStreamingOcclusion")] 
		public CBool UseStreamingOcclusion
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("maxDistance")] 
		public CFloat MaxDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("forceEnable")] 
		public CBool ForceEnable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questPrefetchStreaming_NodeTypeV2()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
