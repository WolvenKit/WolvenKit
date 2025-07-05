using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ToggleQuestPreventionTrigger : gameScriptableSystemRequest
	{
		[Ordinal(0)] 
		[RED("areaReference")] 
		public NodeRef AreaReference
		{
			get => GetPropertyValue<NodeRef>();
			set => SetPropertyValue<NodeRef>(value);
		}

		[Ordinal(1)] 
		[RED("enable")] 
		public CBool Enable
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ToggleQuestPreventionTrigger()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
