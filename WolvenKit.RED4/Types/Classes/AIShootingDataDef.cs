using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class AIShootingDataDef : AIBlackboardDef
	{
		[Ordinal(0)] 
		[RED("shootingPatternPackage")] 
		public gamebbScriptID_Variant ShootingPatternPackage
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(1)] 
		[RED("shootingPattern")] 
		public gamebbScriptID_Variant ShootingPattern
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(2)] 
		[RED("patternList")] 
		public gamebbScriptID_Variant PatternList
		{
			get => GetPropertyValue<gamebbScriptID_Variant>();
			set => SetPropertyValue<gamebbScriptID_Variant>(value);
		}

		[Ordinal(3)] 
		[RED("rightArmLookAtLimitReached")] 
		public gamebbScriptID_Int32 RightArmLookAtLimitReached
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(4)] 
		[RED("totalShotsFired")] 
		public gamebbScriptID_Int32 TotalShotsFired
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(5)] 
		[RED("shotsInBurstFired")] 
		public gamebbScriptID_Int32 ShotsInBurstFired
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(6)] 
		[RED("desiredNumberOfShots")] 
		public gamebbScriptID_Int32 DesiredNumberOfShots
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(7)] 
		[RED("nextShotTimeStamp")] 
		public gamebbScriptID_Float NextShotTimeStamp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(8)] 
		[RED("shotTimeStamp")] 
		public gamebbScriptID_Float ShotTimeStamp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(9)] 
		[RED("maxChargedTimeStamp")] 
		public gamebbScriptID_Float MaxChargedTimeStamp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(10)] 
		[RED("chargeStartTimeStamp")] 
		public gamebbScriptID_Float ChargeStartTimeStamp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(11)] 
		[RED("pauseConditionCheckTimeStamp")] 
		public gamebbScriptID_Float PauseConditionCheckTimeStamp
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(12)] 
		[RED("lastChargeLevel")] 
		public gamebbScriptID_Float LastChargeLevel
		{
			get => GetPropertyValue<gamebbScriptID_Float>();
			set => SetPropertyValue<gamebbScriptID_Float>(value);
		}

		[Ordinal(13)] 
		[RED("fullyCharged")] 
		public gamebbScriptID_Bool FullyCharged
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(14)] 
		[RED("weaponOverheated")] 
		public gamebbScriptID_Bool WeaponOverheated
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		[Ordinal(15)] 
		[RED("requestedTriggerMode")] 
		public gamebbScriptID_Int32 RequestedTriggerMode
		{
			get => GetPropertyValue<gamebbScriptID_Int32>();
			set => SetPropertyValue<gamebbScriptID_Int32>(value);
		}

		[Ordinal(16)] 
		[RED("shootingFromCar")] 
		public gamebbScriptID_Bool ShootingFromCar
		{
			get => GetPropertyValue<gamebbScriptID_Bool>();
			set => SetPropertyValue<gamebbScriptID_Bool>(value);
		}

		public AIShootingDataDef()
		{
			ShootingPatternPackage = new gamebbScriptID_Variant();
			ShootingPattern = new gamebbScriptID_Variant();
			PatternList = new gamebbScriptID_Variant();
			RightArmLookAtLimitReached = new gamebbScriptID_Int32();
			TotalShotsFired = new gamebbScriptID_Int32();
			ShotsInBurstFired = new gamebbScriptID_Int32();
			DesiredNumberOfShots = new gamebbScriptID_Int32();
			NextShotTimeStamp = new gamebbScriptID_Float();
			ShotTimeStamp = new gamebbScriptID_Float();
			MaxChargedTimeStamp = new gamebbScriptID_Float();
			ChargeStartTimeStamp = new gamebbScriptID_Float();
			PauseConditionCheckTimeStamp = new gamebbScriptID_Float();
			LastChargeLevel = new gamebbScriptID_Float();
			FullyCharged = new gamebbScriptID_Bool();
			WeaponOverheated = new gamebbScriptID_Bool();
			RequestedTriggerMode = new gamebbScriptID_Int32();
			ShootingFromCar = new gamebbScriptID_Bool();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
