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
			get => GetProperty(ref _videoPath);
			set => SetProperty(ref _videoPath, value);
		}

		[Ordinal(1)] 
		[RED("channelID")] 
		public TweakDBID ChannelID
		{
			get => GetProperty(ref _channelID);
			set => SetProperty(ref _channelID, value);
		}

		[Ordinal(2)] 
		[RED("messageRecordID")] 
		public TweakDBID MessageRecordID
		{
			get => GetProperty(ref _messageRecordID);
			set => SetProperty(ref _messageRecordID, value);
		}

		[Ordinal(3)] 
		[RED("looped")] 
		public CBool Looped
		{
			get => GetProperty(ref _looped);
			set => SetProperty(ref _looped, value);
		}

		public TvDeviceWidgetCustomData(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
