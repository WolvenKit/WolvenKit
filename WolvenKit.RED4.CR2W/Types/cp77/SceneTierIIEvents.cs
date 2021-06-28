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
			get => GetProperty(ref _cachedSpeedValue);
			set => SetProperty(ref _cachedSpeedValue, value);
		}

		[Ordinal(1)] 
		[RED("maxSpeedStat")] 
		public CHandle<gameStatModifierData> MaxSpeedStat
		{
			get => GetProperty(ref _maxSpeedStat);
			set => SetProperty(ref _maxSpeedStat, value);
		}

		[Ordinal(2)] 
		[RED("currentSpeedMovementPreset")] 
		public CEnum<Tier2WalkType> CurrentSpeedMovementPreset
		{
			get => GetProperty(ref _currentSpeedMovementPreset);
			set => SetProperty(ref _currentSpeedMovementPreset, value);
		}

		[Ordinal(3)] 
		[RED("currentSpeedValue")] 
		public CFloat CurrentSpeedValue
		{
			get => GetProperty(ref _currentSpeedValue);
			set => SetProperty(ref _currentSpeedValue, value);
		}

		[Ordinal(4)] 
		[RED("currentLocomotionState")] 
		public CName CurrentLocomotionState
		{
			get => GetProperty(ref _currentLocomotionState);
			set => SetProperty(ref _currentLocomotionState, value);
		}

		public SceneTierIIEvents(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
