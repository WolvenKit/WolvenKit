using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TV : InteractiveDevice
	{
		private CArray<STvChannel> _channels;
		private CInt32 _initialActiveChannel;
		private CString _securedText;
		private CBool _isInteractive;
		private CBool _muteInterface;
		private CBool _useWhiteNoiseFX;
		private CBool _isShortGlitchActive;
		private gameDelayID _shortGlitchDelayID;
		private CBool _isTVMoving;

		[Ordinal(93)] 
		[RED("channels")] 
		public CArray<STvChannel> Channels
		{
			get
			{
				if (_channels == null)
				{
					_channels = (CArray<STvChannel>) CR2WTypeManager.Create("array:STvChannel", "channels", cr2w, this);
				}
				return _channels;
			}
			set
			{
				if (_channels == value)
				{
					return;
				}
				_channels = value;
				PropertySet(this);
			}
		}

		[Ordinal(94)] 
		[RED("initialActiveChannel")] 
		public CInt32 InitialActiveChannel
		{
			get
			{
				if (_initialActiveChannel == null)
				{
					_initialActiveChannel = (CInt32) CR2WTypeManager.Create("Int32", "initialActiveChannel", cr2w, this);
				}
				return _initialActiveChannel;
			}
			set
			{
				if (_initialActiveChannel == value)
				{
					return;
				}
				_initialActiveChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(95)] 
		[RED("securedText")] 
		public CString SecuredText
		{
			get
			{
				if (_securedText == null)
				{
					_securedText = (CString) CR2WTypeManager.Create("String", "securedText", cr2w, this);
				}
				return _securedText;
			}
			set
			{
				if (_securedText == value)
				{
					return;
				}
				_securedText = value;
				PropertySet(this);
			}
		}

		[Ordinal(96)] 
		[RED("isInteractive")] 
		public CBool IsInteractive
		{
			get
			{
				if (_isInteractive == null)
				{
					_isInteractive = (CBool) CR2WTypeManager.Create("Bool", "isInteractive", cr2w, this);
				}
				return _isInteractive;
			}
			set
			{
				if (_isInteractive == value)
				{
					return;
				}
				_isInteractive = value;
				PropertySet(this);
			}
		}

		[Ordinal(97)] 
		[RED("muteInterface")] 
		public CBool MuteInterface
		{
			get
			{
				if (_muteInterface == null)
				{
					_muteInterface = (CBool) CR2WTypeManager.Create("Bool", "muteInterface", cr2w, this);
				}
				return _muteInterface;
			}
			set
			{
				if (_muteInterface == value)
				{
					return;
				}
				_muteInterface = value;
				PropertySet(this);
			}
		}

		[Ordinal(98)] 
		[RED("useWhiteNoiseFX")] 
		public CBool UseWhiteNoiseFX
		{
			get
			{
				if (_useWhiteNoiseFX == null)
				{
					_useWhiteNoiseFX = (CBool) CR2WTypeManager.Create("Bool", "useWhiteNoiseFX", cr2w, this);
				}
				return _useWhiteNoiseFX;
			}
			set
			{
				if (_useWhiteNoiseFX == value)
				{
					return;
				}
				_useWhiteNoiseFX = value;
				PropertySet(this);
			}
		}

		[Ordinal(99)] 
		[RED("isShortGlitchActive")] 
		public CBool IsShortGlitchActive
		{
			get
			{
				if (_isShortGlitchActive == null)
				{
					_isShortGlitchActive = (CBool) CR2WTypeManager.Create("Bool", "isShortGlitchActive", cr2w, this);
				}
				return _isShortGlitchActive;
			}
			set
			{
				if (_isShortGlitchActive == value)
				{
					return;
				}
				_isShortGlitchActive = value;
				PropertySet(this);
			}
		}

		[Ordinal(100)] 
		[RED("shortGlitchDelayID")] 
		public gameDelayID ShortGlitchDelayID
		{
			get
			{
				if (_shortGlitchDelayID == null)
				{
					_shortGlitchDelayID = (gameDelayID) CR2WTypeManager.Create("gameDelayID", "shortGlitchDelayID", cr2w, this);
				}
				return _shortGlitchDelayID;
			}
			set
			{
				if (_shortGlitchDelayID == value)
				{
					return;
				}
				_shortGlitchDelayID = value;
				PropertySet(this);
			}
		}

		[Ordinal(101)] 
		[RED("isTVMoving")] 
		public CBool IsTVMoving
		{
			get
			{
				if (_isTVMoving == null)
				{
					_isTVMoving = (CBool) CR2WTypeManager.Create("Bool", "isTVMoving", cr2w, this);
				}
				return _isTVMoving;
			}
			set
			{
				if (_isTVMoving == value)
				{
					return;
				}
				_isTVMoving = value;
				PropertySet(this);
			}
		}

		public TV(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
