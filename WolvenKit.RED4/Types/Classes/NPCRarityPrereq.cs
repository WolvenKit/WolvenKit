using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NPCRarityPrereq : gameIScriptablePrereq
	{
		[Ordinal(0)] 
		[RED("rarity")] 
		public CEnum<gamedataNPCRarity> Rarity
		{
			get => GetPropertyValue<CEnum<gamedataNPCRarity>>();
			set => SetPropertyValue<CEnum<gamedataNPCRarity>>(value);
		}

		[Ordinal(1)] 
		[RED("invert")] 
		public CBool Invert
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NPCRarityPrereq()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
