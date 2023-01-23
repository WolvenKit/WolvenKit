using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ScannerRarity : ScannerChunk
	{
		[Ordinal(0)] 
		[RED("rarity")] 
		public CEnum<gamedataNPCRarity> Rarity
		{
			get => GetPropertyValue<CEnum<gamedataNPCRarity>>();
			set => SetPropertyValue<CEnum<gamedataNPCRarity>>(value);
		}

		[Ordinal(1)] 
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ScannerRarity()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
