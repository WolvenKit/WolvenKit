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
			get
			{
				if (_nodeId == null)
				{
					_nodeId = (scnNodeId) CR2WTypeManager.Create("scnNodeId", "nodeId", cr2w, this);
				}
				return _nodeId;
			}
			set
			{
				if (_nodeId == value)
				{
					return;
				}
				_nodeId = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("ffStrategy")] 
		public CEnum<scnFastForwardStrategy> FfStrategy
		{
			get
			{
				if (_ffStrategy == null)
				{
					_ffStrategy = (CEnum<scnFastForwardStrategy>) CR2WTypeManager.Create("scnFastForwardStrategy", "ffStrategy", cr2w, this);
				}
				return _ffStrategy;
			}
			set
			{
				if (_ffStrategy == value)
				{
					return;
				}
				_ffStrategy = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("outputSockets")] 
		public CArray<scnOutputSocket> OutputSockets
		{
			get
			{
				if (_outputSockets == null)
				{
					_outputSockets = (CArray<scnOutputSocket>) CR2WTypeManager.Create("array:scnOutputSocket", "outputSockets", cr2w, this);
				}
				return _outputSockets;
			}
			set
			{
				if (_outputSockets == value)
				{
					return;
				}
				_outputSockets = value;
				PropertySet(this);
			}
		}

		public scnSceneGraphNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
