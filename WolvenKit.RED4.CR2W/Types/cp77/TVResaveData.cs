using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TVResaveData : CVariable
	{
		private MediaResaveData _mediaResaveData;
		private CArray<STvChannel> _channels;
		private CName _securedText;
		private CBool _muteInterface;
		private CBool _useWhiteNoiseFX;

		[Ordinal(0)] 
		[RED("mediaResaveData")] 
		public MediaResaveData MediaResaveData
		{
			get
			{
				if (_mediaResaveData == null)
				{
					_mediaResaveData = (MediaResaveData) CR2WTypeManager.Create("MediaResaveData", "mediaResaveData", cr2w, this);
				}
				return _mediaResaveData;
			}
			set
			{
				if (_mediaResaveData == value)
				{
					return;
				}
				_mediaResaveData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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

		[Ordinal(2)] 
		[RED("securedText")] 
		public CName SecuredText
		{
			get
			{
				if (_securedText == null)
				{
					_securedText = (CName) CR2WTypeManager.Create("CName", "securedText", cr2w, this);
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

		[Ordinal(3)] 
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

		[Ordinal(4)] 
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

		public TVResaveData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
