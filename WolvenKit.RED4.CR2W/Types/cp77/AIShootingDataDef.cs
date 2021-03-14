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
			get
			{
				if (_shootingPatternPackage == null)
				{
					_shootingPatternPackage = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "shootingPatternPackage", cr2w, this);
				}
				return _shootingPatternPackage;
			}
			set
			{
				if (_shootingPatternPackage == value)
				{
					return;
				}
				_shootingPatternPackage = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("shootingPattern")] 
		public gamebbScriptID_Variant ShootingPattern
		{
			get
			{
				if (_shootingPattern == null)
				{
					_shootingPattern = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "shootingPattern", cr2w, this);
				}
				return _shootingPattern;
			}
			set
			{
				if (_shootingPattern == value)
				{
					return;
				}
				_shootingPattern = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("patternList")] 
		public gamebbScriptID_Variant PatternList
		{
			get
			{
				if (_patternList == null)
				{
					_patternList = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "patternList", cr2w, this);
				}
				return _patternList;
			}
			set
			{
				if (_patternList == value)
				{
					return;
				}
				_patternList = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("rightArmLookAtLimitReached")] 
		public gamebbScriptID_Int32 RightArmLookAtLimitReached
		{
			get
			{
				if (_rightArmLookAtLimitReached == null)
				{
					_rightArmLookAtLimitReached = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "rightArmLookAtLimitReached", cr2w, this);
				}
				return _rightArmLookAtLimitReached;
			}
			set
			{
				if (_rightArmLookAtLimitReached == value)
				{
					return;
				}
				_rightArmLookAtLimitReached = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("totalShotsFired")] 
		public gamebbScriptID_Int32 TotalShotsFired
		{
			get
			{
				if (_totalShotsFired == null)
				{
					_totalShotsFired = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "totalShotsFired", cr2w, this);
				}
				return _totalShotsFired;
			}
			set
			{
				if (_totalShotsFired == value)
				{
					return;
				}
				_totalShotsFired = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("shotsInBurstFired")] 
		public gamebbScriptID_Int32 ShotsInBurstFired
		{
			get
			{
				if (_shotsInBurstFired == null)
				{
					_shotsInBurstFired = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "shotsInBurstFired", cr2w, this);
				}
				return _shotsInBurstFired;
			}
			set
			{
				if (_shotsInBurstFired == value)
				{
					return;
				}
				_shotsInBurstFired = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("desiredNumberOfShots")] 
		public gamebbScriptID_Int32 DesiredNumberOfShots
		{
			get
			{
				if (_desiredNumberOfShots == null)
				{
					_desiredNumberOfShots = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "desiredNumberOfShots", cr2w, this);
				}
				return _desiredNumberOfShots;
			}
			set
			{
				if (_desiredNumberOfShots == value)
				{
					return;
				}
				_desiredNumberOfShots = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("nextShotTimeStamp")] 
		public gamebbScriptID_Float NextShotTimeStamp
		{
			get
			{
				if (_nextShotTimeStamp == null)
				{
					_nextShotTimeStamp = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "nextShotTimeStamp", cr2w, this);
				}
				return _nextShotTimeStamp;
			}
			set
			{
				if (_nextShotTimeStamp == value)
				{
					return;
				}
				_nextShotTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("shotTimeStamp")] 
		public gamebbScriptID_Float ShotTimeStamp
		{
			get
			{
				if (_shotTimeStamp == null)
				{
					_shotTimeStamp = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "shotTimeStamp", cr2w, this);
				}
				return _shotTimeStamp;
			}
			set
			{
				if (_shotTimeStamp == value)
				{
					return;
				}
				_shotTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("maxChargedTimeStamp")] 
		public gamebbScriptID_Float MaxChargedTimeStamp
		{
			get
			{
				if (_maxChargedTimeStamp == null)
				{
					_maxChargedTimeStamp = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "maxChargedTimeStamp", cr2w, this);
				}
				return _maxChargedTimeStamp;
			}
			set
			{
				if (_maxChargedTimeStamp == value)
				{
					return;
				}
				_maxChargedTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("chargeStartTimeStamp")] 
		public gamebbScriptID_Float ChargeStartTimeStamp
		{
			get
			{
				if (_chargeStartTimeStamp == null)
				{
					_chargeStartTimeStamp = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "chargeStartTimeStamp", cr2w, this);
				}
				return _chargeStartTimeStamp;
			}
			set
			{
				if (_chargeStartTimeStamp == value)
				{
					return;
				}
				_chargeStartTimeStamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("fullyCharged")] 
		public gamebbScriptID_Bool FullyCharged
		{
			get
			{
				if (_fullyCharged == null)
				{
					_fullyCharged = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "fullyCharged", cr2w, this);
				}
				return _fullyCharged;
			}
			set
			{
				if (_fullyCharged == value)
				{
					return;
				}
				_fullyCharged = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("weaponOverheated")] 
		public gamebbScriptID_Bool WeaponOverheated
		{
			get
			{
				if (_weaponOverheated == null)
				{
					_weaponOverheated = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "weaponOverheated", cr2w, this);
				}
				return _weaponOverheated;
			}
			set
			{
				if (_weaponOverheated == value)
				{
					return;
				}
				_weaponOverheated = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("requestedTriggerMode")] 
		public gamebbScriptID_Int32 RequestedTriggerMode
		{
			get
			{
				if (_requestedTriggerMode == null)
				{
					_requestedTriggerMode = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "requestedTriggerMode", cr2w, this);
				}
				return _requestedTriggerMode;
			}
			set
			{
				if (_requestedTriggerMode == value)
				{
					return;
				}
				_requestedTriggerMode = value;
				PropertySet(this);
			}
		}

		public AIShootingDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
