using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipModEntryController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("modName")] 
		public inkTextWidgetReference ModName
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(2)] 
		[RED("attunementContainer")] 
		public inkWidgetReference AttunementContainer
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(3)] 
		[RED("attunementText")] 
		public inkTextWidgetReference AttunementText
		{
			get => GetPropertyValue<inkTextWidgetReference>();
			set => SetPropertyValue<inkTextWidgetReference>(value);
		}

		[Ordinal(4)] 
		[RED("attunementIcon")] 
		public inkImageWidgetReference AttunementIcon
		{
			get => GetPropertyValue<inkImageWidgetReference>();
			set => SetPropertyValue<inkImageWidgetReference>(value);
		}

		[Ordinal(5)] 
		[RED("attunementLine")] 
		public inkWidgetReference AttunementLine
		{
			get => GetPropertyValue<inkWidgetReference>();
			set => SetPropertyValue<inkWidgetReference>(value);
		}

		[Ordinal(6)] 
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(7)] 
		[RED("settingsListener")] 
		public CHandle<ItemTooltipModSettingsListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<ItemTooltipModSettingsListener>>();
			set => SetPropertyValue<CHandle<ItemTooltipModSettingsListener>>(value);
		}

		[Ordinal(8)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("isCrafting")] 
		public CBool IsCrafting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ItemTooltipModEntryController()
		{
			ModName = new inkTextWidgetReference();
			AttunementContainer = new inkWidgetReference();
			AttunementText = new inkTextWidgetReference();
			AttunementIcon = new inkImageWidgetReference();
			AttunementLine = new inkWidgetReference();
			GroupPath = "/accessibility/interface";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
