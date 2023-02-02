using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class CMaterialTemplate : IMaterialDefinition
	{
		[Ordinal(9)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(10)] 
		[RED("parameters", 3)] 
		public CArrayFixedSize<CArray<CHandle<CMaterialParameter>>> Parameters
		{
			get => GetPropertyValue<CArrayFixedSize<CArray<CHandle<CMaterialParameter>>>>();
			set => SetPropertyValue<CArrayFixedSize<CArray<CHandle<CMaterialParameter>>>>(value);
		}

		[Ordinal(11)] 
		[RED("techniques")] 
		public CArray<MaterialTechnique> Techniques
		{
			get => GetPropertyValue<CArray<MaterialTechnique>>();
			set => SetPropertyValue<CArray<MaterialTechnique>>(value);
		}

		[Ordinal(12)] 
		[RED("samplerStates", 3)] 
		public CArrayFixedSize<CArray<SamplerStateInfo>> SamplerStates
		{
			get => GetPropertyValue<CArrayFixedSize<CArray<SamplerStateInfo>>>();
			set => SetPropertyValue<CArrayFixedSize<CArray<SamplerStateInfo>>>(value);
		}

		[Ordinal(13)] 
		[RED("usedParameters", 3)] 
		public CArrayFixedSize<CArray<MaterialUsedParameter>> UsedParameters
		{
			get => GetPropertyValue<CArrayFixedSize<CArray<MaterialUsedParameter>>>();
			set => SetPropertyValue<CArrayFixedSize<CArray<MaterialUsedParameter>>>(value);
		}

		[Ordinal(14)] 
		[RED("materialPriority")] 
		public CEnum<EMaterialPriority> MaterialPriority
		{
			get => GetPropertyValue<CEnum<EMaterialPriority>>();
			set => SetPropertyValue<CEnum<EMaterialPriority>>(value);
		}

		[Ordinal(15)] 
		[RED("materialType")] 
		public CEnum<ERenderMaterialType> MaterialType
		{
			get => GetPropertyValue<CEnum<ERenderMaterialType>>();
			set => SetPropertyValue<CEnum<ERenderMaterialType>>(value);
		}

		[Ordinal(16)] 
		[RED("audioTag")] 
		public CName AudioTag
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(17)] 
		[RED("resourceVersion")] 
		public CUInt8 ResourceVersion
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		public CMaterialTemplate()
		{
			ParamBlockSize = new(3);
			CanBeMasked = true;
			VertexFactories = new();
			Parameters = new(3);
			Techniques = new();
			SamplerStates = new(3);
			UsedParameters = new(3);

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
