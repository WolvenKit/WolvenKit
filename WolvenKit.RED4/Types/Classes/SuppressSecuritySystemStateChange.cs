using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SuppressSecuritySystemStateChange : redEvent
	{
		[Ordinal(0)] 
		[RED("forceSecuritySystemIntoStrictQuestControl")] 
		public CBool ForceSecuritySystemIntoStrictQuestControl
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public SuppressSecuritySystemStateChange()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
