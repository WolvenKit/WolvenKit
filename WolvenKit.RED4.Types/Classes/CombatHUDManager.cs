using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CombatHUDManager : gameScriptableComponent
	{
		[Ordinal(5)] 
		[RED("isRunning")] 
		public CBool IsRunning
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(6)] 
		[RED("targets")] 
		public CArray<CombatTarget> Targets
		{
			get => GetPropertyValue<CArray<CombatTarget>>();
			set => SetPropertyValue<CArray<CombatTarget>>(value);
		}

		[Ordinal(7)] 
		[RED("interval")] 
		public CFloat Interval
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		[Ordinal(8)] 
		[RED("timeSinceLastUpdate")] 
		public CFloat TimeSinceLastUpdate
		{
			get => GetPropertyValue<CFloat>();
			set => SetPropertyValue<CFloat>(value);
		}

		public CombatHUDManager()
		{
			Targets = new();
			Interval = 1.000000F;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
