using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class communitySpawnPhase : ISerializable
	{
		[Ordinal(0)] 
		[RED("phaseName")] 
		public CName PhaseName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("appearances")] 
		public CArray<CName> Appearances
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(2)] 
		[RED("timePeriods")] 
		public CArray<communityPhaseTimePeriod> TimePeriods
		{
			get => GetPropertyValue<CArray<communityPhaseTimePeriod>>();
			set => SetPropertyValue<CArray<communityPhaseTimePeriod>>(value);
		}

		[Ordinal(3)] 
		[RED("alwaysSpawned")] 
		public CEnum<gameAlwaysSpawnedState> AlwaysSpawned
		{
			get => GetPropertyValue<CEnum<gameAlwaysSpawnedState>>();
			set => SetPropertyValue<CEnum<gameAlwaysSpawnedState>>(value);
		}

		[Ordinal(4)] 
		[RED("prefetchAppearance")] 
		public CBool PrefetchAppearance
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public communitySpawnPhase()
		{
			Appearances = new() { "default" };
			TimePeriods = new() { new communityPhaseTimePeriod { Quantity = 1, Markings = new(), SpotNodeRefs = new(), Categories = new() } };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
