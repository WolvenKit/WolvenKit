using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleGarageComponentPS : gameComponentPS
	{
		[Ordinal(0)] 
		[RED("spawnedVehiclesData")] 
		public CArray<vehicleGarageComponentVehicleData> SpawnedVehiclesData
		{
			get => GetPropertyValue<CArray<vehicleGarageComponentVehicleData>>();
			set => SetPropertyValue<CArray<vehicleGarageComponentVehicleData>>(value);
		}

		[Ordinal(1)] 
		[RED("unlockedVehicles")] 
		public CArray<vehicleGarageVehicleID> UnlockedVehicles
		{
			get => GetPropertyValue<CArray<vehicleGarageVehicleID>>();
			set => SetPropertyValue<CArray<vehicleGarageVehicleID>>(value);
		}

		[Ordinal(2)] 
		[RED("unlockedVehicleArray")] 
		public CArray<vehicleUnlockedVehicle> UnlockedVehicleArray
		{
			get => GetPropertyValue<CArray<vehicleUnlockedVehicle>>();
			set => SetPropertyValue<CArray<vehicleUnlockedVehicle>>(value);
		}

		[Ordinal(3)] 
		[RED("activeVehicles", 3)] 
		public CStatic<vehicleGarageVehicleID> ActiveVehicles
		{
			get => GetPropertyValue<CStatic<vehicleGarageVehicleID>>();
			set => SetPropertyValue<CStatic<vehicleGarageVehicleID>>(value);
		}

		[Ordinal(4)] 
		[RED("mountedVehicleData")] 
		public vehicleGarageComponentVehicleData MountedVehicleData
		{
			get => GetPropertyValue<vehicleGarageComponentVehicleData>();
			set => SetPropertyValue<vehicleGarageComponentVehicleData>(value);
		}

		[Ordinal(5)] 
		[RED("mountedVehicleStolen")] 
		public CBool MountedVehicleStolen
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public vehicleGarageComponentPS()
		{
			SpawnedVehiclesData = new();
			UnlockedVehicles = new();
			UnlockedVehicleArray = new();
			ActiveVehicles = new(3);
			MountedVehicleData = new() { EntityID = new() };
		}
	}
}
