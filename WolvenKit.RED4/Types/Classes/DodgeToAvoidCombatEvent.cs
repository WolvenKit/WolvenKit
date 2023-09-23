using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DodgeToAvoidCombatEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("delayID")] 
		public gameDelayID DelayID
		{
			get => GetPropertyValue<gameDelayID>();
			set => SetPropertyValue<gameDelayID>(value);
		}

		[Ordinal(1)] 
		[RED("npcID")] 
		public entEntityID NpcID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public DodgeToAvoidCombatEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
