using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class ComputerDeviceBlackboardDef : MasterDeviceBaseBlackboardDef
	{
		private gamebbScriptID_Variant _mailThumbnailWidgetsData;
		private gamebbScriptID_Variant _fileThumbnailWidgetsData;
		private gamebbScriptID_Variant _mailWidgetsData;
		private gamebbScriptID_Variant _fileWidgetsData;
		private gamebbScriptID_Variant _menuButtonWidgetsData;
		private gamebbScriptID_Variant _mainMenuButtonWidgetsData;
		private gamebbScriptID_Variant _bannerWidgetsData;

		[Ordinal(8)] 
		[RED("MailThumbnailWidgetsData")] 
		public gamebbScriptID_Variant MailThumbnailWidgetsData
		{
			get
			{
				if (_mailThumbnailWidgetsData == null)
				{
					_mailThumbnailWidgetsData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "MailThumbnailWidgetsData", cr2w, this);
				}
				return _mailThumbnailWidgetsData;
			}
			set
			{
				if (_mailThumbnailWidgetsData == value)
				{
					return;
				}
				_mailThumbnailWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("FileThumbnailWidgetsData")] 
		public gamebbScriptID_Variant FileThumbnailWidgetsData
		{
			get
			{
				if (_fileThumbnailWidgetsData == null)
				{
					_fileThumbnailWidgetsData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "FileThumbnailWidgetsData", cr2w, this);
				}
				return _fileThumbnailWidgetsData;
			}
			set
			{
				if (_fileThumbnailWidgetsData == value)
				{
					return;
				}
				_fileThumbnailWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("MailWidgetsData")] 
		public gamebbScriptID_Variant MailWidgetsData
		{
			get
			{
				if (_mailWidgetsData == null)
				{
					_mailWidgetsData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "MailWidgetsData", cr2w, this);
				}
				return _mailWidgetsData;
			}
			set
			{
				if (_mailWidgetsData == value)
				{
					return;
				}
				_mailWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("FileWidgetsData")] 
		public gamebbScriptID_Variant FileWidgetsData
		{
			get
			{
				if (_fileWidgetsData == null)
				{
					_fileWidgetsData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "FileWidgetsData", cr2w, this);
				}
				return _fileWidgetsData;
			}
			set
			{
				if (_fileWidgetsData == value)
				{
					return;
				}
				_fileWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("MenuButtonWidgetsData")] 
		public gamebbScriptID_Variant MenuButtonWidgetsData
		{
			get
			{
				if (_menuButtonWidgetsData == null)
				{
					_menuButtonWidgetsData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "MenuButtonWidgetsData", cr2w, this);
				}
				return _menuButtonWidgetsData;
			}
			set
			{
				if (_menuButtonWidgetsData == value)
				{
					return;
				}
				_menuButtonWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("MainMenuButtonWidgetsData")] 
		public gamebbScriptID_Variant MainMenuButtonWidgetsData
		{
			get
			{
				if (_mainMenuButtonWidgetsData == null)
				{
					_mainMenuButtonWidgetsData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "MainMenuButtonWidgetsData", cr2w, this);
				}
				return _mainMenuButtonWidgetsData;
			}
			set
			{
				if (_mainMenuButtonWidgetsData == value)
				{
					return;
				}
				_mainMenuButtonWidgetsData = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("BannerWidgetsData")] 
		public gamebbScriptID_Variant BannerWidgetsData
		{
			get
			{
				if (_bannerWidgetsData == null)
				{
					_bannerWidgetsData = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "BannerWidgetsData", cr2w, this);
				}
				return _bannerWidgetsData;
			}
			set
			{
				if (_bannerWidgetsData == value)
				{
					return;
				}
				_bannerWidgetsData = value;
				PropertySet(this);
			}
		}

		public ComputerDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
