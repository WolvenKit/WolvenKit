using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIbehaviorStackScriptTaskDefinition : AIbehaviorTaskDefinition
	{
		private CHandle<AIbehaviortaskStackScript> _script;

		[Ordinal(1)] 
		[RED("script")] 
		public CHandle<AIbehaviortaskStackScript> Script
		{
			get
			{
				if (_script == null)
				{
					_script = (CHandle<AIbehaviortaskStackScript>) CR2WTypeManager.Create("handle:AIbehaviortaskStackScript", "script", cr2w, this);
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

		public AIbehaviorStackScriptTaskDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
