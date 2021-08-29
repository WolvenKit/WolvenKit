using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class ProcessVendettaAchievementEvent : redEvent
	{
		private CWeakHandle<gameObject> _deathInstigator;

		[Ordinal(0)] 
		[RED("deathInstigator")] 
		public CWeakHandle<gameObject> DeathInstigator
		{
			get => GetProperty(ref _deathInstigator);
			set => SetProperty(ref _deathInstigator, value);
		}
	}
}
