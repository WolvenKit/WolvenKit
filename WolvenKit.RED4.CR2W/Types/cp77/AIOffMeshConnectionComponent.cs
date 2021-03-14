using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIOffMeshConnectionComponent : entIComponent
	{
		private CArray<NodeRef> _offMeshConnectionNodesRefs;
		private CEnum<NavGenAgentSize> _agentSize;

		[Ordinal(3)] 
		[RED("offMeshConnectionNodesRefs")] 
		public CArray<NodeRef> OffMeshConnectionNodesRefs
		{
			get
			{
				if (_offMeshConnectionNodesRefs == null)
				{
					_offMeshConnectionNodesRefs = (CArray<NodeRef>) CR2WTypeManager.Create("array:NodeRef", "offMeshConnectionNodesRefs", cr2w, this);
				}
				return _offMeshConnectionNodesRefs;
			}
			set
			{
				if (_offMeshConnectionNodesRefs == value)
				{
					return;
				}
				_offMeshConnectionNodesRefs = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("agentSize")] 
		public CEnum<NavGenAgentSize> AgentSize
		{
			get
			{
				if (_agentSize == null)
				{
					_agentSize = (CEnum<NavGenAgentSize>) CR2WTypeManager.Create("NavGenAgentSize", "agentSize", cr2w, this);
				}
				return _agentSize;
			}
			set
			{
				if (_agentSize == value)
				{
					return;
				}
				_agentSize = value;
				PropertySet(this);
			}
		}

		public AIOffMeshConnectionComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
