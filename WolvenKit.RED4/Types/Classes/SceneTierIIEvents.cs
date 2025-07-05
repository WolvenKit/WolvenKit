using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class SceneTierIIEvents : SceneTierAbstractEvents
	{
		[Ordinal(0)] 
		[RED("cachedSpeedValue")] 
		public CFloat CachedSpeedValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(1)] 
		[RED("maxSpeedStat")] 
		public CHandle<gameStatModifierData_Deprecated> MaxSpeedStat
		{
			get => GetPropertyValue<CHandle<gameStatModifierData_Deprecated>>();
			set => SetPropertyValue<CHandle<gameStatModifierData_Deprecated>>(value);
		}

		[Ordinal(2)] 
		[RED("currentSpeedMovementPreset")] 
		public CEnum<Tier2WalkType> CurrentSpeedMovementPreset
		{
			get => GetPropertyValue<CEnum<Tier2WalkType>>();
			set => SetPropertyValue<CEnum<Tier2WalkType>>(value);
		}

		[Ordinal(3)] 
		[RED("currentSpeedValue")] 
		public CFloat CurrentSpeedValue
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(4)] 
		[RED("currentLocomotionState")] 
		public CName CurrentLocomotionState
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		public SceneTierIIEvents()
		{
			PostConstruct();
		}

		partial void PostConstruct();
	}
}
