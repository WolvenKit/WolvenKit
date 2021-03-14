using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorUnaryConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIbehaviorConditionDefinition> _child;

		[Ordinal(1)] 
		[RED("child")] 
		public CHandle<AIbehaviorConditionDefinition> Child
		{
			get
			{
				if (_child == null)
				{
					_child = (CHandle<AIbehaviorConditionDefinition>) CR2WTypeManager.Create("handle:AIbehaviorConditionDefinition", "child", cr2w, this);
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

		public AIbehaviorUnaryConditionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
