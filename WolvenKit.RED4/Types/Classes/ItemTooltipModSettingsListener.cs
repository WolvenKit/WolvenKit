using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipModSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<ItemTooltipModEntryController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipModEntryController>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipModEntryController>>(value);
		}

		public ItemTooltipModSettingsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
