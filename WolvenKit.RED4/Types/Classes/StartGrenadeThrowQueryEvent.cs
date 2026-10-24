using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class StartGrenadeThrowQueryEvent : redEvent
	{
		[Ordinal(0)] 
		[RED("queryParams")] 
		public gameGrenadeThrowQueryParams QueryParams
		{
			get => GetPropertyValue<gameGrenadeThrowQueryParams>();
			set => SetPropertyValue<gameGrenadeThrowQueryParams>(value);
		}

		public StartGrenadeThrowQueryEvent()
		{
			QueryParams = new gameGrenadeThrowQueryParams();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
