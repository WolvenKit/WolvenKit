using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SceneTierIIEvents : SceneTierAbstractEvents
	{
		private CFloat _cachedSpeedValue;
		private CHandle<gameStatModifierData> _maxSpeedStat;
		private CEnum<Tier2WalkType> _currentSpeedMovementPreset;
		private CFloat _currentSpeedValue;
		private CName _currentLocomotionState;

		[Ordinal(0)] 
		[RED("cachedSpeedValue")] 
		public CFloat CachedSpeedValue
		{
			get
			{
				if (_cachedSpeedValue == null)
				{
					_cachedSpeedValue = (CFloat) CR2WTypeManager.Create("Float", "cachedSpeedValue", cr2w, this);
				}
				return _cachedSpeedValue;
			}
			set
			{
				if (_cachedSpeedValue == value)
				{
					return;
				}
				_cachedSpeedValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(1)] 
		[RED("maxSpeedStat")] 
		public CHandle<gameStatModifierData> MaxSpeedStat
		{
			get
			{
				if (_maxSpeedStat == null)
				{
					_maxSpeedStat = (CHandle<gameStatModifierData>) CR2WTypeManager.Create("handle:gameStatModifierData", "maxSpeedStat", cr2w, this);
				}
				return _maxSpeedStat;
			}
			set
			{
				if (_maxSpeedStat == value)
				{
					return;
				}
				_maxSpeedStat = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("currentSpeedMovementPreset")] 
		public CEnum<Tier2WalkType> CurrentSpeedMovementPreset
		{
			get
			{
				if (_currentSpeedMovementPreset == null)
				{
					_currentSpeedMovementPreset = (CEnum<Tier2WalkType>) CR2WTypeManager.Create("Tier2WalkType", "currentSpeedMovementPreset", cr2w, this);
				}
				return _currentSpeedMovementPreset;
			}
			set
			{
				if (_currentSpeedMovementPreset == value)
				{
					return;
				}
				_currentSpeedMovementPreset = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("currentSpeedValue")] 
		public CFloat CurrentSpeedValue
		{
			get
			{
				if (_currentSpeedValue == null)
				{
					_currentSpeedValue = (CFloat) CR2WTypeManager.Create("Float", "currentSpeedValue", cr2w, this);
				}
				return _currentSpeedValue;
			}
			set
			{
				if (_currentSpeedValue == value)
				{
					return;
				}
				_currentSpeedValue = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("currentLocomotionState")] 
		public CName CurrentLocomotionState
		{
			get
			{
				if (_currentLocomotionState == null)
				{
					_currentLocomotionState = (CName) CR2WTypeManager.Create("CName", "currentLocomotionState", cr2w, this);
				}
				return _currentLocomotionState;
			}
			set
			{
				if (_currentLocomotionState == value)
				{
					return;
				}
				_currentLocomotionState = value;
				PropertySet(this);
			}
		}

		public SceneTierIIEvents(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
