using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OpticalCamoListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("controller")] 
		public CWeakHandle<gameuiCrosshairBaseGameController> Controller
		{
			get => GetPropertyValue<CWeakHandle<gameuiCrosshairBaseGameController>>();
			set => SetPropertyValue<CWeakHandle<gameuiCrosshairBaseGameController>>(value);
		}

		public OpticalCamoListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
