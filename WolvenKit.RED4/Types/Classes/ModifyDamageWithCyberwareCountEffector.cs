using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ModifyDamageWithCyberwareCountEffector : ModifyDamageEffector
	{
		[Ordinal(6)] 
		[RED("minPlayerHealthPercentage")] 
		public CFloat MinPlayerHealthPercentage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("playerIncomingDamageMultiplier")] 
		public CFloat PlayerIncomingDamageMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("playerMaxIncomingDamage")] 
		public CFloat PlayerMaxIncomingDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("damageBuffAmount")] 
		public CFloat DamageBuffAmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("damageBuffRarity")] 
		public CFloat DamageBuffRarity
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(11)] 
		[RED("playVFXOnHitTargets")] 
		public CName PlayVFXOnHitTargets
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("statusEffectRecord")] 
		public CWeakHandle<gamedataStatusEffect_Record> StatusEffectRecord
		{
			get => GetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>();
			set => SetPropertyValue<CWeakHandle<gamedataStatusEffect_Record>>(value);
		}

		public ModifyDamageWithCyberwareCountEffector()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
