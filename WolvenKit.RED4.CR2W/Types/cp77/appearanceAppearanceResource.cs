using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceAppearanceResource : resStreamedResource
	{
		private CName _baseType;
		private CName _baseEntityType;
		private raRef<entEntityTemplate> _baseEntity;
		private CName _partType;
		private CName _preset;
		private CArray<CHandle<appearanceAppearanceDefinition>> _appearances;
		private CArray<appearanceCensorshipEntry> _censorshipMapping;
		private raRef<appearanceCookedAppearanceData> _commonCookData;
		private CArray<CHandle<entdismembermentWoundResource>> _wounds;
		private CArray<CHandle<entdismembermentEffectResource>> _dismEffects;
		private entdismembermentWoundsConfigSet _dismWoundConfig;
		private CInt32 _proxyPolyCount;
		private CBool _forceCompileProxy;

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
		public raRef<entEntityTemplate> BaseEntity
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
		[RED("appearances")] 
		public CArray<CHandle<appearanceAppearanceDefinition>> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(7)] 
		[RED("censorshipMapping")] 
		public CArray<appearanceCensorshipEntry> CensorshipMapping
		{
			get => GetProperty(ref _censorshipMapping);
			set => SetProperty(ref _censorshipMapping, value);
		}

		[Ordinal(8)] 
		[RED("commonCookData")] 
		public raRef<appearanceCookedAppearanceData> CommonCookData
		{
			get => GetProperty(ref _commonCookData);
			set => SetProperty(ref _commonCookData, value);
		}

		[Ordinal(9)] 
		[RED("Wounds")] 
		public CArray<CHandle<entdismembermentWoundResource>> Wounds
		{
			get => GetProperty(ref _wounds);
			set => SetProperty(ref _wounds, value);
		}

		[Ordinal(10)] 
		[RED("DismEffects")] 
		public CArray<CHandle<entdismembermentEffectResource>> DismEffects
		{
			get => GetProperty(ref _dismEffects);
			set => SetProperty(ref _dismEffects, value);
		}

		[Ordinal(11)] 
		[RED("DismWoundConfig")] 
		public entdismembermentWoundsConfigSet DismWoundConfig
		{
			get => GetProperty(ref _dismWoundConfig);
			set => SetProperty(ref _dismWoundConfig, value);
		}

		[Ordinal(12)] 
		[RED("proxyPolyCount")] 
		public CInt32 ProxyPolyCount
		{
			get => GetProperty(ref _proxyPolyCount);
			set => SetProperty(ref _proxyPolyCount, value);
		}

		[Ordinal(13)] 
		[RED("forceCompileProxy")] 
		public CBool ForceCompileProxy
		{
			get => GetProperty(ref _forceCompileProxy);
			set => SetProperty(ref _forceCompileProxy, value);
		}

		public appearanceAppearanceResource(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
