using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIRemovedAsHostileThreat : AIAIEvent
	{
		[Ordinal(2)] 
		[RED("threateningEntity")] 
		public CWeakHandle<AITargetTrackerComponent> ThreateningEntity
		{
			get => GetPropertyValue<CWeakHandle<AITargetTrackerComponent>>();
			set => SetPropertyValue<CWeakHandle<AITargetTrackerComponent>>(value);
		}

		[Ordinal(3)] 
		[RED("threateningEntityCanTriggersCombat")] 
		public CBool ThreateningEntityCanTriggersCombat
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public AIRemovedAsHostileThreat()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
