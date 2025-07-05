using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class PerkDisplayTooltipSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<PerkDisplayTooltipController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<PerkDisplayTooltipController>>();
			set => SetPropertyValue<CWeakHandle<PerkDisplayTooltipController>>(value);
		}

		public PerkDisplayTooltipSettingsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
