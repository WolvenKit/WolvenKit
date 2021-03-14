using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gamePopupSettings : CVariable
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
			get
			{
				if (_closeAtInput == null)
				{
					_closeAtInput = (CBool) CR2WTypeManager.Create("Bool", "closeAtInput", cr2w, this);
				}
				return _closeAtInput;
			}
			set
			{
				if (_closeAtInput == value)
				{
					return;
				}
				_closeAtInput = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("pauseGame")] 
		public CBool PauseGame
		{
			get
			{
				if (_pauseGame == null)
				{
					_pauseGame = (CBool) CR2WTypeManager.Create("Bool", "pauseGame", cr2w, this);
				}
				return _pauseGame;
			}
			set
			{
				if (_pauseGame == value)
				{
					return;
				}
				_pauseGame = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("position")] 
		public CEnum<gamePopupPosition> Position
		{
			get
			{
				if (_position == null)
				{
					_position = (CEnum<gamePopupPosition>) CR2WTypeManager.Create("gamePopupPosition", "position", cr2w, this);
				}
				return _position;
			}
			set
			{
				if (_position == value)
				{
					return;
				}
				_position = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("fullscreen")] 
		public CBool Fullscreen
		{
			get
			{
				if (_fullscreen == null)
				{
					_fullscreen = (CBool) CR2WTypeManager.Create("Bool", "fullscreen", cr2w, this);
				}
				return _fullscreen;
			}
			set
			{
				if (_fullscreen == value)
				{
					return;
				}
				_fullscreen = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("hideInMenu")] 
		public CBool HideInMenu
		{
			get
			{
				if (_hideInMenu == null)
				{
					_hideInMenu = (CBool) CR2WTypeManager.Create("Bool", "hideInMenu", cr2w, this);
				}
				return _hideInMenu;
			}
			set
			{
				if (_hideInMenu == value)
				{
					return;
				}
				_hideInMenu = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("margin")] 
		public inkMargin Margin
		{
			get
			{
				if (_margin == null)
				{
					_margin = (inkMargin) CR2WTypeManager.Create("inkMargin", "margin", cr2w, this);
				}
				return _margin;
			}
			set
			{
				if (_margin == value)
				{
					return;
				}
				_margin = value;
				PropertySet(this);
			}
		}

		public gamePopupSettings(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
