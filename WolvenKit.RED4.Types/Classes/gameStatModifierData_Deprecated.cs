using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameStatModifierData_Deprecated : IScriptable
	{
		private CEnum<gamedataStatType> _statType;
		private CEnum<gameStatModifierType> _modifierType;

		[Ordinal(0)] 
		[RED("statType")] 
		public CEnum<gamedataStatType> StatType
		{
			get => GetProperty(ref _statType);
			set => SetProperty(ref _statType, value);
		}

		[Ordinal(1)] 
		[RED("modifierType")] 
		public CEnum<gameStatModifierType> ModifierType
		{
			get => GetProperty(ref _modifierType);
			set => SetProperty(ref _modifierType, value);
		}
	}
}
