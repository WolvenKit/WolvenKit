using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberdeckStatController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("label")] 
		public inkTextWidgetReference Label
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(3)] 
		[RED("settingsListener")] 
		public CHandle<CyberdeckTooltipSettingsListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<CyberdeckTooltipSettingsListener>>();
			set => SetPropertyValue<CHandle<CyberdeckTooltipSettingsListener>>(value);
		}

		[Ordinal(4)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("minWidth")] 
		public inkWidgetReference MinWidth
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public CyberdeckStatController()
		{
			Label = new inkTextWidgetReference();
			GroupPath = "/accessibility/interface";
			MinWidth = new inkWidgetReference();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
