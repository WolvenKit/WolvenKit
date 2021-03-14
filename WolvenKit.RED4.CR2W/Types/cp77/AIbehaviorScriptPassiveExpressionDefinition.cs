using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorScriptPassiveExpressionDefinition : AIbehaviorPassiveExpressionDefinition
	{
		private CHandle<AIbehaviorexpressionScript> _script;

		[Ordinal(0)] 
		[RED("script")] 
		public CHandle<AIbehaviorexpressionScript> Script
		{
			get
			{
				if (_script == null)
				{
					_script = (CHandle<AIbehaviorexpressionScript>) CR2WTypeManager.Create("handle:AIbehaviorexpressionScript", "script", cr2w, this);
				}
				return _script;
			}
			set
			{
				if (_script == value)
				{
					return;
				}
				_script = value;
				PropertySet(this);
			}
		}

		public AIbehaviorScriptPassiveExpressionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
