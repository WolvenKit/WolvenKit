using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TriggerAttackByChanceEffector : gameEffector
	{
		[Ordinal(0)] 
		[RED("attackTDBID")] 
		public TweakDBID AttackTDBID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("selfStatusEffectID")] 
		public TweakDBID SelfStatusEffectID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("chance")] 
		public CFloat Chance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(4)] 
		[RED("ownerID")] 
		public entEntityID OwnerID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		[Ordinal(5)] 
		[RED("statListener")] 
		public CHandle<TriggerAttackByChanceStatListener> StatListener
		{
			get => GetPropertyValue<CHandle<TriggerAttackByChanceStatListener>>();
			set => SetPropertyValue<CHandle<TriggerAttackByChanceStatListener>>(value);
		}

		[Ordinal(6)] 
		[RED("statBasedChance")] 
		public CFloat StatBasedChance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public TriggerAttackByChanceEffector()
		{
			StatType = Enums.gamedataStatType.Invalid;
			OwnerID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
