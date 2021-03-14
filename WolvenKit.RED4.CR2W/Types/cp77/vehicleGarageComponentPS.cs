using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class vehicleGarageComponentPS : gameComponentPS
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
			get
			{
				if (_spawnedVehiclesData == null)
				{
					_spawnedVehiclesData = (CArray<vehicleGarageComponentVehicleData>) CR2WTypeManager.Create("array:vehicleGarageComponentVehicleData", "spawnedVehiclesData", cr2w, this);
				}
				return _spawnedVehiclesData;
			}
			set
			{
				if (_spawnedVehiclesData == value)
				{
					return;
				}
				_spawnedVehiclesData = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("unlockedVehicles")] 
		public CArray<vehicleGarageVehicleID> UnlockedVehicles
		{
			get
			{
				if (_unlockedVehicles == null)
				{
					_unlockedVehicles = (CArray<vehicleGarageVehicleID>) CR2WTypeManager.Create("array:vehicleGarageVehicleID", "unlockedVehicles", cr2w, this);
				}
				return _unlockedVehicles;
			}
			set
			{
				if (_unlockedVehicles == value)
				{
					return;
				}
				_unlockedVehicles = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("unlockedVehicleArray")] 
		public CArray<vehicleUnlockedVehicle> UnlockedVehicleArray
		{
			get
			{
				if (_unlockedVehicleArray == null)
				{
					_unlockedVehicleArray = (CArray<vehicleUnlockedVehicle>) CR2WTypeManager.Create("array:vehicleUnlockedVehicle", "unlockedVehicleArray", cr2w, this);
				}
				return _unlockedVehicleArray;
			}
			set
			{
				if (_unlockedVehicleArray == value)
				{
					return;
				}
				_unlockedVehicleArray = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("activeVehicles", 3)] 
		public CStatic<vehicleGarageVehicleID> ActiveVehicles
		{
			get
			{
				if (_activeVehicles == null)
				{
					_activeVehicles = (CStatic<vehicleGarageVehicleID>) CR2WTypeManager.Create("static:3,vehicleGarageVehicleID", "activeVehicles", cr2w, this);
				}
				return _activeVehicles;
			}
			set
			{
				if (_activeVehicles == value)
				{
					return;
				}
				_activeVehicles = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("mountedVehicleData")] 
		public vehicleGarageComponentVehicleData MountedVehicleData
		{
			get
			{
				if (_mountedVehicleData == null)
				{
					_mountedVehicleData = (vehicleGarageComponentVehicleData) CR2WTypeManager.Create("vehicleGarageComponentVehicleData", "mountedVehicleData", cr2w, this);
				}
				return _mountedVehicleData;
			}
			set
			{
				if (_mountedVehicleData == value)
				{
					return;
				}
				_mountedVehicleData = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("mountedVehicleStolen")] 
		public CBool MountedVehicleStolen
		{
			get
			{
				if (_mountedVehicleStolen == null)
				{
					_mountedVehicleStolen = (CBool) CR2WTypeManager.Create("Bool", "mountedVehicleStolen", cr2w, this);
				}
				return _mountedVehicleStolen;
			}
			set
			{
				if (_mountedVehicleStolen == value)
				{
					return;
				}
				_mountedVehicleStolen = value;
				PropertySet(this);
			}
		}

		public vehicleGarageComponentPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
