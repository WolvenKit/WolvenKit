using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questSetLifePathRequest : gamePlayerScriptableSystemRequest
	{
		private TweakDBID _lifePathID;

		[Ordinal(1)] 
		[RED("lifePathID")] 
		public TweakDBID LifePathID
		{
			get => GetProperty(ref _lifePathID);
			set => SetProperty(ref _lifePathID, value);
		}
	}
}
