using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gamePlayer : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("peerID")] 
		public netPeerID PeerID
		{
			get => GetPropertyValue<netPeerID>();
			set => SetPropertyValue<netPeerID>(value);
		}

		[Ordinal(1)] 
		[RED("nickname")] 
		public CString Nickname
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public gamePlayer()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
