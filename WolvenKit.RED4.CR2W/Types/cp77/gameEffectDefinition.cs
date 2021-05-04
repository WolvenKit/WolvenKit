using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameEffectDefinition : CVariable
	{
		private CName _tag;
		private CArray<CHandle<gameEffectObjectProvider>> _objectProviders;
		private CArray<CHandle<gameEffectObjectFilter>> _objectFilters;
		private CArray<CHandle<gameEffectExecutor>> _effectExecutors;
		private CArray<CHandle<gameEffectDurationModifier>> _durationModifiers;
		private CArray<CHandle<gameEffectPreAction>> _preActions;
		private CArray<CHandle<gameEffectPostAction>> _postActions;
		private CArray<CHandle<gameEffectAction>> _noTargetsActions;
		private gameEffectSettings _settings;
		private gameEffectDebugSettings _debugSettings;

		[Ordinal(0)] 
		[RED("tag")] 
		public CName Tag
		{
			get => GetProperty(ref _tag);
			set => SetProperty(ref _tag, value);
		}

		[Ordinal(1)] 
		[RED("objectProviders")] 
		public CArray<CHandle<gameEffectObjectProvider>> ObjectProviders
		{
			get => GetProperty(ref _objectProviders);
			set => SetProperty(ref _objectProviders, value);
		}

		[Ordinal(2)] 
		[RED("objectFilters")] 
		public CArray<CHandle<gameEffectObjectFilter>> ObjectFilters
		{
			get => GetProperty(ref _objectFilters);
			set => SetProperty(ref _objectFilters, value);
		}

		[Ordinal(3)] 
		[RED("effectExecutors")] 
		public CArray<CHandle<gameEffectExecutor>> EffectExecutors
		{
			get => GetProperty(ref _effectExecutors);
			set => SetProperty(ref _effectExecutors, value);
		}

		[Ordinal(4)] 
		[RED("durationModifiers")] 
		public CArray<CHandle<gameEffectDurationModifier>> DurationModifiers
		{
			get => GetProperty(ref _durationModifiers);
			set => SetProperty(ref _durationModifiers, value);
		}

		[Ordinal(5)] 
		[RED("preActions")] 
		public CArray<CHandle<gameEffectPreAction>> PreActions
		{
			get => GetProperty(ref _preActions);
			set => SetProperty(ref _preActions, value);
		}

		[Ordinal(6)] 
		[RED("postActions")] 
		public CArray<CHandle<gameEffectPostAction>> PostActions
		{
			get => GetProperty(ref _postActions);
			set => SetProperty(ref _postActions, value);
		}

		[Ordinal(7)] 
		[RED("noTargetsActions")] 
		public CArray<CHandle<gameEffectAction>> NoTargetsActions
		{
			get => GetProperty(ref _noTargetsActions);
			set => SetProperty(ref _noTargetsActions, value);
		}

		[Ordinal(8)] 
		[RED("settings")] 
		public gameEffectSettings Settings
		{
			get => GetProperty(ref _settings);
			set => SetProperty(ref _settings, value);
		}

		[Ordinal(9)] 
		[RED("debugSettings")] 
		public gameEffectDebugSettings DebugSettings
		{
			get => GetProperty(ref _debugSettings);
			set => SetProperty(ref _debugSettings, value);
		}

		public gameEffectDefinition(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
