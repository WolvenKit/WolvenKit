using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class ShouldExitVehicle : AIVehicleConditionAbstract
	{
		[Ordinal(0)] 
		[RED("bb")] 
		public CWeakHandle<gameIBlackboard> Bb
		{
			get => GetPropertyValue<CWeakHandle<gameIBlackboard>>();
			set => SetPropertyValue<CWeakHandle<gameIBlackboard>>(value);
		}

		[Ordinal(1)] 
		[RED("mf")] 
		public CHandle<gamemountingIMountingFacility> Mf
		{
			get => GetPropertyValue<CHandle<gamemountingIMountingFacility>>();
			set => SetPropertyValue<CHandle<gamemountingIMountingFacility>>(value);
		}

		[Ordinal(2)] 
		[RED("initialized")] 
		public CBool Initialized
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public ShouldExitVehicle()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
