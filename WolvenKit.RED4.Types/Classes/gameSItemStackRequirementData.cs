using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameSItemStackRequirementData : RedBaseClass
	{
		private CEnum<gamedataStatType> _statType;
		private CFloat _requiredValue;

		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(1)] 
		[RED("requiredValue")] 
		public CFloat RequiredValue
		{
			get => GetProperty(ref _requiredValue);
			set => SetProperty(ref _requiredValue, value);
		}

		public gameSItemStackRequirementData()
		{
			_statType = new() { Value = Enums.gamedataStatType.Invalid };
		}
	}
}
