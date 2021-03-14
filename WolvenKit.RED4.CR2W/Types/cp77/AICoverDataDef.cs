using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AICoverDataDef : AIBlackboardDef
	{
		private gamebbScriptID_CName _exposureMethod;
		private gamebbScriptID_Bool _currentlyExposed;
		private gamebbScriptID_Variant _commandExposureMethods;
		private gamebbScriptID_Bool _commandCoverOverride;
		private gamebbScriptID_CName _currentCoverStance;
		private gamebbScriptID_CName _desiredCoverStance;
		private gamebbScriptID_CName _lastCoverPreset;
		private gamebbScriptID_CName _lastInitialCoverPreset;
		private gamebbScriptID_Float _lastCoverChangeThreshold;
		private gamebbScriptID_Float _lastVisibilityCheckTimestamp;
		private gamebbScriptID_Variant _currentRing;
		private gamebbScriptID_Variant _lastCoverRing;
		private gamebbScriptID_Int32 _lastDebugCoverPreset;
		private gamebbScriptID_Bool _firstCoverEvaluationDone;

		[Ordinal(0)] 
		[RED("exposureMethod")] 
		public gamebbScriptID_CName ExposureMethod
		{
			get
			{
				if (_exposureMethod == null)
				{
					_exposureMethod = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "exposureMethod", cr2w, this);
				}
				return _exposureMethod;
			}
			set
			{
				if (_exposureMethod == value)
				{
					return;
				}
				_exposureMethod = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("currentlyExposed")] 
		public gamebbScriptID_Bool CurrentlyExposed
		{
			get
			{
				if (_currentlyExposed == null)
				{
					_currentlyExposed = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "currentlyExposed", cr2w, this);
				}
				return _currentlyExposed;
			}
			set
			{
				if (_currentlyExposed == value)
				{
					return;
				}
				_currentlyExposed = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("commandExposureMethods")] 
		public gamebbScriptID_Variant CommandExposureMethods
		{
			get
			{
				if (_commandExposureMethods == null)
				{
					_commandExposureMethods = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "commandExposureMethods", cr2w, this);
				}
				return _commandExposureMethods;
			}
			set
			{
				if (_commandExposureMethods == value)
				{
					return;
				}
				_commandExposureMethods = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("commandCoverOverride")] 
		public gamebbScriptID_Bool CommandCoverOverride
		{
			get
			{
				if (_commandCoverOverride == null)
				{
					_commandCoverOverride = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "commandCoverOverride", cr2w, this);
				}
				return _commandCoverOverride;
			}
			set
			{
				if (_commandCoverOverride == value)
				{
					return;
				}
				_commandCoverOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentCoverStance")] 
		public gamebbScriptID_CName CurrentCoverStance
		{
			get
			{
				if (_currentCoverStance == null)
				{
					_currentCoverStance = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "currentCoverStance", cr2w, this);
				}
				return _currentCoverStance;
			}
			set
			{
				if (_currentCoverStance == value)
				{
					return;
				}
				_currentCoverStance = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("desiredCoverStance")] 
		public gamebbScriptID_CName DesiredCoverStance
		{
			get
			{
				if (_desiredCoverStance == null)
				{
					_desiredCoverStance = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "desiredCoverStance", cr2w, this);
				}
				return _desiredCoverStance;
			}
			set
			{
				if (_desiredCoverStance == value)
				{
					return;
				}
				_desiredCoverStance = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("lastCoverPreset")] 
		public gamebbScriptID_CName LastCoverPreset
		{
			get
			{
				if (_lastCoverPreset == null)
				{
					_lastCoverPreset = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "lastCoverPreset", cr2w, this);
				}
				return _lastCoverPreset;
			}
			set
			{
				if (_lastCoverPreset == value)
				{
					return;
				}
				_lastCoverPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("lastInitialCoverPreset")] 
		public gamebbScriptID_CName LastInitialCoverPreset
		{
			get
			{
				if (_lastInitialCoverPreset == null)
				{
					_lastInitialCoverPreset = (gamebbScriptID_CName) CR2WTypeManager.Create("gamebbScriptID_CName", "lastInitialCoverPreset", cr2w, this);
				}
				return _lastInitialCoverPreset;
			}
			set
			{
				if (_lastInitialCoverPreset == value)
				{
					return;
				}
				_lastInitialCoverPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("lastCoverChangeThreshold")] 
		public gamebbScriptID_Float LastCoverChangeThreshold
		{
			get
			{
				if (_lastCoverChangeThreshold == null)
				{
					_lastCoverChangeThreshold = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "lastCoverChangeThreshold", cr2w, this);
				}
				return _lastCoverChangeThreshold;
			}
			set
			{
				if (_lastCoverChangeThreshold == value)
				{
					return;
				}
				_lastCoverChangeThreshold = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("lastVisibilityCheckTimestamp")] 
		public gamebbScriptID_Float LastVisibilityCheckTimestamp
		{
			get
			{
				if (_lastVisibilityCheckTimestamp == null)
				{
					_lastVisibilityCheckTimestamp = (gamebbScriptID_Float) CR2WTypeManager.Create("gamebbScriptID_Float", "lastVisibilityCheckTimestamp", cr2w, this);
				}
				return _lastVisibilityCheckTimestamp;
			}
			set
			{
				if (_lastVisibilityCheckTimestamp == value)
				{
					return;
				}
				_lastVisibilityCheckTimestamp = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("currentRing")] 
		public gamebbScriptID_Variant CurrentRing
		{
			get
			{
				if (_currentRing == null)
				{
					_currentRing = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "currentRing", cr2w, this);
				}
				return _currentRing;
			}
			set
			{
				if (_currentRing == value)
				{
					return;
				}
				_currentRing = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("lastCoverRing")] 
		public gamebbScriptID_Variant LastCoverRing
		{
			get
			{
				if (_lastCoverRing == null)
				{
					_lastCoverRing = (gamebbScriptID_Variant) CR2WTypeManager.Create("gamebbScriptID_Variant", "lastCoverRing", cr2w, this);
				}
				return _lastCoverRing;
			}
			set
			{
				if (_lastCoverRing == value)
				{
					return;
				}
				_lastCoverRing = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("lastDebugCoverPreset")] 
		public gamebbScriptID_Int32 LastDebugCoverPreset
		{
			get
			{
				if (_lastDebugCoverPreset == null)
				{
					_lastDebugCoverPreset = (gamebbScriptID_Int32) CR2WTypeManager.Create("gamebbScriptID_Int32", "lastDebugCoverPreset", cr2w, this);
				}
				return _lastDebugCoverPreset;
			}
			set
			{
				if (_lastDebugCoverPreset == value)
				{
					return;
				}
				_lastDebugCoverPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("firstCoverEvaluationDone")] 
		public gamebbScriptID_Bool FirstCoverEvaluationDone
		{
			get
			{
				if (_firstCoverEvaluationDone == null)
				{
					_firstCoverEvaluationDone = (gamebbScriptID_Bool) CR2WTypeManager.Create("gamebbScriptID_Bool", "firstCoverEvaluationDone", cr2w, this);
				}
				return _firstCoverEvaluationDone;
			}
			set
			{
				if (_firstCoverEvaluationDone == value)
				{
					return;
				}
				_firstCoverEvaluationDone = value;
				PropertySet(this);
			}
		}

		public AICoverDataDef(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
