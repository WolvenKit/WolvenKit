using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatModifierDetailedData : RedBaseClass
	{
		private CEnum<gamedataStatType> _statType;
		private CFloat _value;
		private CEnum<gameStatModifierType> _modifierType;

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
		[RED("modifierType")] 
		public CEnum<gameStatModifierType> ModifierType
		{
			get => GetProperty(ref _modifierType);
			set => SetProperty(ref _modifierType, value);
		}

		public gameStatModifierDetailedData()
		{
			_statType = new() { Value = Enums.gamedataStatType.Invalid };
		}
	}
}
