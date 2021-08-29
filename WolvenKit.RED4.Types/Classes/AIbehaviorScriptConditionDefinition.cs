using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class AIbehaviorScriptConditionDefinition : AIbehaviorConditionDefinition
	{
		private CHandle<AIbehaviorconditionScript> _script;
		private CBool _disableLazyInitialization;

		[Ordinal(1)] 
		[RED("script")] 
		public CHandle<AIbehaviorconditionScript> Script
		{
			get => GetProperty(ref _script);
			set => SetProperty(ref _script, value);
		}

		[Ordinal(2)] 
		[RED("disableLazyInitialization")] 
		public CBool DisableLazyInitialization
		{
			get => GetProperty(ref _disableLazyInitialization);
			set => SetProperty(ref _disableLazyInitialization, value);
		}
	}
}
