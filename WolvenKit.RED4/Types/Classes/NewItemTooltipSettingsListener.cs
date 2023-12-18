using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class NewItemTooltipSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<NewItemTooltipCommonController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<NewItemTooltipCommonController>>();
			set => SetPropertyValue<CWeakHandle<NewItemTooltipCommonController>>(value);
		}

		public NewItemTooltipSettingsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
