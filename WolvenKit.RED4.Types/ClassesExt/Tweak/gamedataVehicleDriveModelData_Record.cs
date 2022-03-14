
namespace WolvenKit.RED4.Types
{
	public partial class gamedataVehicleDriveModelData_Record
	{
		[RED("airResistanceFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat AirResistanceFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("antiSwaybarDampingScalor")]
		[REDProperty(IsIgnored = true)]
		public CFloat AntiSwaybarDampingScalor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bankBodyFBTanMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat BankBodyFBTanMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bankBodyLRTanMultiplier")]
		[REDProperty(IsIgnored = true)]
		public CFloat BankBodyLRTanMultiplier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bikeCurvesPath")]
		[REDProperty(IsIgnored = true)]
		public CResourceAsyncReference<CResource> BikeCurvesPath
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}
		
		[RED("bikeMaxTilt")]
		[REDProperty(IsIgnored = true)]
		public CFloat BikeMaxTilt
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bikeTiltCustomSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat BikeTiltCustomSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bikeTiltPID")]
		[REDProperty(IsIgnored = true)]
		public CArray<CFloat> BikeTiltPID
		{
			get => GetPropertyValue<CArray<CFloat>>();
			set => SetPropertyValue<CArray<CFloat>>(value);
		}
		
		[RED("bikeTiltReturnSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat BikeTiltReturnSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bikeTiltSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat BikeTiltSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("bodyFriction")]
		[REDProperty(IsIgnored = true)]
		public CFloat BodyFriction
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("brakingEstimationMagicFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat BrakingEstimationMagicFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("brakingFrictionFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat BrakingFrictionFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("burnOut")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID BurnOut
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("burnOutRotationModifier")]
		[REDProperty(IsIgnored = true)]
		public CFloat BurnOutRotationModifier
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("center_of_mass_offset")]
		[REDProperty(IsIgnored = true)]
		public Vector3 Center_of_mass_offset
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("chassis_mass")]
		[REDProperty(IsIgnored = true)]
		public CFloat Chassis_mass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("differentialOvershootFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat DifferentialOvershootFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("driveHelpers")]
		[REDProperty(IsIgnored = true)]
		public CArray<TweakDBID> DriveHelpers
		{
			get => GetPropertyValue<CArray<TweakDBID>>();
			set => SetPropertyValue<CArray<TweakDBID>>(value);
		}
		
		[RED("forwardWeightTransferFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat ForwardWeightTransferFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("handbrakeBrakingTorque")]
		[REDProperty(IsIgnored = true)]
		public CFloat HandbrakeBrakingTorque
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("lowVelStoppingDeceleration")]
		[REDProperty(IsIgnored = true)]
		public CFloat LowVelStoppingDeceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("maxWheelTurnDeg")]
		[REDProperty(IsIgnored = true)]
		public CFloat MaxWheelTurnDeg
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("momentOfInertia")]
		[REDProperty(IsIgnored = true)]
		public Vector3 MomentOfInertia
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("momentOfInertiaScale")]
		[REDProperty(IsIgnored = true)]
		public Vector3 MomentOfInertiaScale
		{
			get => GetPropertyValue<Vector3>();
			set => SetPropertyValue<Vector3>(value);
		}
		
		[RED("perfectSteeringFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat PerfectSteeringFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("sideWeightTransferFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat SideWeightTransferFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("slipAngleCurveScale")]
		[REDProperty(IsIgnored = true)]
		public CFloat SlipAngleCurveScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("slipAngleMinSpeedThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat SlipAngleMinSpeedThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("slipRatioCurveScale")]
		[REDProperty(IsIgnored = true)]
		public CFloat SlipRatioCurveScale
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("slipRatioMinSpeedThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat SlipRatioMinSpeedThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("slopeTractionReductionBegin")]
		[REDProperty(IsIgnored = true)]
		public CFloat SlopeTractionReductionBegin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("slopeTractionReductionFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat SlopeTractionReductionFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("slopeTractionReductionMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat SlopeTractionReductionMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("smoothWheelContactDecreaseTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat SmoothWheelContactDecreaseTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("smoothWheelContactIncreseTime")]
		[REDProperty(IsIgnored = true)]
		public CFloat SmoothWheelContactIncreseTime
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankAcceleration")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankAcceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankCTOD")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankCTOD
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankCTOI")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankCTOI
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankCTOP")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankCTOP
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankDeceleration")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankDeceleration
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankGravityMul")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankGravityMul
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankMaxSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankMaxSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankSpringDamping")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankSpringDamping
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankSpringDistance")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankSpringDistance
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankSpringRadius")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankSpringRadius
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankSpringsLocalPositions")]
		[REDProperty(IsIgnored = true)]
		public CArray<Vector2> TankSpringsLocalPositions
		{
			get => GetPropertyValue<CArray<Vector2>>();
			set => SetPropertyValue<CArray<Vector2>>(value);
		}
		
		[RED("tankSpringStiffness")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankSpringStiffness
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankSpringVerticalOffset")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankSpringVerticalOffset
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("tankTurningSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat TankTurningSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("total_mass")]
		[REDProperty(IsIgnored = true)]
		public CFloat Total_mass
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turningRollFactor")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurningRollFactor
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turningRollFactorWeakContactMul")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurningRollFactorWeakContactMul
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turningRollFactorWeakContactThresholdMax")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurningRollFactorWeakContactThresholdMax
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turningRollFactorWeakContactThresholdMin")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurningRollFactorWeakContactThresholdMin
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turnUpdateBaseSpeedThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurnUpdateBaseSpeedThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turnUpdateInputDiffForFastChange")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurnUpdateInputDiffForFastChange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turnUpdateInputDiffForSlowChange")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurnUpdateInputDiffForSlowChange
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turnUpdateInputDiffProgressionPow")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurnUpdateInputDiffProgressionPow
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turnUpdateInputFastChangeSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurnUpdateInputFastChangeSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turnUpdateInputSlowChangeSpeed")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurnUpdateInputSlowChangeSpeed
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turnUpdateMaxSpeedThreshold")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurnUpdateMaxSpeedThreshold
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turnUpdateMaxSpeedTurnChangeMul")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurnUpdateMaxSpeedTurnChangeMul
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("turnUpdateMaxSpeedTurnMul")]
		[REDProperty(IsIgnored = true)]
		public CFloat TurnUpdateMaxSpeedTurnMul
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("useAlternativeTurnUpdate")]
		[REDProperty(IsIgnored = true)]
		public CBool UseAlternativeTurnUpdate
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}
		
		[RED("waterParams")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID WaterParams
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("wheelSetup")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID WheelSetup
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("wheelsFrictionMap")]
		[REDProperty(IsIgnored = true)]
		public TweakDBID WheelsFrictionMap
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}
		
		[RED("wheelTurnMaxAddPerSecond")]
		[REDProperty(IsIgnored = true)]
		public CFloat WheelTurnMaxAddPerSecond
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
		
		[RED("wheelTurnMaxSubPerSecond")]
		[REDProperty(IsIgnored = true)]
		public CFloat WheelTurnMaxSubPerSecond
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}
	}
}
