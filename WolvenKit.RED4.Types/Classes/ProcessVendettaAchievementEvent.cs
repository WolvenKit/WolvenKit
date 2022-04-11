using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ProcessVendettaAchievementEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("deathInstigator")] 
		public CWeakHandle<gameObject> DeathInstigator
		{
			get => GetPropertyValue<CWeakHandle<gameObject>>();
			set => SetPropertyValue<CWeakHandle<gameObject>>(value);
		}

		public ProcessVendettaAchievementEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
