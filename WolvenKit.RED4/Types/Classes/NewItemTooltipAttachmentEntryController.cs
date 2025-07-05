using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipAttachmentEntryController : inkWidgetLogicController
	{
		[Ordinal(1)] 
		[RED("text")] 
		public inkTextWidgetReference Text
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
		[RED("settings")] 
		public CHandle<userSettingsUserSettings> Settings
		{
			get => GetPropertyValue<CHandle<userSettingsUserSettings>>();
			set => SetPropertyValue<CHandle<userSettingsUserSettings>>(value);
		}

		[Ordinal(6)] 
		[RED("settingsListener")] 
		public CHandle<NewItemTooltipAttachmentEntrySettingsListener> SettingsListener
		{
			get => GetPropertyValue<CHandle<NewItemTooltipAttachmentEntrySettingsListener>>();
			set => SetPropertyValue<CHandle<NewItemTooltipAttachmentEntrySettingsListener>>(value);
		}

		[Ordinal(7)] 
		[RED("groupPath")] 
		public CName GroupPath
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("bigFontEnabled")] 
		public CBool BigFontEnabled
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(9)] 
		[RED("isCrafting")] 
		public CBool IsCrafting
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public NewItemTooltipAttachmentEntryController()
		{
			Text = new inkTextWidgetReference();
			AttunementContainer = new inkWidgetReference();
			AttunementText = new inkTextWidgetReference();
			AttunementIcon = new inkImageWidgetReference();
			GroupPath = "/accessibility/interface";

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
