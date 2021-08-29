using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetNPCRarityHitPrereqCondition : BaseHitPrereqCondition
	{
		private CEnum<gamedataNPCRarity> _rarity;

		[Ordinal(1)] 
		[RED("rarity")] 
		public CEnum<gamedataNPCRarity> Rarity
		{
			get => GetProperty(ref _rarity);
			set => SetProperty(ref _rarity, value);
		}
	}
}
