using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gamePopupSettings : RedBaseClass
	{
		private CBool _closeAtInput;
		private CBool _pauseGame;
		private CEnum<gamePopupPosition> _position;
		private CBool _fullscreen;
		private CBool _hideInMenu;
		private inkMargin _margin;

		[Ordinal(0)] 
		[RED("closeAtInput")] 
		public CBool CloseAtInput
		{
			get => GetProperty(ref _closeAtInput);
			set => SetProperty(ref _closeAtInput, value);
		}

		[Ordinal(1)] 
		[RED("pauseGame")] 
		public CBool PauseGame
		{
			get => GetProperty(ref _pauseGame);
			set => SetProperty(ref _pauseGame, value);
		}

		[Ordinal(2)] 
		[RED("position")] 
		public CEnum<gamePopupPosition> Position
		{
			get => GetProperty(ref _position);
			set => SetProperty(ref _position, value);
		}

		[Ordinal(3)] 
		[RED("fullscreen")] 
		public CBool Fullscreen
		{
			get => GetProperty(ref _fullscreen);
			set => SetProperty(ref _fullscreen, value);
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

		public gamePopupSettings()
		{
			_closeAtInput = true;
			_position = new() { Value = Enums.gamePopupPosition.Center };
		}
	}
}
