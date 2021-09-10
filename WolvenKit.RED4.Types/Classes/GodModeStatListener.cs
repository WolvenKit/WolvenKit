using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GodModeStatListener : gameScriptStatsListener
	{
		[Ordinal(0)] 
		[RED("healthbar")] 
		public CWeakHandle<healthbarWidgetGameController> Healthbar
		{
			get => GetPropertyValue<CWeakHandle<healthbarWidgetGameController>>();
			set => SetPropertyValue<CWeakHandle<healthbarWidgetGameController>>(value);
		}
	}
}
