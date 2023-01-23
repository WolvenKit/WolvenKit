using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class worldTrafficSyncPointDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("laneRefs")] 
		public CArray<NodeRef> LaneRefs
		{
			get => GetPropertyValue<CArray<NodeRef>>();
			set => SetPropertyValue<CArray<NodeRef>>(value);
		}

		[Ordinal(1)] 
		[RED("lanePositions")] 
		public CArray<CFloat> LanePositions
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}

		[Ordinal(2)] 
		[RED("length")] 
		public CFloat Length
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public worldTrafficSyncPointDefinition()
		{
			LaneRefs = new();
			LanePositions = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
