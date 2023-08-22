using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public abstract partial class scnSceneGraphNode : ISerializable
	{
		[Ordinal(0)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get => GetPropertyValue<scnNodeId>();
			set => SetPropertyValue<scnNodeId>(value);
		}

		[Ordinal(1)] 
		[RED("ffStrategy")] 
		public CEnum<scnFastForwardStrategy> FfStrategy
		{
			get => GetPropertyValue<CEnum<scnFastForwardStrategy>>();
			set => SetPropertyValue<CEnum<scnFastForwardStrategy>>(value);
		}

		[Ordinal(2)] 
		[RED("outputSockets")] 
		public CArray<scnOutputSocket> OutputSockets
		{
			get => GetPropertyValue<CArray<scnOutputSocket>>();
			set => SetPropertyValue<CArray<scnOutputSocket>>(value);
		}

		public scnSceneGraphNode()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
