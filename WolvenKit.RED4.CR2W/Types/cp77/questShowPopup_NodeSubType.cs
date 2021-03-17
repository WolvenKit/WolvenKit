using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questShowPopup_NodeSubType : questITutorial_NodeSubType
	{
		private CHandle<gameJournalPath> _path;
		private CBool _open;
		private CBool _closeAtInput;
		private CBool _pauseGame;
		private CBool _hideInMenu;
		private inkMargin _margin;
		private CEnum<questTutorialScreenMode> _screenMode;
		private CEnum<gamePopupPosition> _position;
		private CBool _lockPlayerMovement;
		private CBool _closeCurrentPopup;
		private CEnum<gameVideoType> _videoType;
		private raRef<Bink> _video;
		private CBool _ignoreDisabledTutorials;

		[Ordinal(0)] 
		[RED("path")] 
		public CHandle<gameJournalPath> Path
		{
			get => GetProperty(ref _path);
			set => SetProperty(ref _path, value);
		}

		[Ordinal(1)] 
		[RED("open")] 
		public CBool Open
		{
			get => GetProperty(ref _open);
			set => SetProperty(ref _open, value);
		}

		[Ordinal(2)] 
		[RED("closeAtInput")] 
		public CBool CloseAtInput
		{
			get => GetProperty(ref _closeAtInput);
			set => SetProperty(ref _closeAtInput, value);
		}

		[Ordinal(3)] 
		[RED("pauseGame")] 
		public CBool PauseGame
		{
			get => GetProperty(ref _pauseGame);
			set => SetProperty(ref _pauseGame, value);
		}

		[Ordinal(4)] 
		[RED("hideInMenu")] 
		public CBool HideInMenu
		{
			get => GetProperty(ref _hideInMenu);
			set => SetProperty(ref _hideInMenu, value);
		}

		[Ordinal(5)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get => GetProperty(ref _margin);
			set => SetProperty(ref _margin, value);
		}

		[Ordinal(6)] 
		[RED("screenMode")] 
		public CEnum<questTutorialScreenMode> ScreenMode
		{
			get => GetProperty(ref _screenMode);
			set => SetProperty(ref _screenMode, value);
		}

		[Ordinal(7)] 
		[RED("position")] 
		public CEnum<gamePopupPosition> Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(8)] 
		[RED("lockPlayerMovement")] 
		public CBool LockPlayerMovement
		{
			get => GetProperty(ref _lockPlayerMovement);
			set => SetProperty(ref _lockPlayerMovement, value);
		}

		[Ordinal(9)] 
		[RED("closeCurrentPopup")] 
		public CBool CloseCurrentPopup
		{
			get => GetProperty(ref _closeCurrentPopup);
			set => SetProperty(ref _closeCurrentPopup, value);
		}

		[Ordinal(10)] 
		[RED("videoType")] 
		public CEnum<gameVideoType> VideoType
		{
			get => GetProperty(ref _videoType);
			set => SetProperty(ref _videoType, value);
		}

		[Ordinal(11)] 
		[RED("video")] 
		public raRef<Bink> Video
		{
			get => GetProperty(ref _video);
			set => SetProperty(ref _video, value);
		}

		[Ordinal(12)] 
		[RED("ignoreDisabledTutorials")] 
		public CBool IgnoreDisabledTutorials
		{
			get => GetProperty(ref _ignoreDisabledTutorials);
			set => SetProperty(ref _ignoreDisabledTutorials, value);
		}

		public questShowPopup_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
