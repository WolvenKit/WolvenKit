using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class STvChannel : RedBaseClass
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
			get => GetProperty(ref _channelName);
			set => SetProperty(ref _channelName, value);
		}

		[Ordinal(1)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get => GetProperty(ref _videoPath);
			set => SetProperty(ref _videoPath, value);
		}

		[Ordinal(2)] 
		[RED("messageRecordID")] 
		public TweakDBID MessageRecordID
		{
			get => GetProperty(ref _messageRecordID);
			set => SetProperty(ref _messageRecordID, value);
		}

		[Ordinal(3)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetProperty(ref _audioEvent);
			set => SetProperty(ref _audioEvent, value);
		}

		[Ordinal(4)] 
		[RED("looped")] 
		public CBool Looped
		{
			get => GetProperty(ref _looped);
			set => SetProperty(ref _looped, value);
		}

		[Ordinal(5)] 
		[RED("sequence")] 
		public CArray<SequenceVideo> Sequence
		{
			get => GetProperty(ref _sequence);
			set => SetProperty(ref _sequence, value);
		}

		[Ordinal(6)] 
		[RED("channelTweakID")] 
		public TweakDBID ChannelTweakID
		{
			get => GetProperty(ref _channelTweakID);
			set => SetProperty(ref _channelTweakID, value);
		}

		public STvChannel()
		{
			_channelName = new() { Text = "1" };
			_looped = true;
		}
	}
}
