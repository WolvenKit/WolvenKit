using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeEquippingDecisions : MeleeIdleDecisions
	{
		[Ordinal(2)] 
		[RED("hasEquipAttack")] 
		public CBool HasEquipAttack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MeleeEquippingDecisions()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
