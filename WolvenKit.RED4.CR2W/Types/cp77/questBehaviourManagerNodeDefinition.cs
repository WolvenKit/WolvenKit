using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questBehaviourManagerNodeDefinition : questSignalStoppingNodeDefinition
	{
		private gameEntityReference _puppet;
		private CHandle<workIWorkspotQuestAction> _type;
		private CHandle<questIBehaviourManager_NodeType> _newType;

		[Ordinal(2)] 
		[RED("puppet")] 
		public gameEntityReference Puppet
		{
			get
			{
				if (_puppet == null)
				{
					_puppet = (gameEntityReference) CR2WTypeManager.Create("gameEntityReference", "puppet", cr2w, this);
				}
				return _puppet;
			}
			set
			{
				if (_puppet == value)
				{
					return;
				}
				_puppet = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("type")] 
		public CHandle<workIWorkspotQuestAction> Type
		{
			get
			{
				if (_type == null)
				{
					_type = (CHandle<workIWorkspotQuestAction>) CR2WTypeManager.Create("handle:workIWorkspotQuestAction", "type", cr2w, this);
				}
				return _type;
			}
			set
			{
				if (_type == value)
				{
					return;
				}
				_type = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("newType")] 
		public CHandle<questIBehaviourManager_NodeType> NewType
		{
			get
			{
				if (_newType == null)
				{
					_newType = (CHandle<questIBehaviourManager_NodeType>) CR2WTypeManager.Create("handle:questIBehaviourManager_NodeType", "newType", cr2w, this);
				}
				return _newType;
			}
			set
			{
				if (_newType == value)
				{
					return;
				}
				_newType = value;
				PropertySet(this);
			}
		}

		public questBehaviourManagerNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
