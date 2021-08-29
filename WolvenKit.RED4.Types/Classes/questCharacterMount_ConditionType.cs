using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterMount_ConditionType : questICharacterConditionType
	{
		private CBool _anyParent;
		private gameEntityReference _parentRef;
		private CBool _parentIsPlayer;
		private CBool _anyChild;
		private gameEntityReference _childRef;
		private CBool _childIsPlayer;
		private CEnum<questMountConditionType> _condition;
		private CBool _enterAnimationFinished;
		private CEnum<gameMountingSlotRole> _role;
		private CBool _usePlayersVehicle;
		private CString _playerVehicleName;
		private CEnum<questMountVehicleType> _vehicleType;
		private CEnum<questMountVehicleOrigin> _vehicleOrigin;

		[Ordinal(0)] 
		[RED("anyParent")] 
		public CBool AnyParent
		{
			get => GetProperty(ref _anyParent);
			set => SetProperty(ref _anyParent, value);
		}

		[Ordinal(1)] 
		[RED("parentRef")] 
		public gameEntityReference ParentRef
		{
			get => GetProperty(ref _parentRef);
			set => SetProperty(ref _parentRef, value);
		}

		[Ordinal(2)] 
		[RED("parentIsPlayer")] 
		public CBool ParentIsPlayer
		{
			get => GetProperty(ref _parentIsPlayer);
			set => SetProperty(ref _parentIsPlayer, value);
		}

		[Ordinal(3)] 
		[RED("anyChild")] 
		public CBool AnyChild
		{
			get => GetProperty(ref _anyChild);
			set => SetProperty(ref _anyChild, value);
		}

		[Ordinal(4)] 
		[RED("childRef")] 
		public gameEntityReference ChildRef
		{
			get => GetProperty(ref _childRef);
			set => SetProperty(ref _childRef, value);
		}

		[Ordinal(5)] 
		[RED("childIsPlayer")] 
		public CBool ChildIsPlayer
		{
			get => GetProperty(ref _childIsPlayer);
			set => SetProperty(ref _childIsPlayer, value);
		}

		[Ordinal(6)] 
		[RED("condition")] 
		public CEnum<questMountConditionType> Condition
		{
			get => GetProperty(ref _condition);
			set => SetProperty(ref _condition, value);
		}

		[Ordinal(7)] 
		[RED("enterAnimationFinished")] 
		public CBool EnterAnimationFinished
		{
			get => GetProperty(ref _enterAnimationFinished);
			set => SetProperty(ref _enterAnimationFinished, value);
		}

		[Ordinal(8)] 
		[RED("role")] 
		public CEnum<gameMountingSlotRole> Role
		{
			get => GetProperty(ref _role);
			set => SetProperty(ref _role, value);
		}

		[Ordinal(9)] 
		[RED("usePlayersVehicle")] 
		public CBool UsePlayersVehicle
		{
			get => GetProperty(ref _usePlayersVehicle);
			set => SetProperty(ref _usePlayersVehicle, value);
		}

		[Ordinal(10)] 
		[RED("playerVehicleName")] 
		public CString PlayerVehicleName
		{
			get => GetProperty(ref _playerVehicleName);
			set => SetProperty(ref _playerVehicleName, value);
		}

		[Ordinal(11)] 
		[RED("vehicleType")] 
		public CEnum<questMountVehicleType> VehicleType
		{
			get => GetProperty(ref _vehicleType);
			set => SetProperty(ref _vehicleType, value);
		}

		[Ordinal(12)] 
		[RED("vehicleOrigin")] 
		public CEnum<questMountVehicleOrigin> VehicleOrigin
		{
			get => GetProperty(ref _vehicleOrigin);
			set => SetProperty(ref _vehicleOrigin, value);
		}
	}
}
