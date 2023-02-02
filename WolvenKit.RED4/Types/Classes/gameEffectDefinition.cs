using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameEffectDefinition : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("objectProviders")] 
		public CArray<CHandle<gameEffectObjectProvider>> ObjectProviders
		{
			get => GetPropertyValue<CArray<CHandle<gameEffectObjectProvider>>>();
			set => SetPropertyValue<CArray<CHandle<gameEffectObjectProvider>>>(value);
		}

		[Ordinal(2)] 
		[RED("objectFilters")] 
		public CArray<CHandle<gameEffectObjectFilter>> ObjectFilters
		{
			get => GetPropertyValue<CArray<CHandle<gameEffectObjectFilter>>>();
			set => SetPropertyValue<CArray<CHandle<gameEffectObjectFilter>>>(value);
		}

		[Ordinal(3)] 
		[RED("effectExecutors")] 
		public CArray<CHandle<gameEffectExecutor>> EffectExecutors
		{
			get => GetPropertyValue<CArray<CHandle<gameEffectExecutor>>>();
			set => SetPropertyValue<CArray<CHandle<gameEffectExecutor>>>(value);
		}

		[Ordinal(4)] 
		[RED("durationModifiers")] 
		public CArray<CHandle<gameEffectDurationModifier>> DurationModifiers
		{
			get => GetPropertyValue<CArray<CHandle<gameEffectDurationModifier>>>();
			set => SetPropertyValue<CArray<CHandle<gameEffectDurationModifier>>>(value);
		}

		[Ordinal(5)] 
		[RED("preActions")] 
		public CArray<CHandle<gameEffectPreAction>> PreActions
		{
			get => GetPropertyValue<CArray<CHandle<gameEffectPreAction>>>();
			set => SetPropertyValue<CArray<CHandle<gameEffectPreAction>>>(value);
		}

		[Ordinal(6)] 
		[RED("postActions")] 
		public CArray<CHandle<gameEffectPostAction>> PostActions
		{
			get => GetPropertyValue<CArray<CHandle<gameEffectPostAction>>>();
			set => SetPropertyValue<CArray<CHandle<gameEffectPostAction>>>(value);
		}

		[Ordinal(7)] 
		[RED("noTargetsActions")] 
		public CArray<CHandle<gameEffectAction>> NoTargetsActions
		{
			get => GetPropertyValue<CArray<CHandle<gameEffectAction>>>();
			set => SetPropertyValue<CArray<CHandle<gameEffectAction>>>(value);
		}

		[Ordinal(8)] 
		[RED("settings")] 
		public gameEffectSettings Settings
		{
			get => GetPropertyValue<gameEffectSettings>();
			set => SetPropertyValue<gameEffectSettings>(value);
		}

		[Ordinal(9)] 
		[RED("debugSettings")] 
		public gameEffectDebugSettings DebugSettings
		{
			get => GetPropertyValue<gameEffectDebugSettings>();
			set => SetPropertyValue<gameEffectDebugSettings>(value);
		}

		public gameEffectDefinition()
		{
			ObjectProviders = new();
			ObjectFilters = new();
			EffectExecutors = new();
			DurationModifiers = new();
			PreActions = new();
			PostActions = new();
			NoTargetsActions = new();
			Settings = new();
			DebugSettings = new() { Duration = 1.000000F, Color = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
