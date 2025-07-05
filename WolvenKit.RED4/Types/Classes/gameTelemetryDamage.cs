using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameTelemetryDamage : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("attackType")] 
		public CEnum<gamedataAttackType> AttackType
		{
			get => GetPropertyValue<CEnum<gamedataAttackType>>();
			set => SetPropertyValue<CEnum<gamedataAttackType>>(value);
		}

		[Ordinal(1)] 
		[RED("attackRecord")] 
		public TweakDBID AttackRecord
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(2)] 
		[RED("damageAmount")] 
		public CFloat DamageAmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("weapon")] 
		public gameTelemetryInventoryItem Weapon
		{
			get => GetPropertyValue<gameTelemetryInventoryItem>();
			set => SetPropertyValue<gameTelemetryInventoryItem>(value);
		}

		[Ordinal(4)] 
		[RED("sourceEntity")] 
		public gameTelemetrySourceEntity SourceEntity
		{
			get => GetPropertyValue<gameTelemetrySourceEntity>();
			set => SetPropertyValue<gameTelemetrySourceEntity>(value);
		}

		[Ordinal(5)] 
		[RED("hitCount")] 
		public CUInt32 HitCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(6)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameTelemetryDamage()
		{
			AttackType = Enums.gamedataAttackType.Invalid;
			Weapon = new gameTelemetryInventoryItem { ItemID = new gameItemID(), Quality = Enums.gamedataQuality.Invalid, ItemType = Enums.gamedataItemType.Invalid, ItemLevel = -1 };
			SourceEntity = new gameTelemetrySourceEntity();
			HitCount = 1;
			Distance = -1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
