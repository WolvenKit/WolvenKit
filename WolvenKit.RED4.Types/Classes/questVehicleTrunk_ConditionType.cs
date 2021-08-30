using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questVehicleTrunk_ConditionType : questIVehicleConditionType
	{
		private CBool _anyVehicle;
		private CBool _playerVehicle;
		private gameEntityReference _vehicleRef;
		private CBool _anyObject;
		private gameEntityReference _objectRef;
		private CBool _inverted;
		private CBool _isInside;

		[Ordinal(0)] 
		[RED("anyVehicle")] 
		public CBool AnyVehicle
		{
			get => GetProperty(ref _anyVehicle);
			set => SetProperty(ref _anyVehicle, value);
		}

		[Ordinal(1)] 
		[RED("playerVehicle")] 
		public CBool PlayerVehicle
		{
			get => GetProperty(ref _playerVehicle);
			set => SetProperty(ref _playerVehicle, value);
		}

		[Ordinal(2)] 
		[RED("vehicleRef")] 
		public gameEntityReference VehicleRef
		{
			get => GetProperty(ref _vehicleRef);
			set => SetProperty(ref _vehicleRef, value);
		}

		[Ordinal(3)] 
		[RED("anyObject")] 
		public CBool AnyObject
		{
			get => GetProperty(ref _anyObject);
			set => SetProperty(ref _anyObject, value);
		}

		[Ordinal(4)] 
		[RED("objectRef")] 
		public gameEntityReference ObjectRef
		{
			get => GetProperty(ref _objectRef);
			set => SetProperty(ref _objectRef, value);
		}

		[Ordinal(5)] 
		[RED("inverted")] 
		public CBool Inverted
		{
			get => GetProperty(ref _inverted);
			set => SetProperty(ref _inverted, value);
		}

		[Ordinal(6)] 
		[RED("isInside")] 
		public CBool IsInside
		{
			get => GetProperty(ref _isInside);
			set => SetProperty(ref _isInside, value);
		}

		public questVehicleTrunk_ConditionType()
		{
			_playerVehicle = true;
			_isInside = true;
		}
	}
}
