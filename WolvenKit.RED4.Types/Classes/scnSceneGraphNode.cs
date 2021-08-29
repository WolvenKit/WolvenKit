using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class scnSceneGraphNode : ISerializable
	{
		private scnNodeId _nodeId;
		private CEnum<scnFastForwardStrategy> _ffStrategy;
		private CArray<scnOutputSocket> _outputSockets;

		[Ordinal(0)] 
		[RED("nodeId")] 
		public scnNodeId NodeId
		{
			get => GetProperty(ref _nodeId);
			set => SetProperty(ref _nodeId, value);
		}

		[Ordinal(1)] 
		[RED("ffStrategy")] 
		public CEnum<scnFastForwardStrategy> FfStrategy
		{
			get => GetProperty(ref _ffStrategy);
			set => SetProperty(ref _ffStrategy, value);
		}

		[Ordinal(2)] 
		[RED("outputSockets")] 
		public CArray<scnOutputSocket> OutputSockets
		{
			get => GetProperty(ref _outputSockets);
			set => SetProperty(ref _outputSockets, value);
		}
	}
}
