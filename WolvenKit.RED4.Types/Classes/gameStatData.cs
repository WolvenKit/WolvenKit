using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatData : RedBaseClass
	{
		private CArray<gameStatModifierHandle> _modifiers;
		private CEnum<gamedataStatType> _statType;

		[Ordinal(0)] 
		[RED("modifiers")] 
		public CArray<gameStatModifierHandle> Modifiers
		{
			get => GetProperty(ref _modifiers);
			set => SetProperty(ref _modifiers, value);
		}

		[Ordinal(1)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}
	}
}
