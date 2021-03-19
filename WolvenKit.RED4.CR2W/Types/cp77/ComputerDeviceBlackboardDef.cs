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
			get => GetProperty(ref _mailThumbnailWidgetsData);
			set => SetProperty(ref _mailThumbnailWidgetsData, value);
		}

		[Ordinal(9)] 
		[RED("FileThumbnailWidgetsData")] 
		public gamebbScriptID_Variant FileThumbnailWidgetsData
		{
			get => GetProperty(ref _fileThumbnailWidgetsData);
			set => SetProperty(ref _fileThumbnailWidgetsData, value);
		}

		[Ordinal(10)] 
		[RED("MailWidgetsData")] 
		public gamebbScriptID_Variant MailWidgetsData
		{
			get => GetProperty(ref _mailWidgetsData);
			set => SetProperty(ref _mailWidgetsData, value);
		}

		[Ordinal(11)] 
		[RED("FileWidgetsData")] 
		public gamebbScriptID_Variant FileWidgetsData
		{
			get => GetProperty(ref _fileWidgetsData);
			set => SetProperty(ref _fileWidgetsData, value);
		}

		[Ordinal(12)] 
		[RED("MenuButtonWidgetsData")] 
		public gamebbScriptID_Variant MenuButtonWidgetsData
		{
			get => GetProperty(ref _menuButtonWidgetsData);
			set => SetProperty(ref _menuButtonWidgetsData, value);
		}

		[Ordinal(13)] 
		[RED("MainMenuButtonWidgetsData")] 
		public gamebbScriptID_Variant MainMenuButtonWidgetsData
		{
			get => GetProperty(ref _mainMenuButtonWidgetsData);
			set => SetProperty(ref _mainMenuButtonWidgetsData, value);
		}

		[Ordinal(14)] 
		[RED("BannerWidgetsData")] 
		public gamebbScriptID_Variant BannerWidgetsData
		{
			get => GetProperty(ref _bannerWidgetsData);
			set => SetProperty(ref _bannerWidgetsData, value);
		}

		public ComputerDeviceBlackboardDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
