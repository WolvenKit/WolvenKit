using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CombatGadgetQuickThrowEvents : CombatGadgetTransitions
	{
		[Ordinal(0)] 
		[RED("grenadeThrown")] 
		public CBool GrenadeThrown
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("event")] 
		public CBool Event
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CombatGadgetQuickThrowEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
