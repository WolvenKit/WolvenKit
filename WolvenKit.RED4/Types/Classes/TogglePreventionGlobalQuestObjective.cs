using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TogglePreventionGlobalQuestObjective : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("preventionGlobalQuestDisabled")] 
		public CBool PreventionGlobalQuestDisabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("eventSource")] 
		public CName EventSource
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public TogglePreventionGlobalQuestObjective()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
