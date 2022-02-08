using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class TutorialPopupData : inkGameNotificationData
	{
		[Ordinal(6)] 
		[RED("closeAtInput")] 
		public CBool CloseAtInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(7)] 
		[RED("pauseGame")] 
		public CBool PauseGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("isModal")] 
		public CBool IsModal
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("position")] 
		public CEnum<gamePopupPosition> Position
		{
			get => GetPropertyValue<CEnum<gamePopupPosition>>();
			set => SetPropertyValue<CEnum<gamePopupPosition>>(value);
		}

		[Ordinal(10)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(11)] 
		[RED("imageId")] 
		public TweakDBID ImageId
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(12)] 
		[RED("title")] 
		public CString Title
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(13)] 
		[RED("message")] 
		public CString Message
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(14)] 
		[RED("videoType")] 
		public CEnum<gameVideoType> VideoType
		{
			get => GetPropertyValue<CEnum<gameVideoType>>();
			set => SetPropertyValue<CEnum<gameVideoType>>(value);
		}

		[Ordinal(15)] 
		[RED("video")] 
		public redResourceReferenceScriptToken Video
		{
			get => GetPropertyValue<redResourceReferenceScriptToken>();
			set => SetPropertyValue<redResourceReferenceScriptToken>(value);
		}

		public TutorialPopupData()
		{
			Margin = new();
			Video = new();
		}
	}
}
