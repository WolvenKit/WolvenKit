using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class questCharacterState_PlayerSubType : questICharacterConditionSubType
	{
		[Ordinal(0)] 
		[RED("locomotionComparisonType")] 
		public CEnum<questEComparisonTypeEquality> LocomotionComparisonType
		{
			get => GetPropertyValue<CEnum<questEComparisonTypeEquality>>();
			set => SetPropertyValue<CEnum<questEComparisonTypeEquality>>(value);
		}

		[Ordinal(1)] 
		[RED("locomotionState")] 
		public CEnum<gamePSMLocomotionStates> LocomotionState
		{
			get => GetPropertyValue<CEnum<gamePSMLocomotionStates>>();
			set => SetPropertyValue<CEnum<gamePSMLocomotionStates>>(value);
		}

		[Ordinal(2)] 
		[RED("upperBodyComparisonType")] 
		public CEnum<questEComparisonTypeEquality> UpperBodyComparisonType
		{
			get => GetPropertyValue<CEnum<questEComparisonTypeEquality>>();
			set => SetPropertyValue<CEnum<questEComparisonTypeEquality>>(value);
		}

		[Ordinal(3)] 
		[RED("upperBodyState")] 
		public CEnum<gamePSMUpperBodyStates> UpperBodyState
		{
			get => GetPropertyValue<CEnum<gamePSMUpperBodyStates>>();
			set => SetPropertyValue<CEnum<gamePSMUpperBodyStates>>(value);
		}

		[Ordinal(4)] 
		[RED("weaponComparisonType")] 
		public CEnum<questEComparisonTypeEquality> WeaponComparisonType
		{
			get => GetPropertyValue<CEnum<questEComparisonTypeEquality>>();
			set => SetPropertyValue<CEnum<questEComparisonTypeEquality>>(value);
		}

		[Ordinal(5)] 
		[RED("weaponState")] 
		public CEnum<gamePSMWeaponStates> WeaponState
		{
			get => GetPropertyValue<CEnum<gamePSMWeaponStates>>();
			set => SetPropertyValue<CEnum<gamePSMWeaponStates>>(value);
		}

		[Ordinal(6)] 
		[RED("timeDilationComparisonType")] 
		public CEnum<questEComparisonTypeEquality> TimeDilationComparisonType
		{
			get => GetPropertyValue<CEnum<questEComparisonTypeEquality>>();
			set => SetPropertyValue<CEnum<questEComparisonTypeEquality>>(value);
		}

		[Ordinal(7)] 
		[RED("timeDilationState")] 
		public CEnum<gamePSMTimeDilation> TimeDilationState
		{
			get => GetPropertyValue<CEnum<gamePSMTimeDilation>>();
			set => SetPropertyValue<CEnum<gamePSMTimeDilation>>(value);
		}

		[Ordinal(8)] 
		[RED("vehicleComparisonType")] 
		public CEnum<questEComparisonTypeEquality> VehicleComparisonType
		{
			get => GetPropertyValue<CEnum<questEComparisonTypeEquality>>();
			set => SetPropertyValue<CEnum<questEComparisonTypeEquality>>(value);
		}

		[Ordinal(9)] 
		[RED("vehicleState")] 
		public CEnum<gamePSMVehicle> VehicleState
		{
			get => GetPropertyValue<CEnum<gamePSMVehicle>>();
			set => SetPropertyValue<CEnum<gamePSMVehicle>>(value);
		}

		[Ordinal(10)] 
		[RED("takedownStateComparisonType")] 
		public CEnum<questEComparisonTypeEquality> TakedownStateComparisonType
		{
			get => GetPropertyValue<CEnum<questEComparisonTypeEquality>>();
			set => SetPropertyValue<CEnum<questEComparisonTypeEquality>>(value);
		}

		[Ordinal(11)] 
		[RED("takedownState")] 
		public CEnum<gamePSMTakedown> TakedownState
		{
			get => GetPropertyValue<CEnum<gamePSMTakedown>>();
			set => SetPropertyValue<CEnum<gamePSMTakedown>>(value);
		}

		[Ordinal(12)] 
		[RED("swimmingStateComparisonType")] 
		public CEnum<questEComparisonTypeEquality> SwimmingStateComparisonType
		{
			get => GetPropertyValue<CEnum<questEComparisonTypeEquality>>();
			set => SetPropertyValue<CEnum<questEComparisonTypeEquality>>(value);
		}

		[Ordinal(13)] 
		[RED("swimmingState")] 
		public CEnum<gamePSMSwimming> SwimmingState
		{
			get => GetPropertyValue<CEnum<gamePSMSwimming>>();
			set => SetPropertyValue<CEnum<gamePSMSwimming>>(value);
		}

		public questCharacterState_PlayerSubType()
		{
			LocomotionState = Enums.gamePSMLocomotionStates.Any;
			UpperBodyState = Enums.gamePSMUpperBodyStates.Any;
			WeaponState = Enums.gamePSMWeaponStates.Any;
			TimeDilationState = Enums.gamePSMTimeDilation.Any;
			VehicleState = Enums.gamePSMVehicle.Any;
			TakedownState = Enums.gamePSMTakedown.Any;
			SwimmingState = Enums.gamePSMSwimming.Any;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
