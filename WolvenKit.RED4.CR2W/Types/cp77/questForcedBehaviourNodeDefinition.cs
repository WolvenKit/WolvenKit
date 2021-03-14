using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questForcedBehaviourNodeDefinition : questSignalStoppingNodeDefinition
	{
		private gameEntityReference _puppet;
		private CHandle<questForcedBehaviorReference> _tree;
		private CHandle<AIbehaviorParameterizedBehavior> _behavior;

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
		[RED("tree")] 
		public CHandle<questForcedBehaviorReference> Tree
		{
			get
			{
				if (_tree == null)
				{
					_tree = (CHandle<questForcedBehaviorReference>) CR2WTypeManager.Create("handle:questForcedBehaviorReference", "tree", cr2w, this);
				}
				return _tree;
			}
			set
			{
				if (_tree == value)
				{
					return;
				}
				_tree = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("behavior")] 
		public CHandle<AIbehaviorParameterizedBehavior> Behavior
		{
			get
			{
				if (_behavior == null)
				{
					_behavior = (CHandle<AIbehaviorParameterizedBehavior>) CR2WTypeManager.Create("handle:AIbehaviorParameterizedBehavior", "behavior", cr2w, this);
				}
				return _behavior;
			}
			set
			{
				if (_behavior == value)
				{
					return;
				}
				_behavior = value;
				PropertySet(this);
			}
		}

		public questForcedBehaviourNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
