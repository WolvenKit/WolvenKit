using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePlayer : CVariable
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

		public gamePlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
