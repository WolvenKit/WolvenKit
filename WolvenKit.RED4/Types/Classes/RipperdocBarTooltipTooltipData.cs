using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class RipperdocBarTooltipTooltipData : ATooltipData
	{
		[Ordinal(0)] 
		[RED("barType")] 
		public CEnum<BarType> BarType
		{
			get => GetPropertyValue<CEnum<BarType>>();
			set => SetPropertyValue<CEnum<BarType>>(value);
		}

		[Ordinal(1)] 
		[RED("totalValue")] 
		public CInt32 TotalValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("maxValue")] 
		public CInt32 MaxValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(3)] 
		[RED("maxDamageReduction")] 
		public CFloat MaxDamageReduction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("capacityPerk1Bought")] 
		public CBool CapacityPerk1Bought
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("capacityPerk2Bought")] 
		public CBool CapacityPerk2Bought
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("armorPerk1Bought")] 
		public CBool ArmorPerk1Bought
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("statsData")] 
		public CArray<gameStatViewData> StatsData
		{
			get => GetPropertyValue<CArray<gameStatViewData>>();
			set => SetPropertyValue<CArray<gameStatViewData>>(value);
		}

		[Ordinal(8)] 
		[RED("statValue")] 
		public CInt32 StatValue
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(9)] 
		[RED("health")] 
		public CFloat Health
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public RipperdocBarTooltipTooltipData()
		{
			StatsData = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
