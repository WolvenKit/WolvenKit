using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class TutorialPopupData : inkGameNotificationData
	{
		[Ordinal(7)] 
		[RED("closeAtInput")] 
		public CBool CloseAtInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("pauseGame")] 
		public CBool PauseGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isModal")] 
		public CBool IsModal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("position")] 
		public CEnum<gamePopupPosition> Position
		{
			get => GetPropertyValue<CEnum<gamePopupPosition>>();
			set => SetPropertyValue<CEnum<gamePopupPosition>>(value);
		}

		[Ordinal(11)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(12)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(13)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(14)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(15)] 
		[RED("messageOverrideDataList")] 
		public CArray<CHandle<gameJournalEntryOverrideData>> MessageOverrideDataList
		{
			get => GetPropertyValue<CArray<CHandle<gameJournalEntryOverrideData>>>();
			set => SetPropertyValue<CArray<CHandle<gameJournalEntryOverrideData>>>(value);
		}

		[Ordinal(16)] 
		[RED("videoType")] 
		public CEnum<gameVideoType> VideoType
		{
			get => GetPropertyValue<CEnum<gameVideoType>>();
			set => SetPropertyValue<CEnum<gameVideoType>>(value);
		}

		[Ordinal(17)] 
		[RED("video")] 
		public redResourceReferenceScriptToken Video
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		public TutorialPopupData()
		{
			Margin = new inkMargin();
			MessageOverrideDataList = new();
			Video = new redResourceReferenceScriptToken();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
