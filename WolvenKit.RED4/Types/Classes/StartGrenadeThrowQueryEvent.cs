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
			QueryParams = new() { ThrowAngleDegrees = -1.000000F, GravitySimulation = -9.800000F, MinTargetAngleDegrees = -180.000000F, MaxTargetAngleDegrees = 180.000000F };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
