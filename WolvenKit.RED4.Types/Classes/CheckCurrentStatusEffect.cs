using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CheckCurrentStatusEffect : AIStatusEffectCondition
	{
		private CEnum<gamedataStatusEffectType> _statusEffectTypeToCompare;
		private CName _statusEffectTagToCompare;

		[Ordinal(0)] 
		[RED("statusEffectTypeToCompare")] 
		public CEnum<gamedataStatusEffectType> StatusEffectTypeToCompare
		{
			get => GetProperty(ref _statusEffectTypeToCompare);
			set => SetProperty(ref _statusEffectTypeToCompare, value);
		}

		[Ordinal(1)] 
		[RED("statusEffectTagToCompare")] 
		public CName StatusEffectTagToCompare
		{
			get => GetProperty(ref _statusEffectTagToCompare);
			set => SetProperty(ref _statusEffectTagToCompare, value);
		}
	}
}
