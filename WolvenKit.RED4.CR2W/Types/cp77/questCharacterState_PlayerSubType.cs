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
		private CEnum<questEComparisonTypeEquality> _swimmingStateComparisonType;
		private CEnum<gamePSMSwimming> _swimmingState;

		[Ordinal(0)] 
		[RED("locomotionComparisonType")] 
		public CEnum<questEComparisonTypeEquality> LocomotionComparisonType
		{
			get => GetProperty(ref _locomotionComparisonType);
			set => SetProperty(ref _locomotionComparisonType, value);
		}

		[Ordinal(1)] 
		[RED("locomotionState")] 
		public CEnum<gamePSMLocomotionStates> LocomotionState
		{
			get => GetProperty(ref _locomotionState);
			set => SetProperty(ref _locomotionState, value);
		}

		[Ordinal(2)] 
		[RED("upperBodyComparisonType")] 
		public CEnum<questEComparisonTypeEquality> UpperBodyComparisonType
		{
			get => GetProperty(ref _upperBodyComparisonType);
			set => SetProperty(ref _upperBodyComparisonType, value);
		}

		[Ordinal(3)] 
		[RED("upperBodyState")] 
		public CEnum<gamePSMUpperBodyStates> UpperBodyState
		{
			get => GetProperty(ref _upperBodyState);
			set => SetProperty(ref _upperBodyState, value);
		}

		[Ordinal(4)] 
		[RED("weaponComparisonType")] 
		public CEnum<questEComparisonTypeEquality> WeaponComparisonType
		{
			get => GetProperty(ref _weaponComparisonType);
			set => SetProperty(ref _weaponComparisonType, value);
		}

		[Ordinal(5)] 
		[RED("weaponState")] 
		public CEnum<gamePSMWeaponStates> WeaponState
		{
			get => GetProperty(ref _weaponState);
			set => SetProperty(ref _weaponState, value);
		}

		[Ordinal(6)] 
		[RED("timeDilationComparisonType")] 
		public CEnum<questEComparisonTypeEquality> TimeDilationComparisonType
		{
			get => GetProperty(ref _timeDilationComparisonType);
			set => SetProperty(ref _timeDilationComparisonType, value);
		}

		[Ordinal(7)] 
		[RED("timeDilationState")] 
		public CEnum<gamePSMTimeDilation> TimeDilationState
		{
			get => GetProperty(ref _timeDilationState);
			set => SetProperty(ref _timeDilationState, value);
		}

		[Ordinal(8)] 
		[RED("vehicleComparisonType")] 
		public CEnum<questEComparisonTypeEquality> VehicleComparisonType
		{
			get => GetProperty(ref _vehicleComparisonType);
			set => SetProperty(ref _vehicleComparisonType, value);
		}

		[Ordinal(9)] 
		[RED("vehicleState")] 
		public CEnum<gamePSMVehicle> VehicleState
		{
			get => GetProperty(ref _vehicleState);
			set => SetProperty(ref _vehicleState, value);
		}

		[Ordinal(10)] 
		[RED("takedownStateComparisonType")] 
		public CEnum<questEComparisonTypeEquality> TakedownStateComparisonType
		{
			get => GetProperty(ref _takedownStateComparisonType);
			set => SetProperty(ref _takedownStateComparisonType, value);
		}

		[Ordinal(11)] 
		[RED("takedownState")] 
		public CEnum<gamePSMTakedown> TakedownState
		{
			get => GetProperty(ref _takedownState);
			set => SetProperty(ref _takedownState, value);
		}

		[Ordinal(12)] 
		[RED("swimmingStateComparisonType")] 
		public CEnum<questEComparisonTypeEquality> SwimmingStateComparisonType
		{
			get => GetProperty(ref _swimmingStateComparisonType);
			set => SetProperty(ref _swimmingStateComparisonType, value);
		}

		[Ordinal(13)] 
		[RED("swimmingState")] 
		public CEnum<gamePSMSwimming> SwimmingState
		{
			get => GetProperty(ref _swimmingState);
			set => SetProperty(ref _swimmingState, value);
		}

		public questCharacterState_PlayerSubType(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
