using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class HDRSettingsVarListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<gameuiHDRSettingsGameController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<gameuiHDRSettingsGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiHDRSettingsGameController>>(value);
		}

		public HDRSettingsVarListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
