using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class enteventsHitCharacterControllerEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("entity")] 
		public CWeakHandle<entEntity> Entity
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(1)] 
		[RED("component")] 
		public CWeakHandle<entIComponent> Component
		{
			get => GetPropertyValue<CWeakHandle<entIComponent>>();
			set => SetPropertyValue<CWeakHandle<entIComponent>>(value);
		}

		public enteventsHitCharacterControllerEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
