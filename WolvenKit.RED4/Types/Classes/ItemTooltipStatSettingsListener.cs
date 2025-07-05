using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipStatSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<ItemTooltipStatController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipStatController>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipStatController>>(value);
		}

		public ItemTooltipStatSettingsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
