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
			get
			{
				if (_vehicleType == null)
				{
					_vehicleType = (CEnum<questMountVehicleType>) CR2WTypeManager.Create("questMountVehicleType", "vehicleType", cr2w, this);
				}
				return _vehicleType;
			}
			set
			{
				if (_vehicleType == value)
				{
					return;
				}
				_vehicleType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("vehicleOrigin")] 
		public CEnum<questMountVehicleOrigin> VehicleOrigin
		{
			get
			{
				if (_vehicleOrigin == null)
				{
					_vehicleOrigin = (CEnum<questMountVehicleOrigin>) CR2WTypeManager.Create("questMountVehicleOrigin", "vehicleOrigin", cr2w, this);
				}
				return _vehicleOrigin;
			}
			set
			{
				if (_vehicleOrigin == value)
				{
					return;
				}
				_vehicleOrigin = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("characters")] 
		public CArray<CHandle<questMountedObjectInfo>> Characters
		{
			get
			{
				if (_characters == null)
				{
					_characters = (CArray<CHandle<questMountedObjectInfo>>) CR2WTypeManager.Create("array:handle:questMountedObjectInfo", "characters", cr2w, this);
				}
				return _characters;
			}
			set
			{
				if (_characters == value)
				{
					return;
				}
				_characters = value;
				PropertySet(this);
			}
		}

		public questCharacterMountedTogether_ConditionType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
