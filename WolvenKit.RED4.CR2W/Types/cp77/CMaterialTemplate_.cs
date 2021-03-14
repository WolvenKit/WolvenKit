using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class CMaterialTemplate_ : IMaterialDefinition
	{
		private CName _name;
		private CArrayFixedSize<CArray<CHandle<CMaterialParameter>>> _parameters;
		private CArray<MaterialTechnique> _techniques;
		private CArrayFixedSize<CArray<SamplerStateInfo>> _samplerStates;
		private CArrayFixedSize<CArray<MaterialUsedParameter>> _usedParameters;
		private CEnum<EMaterialPriority> _materialPriority;
		private CEnum<ERenderMaterialType> _materialType;
		private CName _audioTag;
		private CUInt8 _resourceVersion;

		[Ordinal(8)] 
		[RED("name")] 
		public CName Name
		{
			get
			{
				if (_name == null)
				{
					_name = (CName) CR2WTypeManager.Create("CName", "name", cr2w, this);
				}
				return _name;
			}
			set
			{
				if (_name == value)
				{
					return;
				}
				_name = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("parameters", 3)] 
		public CArrayFixedSize<CArray<CHandle<CMaterialParameter>>> Parameters
		{
			get
			{
				if (_parameters == null)
				{
					_parameters = (CArrayFixedSize<CArray<CHandle<CMaterialParameter>>>) CR2WTypeManager.Create("[3]array:handle:CMaterialParameter", "parameters", cr2w, this);
				}
				return _parameters;
			}
			set
			{
				if (_parameters == value)
				{
					return;
				}
				_parameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("techniques")] 
		public CArray<MaterialTechnique> Techniques
		{
			get
			{
				if (_techniques == null)
				{
					_techniques = (CArray<MaterialTechnique>) CR2WTypeManager.Create("array:MaterialTechnique", "techniques", cr2w, this);
				}
				return _techniques;
			}
			set
			{
				if (_techniques == value)
				{
					return;
				}
				_techniques = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("samplerStates", 3)] 
		public CArrayFixedSize<CArray<SamplerStateInfo>> SamplerStates
		{
			get
			{
				if (_samplerStates == null)
				{
					_samplerStates = (CArrayFixedSize<CArray<SamplerStateInfo>>) CR2WTypeManager.Create("[3]array:SamplerStateInfo", "samplerStates", cr2w, this);
				}
				return _samplerStates;
			}
			set
			{
				if (_samplerStates == value)
				{
					return;
				}
				_samplerStates = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("usedParameters", 3)] 
		public CArrayFixedSize<CArray<MaterialUsedParameter>> UsedParameters
		{
			get
			{
				if (_usedParameters == null)
				{
					_usedParameters = (CArrayFixedSize<CArray<MaterialUsedParameter>>) CR2WTypeManager.Create("[3]array:MaterialUsedParameter", "usedParameters", cr2w, this);
				}
				return _usedParameters;
			}
			set
			{
				if (_usedParameters == value)
				{
					return;
				}
				_usedParameters = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("materialPriority")] 
		public CEnum<EMaterialPriority> MaterialPriority
		{
			get
			{
				if (_materialPriority == null)
				{
					_materialPriority = (CEnum<EMaterialPriority>) CR2WTypeManager.Create("EMaterialPriority", "materialPriority", cr2w, this);
				}
				return _materialPriority;
			}
			set
			{
				if (_materialPriority == value)
				{
					return;
				}
				_materialPriority = value;
				PropertySet(this);
			}
		}

		[Ordinal(14)] 
		[RED("materialType")] 
		public CEnum<ERenderMaterialType> MaterialType
		{
			get
			{
				if (_materialType == null)
				{
					_materialType = (CEnum<ERenderMaterialType>) CR2WTypeManager.Create("ERenderMaterialType", "materialType", cr2w, this);
				}
				return _materialType;
			}
			set
			{
				if (_materialType == value)
				{
					return;
				}
				_materialType = value;
				PropertySet(this);
			}
		}

		[Ordinal(15)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get
			{
				if (_audioTag == null)
				{
					_audioTag = (CName) CR2WTypeManager.Create("CName", "audioTag", cr2w, this);
				}
				return _audioTag;
			}
			set
			{
				if (_audioTag == value)
				{
					return;
				}
				_audioTag = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get
			{
				if (_resourceVersion == null)
				{
					_resourceVersion = (CUInt8) CR2WTypeManager.Create("Uint8", "resourceVersion", cr2w, this);
				}
				return _resourceVersion;
			}
			set
			{
				if (_resourceVersion == value)
				{
					return;
				}
				_resourceVersion = value;
				PropertySet(this);
			}
		}

		public CMaterialTemplate_(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
