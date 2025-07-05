using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipAttachmentEntrySettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<NewItemTooltipAttachmentEntryController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<NewItemTooltipAttachmentEntryController>>();
			set => SetPropertyValue<CWeakHandle<NewItemTooltipAttachmentEntryController>>(value);
		}

		public NewItemTooltipAttachmentEntrySettingsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
