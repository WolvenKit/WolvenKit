using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerStatDetails : RedBaseClass
	{
		private CEnum<gamedataStatType> _statType;
		private CFloat _value;
		private CFloat _baseValue;

		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(1)] 
		[RED("value")] 
		public CFloat Value
		{
			get => GetProperty(ref _value);
			set => SetProperty(ref _value, value);
		}

		[Ordinal(2)] 
		[RED("baseValue")] 
		public CFloat BaseValue
		{
			get => GetProperty(ref _baseValue);
			set => SetProperty(ref _baseValue, value);
		}
	}
}
