using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleSummonDataDef : gamebbScriptDefinition
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

		public VehicleSummonDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
