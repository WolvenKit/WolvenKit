using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EvaluateGameplayRoleEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("force")] 
		public CBool Force
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public EvaluateGameplayRoleEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
