using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneGraphNode : ISerializable
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

		public scnSceneGraphNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
