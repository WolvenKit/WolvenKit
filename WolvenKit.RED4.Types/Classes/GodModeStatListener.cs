using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class GodModeStatListener : gameScriptStatsListener
	{
		private CWeakHandle<healthbarWidgetGameController> _healthbar;

		[Ordinal(0)] 
		[RED("healthbar")] 
		public CWeakHandle<healthbarWidgetGameController> Healthbar
		{
			get => GetProperty(ref _healthbar);
			set => SetProperty(ref _healthbar, value);
		}
	}
}
