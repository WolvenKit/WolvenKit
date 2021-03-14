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
			get
			{
				if (_baseType == null)
				{
					_baseType = (CName) CR2WTypeManager.Create("CName", "baseType", cr2w, this);
				}
				return _baseType;
			}
			set
			{
				if (_baseType == value)
				{
					return;
				}
				_baseType = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("baseEntityType")] 
		public CName BaseEntityType
		{
			get
			{
				if (_baseEntityType == null)
				{
					_baseEntityType = (CName) CR2WTypeManager.Create("CName", "baseEntityType", cr2w, this);
				}
				return _baseEntityType;
			}
			set
			{
				if (_baseEntityType == value)
				{
					return;
				}
				_baseEntityType = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("baseEntity")] 
		public raRef<entEntityTemplate> BaseEntity
		{
			get
			{
				if (_baseEntity == null)
				{
					_baseEntity = (raRef<entEntityTemplate>) CR2WTypeManager.Create("raRef:entEntityTemplate", "baseEntity", cr2w, this);
				}
				return _baseEntity;
			}
			set
			{
				if (_baseEntity == value)
				{
					return;
				}
				_baseEntity = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("partType")] 
		public CName PartType
		{
			get
			{
				if (_partType == null)
				{
					_partType = (CName) CR2WTypeManager.Create("CName", "partType", cr2w, this);
				}
				return _partType;
			}
			set
			{
				if (_partType == value)
				{
					return;
				}
				_partType = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("preset")] 
		public CName Preset
		{
			get
			{
				if (_preset == null)
				{
					_preset = (CName) CR2WTypeManager.Create("CName", "preset", cr2w, this);
				}
				return _preset;
			}
			set
			{
				if (_preset == value)
				{
					return;
				}
				_preset = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("appearances")] 
		public CArray<CHandle<appearanceAppearanceDefinition>> Appearances
		{
			get
			{
				if (_appearances == null)
				{
					_appearances = (CArray<CHandle<appearanceAppearanceDefinition>>) CR2WTypeManager.Create("array:handle:appearanceAppearanceDefinition", "appearances", cr2w, this);
				}
				return _appearances;
			}
			set
			{
				if (_appearances == value)
				{
					return;
				}
				_appearances = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("censorshipMapping")] 
		public CArray<appearanceCensorshipEntry> CensorshipMapping
		{
			get
			{
				if (_censorshipMapping == null)
				{
					_censorshipMapping = (CArray<appearanceCensorshipEntry>) CR2WTypeManager.Create("array:appearanceCensorshipEntry", "censorshipMapping", cr2w, this);
				}
				return _censorshipMapping;
			}
			set
			{
				if (_censorshipMapping == value)
				{
					return;
				}
				_censorshipMapping = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("commonCookData")] 
		public raRef<appearanceCookedAppearanceData> CommonCookData
		{
			get
			{
				if (_commonCookData == null)
				{
					_commonCookData = (raRef<appearanceCookedAppearanceData>) CR2WTypeManager.Create("raRef:appearanceCookedAppearanceData", "commonCookData", cr2w, this);
				}
				return _commonCookData;
			}
			set
			{
				if (_commonCookData == value)
				{
					return;
				}
				_commonCookData = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("Wounds")] 
		public CArray<CHandle<entdismembermentWoundResource>> Wounds
		{
			get
			{
				if (_wounds == null)
				{
					_wounds = (CArray<CHandle<entdismembermentWoundResource>>) CR2WTypeManager.Create("array:handle:entdismembermentWoundResource", "Wounds", cr2w, this);
				}
				return _wounds;
			}
			set
			{
				if (_wounds == value)
				{
					return;
				}
				_wounds = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("DismEffects")] 
		public CArray<CHandle<entdismembermentEffectResource>> DismEffects
		{
			get
			{
				if (_dismEffects == null)
				{
					_dismEffects = (CArray<CHandle<entdismembermentEffectResource>>) CR2WTypeManager.Create("array:handle:entdismembermentEffectResource", "DismEffects", cr2w, this);
				}
				return _dismEffects;
			}
			set
			{
				if (_dismEffects == value)
				{
					return;
				}
				_dismEffects = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("DismWoundConfig")] 
		public entdismembermentWoundsConfigSet DismWoundConfig
		{
			get
			{
				if (_dismWoundConfig == null)
				{
					_dismWoundConfig = (entdismembermentWoundsConfigSet) CR2WTypeManager.Create("entdismembermentWoundsConfigSet", "DismWoundConfig", cr2w, this);
				}
				return _dismWoundConfig;
			}
			set
			{
				if (_dismWoundConfig == value)
				{
					return;
				}
				_dismWoundConfig = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("proxyPolyCount")] 
		public CInt32 ProxyPolyCount
		{
			get
			{
				if (_proxyPolyCount == null)
				{
					_proxyPolyCount = (CInt32) CR2WTypeManager.Create("Int32", "proxyPolyCount", cr2w, this);
				}
				return _proxyPolyCount;
			}
			set
			{
				if (_proxyPolyCount == value)
				{
					return;
				}
				_proxyPolyCount = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("forceCompileProxy")] 
		public CBool ForceCompileProxy
		{
			get
			{
				if (_forceCompileProxy == null)
				{
					_forceCompileProxy = (CBool) CR2WTypeManager.Create("Bool", "forceCompileProxy", cr2w, this);
				}
				return _forceCompileProxy;
			}
			set
			{
				if (_forceCompileProxy == value)
				{
					return;
				}
				_forceCompileProxy = value;
				PropertySet(this);
			}
		}

		public appearanceAppearanceResource(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
