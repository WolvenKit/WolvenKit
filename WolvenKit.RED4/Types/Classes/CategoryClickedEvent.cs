using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CategoryClickedEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("statsData")] 
		public gameStatViewData StatsData
		{
			get => GetPropertyValue<gameStatViewData>();
			set => SetPropertyValue<gameStatViewData>(value);
		}

		public CategoryClickedEvent()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
