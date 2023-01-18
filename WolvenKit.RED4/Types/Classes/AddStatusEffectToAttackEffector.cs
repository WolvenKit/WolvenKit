using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AddStatusEffectToAttackEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("isRandom")] 
		public CBool IsRandom
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("applicationChance")] 
		public CFloat ApplicationChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("statusEffect")] 
		public SHitStatusEffect StatusEffect
		{
			get => GetPropertyValue<SHitStatusEffect>();
			set => SetPropertyValue<SHitStatusEffect>(value);
		}

		[Ordinal(3)] 
		[RED("stacks")] 
		public CFloat Stacks
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public AddStatusEffectToAttackEffector()
		{
			StatusEffect = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
