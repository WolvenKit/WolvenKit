using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerStatDetails : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetPropertyValue<CEnum<gamedataStatType>>();
			set => SetPropertyValue<CEnum<gamedataStatType>>(value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(2)] 
		[RED("baseValue")] 
		public CFloat BaseValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public ScannerStatDetails()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
