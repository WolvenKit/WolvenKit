using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OverclockListener : gameScriptStatusEffectListener
	{
		[Ordinal(0)] 
		[RED("healthBar")] 
		public CWeakHandle<healthbarWidgetGameController> HealthBar
		{
			get => GetPropertyValue<CWeakHandle<healthbarWidgetGameController>>();
			set => SetPropertyValue<CWeakHandle<healthbarWidgetGameController>>(value);
		}

		public OverclockListener()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
