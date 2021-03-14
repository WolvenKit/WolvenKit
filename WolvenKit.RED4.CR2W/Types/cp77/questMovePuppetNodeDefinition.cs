using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questMovePuppetNodeDefinition : questConfigurableAICommandNode
	{
		private gameEntityReference _entityReference;
		private CName _moveType;
		private CHandle<questAICommandParams> _nodeParams;

		[Ordinal(2)] 
		[RED("entityReference")] 
		public gameEntityReference EntityReference
		{
			get
			{
				if (_entityReference == null)
				{
					_entityReference = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "entityReference", cr2w, this);
				}
				return _entityReference;
			}
			set
			{
				if (_entityReference == value)
				{
					return;
				}
				_entityReference = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("moveType")] 
		public CName MoveType
		{
			get
			{
				if (_moveType == null)
				{
					_moveType = (CName) CR2WTypeManager.Create("CName", "moveType", cr2w, this);
				}
				return _moveType;
			}
			set
			{
				if (_moveType == value)
				{
					return;
				}
				_moveType = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("nodeParams")] 
		public CHandle<questAICommandParams> NodeParams
		{
			get
			{
				if (_nodeParams == null)
				{
					_nodeParams = (CHandle<questAICommandParams>) CR2WTypeManager.Create("handle:questAICommandParams", "nodeParams", cr2w, this);
				}
				return _nodeParams;
			}
			set
			{
				if (_nodeParams == value)
				{
					return;
				}
				_nodeParams = value;
				PropertySet(this);
			}
		}

		public questMovePuppetNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
