using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
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
		[RED("damageAmount")] 
		public CFloat DamageAmount
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("weapon")] 
		public gameTelemetryInventoryItem Weapon
		{
			get => GetPropertyValue<gameTelemetryInventoryItem>();
			set => SetPropertyValue<gameTelemetryInventoryItem>(value);
		}

		[Ordinal(3)] 
		[RED("hitCount")] 
		public CUInt32 HitCount
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(4)] 
		[RED("distance")] 
		public CFloat Distance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("time")] 
		public CFloat Time
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public gameTelemetryDamage()
		{
			AttackType = Enums.gamedataAttackType.Invalid;
			Weapon = new() { ItemID = new(), Quality = -1, ItemType = Enums.gamedataItemType.Invalid, ItemLevel = -1 };
			HitCount = 1;
			Distance = -1.000000F;
		}
	}
}
