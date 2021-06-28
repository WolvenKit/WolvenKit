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
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(9)] 
		[RED("parameters", 3)] 
		public CArrayFixedSize<CArray<CHandle<CMaterialParameter>>> Parameters
		{
			get => GetProperty(ref _parameters);
			set => SetProperty(ref _parameters, value);
		}

		[Ordinal(10)] 
		[RED("techniques")] 
		public CArray<MaterialTechnique> Techniques
		{
			get => GetProperty(ref _techniques);
			set => SetProperty(ref _techniques, value);
		}

		[Ordinal(11)] 
		[RED("samplerStates", 3)] 
		public CArrayFixedSize<CArray<SamplerStateInfo>> SamplerStates
		{
			get => GetProperty(ref _samplerStates);
			set => SetProperty(ref _samplerStates, value);
		}

		[Ordinal(12)] 
		[RED("usedParameters", 3)] 
		public CArrayFixedSize<CArray<MaterialUsedParameter>> UsedParameters
		{
			get => GetProperty(ref _usedParameters);
			set => SetProperty(ref _usedParameters, value);
		}

		[Ordinal(13)] 
		[RED("materialPriority")] 
		public CEnum<EMaterialPriority> MaterialPriority
		{
			get => GetProperty(ref _materialPriority);
			set => SetProperty(ref _materialPriority, value);
		}

		[Ordinal(14)] 
		[RED("materialType")] 
		public CEnum<ERenderMaterialType> MaterialType
		{
			get => GetProperty(ref _materialType);
			set => SetProperty(ref _materialType, value);
		}

		[Ordinal(15)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get => GetProperty(ref _audioTag);
			set => SetProperty(ref _audioTag, value);
		}

		[Ordinal(16)] 
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get => GetProperty(ref _resourceVersion);
			set => SetProperty(ref _resourceVersion, value);
		}

		public CMaterialTemplate_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
