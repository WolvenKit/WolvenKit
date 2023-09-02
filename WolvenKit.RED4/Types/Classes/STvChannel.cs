using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class STvChannel : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("channelName")] 
		public CString ChannelName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(1)] 
		[RED("videoPath")] 
		public redResourceReferenceScriptToken VideoPath
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		[Ordinal(2)] 
		[RED("messageRecordID")] 
		public TweakDBID MessageRecordID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(3)] 
		[RED("audioEvent")] 
		public CName AudioEvent
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("looped")] 
		public CBool Looped
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("sequence")] 
		public CArray<SequenceVideo> Sequence
		{
			get => GetPropertyValue<CArray<SequenceVideo>>();
			set => SetPropertyValue<CArray<SequenceVideo>>(value);
		}

		[Ordinal(6)] 
		[RED("channelTweakID")] 
		public TweakDBID ChannelTweakID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		public STvChannel()
		{
			ChannelName = "1";
			VideoPath = new redResourceReferenceScriptToken();
			Looped = true;
			Sequence = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
