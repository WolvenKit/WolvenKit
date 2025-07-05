using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryTooltiData_GrenadeData : IScriptable
	{
		[Ordinal(0)] 
		[RED("type")] 
		public CEnum<GrenadeDamageType> Type
		{
			get => GetPropertyValue<CEnum<GrenadeDamageType>>();
			set => SetPropertyValue<CEnum<GrenadeDamageType>>(value);
		}

		[Ordinal(1)] 
		[RED("range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(3)] 
		[RED("delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("damagePerTick")] 
		public CFloat DamagePerTick
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("damageType")] 
		public CEnum<gamedataStatType> DamageType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(6)] 
		[RED("detonationTimer")] 
		public CFloat DetonationTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("deliveryMethod")] 
		public CEnum<gamedataGrenadeDeliveryMethodType> DeliveryMethod
		{
			get => GetPropertyValue<CEnum<gamedataGrenadeDeliveryMethodType>>();
			set => SetPropertyValue<CEnum<gamedataGrenadeDeliveryMethodType>>(value);
		}

		[Ordinal(8)] 
		[RED("totalDamage")] 
		public CFloat TotalDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("grenadeType")] 
		public CEnum<EGrenadeType> GrenadeType
		{
			get => GetPropertyValue<CEnum<EGrenadeType>>();
			set => SetPropertyValue<CEnum<EGrenadeType>>(value);
		}

		public InventoryTooltiData_GrenadeData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
