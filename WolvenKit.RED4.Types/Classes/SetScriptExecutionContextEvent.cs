using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class SetScriptExecutionContextEvent : redEvent
	{
		private AIbehaviorScriptExecutionContext _scriptExecutionContext;

		[Ordinal(0)] 
		[RED("scriptExecutionContext")] 
		public AIbehaviorScriptExecutionContext ScriptExecutionContext
		{
			get => GetProperty(ref _scriptExecutionContext);
			set => SetProperty(ref _scriptExecutionContext, value);
		}
	}
}
