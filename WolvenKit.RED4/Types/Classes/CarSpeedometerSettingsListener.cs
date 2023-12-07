using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CarSpeedometerSettingsListener : userSettingsVarListener
	{
		[Ordinal(0)] 
		[RED("ctrl")] 
		public CWeakHandle<hudCarController> Ctrl
		{
			get => GetPropertyValue<CWeakHandle<hudCarController>>();
			set => SetPropertyValue<CWeakHandle<hudCarController>>(value);
		}

		public CarSpeedometerSettingsListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
