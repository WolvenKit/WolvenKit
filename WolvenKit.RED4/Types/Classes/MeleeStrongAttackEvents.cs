using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MeleeStrongAttackEvents : MeleeAttackGenericEvents
	{
		[Ordinal(14)] 
		[RED("slowMoSet")] 
		public CBool SlowMoSet
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(15)] 
		[RED("crouchedAfterLeapAttack")] 
		public CBool CrouchedAfterLeapAttack
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public MeleeStrongAttackEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
