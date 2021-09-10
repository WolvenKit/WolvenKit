using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TargetNPCRarityHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(1)] 
		[RED("rarity")] 
		public CEnum<gamedataNPCRarity> Rarity
		{
			get => GetPropertyValue<CEnum<gamedataNPCRarity>>();
			set => SetPropertyValue<CEnum<gamedataNPCRarity>>(value);
		}
	}
}
