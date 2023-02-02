using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class UIInventoryItemGrenadeData : IScriptable
	{
		[Ordinal(0)] 
		[RED("Type")] 
		public CEnum<GrenadeDamageType> Type
		{
			get => GetPropertyValue<CEnum<GrenadeDamageType>>();
			set => SetPropertyValue<CEnum<GrenadeDamageType>>(value);
		}

		[Ordinal(1)] 
		[RED("Range")] 
		public CFloat Range
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("DeliveryMethod")] 
		public CEnum<gamedataGrenadeDeliveryMethodType> DeliveryMethod
		{
			get => GetPropertyValue<CEnum<gamedataGrenadeDeliveryMethodType>>();
			set => SetPropertyValue<CEnum<gamedataGrenadeDeliveryMethodType>>(value);
		}

		[Ordinal(3)] 
		[RED("Duration")] 
		public CFloat Duration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("Delay")] 
		public CFloat Delay
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(5)] 
		[RED("DetonationTimer")] 
		public CFloat DetonationTimer
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(6)] 
		[RED("DamagePerTick")] 
		public CFloat DamagePerTick
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("DamageType")] 
		public CEnum<gamedataStatType> DamageType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(8)] 
		[RED("TotalDamage")] 
		public CFloat TotalDamage
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public UIInventoryItemGrenadeData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
