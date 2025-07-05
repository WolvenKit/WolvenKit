using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class VehicleSummonDataDef : gamebbScriptDefinition
	{
		[Ordinal(0)] 
		[RED("GarageState")] 
		public gamebbScriptID_Uint32 GarageState
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(1)] 
		[RED("UnlockedVehiclesCount")] 
		public gamebbScriptID_Uint32 UnlockedVehiclesCount
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(2)] 
		[RED("SummonState")] 
		public gamebbScriptID_Uint32 SummonState
		{
			get => GetPropertyValue<gamebbScriptID_Uint32>();
			set => SetPropertyValue<gamebbScriptID_Uint32>(value);
		}

		[Ordinal(3)] 
		[RED("SummonedVehicleEntityID")] 
		public gamebbScriptID_EntityID SummonedVehicleEntityID
		{
			get => GetPropertyValue<gamebbScriptID_EntityID>();
			set => SetPropertyValue<gamebbScriptID_EntityID>(value);
		}

		public VehicleSummonDataDef()
		{
			GarageState = new gamebbScriptID_Uint32();
			UnlockedVehiclesCount = new gamebbScriptID_Uint32();
			SummonState = new gamebbScriptID_Uint32();
			SummonedVehicleEntityID = new gamebbScriptID_EntityID();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
