using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class appearanceAppearanceResource : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("alternateAppearanceSettingName")] 
		public CName AlternateAppearanceSettingName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("alternateAppearanceSuffixes")] 
		public CArray<CName> AlternateAppearanceSuffixes
		{
			get => GetPropertyValue<CArray<CName>>();
			set => SetPropertyValue<CArray<CName>>(value);
		}

		[Ordinal(3)] 
		[RED("alternateAppearanceMapping")] 
		public CArray<appearanceAlternateAppearanceEntry> AlternateAppearanceMapping
		{
			get => GetPropertyValue<CArray<appearanceAlternateAppearanceEntry>>();
			set => SetPropertyValue<CArray<appearanceAlternateAppearanceEntry>>(value);
		}

		[Ordinal(4)] 
		[RED("censorshipMapping")] 
		public CArray<appearanceCensorshipEntry> CensorshipMapping
		{
			get => GetPropertyValue<CArray<appearanceCensorshipEntry>>();
			set => SetPropertyValue<CArray<appearanceCensorshipEntry>>(value);
		}

		[Ordinal(5)] 
		[RED("Wounds")] 
		public CArray<CHandle<entdismembermentWoundResource>> Wounds
		{
			get => GetPropertyValue<CArray<CHandle<entdismembermentWoundResource>>>();
			set => SetPropertyValue<CArray<CHandle<entdismembermentWoundResource>>>(value);
		}

		[Ordinal(6)] 
		[RED("DismEffects")] 
		public CArray<CHandle<entdismembermentEffectResource>> DismEffects
		{
			get => GetPropertyValue<CArray<CHandle<entdismembermentEffectResource>>>();
			set => SetPropertyValue<CArray<CHandle<entdismembermentEffectResource>>>(value);
		}

		[Ordinal(7)] 
		[RED("DismWoundConfig")] 
		public entdismembermentWoundsConfigSet DismWoundConfig
		{
			get => GetPropertyValue<entdismembermentWoundsConfigSet>();
			set => SetPropertyValue<entdismembermentWoundsConfigSet>(value);
		}

		[Ordinal(8)] 
		[RED("baseType")] 
		public CName BaseType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(9)] 
		[RED("baseEntityType")] 
		public CName BaseEntityType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("baseEntity")] 
		public CResourceAsyncReference<entEntityTemplate> BaseEntity
		{
			get => GetPropertyValue<CResourceAsyncReference<entEntityTemplate>>();
			set => SetPropertyValue<CResourceAsyncReference<entEntityTemplate>>(value);
		}

		[Ordinal(11)] 
		[RED("partType")] 
		public CName PartType
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(12)] 
		[RED("preset")] 
		public CName Preset
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(13)] 
		[RED("appearances")] 
		public CArray<CHandle<appearanceAppearanceDefinition>> Appearances
		{
			get => GetPropertyValue<CArray<CHandle<appearanceAppearanceDefinition>>>();
			set => SetPropertyValue<CArray<CHandle<appearanceAppearanceDefinition>>>(value);
		}

		[Ordinal(14)] 
		[RED("commonCookData")] 
		public CResourceAsyncReference<appearanceCookedAppearanceData> CommonCookData
		{
			get => GetPropertyValue<CResourceAsyncReference<appearanceCookedAppearanceData>>();
			set => SetPropertyValue<CResourceAsyncReference<appearanceCookedAppearanceData>>(value);
		}

		[Ordinal(15)] 
		[RED("proxyPolyCount")] 
		public CInt32 ProxyPolyCount
		{
			get => GetPropertyValue<CInt32>();
			set => SetPropertyValue<CInt32>(value);
		}

		[Ordinal(16)] 
		[RED("forceCompileProxy")] 
		public CBool ForceCompileProxy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		[Ordinal(17)] 
		[RED("generatePlayerBlockingCollisionForProxy")] 
		public CBool GeneratePlayerBlockingCollisionForProxy
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public appearanceAppearanceResource()
		{
			AlternateAppearanceSuffixes = new();
			AlternateAppearanceMapping = new();
			CensorshipMapping = new();
			Wounds = new();
			DismEffects = new();
			DismWoundConfig = new entdismembermentWoundsConfigSet { Configs = new() };
			Appearances = new();
			ProxyPolyCount = 1400;

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
