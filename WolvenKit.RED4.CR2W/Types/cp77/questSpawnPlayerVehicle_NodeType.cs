using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questSpawnPlayerVehicle_NodeType : questIVehicleManagerNodeType
	{
		private CBool _despawn;
		private CHandle<questUniversalRef> _positionRef;
		private Vector3 _offset;
		private CBool _driveIn;
		private CString _vehicle;
		private CName _vehicleGlobalName;
		private CBool _despawnAllVehicles;

		[Ordinal(0)] 
		[RED("despawn")] 
		public CBool Despawn
		{
			get => GetProperty(ref _despawn);
			set => SetProperty(ref _despawn, value);
		}

		[Ordinal(1)] 
		[RED("positionRef")] 
		public CHandle<questUniversalRef> PositionRef
		{
			get => GetProperty(ref _positionRef);
			set => SetProperty(ref _positionRef, value);
		}

		[Ordinal(2)] 
		[RED("offset")] 
		public Vector3 Offset
		{
			get => GetProperty(ref _offset);
			set => SetProperty(ref _offset, value);
		}

		[Ordinal(3)] 
		[RED("driveIn")] 
		public CBool DriveIn
		{
			get => GetProperty(ref _driveIn);
			set => SetProperty(ref _driveIn, value);
		}

		[Ordinal(4)] 
		[RED("vehicle")] 
		public CString Vehicle
		{
			get => GetProperty(ref _vehicle);
			set => SetProperty(ref _vehicle, value);
		}

		[Ordinal(5)] 
		[RED("vehicleGlobalName")] 
		public CName VehicleGlobalName
		{
			get => GetProperty(ref _vehicleGlobalName);
			set => SetProperty(ref _vehicleGlobalName, value);
		}

		[Ordinal(6)] 
		[RED("despawnAllVehicles")] 
		public CBool DespawnAllVehicles
		{
			get => GetProperty(ref _despawnAllVehicles);
			set => SetProperty(ref _despawnAllVehicles, value);
		}

		public questSpawnPlayerVehicle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
