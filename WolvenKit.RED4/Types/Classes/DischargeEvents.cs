using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class DischargeEvents : WeaponEventsTransition
	{
		[Ordinal(6)] 
		[RED("layerId")] 
		public CUInt32 LayerId
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(7)] 
		[RED("statPoolsSystem")] 
		public CHandle<gameStatPoolsSystem> StatPoolsSystem
		{
			get => GetPropertyValue<CHandle<gameStatPoolsSystem>>();
			set => SetPropertyValue<CHandle<gameStatPoolsSystem>>(value);
		}

		[Ordinal(8)] 
		[RED("statsSystem")] 
		public CHandle<gameStatsSystem> StatsSystem
		{
			get => GetPropertyValue<CHandle<gameStatsSystem>>();
			set => SetPropertyValue<CHandle<gameStatsSystem>>(value);
		}

		[Ordinal(9)] 
		[RED("weaponID")] 
		public entEntityID WeaponID
		{
			get => GetPropertyValue<entEntityID>();
			set => SetPropertyValue<entEntityID>(value);
		}

		public DischargeEvents()
		{
			StateMachineInstanceData = new gamestateMachineStateMachineInstanceData();
			WeaponID = new entEntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
