using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TriggerDelayedReactionEvent : DelayedCrowdReactionEvent
	{
		[Ordinal(2)] 
		[RED("initAnim")] 
		public CBool InitAnim
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("behavior")] 
		public CEnum<gamedataOutput> Behavior
		{
			get => GetPropertyValue<CEnum<gamedataOutput>>();
			set => SetPropertyValue<CEnum<gamedataOutput>>(value);
		}

		public TriggerDelayedReactionEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
