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

		[Ordinal(18)] 
		[RED("gyroTutorialProgress")] 
		public CInt32 GyroTutorialProgress
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(19)] 
		[RED("hasGyroTutorialCounter")] 
		public CBool HasGyroTutorialCounter
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(20)] 
		[RED("gyroTutorialProgressMax")] 
		public CInt32 GyroTutorialProgressMax
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(21)] 
		[RED("gyroCounterStr")] 
		public CString GyroCounterStr
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(22)] 
		[RED("gyroCounterParamStr")] 
		public CString GyroCounterParamStr
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		public TutorialPopupData()
		{
			Margin = new inkMargin();
			MessageOverrideDataList = new();
			Video = new redResourceReferenceScriptToken();
			GyroTutorialProgressMax = 3;
			GyroCounterStr = "{gyro_tutorial_progress0}";
			GyroCounterParamStr = "gyro_tutorial_progress0";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
