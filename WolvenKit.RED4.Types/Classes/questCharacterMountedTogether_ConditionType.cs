using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterMountedTogether_ConditionType : questICharacterConditionType
	{
		[Ordinal(0)] 
		[RED("vehicleType")] 
		public CEnum<questMountVehicleType> VehicleType
		{
			get => GetPropertyValue<CEnum<questMountVehicleType>>();
			set => SetPropertyValue<CEnum<questMountVehicleType>>(value);
		}

		[Ordinal(1)] 
		[RED("vehicleOrigin")] 
		public CEnum<questMountVehicleOrigin> VehicleOrigin
		{
			get => GetPropertyValue<CEnum<questMountVehicleOrigin>>();
			set => SetPropertyValue<CEnum<questMountVehicleOrigin>>(value);
		}

		[Ordinal(2)] 
		[RED("characters")] 
		public CArray<CHandle<questMountedObjectInfo>> Characters
		{
			get => GetPropertyValue<CArray<CHandle<questMountedObjectInfo>>>();
			set => SetPropertyValue<CArray<CHandle<questMountedObjectInfo>>>(value);
		}

		public questCharacterMountedTogether_ConditionType()
		{
			Characters = new() { null };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
