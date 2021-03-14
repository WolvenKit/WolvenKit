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
			get
			{
				if (_graph == null)
				{
					_graph = (CArray<CHandle<scnSceneGraphNode>>) CR2WTypeManager.Create("array:handle:scnSceneGraphNode", "graph", cr2w, this);
				}
				return _graph;
			}
			set
			{
				if (_graph == value)
				{
					return;
				}
				_graph = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("startNodes")] 
		public CArray<scnNodeId> StartNodes
		{
			get
			{
				if (_startNodes == null)
				{
					_startNodes = (CArray<scnNodeId>) CR2WTypeManager.Create("array:scnNodeId", "startNodes", cr2w, this);
				}
				return _startNodes;
			}
			set
			{
				if (_startNodes == value)
				{
					return;
				}
				_startNodes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("endNodes")] 
		public CArray<scnNodeId> EndNodes
		{
			get
			{
				if (_endNodes == null)
				{
					_endNodes = (CArray<scnNodeId>) CR2WTypeManager.Create("array:scnNodeId", "endNodes", cr2w, this);
				}
				return _endNodes;
			}
			set
			{
				if (_endNodes == value)
				{
					return;
				}
				_endNodes = value;
				PropertySet(this);
			}
		}

		public scnSceneGraph(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
