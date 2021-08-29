using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class BossHealthStatListener : gameScriptStatPoolsListener
	{
		private CWeakHandle<BossHealthBarGameController> _healthbar;

		[Ordinal(0)] 
		[RED("healthbar")] 
		public CWeakHandle<BossHealthBarGameController> Healthbar
		{
			get => GetProperty(ref _healthbar);
			set => SetProperty(ref _healthbar, value);
		}
	}
}
