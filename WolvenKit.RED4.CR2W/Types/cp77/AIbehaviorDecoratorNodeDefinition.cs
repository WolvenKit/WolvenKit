using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorDecoratorNodeDefinition : AIbehaviorTreeNodeDefinition
	{
		private CHandle<AIbehaviorTreeNodeDefinition> _child;

		[Ordinal(0)] 
		[RED("child")] 
		public CHandle<AIbehaviorTreeNodeDefinition> Child
		{
			get
			{
				if (_child == null)
				{
					_child = (CHandle<AIbehaviorTreeNodeDefinition>) CR2WTypeManager.Create("handle:AIbehaviorTreeNodeDefinition", "child", cr2w, this);
				}
				return _child;
			}
			set
			{
				if (_child == value)
				{
					return;
				}
				_child = value;
				PropertySet(this);
			}
		}

		public AIbehaviorDecoratorNodeDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
