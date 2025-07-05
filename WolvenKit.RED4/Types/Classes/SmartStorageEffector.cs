using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SmartStorageEffector : ModifyAttackEffector
	{
		[Ordinal(0)] 
		[RED("baseRevengeChance")] 
		public CFloat BaseRevengeChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("revengeChanceStep")] 
		public CFloat RevengeChanceStep
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("revealDuration")] 
		public CFloat RevealDuration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("statusEffectForTarget")] 
		public TweakDBID StatusEffectForTarget
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(4)] 
		[RED("statusEffectForSelf")] 
		public TweakDBID StatusEffectForSelf
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(5)] 
		[RED("currentChance")] 
		public CFloat CurrentChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public SmartStorageEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
