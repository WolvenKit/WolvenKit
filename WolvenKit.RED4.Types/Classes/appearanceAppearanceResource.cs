using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class appearanceAppearanceResource : resStreamedResource
	{
		private CName _baseType;
		private CName _baseEntityType;
		private CResourceAsyncReference<entEntityTemplate> _baseEntity;
		private CName _partType;
		private CName _preset;
		private CName _alternateAppearanceSettingName;
		private CArray<CName> _alternateAppearanceSuffixes;
		private CArray<appearanceAlternateAppearanceEntry> _alternateAppearanceMapping;
		private CArray<CHandle<appearanceAppearanceDefinition>> _appearances;
		private CArray<appearanceCensorshipEntry> _censorshipMapping;
		private CResourceAsyncReference<appearanceCookedAppearanceData> _commonCookData;
		private CArray<CHandle<entdismembermentWoundResource>> _wounds;
		private CArray<CHandle<entdismembermentEffectResource>> _dismEffects;
		private entdismembermentWoundsConfigSet _dismWoundConfig;
		private CInt32 _proxyPolyCount;
		private CBool _forceCompileProxy;
		private CBool _generatePlayerBlockingCollisionForProxy;

		[Ordinal(1)] 
		[RED("baseType")] 
		public CName BaseType
		{
			get => GetProperty(ref _baseType);
			set => SetProperty(ref _baseType, value);
		}

		[Ordinal(2)] 
		[RED("baseEntityType")] 
		public CName BaseEntityType
		{
			get => GetProperty(ref _baseEntityType);
			set => SetProperty(ref _baseEntityType, value);
		}

		[Ordinal(3)] 
		[RED("baseEntity")] 
		public CResourceAsyncReference<entEntityTemplate> BaseEntity
		{
			get => GetProperty(ref _baseEntity);
			set => SetProperty(ref _baseEntity, value);
		}

		[Ordinal(4)] 
		[RED("partType")] 
		public CName PartType
		{
			get => GetProperty(ref _partType);
			set => SetProperty(ref _partType, value);
		}

		[Ordinal(5)] 
		[RED("preset")] 
		public CName Preset
		{
			get => GetProperty(ref _preset);
			set => SetProperty(ref _preset, value);
		}

		[Ordinal(6)] 
		[RED("alternateAppearanceSettingName")] 
		public CName AlternateAppearanceSettingName
		{
			get => GetProperty(ref _alternateAppearanceSettingName);
			set => SetProperty(ref _alternateAppearanceSettingName, value);
		}

		[Ordinal(7)] 
		[RED("alternateAppearanceSuffixes")] 
		public CArray<CName> AlternateAppearanceSuffixes
		{
			get => GetProperty(ref _alternateAppearanceSuffixes);
			set => SetProperty(ref _alternateAppearanceSuffixes, value);
		}

		[Ordinal(8)] 
		[RED("alternateAppearanceMapping")] 
		public CArray<appearanceAlternateAppearanceEntry> AlternateAppearanceMapping
		{
			get => GetProperty(ref _alternateAppearanceMapping);
			set => SetProperty(ref _alternateAppearanceMapping, value);
		}

		[Ordinal(9)] 
		[RED("appearances")] 
		public CArray<CHandle<appearanceAppearanceDefinition>> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(10)] 
		[RED("censorshipMapping")] 
		public CArray<appearanceCensorshipEntry> CensorshipMapping
		{
			get => GetProperty(ref _censorshipMapping);
			set => SetProperty(ref _censorshipMapping, value);
		}

		[Ordinal(11)] 
		[RED("commonCookData")] 
		public CResourceAsyncReference<appearanceCookedAppearanceData> CommonCookData
		{
			get => GetProperty(ref _commonCookData);
			set => SetProperty(ref _commonCookData, value);
		}

		[Ordinal(12)] 
		[RED("Wounds")] 
		public CArray<CHandle<entdismembermentWoundResource>> Wounds
		{
			get => GetProperty(ref _wounds);
			set => SetProperty(ref _wounds, value);
		}

		[Ordinal(13)] 
		[RED("DismEffects")] 
		public CArray<CHandle<entdismembermentEffectResource>> DismEffects
		{
			get => GetProperty(ref _dismEffects);
			set => SetProperty(ref _dismEffects, value);
		}

		[Ordinal(14)] 
		[RED("DismWoundConfig")] 
		public entdismembermentWoundsConfigSet DismWoundConfig
		{
			get => GetProperty(ref _dismWoundConfig);
			set => SetProperty(ref _dismWoundConfig, value);
		}

		[Ordinal(15)] 
		[RED("proxyPolyCount")] 
		public CInt32 ProxyPolyCount
		{
			get => GetProperty(ref _proxyPolyCount);
			set => SetProperty(ref _proxyPolyCount, value);
		}

		[Ordinal(16)] 
		[RED("forceCompileProxy")] 
		public CBool ForceCompileProxy
		{
			get => GetProperty(ref _forceCompileProxy);
			set => SetProperty(ref _forceCompileProxy, value);
		}

		[Ordinal(17)] 
		[RED("generatePlayerBlockingCollisionForProxy")] 
		public CBool GeneratePlayerBlockingCollisionForProxy
		{
			get => GetProperty(ref _generatePlayerBlockingCollisionForProxy);
			set => SetProperty(ref _generatePlayerBlockingCollisionForProxy, value);
		}

		public appearanceAppearanceResource()
		{
			_proxyPolyCount = 1400;
		}
	}
}
