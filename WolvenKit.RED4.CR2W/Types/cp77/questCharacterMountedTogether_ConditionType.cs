using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterMountedTogether_ConditionType : questICharacterConditionType
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

		public questCharacterMountedTogether_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
