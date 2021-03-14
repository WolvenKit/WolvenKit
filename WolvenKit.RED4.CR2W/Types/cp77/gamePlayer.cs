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
			get
			{
				if (_peerID == null)
				{
					_peerID = (netPeerID) CR2WTypeManager.Create("netPeerID", "peerID", cr2w, this);
				}
				return _peerID;
			}
			set
			{
				if (_peerID == value)
				{
					return;
				}
				_peerID = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("nickname")] 
		public CString Nickname
		{
			get
			{
				if (_nickname == null)
				{
					_nickname = (CString) CR2WTypeManager.Create("String", "nickname", cr2w, this);
				}
				return _nickname;
			}
			set
			{
				if (_nickname == value)
				{
					return;
				}
				_nickname = value;
				PropertySet(this);
			}
		}

		public gamePlayer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
