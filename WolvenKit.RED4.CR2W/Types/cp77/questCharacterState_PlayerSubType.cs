using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class questCharacterState_PlayerSubType : questICharacterConditionSubType
	{
		private CEnum<questEComparisonTypeEquality> _locomotionComparisonType;
		private CEnum<gamePSMLocomotionStates> _locomotionState;
		private CEnum<questEComparisonTypeEquality> _upperBodyComparisonType;
		private CEnum<gamePSMUpperBodyStates> _upperBodyState;
		private CEnum<questEComparisonTypeEquality> _weaponComparisonType;
		private CEnum<gamePSMWeaponStates> _weaponState;
		private CEnum<questEComparisonTypeEquality> _timeDilationComparisonType;
		private CEnum<gamePSMTimeDilation> _timeDilationState;
		private CEnum<questEComparisonTypeEquality> _vehicleComparisonType;
		private CEnum<gamePSMVehicle> _vehicleState;
		private CEnum<questEComparisonTypeEquality> _takedownStateComparisonType;
		private CEnum<gamePSMTakedown> _takedownState;

		[Ordinal(0)] 
		[RED("locomotionComparisonType")] 
		public CEnum<questEComparisonTypeEquality> LocomotionComparisonType
		{
			get
			{
				if (_locomotionComparisonType == null)
				{
					_locomotionComparisonType = (CEnum<questEComparisonTypeEquality>) CR2WTypeManager.Create("questEComparisonTypeEquality", "locomotionComparisonType", cr2w, this);
				}
				return _locomotionComparisonType;
			}
			set
			{
				if (_locomotionComparisonType == value)
				{
					return;
				}
				_locomotionComparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("locomotionState")] 
		public CEnum<gamePSMLocomotionStates> LocomotionState
		{
			get
			{
				if (_locomotionState == null)
				{
					_locomotionState = (CEnum<gamePSMLocomotionStates>) CR2WTypeManager.Create("gamePSMLocomotionStates", "locomotionState", cr2w, this);
				}
				return _locomotionState;
			}
			set
			{
				if (_locomotionState == value)
				{
					return;
				}
				_locomotionState = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("upperBodyComparisonType")] 
		public CEnum<questEComparisonTypeEquality> UpperBodyComparisonType
		{
			get
			{
				if (_upperBodyComparisonType == null)
				{
					_upperBodyComparisonType = (CEnum<questEComparisonTypeEquality>) CR2WTypeManager.Create("questEComparisonTypeEquality", "upperBodyComparisonType", cr2w, this);
				}
				return _upperBodyComparisonType;
			}
			set
			{
				if (_upperBodyComparisonType == value)
				{
					return;
				}
				_upperBodyComparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("upperBodyState")] 
		public CEnum<gamePSMUpperBodyStates> UpperBodyState
		{
			get
			{
				if (_upperBodyState == null)
				{
					_upperBodyState = (CEnum<gamePSMUpperBodyStates>) CR2WTypeManager.Create("gamePSMUpperBodyStates", "upperBodyState", cr2w, this);
				}
				return _upperBodyState;
			}
			set
			{
				if (_upperBodyState == value)
				{
					return;
				}
				_upperBodyState = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("weaponComparisonType")] 
		public CEnum<questEComparisonTypeEquality> WeaponComparisonType
		{
			get
			{
				if (_weaponComparisonType == null)
				{
					_weaponComparisonType = (CEnum<questEComparisonTypeEquality>) CR2WTypeManager.Create("questEComparisonTypeEquality", "weaponComparisonType", cr2w, this);
				}
				return _weaponComparisonType;
			}
			set
			{
				if (_weaponComparisonType == value)
				{
					return;
				}
				_weaponComparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("weaponState")] 
		public CEnum<gamePSMWeaponStates> WeaponState
		{
			get
			{
				if (_weaponState == null)
				{
					_weaponState = (CEnum<gamePSMWeaponStates>) CR2WTypeManager.Create("gamePSMWeaponStates", "weaponState", cr2w, this);
				}
				return _weaponState;
			}
			set
			{
				if (_weaponState == value)
				{
					return;
				}
				_weaponState = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("timeDilationComparisonType")] 
		public CEnum<questEComparisonTypeEquality> TimeDilationComparisonType
		{
			get
			{
				if (_timeDilationComparisonType == null)
				{
					_timeDilationComparisonType = (CEnum<questEComparisonTypeEquality>) CR2WTypeManager.Create("questEComparisonTypeEquality", "timeDilationComparisonType", cr2w, this);
				}
				return _timeDilationComparisonType;
			}
			set
			{
				if (_timeDilationComparisonType == value)
				{
					return;
				}
				_timeDilationComparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("timeDilationState")] 
		public CEnum<gamePSMTimeDilation> TimeDilationState
		{
			get
			{
				if (_timeDilationState == null)
				{
					_timeDilationState = (CEnum<gamePSMTimeDilation>) CR2WTypeManager.Create("gamePSMTimeDilation", "timeDilationState", cr2w, this);
				}
				return _timeDilationState;
			}
			set
			{
				if (_timeDilationState == value)
				{
					return;
				}
				_timeDilationState = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("vehicleComparisonType")] 
		public CEnum<questEComparisonTypeEquality> VehicleComparisonType
		{
			get
			{
				if (_vehicleComparisonType == null)
				{
					_vehicleComparisonType = (CEnum<questEComparisonTypeEquality>) CR2WTypeManager.Create("questEComparisonTypeEquality", "vehicleComparisonType", cr2w, this);
				}
				return _vehicleComparisonType;
			}
			set
			{
				if (_vehicleComparisonType == value)
				{
					return;
				}
				_vehicleComparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("vehicleState")] 
		public CEnum<gamePSMVehicle> VehicleState
		{
			get
			{
				if (_vehicleState == null)
				{
					_vehicleState = (CEnum<gamePSMVehicle>) CR2WTypeManager.Create("gamePSMVehicle", "vehicleState", cr2w, this);
				}
				return _vehicleState;
			}
			set
			{
				if (_vehicleState == value)
				{
					return;
				}
				_vehicleState = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("takedownStateComparisonType")] 
		public CEnum<questEComparisonTypeEquality> TakedownStateComparisonType
		{
			get
			{
				if (_takedownStateComparisonType == null)
				{
					_takedownStateComparisonType = (CEnum<questEComparisonTypeEquality>) CR2WTypeManager.Create("questEComparisonTypeEquality", "takedownStateComparisonType", cr2w, this);
				}
				return _takedownStateComparisonType;
			}
			set
			{
				if (_takedownStateComparisonType == value)
				{
					return;
				}
				_takedownStateComparisonType = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("takedownState")] 
		public CEnum<gamePSMTakedown> TakedownState
		{
			get
			{
				if (_takedownState == null)
				{
					_takedownState = (CEnum<gamePSMTakedown>) CR2WTypeManager.Create("gamePSMTakedown", "takedownState", cr2w, this);
				}
				return _takedownState;
			}
			set
			{
				if (_takedownState == value)
				{
					return;
				}
				_takedownState = value;
				PropertySet(this);
			}
		}

		public questCharacterState_PlayerSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
