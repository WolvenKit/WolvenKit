using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class STvChannel : CVariable
	{
		private CString _channelName;
		private redResourceReferenceScriptToken _videoPath;
		private TweakDBID _messageRecordID;
		private CName _audioEvent;
		private CBool _looped;
		private CArray<SequenceVideo> _sequence;
		private TweakDBID _channelTweakID;

		[Ordinal(0)] 
		[RED("channelName")] 
		public CString ChannelName
		{
			get
			{
				if (_channelName == null)
				{
					_channelName = (CString) CR2WTypeManager.Create("String", "channelName", cr2w, this);
				}
				return _channelName;
			}
			set
			{
				if (_channelName == value)
				{
					return;
				}
				_channelName = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
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
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get
			{
				if (_audioEvent == null)
				{
					_audioEvent = (CName) CR2WTypeManager.Create("CName", "audioEvent", cr2w, this);
				}
				return _audioEvent;
			}
			set
			{
				if (_audioEvent == value)
				{
					return;
				}
				_audioEvent = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
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

		[Ordinal(5)] 
		[RED("sequence")] 
		public CArray<SequenceVideo> Sequence
		{
			get
			{
				if (_sequence == null)
				{
					_sequence = (CArray<SequenceVideo>) CR2WTypeManager.Create("array:SequenceVideo", "sequence", cr2w, this);
				}
				return _sequence;
			}
			set
			{
				if (_sequence == value)
				{
					return;
				}
				_sequence = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("channelTweakID")] 
		public TweakDBID ChannelTweakID
		{
			get
			{
				if (_channelTweakID == null)
				{
					_channelTweakID = (TweakDBID) CR2WTypeManager.Create("TweakDBID", "channelTweakID", cr2w, this);
				}
				return _channelTweakID;
			}
			set
			{
				if (_channelTweakID == value)
				{
					return;
				}
				_channelTweakID = value;
				PropertySet(this);
			}
		}

		public STvChannel(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
