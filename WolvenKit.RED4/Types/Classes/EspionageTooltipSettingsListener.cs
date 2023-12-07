using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class EspionageTooltipSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<NewPerksCyberwareTooltipController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<NewPerksCyberwareTooltipController>>();
			set => SetPropertyValue<CWeakHandle<NewPerksCyberwareTooltipController>>(value);
		}

		public EspionageTooltipSettingsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
