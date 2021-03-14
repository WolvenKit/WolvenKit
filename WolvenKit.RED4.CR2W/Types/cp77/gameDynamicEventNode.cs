using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameDynamicEventNode : worldAreaShapeNode
	{
		private NodeRef _mappinRef;
		private CHandle<questIBaseCondition> _condition;

		[Ordinal(6)] 
		[RED("mappinRef")] 
		public NodeRef MappinRef
		{
			get
			{
				if (_mappinRef == null)
				{
					_mappinRef = (NodeRef) CR2WTypeManager.Create("NodeRef", "mappinRef", cr2w, this);
				}
				return _mappinRef;
			}
			set
			{
				if (_mappinRef == value)
				{
					return;
				}
				_mappinRef = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("condition")] 
		public CHandle<questIBaseCondition> Condition
		{
			get
			{
				if (_condition == null)
				{
					_condition = (CHandle<questIBaseCondition>) CR2WTypeManager.Create("handle:questIBaseCondition", "condition", cr2w, this);
				}
				return _condition;
			}
			set
			{
				if (_condition == value)
				{
					return;
				}
				_condition = value;
				PropertySet(this);
			}
		}

		public gameDynamicEventNode(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
