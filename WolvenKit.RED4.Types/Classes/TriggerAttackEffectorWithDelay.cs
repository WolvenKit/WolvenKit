using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TriggerAttackEffectorWithDelay : redEvent
	{
		[Ordinal(0)] 
		[RED("attack")] 
		public CHandle<gameAttack_GameEffect> Attack
		{
			get => GetPropertyValue<CHandle<gameAttack_GameEffect>>();
			set => SetPropertyValue<CHandle<gameAttack_GameEffect>>(value);
		}

		public TriggerAttackEffectorWithDelay()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
