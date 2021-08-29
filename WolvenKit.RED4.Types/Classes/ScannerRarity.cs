using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ScannerRarity : ScannerChunk
	{
		private CEnum<gamedataNPCRarity> _rarity;
		private CBool _isCivilian;

		[Ordinal(0)] 
		[RED("rarity")] 
		public CEnum<gamedataNPCRarity> Rarity
		{
			get => GetProperty(ref _rarity);
			set => SetProperty(ref _rarity, value);
		}

		[Ordinal(1)] 
		[RED("isCivilian")] 
		public CBool IsCivilian
		{
			get => GetProperty(ref _isCivilian);
			set => SetProperty(ref _isCivilian, value);
		}
	}
}
