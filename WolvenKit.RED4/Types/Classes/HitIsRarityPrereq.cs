using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HitIsRarityPrereq : GenericHitPrereq
	{
		[Ordinal(5)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("rarity")] 
		public CEnum<gamedataNPCRarity> Rarity
		{
			get => GetPropertyValue<CEnum<gamedataNPCRarity>>();
			set => SetPropertyValue<CEnum<gamedataNPCRarity>>(value);
		}

		public HitIsRarityPrereq()
		{
			IsSync = true;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
