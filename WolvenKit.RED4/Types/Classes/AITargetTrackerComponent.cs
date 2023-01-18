using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AITargetTrackerComponent : gameComponent
	{
		[Ordinal(4)] 
		[RED("TriggersCombat")] 
		public CBool TriggersCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AITargetTrackerComponent()
		{
			Name = "TargetTracker";
			TriggersCombat = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
