using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class appearanceAppearanceDefinition : ISerializable
	{
		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(1)] 
		[RED("parentAppearance")] 
		public CName ParentAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(2)] 
		[RED("partsMasks")] 
		public CArray<CArray<CName>> PartsMasks
		{
			get => GetPropertyValue<CArray<CArray<CName>>>();
			set => SetPropertyValue<CArray<CArray<CName>>>(value);
		}

		[Ordinal(3)] 
		[RED("partsValues")] 
		public CArray<appearanceAppearancePart> PartsValues
		{
			get => GetPropertyValue<CArray<appearanceAppearancePart>>();
			set => SetPropertyValue<CArray<appearanceAppearancePart>>(value);
		}

		[Ordinal(4)] 
		[RED("partsOverrides")] 
		public CArray<appearanceAppearancePartOverrides> PartsOverrides
		{
			get => GetPropertyValue<CArray<appearanceAppearancePartOverrides>>();
			set => SetPropertyValue<CArray<appearanceAppearancePartOverrides>>(value);
		}

		[Ordinal(5)] 
		[RED("proxyMesh")] 
		public CResourceAsyncReference<CMesh> ProxyMesh
		{
			get => GetPropertyValue<CResourceAsyncReference<CMesh>>();
			set => SetPropertyValue<CResourceAsyncReference<CMesh>>(value);
		}

		[Ordinal(6)] 
		[RED("forcedLodDistance")] 
		public CUInt8 ForcedLodDistance
		{
			get => GetPropertyValue<CUInt8>();
			set => SetPropertyValue<CUInt8>(value);
		}

		[Ordinal(7)] 
		[RED("proxyMeshAppearance")] 
		public CName ProxyMeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(8)] 
		[RED("cookedDataPathOverride")] 
		public CResourceAsyncReference<CResource> CookedDataPathOverride
		{
			get => GetPropertyValue<CResourceAsyncReference<CResource>>();
			set => SetPropertyValue<CResourceAsyncReference<CResource>>(value);
		}

		[Ordinal(9)] 
		[RED("parametersBuffer")] 
		public entEntityParametersBuffer ParametersBuffer
		{
			get => GetPropertyValue<entEntityParametersBuffer>();
			set => SetPropertyValue<entEntityParametersBuffer>(value);
		}

		[Ordinal(10)] 
		[RED("visualTags")] 
		public redTagList VisualTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(11)] 
		[RED("inheritedVisualTags")] 
		public redTagList InheritedVisualTags
		{
			get => GetPropertyValue<redTagList>();
			set => SetPropertyValue<redTagList>(value);
		}

		[Ordinal(12)] 
		[RED("hitRepresentationOverrides")] 
		public CArray<gameHitRepresentationOverride> HitRepresentationOverrides
		{
			get => GetPropertyValue<CArray<gameHitRepresentationOverride>>();
			set => SetPropertyValue<CArray<gameHitRepresentationOverride>>(value);
		}

		[Ordinal(13)] 
		[RED("compiledData")] 
		public SerializationDeferredDataBuffer CompiledData
		{
			get => GetPropertyValue<SerializationDeferredDataBuffer>();
			set => SetPropertyValue<SerializationDeferredDataBuffer>(value);
		}

		[Ordinal(14)] 
		[RED("resolvedDependencies")] 
		public CArray<CResourceAsyncReference<CResource>> ResolvedDependencies
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}

		[Ordinal(15)] 
		[RED("looseDependencies")] 
		public CArray<CResourceAsyncReference<CResource>> LooseDependencies
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}

		[Ordinal(16)] 
		[RED("censorFlags")] 
		public CUInt32 CensorFlags
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		public appearanceAppearanceDefinition()
		{
			PartsMasks = new();
			PartsValues = new();
			PartsOverrides = new();
			ParametersBuffer = new entEntityParametersBuffer { ParameterBuffers = new() };
			VisualTags = new redTagList { Tags = new() };
			InheritedVisualTags = new redTagList { Tags = new() };
			HitRepresentationOverrides = new();
			ResolvedDependencies = new();
			LooseDependencies = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
