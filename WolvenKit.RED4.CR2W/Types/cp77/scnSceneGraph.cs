using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class scnSceneGraph : ISerializable
	{
		private CArray<CHandle<scnSceneGraphNode>> _graph;
		private CArray<scnNodeId> _startNodes;
		private CArray<scnNodeId> _endNodes;

		[Ordinal(0)] 
		[RED("graph")] 
		public CArray<CHandle<scnSceneGraphNode>> Graph
		{
			get => GetProperty(ref _graph);
			set => SetProperty(ref _graph, value);
		}

		[Ordinal(1)] 
		[RED("startNodes")] 
		public CArray<scnNodeId> StartNodes
		{
			get => GetProperty(ref _startNodes);
			set => SetProperty(ref _startNodes, value);
		}

		[Ordinal(2)] 
		[RED("endNodes")] 
		public CArray<scnNodeId> EndNodes
		{
			get => GetProperty(ref _endNodes);
			set => SetProperty(ref _endNodes, value);
		}

		public scnSceneGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
