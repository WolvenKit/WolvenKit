using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorSubtreeDefinition : AIbehaviorNestedTreeDefinition
	{
		private CHandle<AIbehaviorParameterizedBehavior> _tree;

		[Ordinal(2)] 
		[RED("tree")] 
		public CHandle<AIbehaviorParameterizedBehavior> Tree
		{
			get
			{
				if (_tree == null)
				{
					_tree = (CHandle<AIbehaviorParameterizedBehavior>) CR2WTypeManager.Create("handle:AIbehaviorParameterizedBehavior", "tree", cr2w, this);
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

		public AIbehaviorSubtreeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
