using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class InventoryTooltipData_StatData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("statName")] 
		public CString StatName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(2)] 
		[RED("minStatValue")] 
		public CInt32 MinStatValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("maxStatValue")] 
		public CInt32 MaxStatValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(4)] 
		[RED("currentValue")] 
		public CInt32 CurrentValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(5)] 
		[RED("diffValue")] 
		public CInt32 DiffValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(6)] 
		[RED("minStatValueF")] 
		public CFloat MinStatValueF
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(7)] 
		[RED("maxStatValueF")] 
		public CFloat MaxStatValueF
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("currentValueF")] 
		public CFloat CurrentValueF
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(9)] 
		[RED("diffValueF")] 
		public CFloat DiffValueF
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(10)] 
		[RED("state")] 
		public CEnum<EInventoryDataStatDisplayType> State
		{
			get => GetPropertyValue<CEnum<EInventoryDataStatDisplayType>>();
			set => SetPropertyValue<CEnum<EInventoryDataStatDisplayType>>(value);
		}

		public InventoryTooltipData_StatData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
