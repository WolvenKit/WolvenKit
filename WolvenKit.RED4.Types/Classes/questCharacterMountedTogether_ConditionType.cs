using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class questCharacterMountedTogether_ConditionType : questICharacterConditionType
	{
		private CEnum<questMountVehicleType> _vehicleType;
		private CEnum<questMountVehicleOrigin> _vehicleOrigin;
		private CArray<CHandle<questMountedObjectInfo>> _characters;

		[Ordinal(0)] 
		[RED("vehicleType")] 
		public CEnum<questMountVehicleType> VehicleType
		{
			get => GetProperty(ref _vehicleType);
			set => SetProperty(ref _vehicleType, value);
		}

		[Ordinal(1)] 
		[RED("vehicleOrigin")] 
		public CEnum<questMountVehicleOrigin> VehicleOrigin
		{
			get => GetProperty(ref _vehicleOrigin);
			set => SetProperty(ref _vehicleOrigin, value);
		}

		[Ordinal(2)] 
		[RED("characters")] 
		public CArray<CHandle<questMountedObjectInfo>> Characters
		{
			get => GetProperty(ref _characters);
			set => SetProperty(ref _characters, value);
		}
	}
}
