using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterManagerParameters_SetLifePath : questICharacterManagerParameters_NodeSubType
	{
		private TweakDBID _lifePathID;

		[Ordinal(0)] 
		[RED("lifePathID")] 
		public TweakDBID LifePathID
		{
			get => GetProperty(ref _lifePathID);
			set => SetProperty(ref _lifePathID, value);
		}
	}
}
