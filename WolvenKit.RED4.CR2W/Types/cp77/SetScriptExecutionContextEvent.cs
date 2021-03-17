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
			get => GetProperty(ref _scriptExecutionContext);
			set => SetProperty(ref _scriptExecutionContext, value);
		}

		public SetScriptExecutionContextEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
