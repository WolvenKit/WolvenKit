using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class OnSquadmateDied : redEvent
	{
		[Ordinal(0)] 
		[RED("squad")] 
		public CName Squad
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("squadmate")] 
		public CWeakHandle<entEntity> Squadmate
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		[Ordinal(2)] 
		[RED("killer")] 
		public CWeakHandle<entEntity> Killer
		{
			get => GetPropertyValue<CWeakHandle<entEntity>>();
			set => SetPropertyValue<CWeakHandle<entEntity>>(value);
		}

		public OnSquadmateDied()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
