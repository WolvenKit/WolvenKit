using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class TvDeviceWidgetCustomData : WidgetCustomData
	{
		private redResourceReferenceScriptToken _videoPath;
		private TweakDBID _channelID;
		private TweakDBID _messageRecordID;
		private CBool _looped;

		[Ordinal(0)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get
			{
				if (_videoPath == null)
				{
					_videoPath = (redResourceReferenceScriptToken) CR2WTypeManager.Create("redResourceReferenceScriptToken", "videoPath", cr2w, this);
				}
				return _videoPath;
			}
			set
			{
				if (_videoPath == value)
				{
					return;
				}
				_videoPath = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("channelID")] 
		public TweakDBID ChannelID
		{
			get
			{
				if (_channelID == null)
				{
					_channelID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "channelID", cr2w, this);
				}
				return _channelID;
			}
			set
			{
				if (_channelID == value)
				{
					return;
				}
				_channelID = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("messageRecordID")] 
		public TweakDBID MessageRecordID
		{
			get
			{
				if (_messageRecordID == null)
				{
					_messageRecordID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "messageRecordID", cr2w, this);
				}
				return _messageRecordID;
			}
			set
			{
				if (_messageRecordID == value)
				{
					return;
				}
				_messageRecordID = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("looped")] 
		public CBool Looped
		{
			get
			{
				if (_looped == null)
				{
					_looped = (CBool) CR2WTypeManager.Create("Bool", "looped", cr2w, this);
				}
				return _looped;
			}
			set
			{
				if (_looped == value)
				{
					return;
				}
				_looped = value;
				PropertySet(this);
			}
		}

		public TvDeviceWidgetCustomData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
