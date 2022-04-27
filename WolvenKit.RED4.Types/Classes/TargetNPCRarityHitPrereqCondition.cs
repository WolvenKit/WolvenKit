using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TargetNPCRarityHitPrereqCondition : BaseHitPrereqCondition
	{
		[Ordinal(3)] 
		[RED("rarity")] 
		public CEnum<gamedataNPCRarity> Rarity
		{
			get => GetPropertyValue<CEnum<gamedataNPCRarity>>();
			set => SetPropertyValue<CEnum<gamedataNPCRarity>>(value);
		}

		public TargetNPCRarityHitPrereqCondition()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
