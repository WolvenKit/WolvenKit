using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class CompanionHealthStatListener : gameScriptStatPoolsListener
	{
		private CWeakHandle<CompanionHealthBarGameController> _healthbar;

		[Ordinal(0)] 
		[RED("healthbar")] 
		public CWeakHandle<CompanionHealthBarGameController> Healthbar
		{
			get => GetProperty(ref _healthbar);
			set => SetProperty(ref _healthbar, value);
		}
	}
}
