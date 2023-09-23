using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
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
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
