using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TVSetup : CVariable
	{
		private CArray<STvChannel> _channels;
		private CInt32 _initialChannel;
		private TweakDBID _initialGlobalTvChannel;
		private CBool _muteInterface;
		private CBool _isInteractive;
		private CBool _isGlobalTvOnly;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("initialChannel")] 
		public CInt32 InitialChannel
		{
			get
			{
				if (_initialChannel == null)
				{
					_initialChannel = (CInt32) CR2WTypeManager.Create("Int32", "initialChannel", cr2w, this);
				}
				return _initialChannel;
			}
			set
			{
				if (_initialChannel == value)
				{
					return;
				}
				_initialChannel = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("initialGlobalTvChannel")] 
		public TweakDBID InitialGlobalTvChannel
		{
			get
			{
				if (_initialGlobalTvChannel == null)
				{
					_initialGlobalTvChannel = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "initialGlobalTvChannel", cr2w, this);
				}
				return _initialGlobalTvChannel;
			}
			set
			{
				if (_initialGlobalTvChannel == value)
				{
					return;
				}
				_initialGlobalTvChannel = value;
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

		[Ordinal(5)] 
		[RED("isGlobalTvOnly")] 
		public CBool IsGlobalTvOnly
		{
			get
			{
				if (_isGlobalTvOnly == null)
				{
					_isGlobalTvOnly = (CBool) CR2WTypeManager.Create("Bool", "isGlobalTvOnly", cr2w, this);
				}
				return _isGlobalTvOnly;
			}
			set
			{
				if (_isGlobalTvOnly == value)
				{
					return;
				}
				_isGlobalTvOnly = value;
				PropertySet(this);
			}
		}

		public TVSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
