using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorDebugFailsafeConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIArgumentMapping> _logMessage;

		[Ordinal(1)] 
		[RED("logMessage")] 
		public CHandle<AIArgumentMapping> LogMessage
		{
			get => GetProperty(ref _logMessage);
			set => SetProperty(ref _logMessage, value);
		}
	}
}
