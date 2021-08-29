using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class vehicleGarageComponentPS : gameComponentPS
	{
		private CArray<vehicleGarageComponentVehicleData> _spawnedVehiclesData;
		private CArray<vehicleGarageVehicleID> _unlockedVehicles;
		private CArray<vehicleUnlockedVehicle> _unlockedVehicleArray;
		private CStatic<vehicleGarageVehicleID> _activeVehicles;
		private vehicleGarageComponentVehicleData _mountedVehicleData;
		private CBool _mountedVehicleStolen;

		[Ordinal(0)] 
		[RED("spawnedVehiclesData")] 
		public CArray<vehicleGarageComponentVehicleData> SpawnedVehiclesData
		{
			get => GetProperty(ref _spawnedVehiclesData);
			set => SetProperty(ref _spawnedVehiclesData, value);
		}

		[Ordinal(1)] 
		[RED("unlockedVehicles")] 
		public CArray<vehicleGarageVehicleID> UnlockedVehicles
		{
			get => GetProperty(ref _unlockedVehicles);
			set => SetProperty(ref _unlockedVehicles, value);
		}

		[Ordinal(2)] 
		[RED("unlockedVehicleArray")] 
		public CArray<vehicleUnlockedVehicle> UnlockedVehicleArray
		{
			get => GetProperty(ref _unlockedVehicleArray);
			set => SetProperty(ref _unlockedVehicleArray, value);
		}

		[Ordinal(3)] 
		[RED("activeVehicles", 3)] 
		public CStatic<vehicleGarageVehicleID> ActiveVehicles
		{
			get => GetProperty(ref _activeVehicles);
			set => SetProperty(ref _activeVehicles, value);
		}

		[Ordinal(4)] 
		[RED("mountedVehicleData")] 
		public vehicleGarageComponentVehicleData MountedVehicleData
		{
			get => GetProperty(ref _mountedVehicleData);
			set => SetProperty(ref _mountedVehicleData, value);
		}

		[Ordinal(5)] 
		[RED("mountedVehicleStolen")] 
		public CBool MountedVehicleStolen
		{
			get => GetProperty(ref _mountedVehicleStolen);
			set => SetProperty(ref _mountedVehicleStolen, value);
		}
	}
}
