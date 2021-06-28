using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AIShootingDataDef : AIBlackboardDef
	{
		private gamebbScriptID_Variant _shootingPatternPackage;
		private gamebbScriptID_Variant _shootingPattern;
		private gamebbScriptID_Variant _patternList;
		private gamebbScriptID_Int32 _rightArmLookAtLimitReached;
		private gamebbScriptID_Int32 _totalShotsFired;
		private gamebbScriptID_Int32 _shotsInBurstFired;
		private gamebbScriptID_Int32 _desiredNumberOfShots;
		private gamebbScriptID_Float _nextShotTimeStamp;
		private gamebbScriptID_Float _shotTimeStamp;
		private gamebbScriptID_Float _maxChargedTimeStamp;
		private gamebbScriptID_Float _chargeStartTimeStamp;
		private gamebbScriptID_Bool _fullyCharged;
		private gamebbScriptID_Bool _weaponOverheated;
		private gamebbScriptID_Int32 _requestedTriggerMode;

		[Ordinal(0)] 
		[RED("shootingPatternPackage")] 
		public gamebbScriptID_Variant ShootingPatternPackage
		{
			get => GetProperty(ref _shootingPatternPackage);
			set => SetProperty(ref _shootingPatternPackage, value);
		}

		[Ordinal(1)] 
		[RED("shootingPattern")] 
		public gamebbScriptID_Variant ShootingPattern
		{
			get => GetProperty(ref _shootingPattern);
			set => SetProperty(ref _shootingPattern, value);
		}

		[Ordinal(2)] 
		[RED("patternList")] 
		public gamebbScriptID_Variant PatternList
		{
			get => GetProperty(ref _patternList);
			set => SetProperty(ref _patternList, value);
		}

		[Ordinal(3)] 
		[RED("rightArmLookAtLimitReached")] 
		public gamebbScriptID_Int32 RightArmLookAtLimitReached
		{
			get => GetProperty(ref _rightArmLookAtLimitReached);
			set => SetProperty(ref _rightArmLookAtLimitReached, value);
		}

		[Ordinal(4)] 
		[RED("totalShotsFired")] 
		public gamebbScriptID_Int32 TotalShotsFired
		{
			get => GetProperty(ref _totalShotsFired);
			set => SetProperty(ref _totalShotsFired, value);
		}

		[Ordinal(5)] 
		[RED("shotsInBurstFired")] 
		public gamebbScriptID_Int32 ShotsInBurstFired
		{
			get => GetProperty(ref _shotsInBurstFired);
			set => SetProperty(ref _shotsInBurstFired, value);
		}

		[Ordinal(6)] 
		[RED("desiredNumberOfShots")] 
		public gamebbScriptID_Int32 DesiredNumberOfShots
		{
			get => GetProperty(ref _desiredNumberOfShots);
			set => SetProperty(ref _desiredNumberOfShots, value);
		}

		[Ordinal(7)] 
		[RED("nextShotTimeStamp")] 
		public gamebbScriptID_Float NextShotTimeStamp
		{
			get => GetProperty(ref _nextShotTimeStamp);
			set => SetProperty(ref _nextShotTimeStamp, value);
		}

		[Ordinal(8)] 
		[RED("shotTimeStamp")] 
		public gamebbScriptID_Float ShotTimeStamp
		{
			get => GetProperty(ref _shotTimeStamp);
			set => SetProperty(ref _shotTimeStamp, value);
		}

		[Ordinal(9)] 
		[RED("maxChargedTimeStamp")] 
		public gamebbScriptID_Float MaxChargedTimeStamp
		{
			get => GetProperty(ref _maxChargedTimeStamp);
			set => SetProperty(ref _maxChargedTimeStamp, value);
		}

		[Ordinal(10)] 
		[RED("chargeStartTimeStamp")] 
		public gamebbScriptID_Float ChargeStartTimeStamp
		{
			get => GetProperty(ref _chargeStartTimeStamp);
			set => SetProperty(ref _chargeStartTimeStamp, value);
		}

		[Ordinal(11)] 
		[RED("fullyCharged")] 
		public gamebbScriptID_Bool FullyCharged
		{
			get => GetProperty(ref _fullyCharged);
			set => SetProperty(ref _fullyCharged, value);
		}

		[Ordinal(12)] 
		[RED("weaponOverheated")] 
		public gamebbScriptID_Bool WeaponOverheated
		{
			get => GetProperty(ref _weaponOverheated);
			set => SetProperty(ref _weaponOverheated, value);
		}

		[Ordinal(13)] 
		[RED("requestedTriggerMode")] 
		public gamebbScriptID_Int32 RequestedTriggerMode
		{
			get => GetProperty(ref _requestedTriggerMode);
			set => SetProperty(ref _requestedTriggerMode, value);
		}

		public AIShootingDataDef(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
