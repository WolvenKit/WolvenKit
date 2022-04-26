using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class GodModeStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("healthbar")] 
		public CWeakHandle<healthbarWidgetGameController> Healthbar
		{
			get => GetPropertyValue<CWeakHandle<healthbarWidgetGameController>>();
			set => SetPropertyValue<CWeakHandle<healthbarWidgetGameController>>(value);
		}

		public GodModeStatListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
