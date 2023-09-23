using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ComputerDeviceBlackboardDef : MasterDeviceBaseBlackboardDef
	{
		[Ordinal(9)] 
		[RED("MailThumbnailWidgetsData")] 
		public gamebbScriptID_Variant MailThumbnailWidgetsData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(10)] 
		[RED("FileThumbnailWidgetsData")] 
		public gamebbScriptID_Variant FileThumbnailWidgetsData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(11)] 
		[RED("MailWidgetsData")] 
		public gamebbScriptID_Variant MailWidgetsData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(12)] 
		[RED("FileWidgetsData")] 
		public gamebbScriptID_Variant FileWidgetsData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(13)] 
		[RED("MenuButtonWidgetsData")] 
		public gamebbScriptID_Variant MenuButtonWidgetsData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(14)] 
		[RED("MainMenuButtonWidgetsData")] 
		public gamebbScriptID_Variant MainMenuButtonWidgetsData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(15)] 
		[RED("BannerWidgetsData")] 
		public gamebbScriptID_Variant BannerWidgetsData
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		public ComputerDeviceBlackboardDef()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
