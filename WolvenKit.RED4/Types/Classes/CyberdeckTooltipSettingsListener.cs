using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CyberdeckTooltipSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<CyberdeckTooltip> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<CyberdeckTooltip>>();
			set => SetPropertyValue<CWeakHandle<CyberdeckTooltip>>(value);
		}

		[Ordinal(1)] 
		[RED("statctrl")] 
		public CWeakHandle<CyberdeckStatController> Statctrl
		{
			get => GetPropertyValue<CWeakHandle<CyberdeckStatController>>();
			set => SetPropertyValue<CWeakHandle<CyberdeckStatController>>(value);
		}

		public CyberdeckTooltipSettingsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
