using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ItemTooltipSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<ItemTooltipCommonController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<ItemTooltipCommonController>>();
			set => SetPropertyValue<CWeakHandle<ItemTooltipCommonController>>(value);
		}

		public ItemTooltipSettingsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
