using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GlamdocFactData : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("spendCostThreshold")] 
		public CInt32 SpendCostThreshold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(1)] 
		[RED("spendCountThreshold")] 
		public CInt32 SpendCountThreshold
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(2)] 
		[RED("factName")] 
		public CName FactName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public GlamdocFactData()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
