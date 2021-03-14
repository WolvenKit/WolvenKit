using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SetScriptExecutionContextEvent : redEvent
	{
		private AIbehaviorScriptExecutionContext _scriptExecutionContext;

		[Ordinal(0)] 
		[RED("scriptExecutionContext")] 
		public AIbehaviorScriptExecutionContext ScriptExecutionContext
		{
			get
			{
				if (_scriptExecutionContext == null)
				{
					_scriptExecutionContext = (AIbehaviorScriptExecutionContext) CR2WTypeManager.Create("AIbehaviorScriptExecutionContext", "scriptExecutionContext", cr2w, this);
				}
				return _scriptExecutionContext;
			}
			set
			{
				if (_scriptExecutionContext == value)
				{
					return;
				}
				_scriptExecutionContext = value;
				PropertySet(this);
			}
		}

		public SetScriptExecutionContextEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
