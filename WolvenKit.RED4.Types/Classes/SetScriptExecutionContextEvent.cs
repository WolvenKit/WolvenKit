using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetScriptExecutionContextEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("scriptExecutionContext")] 
		public AIbehaviorScriptExecutionContext ScriptExecutionContext
		{
			get => GetPropertyValue<AIbehaviorScriptExecutionContext>();
			set => SetPropertyValue<AIbehaviorScriptExecutionContext>(value);
		}

		public SetScriptExecutionContextEvent()
		{
			ScriptExecutionContext = new();
		}
	}
}
