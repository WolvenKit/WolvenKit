using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class VehicleSummonDataDef : gamebbScriptDefinition
	{
		private gamebbScriptID_Uint32 _garageState;
		private gamebbScriptID_Uint32 _unlockedVehiclesCount;
		private gamebbScriptID_Uint32 _summonState;
		private gamebbScriptID_EntityID _summonedVehicleEntityID;

		[Ordinal(0)] 
		[RED("GarageState")] 
		public gamebbScriptID_Uint32 GarageState
		{
			get => GetProperty(ref _garageState);
			set => SetProperty(ref _garageState, value);
		}

		[Ordinal(1)] 
		[RED("UnlockedVehiclesCount")] 
		public gamebbScriptID_Uint32 UnlockedVehiclesCount
		{
			get => GetProperty(ref _unlockedVehiclesCount);
			set => SetProperty(ref _unlockedVehiclesCount, value);
		}

		[Ordinal(2)] 
		[RED("SummonState")] 
		public gamebbScriptID_Uint32 SummonState
		{
			get => GetProperty(ref _summonState);
			set => SetProperty(ref _summonState, value);
		}

		[Ordinal(3)] 
		[RED("SummonedVehicleEntityID")] 
		public gamebbScriptID_EntityID SummonedVehicleEntityID
		{
			get => GetProperty(ref _summonedVehicleEntityID);
			set => SetProperty(ref _summonedVehicleEntityID, value);
		}
	}
}
