using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterMount_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("anyParent")] 
		public CBool AnyParent
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(1)] 
		[RED("parentRef")] 
		public gameEntityReference ParentRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(2)] 
		[RED("parentIsPlayer")] 
		public CBool ParentIsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(3)] 
		[RED("anyChild")] 
		public CBool AnyChild
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(4)] 
		[RED("childRef")] 
		public gameEntityReference ChildRef
		{
			get => GetPropertyValue<gameEntityReference>();
			set => SetPropertyValue<gameEntityReference>(value);
		}

		[Ordinal(5)] 
		[RED("childIsPlayer")] 
		public CBool ChildIsPlayer
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("condition")] 
		public CEnum<questMountConditionType> Condition
		{
			get => GetPropertyValue<CEnum<questMountConditionType>>();
			set => SetPropertyValue<CEnum<questMountConditionType>>(value);
		}

		[Ordinal(7)] 
		[RED("enterAnimationFinished")] 
		public CBool EnterAnimationFinished
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(8)] 
		[RED("role")] 
		public CEnum<gameMountingSlotRole> Role
		{
			get => GetPropertyValue<CEnum<gameMountingSlotRole>>();
			set => SetPropertyValue<CEnum<gameMountingSlotRole>>(value);
		}

		[Ordinal(9)] 
		[RED("usePlayersVehicle")] 
		public CBool UsePlayersVehicle
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(10)] 
		[RED("playerVehicleName")] 
		public CString PlayerVehicleName
		{
			get => GetPropertyValue<CString>();
			set => SetPropertyValue<CString>(value);
		}

		[Ordinal(11)] 
		[RED("vehicleType")] 
		public CEnum<questMountVehicleType> VehicleType
		{
			get => GetPropertyValue<CEnum<questMountVehicleType>>();
			set => SetPropertyValue<CEnum<questMountVehicleType>>(value);
		}

		[Ordinal(12)] 
		[RED("vehicleOrigin")] 
		public CEnum<questMountVehicleOrigin> VehicleOrigin
		{
			get => GetPropertyValue<CEnum<questMountVehicleOrigin>>();
			set => SetPropertyValue<CEnum<questMountVehicleOrigin>>(value);
		}

		public questCharacterMount_ConditionType()
		{
			ParentRef = new gameEntityReference { Names = new() };
			ChildRef = new gameEntityReference { Names = new() };
			Role = Enums.gameMountingSlotRole.Invalid;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
