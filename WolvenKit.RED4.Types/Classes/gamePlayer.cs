using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePlayer : RedBaseClass
	{
		private netPeerID _peerID;
		private CString _nickname;

		[Ordinal(0)] 
		[RED("peerID")] 
		public netPeerID PeerID
		{
			get => GetProperty(ref _peerID);
			set => SetProperty(ref _peerID, value);
		}

		[Ordinal(1)] 
		[RED("nickname")] 
		public CString Nickname
		{
			get => GetProperty(ref _nickname);
			set => SetProperty(ref _nickname, value);
		}
	}
}
