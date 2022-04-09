using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questShowPopup_NodeSubType : questITutorial_NodeSubType
	{
		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetPropertyValue<CHandle<gameJournalPath>>();
			set => SetPropertyValue<CHandle<gameJournalPath>>(value);
		}

		[Ordinal(1)] 
		[RED("open")] 
		public CBool Open
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(2)] 
		[RED("closeAtInput")] 
		public CBool CloseAtInput
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("pauseGame")] 
		public CBool PauseGame
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("hideInMenu")] 
		public CBool HideInMenu
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(5)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetPropertyValue<inkMargin>();
			set => SetPropertyValue<inkMargin>(value);
		}

		[Ordinal(6)] 
		[RED("screenMode")] 
		public CEnum<questTutorialScreenMode> ScreenMode
		{
			get => GetPropertyValue<CEnum<questTutorialScreenMode>>();
			set => SetPropertyValue<CEnum<questTutorialScreenMode>>(value);
		}

		[Ordinal(7)] 
		[RED("position")] 
		public CEnum<gamePopupPosition> Position
		{
			get => GetPropertyValue<CEnum<gamePopupPosition>>();
			set => SetPropertyValue<CEnum<gamePopupPosition>>(value);
		}

		[Ordinal(8)] 
		[RED("lockPlayerMovement")] 
		public CBool LockPlayerMovement
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("closeCurrentPopup")] 
		public CBool CloseCurrentPopup
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("videoType")] 
		public CEnum<gameVideoType> VideoType
		{
			get => GetPropertyValue<CEnum<gameVideoType>>();
			set => SetPropertyValue<CEnum<gameVideoType>>(value);
		}

		[Ordinal(11)] 
		[RED("video")] 
		public CResourceAsyncReference<Bink> Video
		{
			get => GetPropertyValue<CResourceAsyncReference<Bink>>();
			set => SetPropertyValue<CResourceAsyncReference<Bink>>(value);
		}

		[Ordinal(12)] 
		[RED("ignoreDisabledTutorials")] 
		public CBool IgnoreDisabledTutorials
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public questShowPopup_NodeSubType()
		{
			Open = true;
			CloseAtInput = true;
			HideInMenu = true;
			Margin = new();
			Position = Enums.gamePopupPosition.Center;
			CloseCurrentPopup = true;
			VideoType = Enums.gameVideoType.Unknown;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
