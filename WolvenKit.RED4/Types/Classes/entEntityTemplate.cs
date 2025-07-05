using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class entEntityTemplate : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("includes")] 
		public CArray<entTemplateInclude> Includes
		{
			get => GetPropertyValue<CArray<entTemplateInclude>>();
			set => SetPropertyValue<CArray<entTemplateInclude>>(value);
		}

		[Ordinal(2)] 
		[RED("appearances")] 
		public CArray<entTemplateAppearance> Appearances
		{
			get => GetPropertyValue<CArray<entTemplateAppearance>>();
			set => SetPropertyValue<CArray<entTemplateAppearance>>(value);
		}

		[Ordinal(3)] 
		[RED("defaultAppearance")] 
		public CName DefaultAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(4)] 
		[RED("visualTagsSchema")] 
		public CHandle<entVisualTagsSchema> VisualTagsSchema
		{
			get => GetPropertyValue<CHandle<entVisualTagsSchema>>();
			set => SetPropertyValue<CHandle<entVisualTagsSchema>>(value);
		}

		[Ordinal(5)] 
		[RED("componentResolveSettings")] 
		public CArray<entTemplateComponentResolveSettings> ComponentResolveSettings
		{
			get => GetPropertyValue<CArray<entTemplateComponentResolveSettings>>();
			set => SetPropertyValue<CArray<entTemplateComponentResolveSettings>>(value);
		}

		[Ordinal(6)] 
		[RED("bindingOverrides")] 
		public CArray<entTemplateBindingOverride> BindingOverrides
		{
			get => GetPropertyValue<CArray<entTemplateBindingOverride>>();
			set => SetPropertyValue<CArray<entTemplateBindingOverride>>(value);
		}

		[Ordinal(7)] 
		[RED("backendDataOverrides")] 
		public CArray<entTemplateComponentBackendDataOverrideInfo> BackendDataOverrides
		{
			get => GetPropertyValue<CArray<entTemplateComponentBackendDataOverrideInfo>>();
			set => SetPropertyValue<CArray<entTemplateComponentBackendDataOverrideInfo>>(value);
		}

		[Ordinal(8)] 
		[RED("localData")] 
		public DataBuffer LocalData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(9)] 
		[RED("includeInstanceBuffer")] 
		public DataBuffer IncludeInstanceBuffer
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(10)] 
		[RED("compiledData")] 
		public DataBuffer CompiledData
		{
			get => GetPropertyValue<DataBuffer>();
			set => SetPropertyValue<DataBuffer>(value);
		}

		[Ordinal(11)] 
		[RED("resolvedDependencies")] 
		public CArray<CResourceAsyncReference<CResource>> ResolvedDependencies
		{
			get => GetPropertyValue<CArray<CResourceAsyncReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceAsyncReference<CResource>>>(value);
		}

		[Ordinal(12)] 
		[RED("inplaceResources")] 
		public CArray<CResourceReference<CResource>> InplaceResources
		{
			get => GetPropertyValue<CArray<CResourceReference<CResource>>>();
			set => SetPropertyValue<CArray<CResourceReference<CResource>>>(value);
		}

		[Ordinal(13)] 
		[RED("compiledEntityLODFlags")] 
		public CUInt16 CompiledEntityLODFlags
		{
			get => GetPropertyValue<CUInt16>();
			set => SetPropertyValue<CUInt16>(value);
		}

		public entEntityTemplate()
		{
			Includes = new();
			Appearances = new();
			DefaultAppearance = "default";
			ComponentResolveSettings = new();
			BindingOverrides = new();
			BackendDataOverrides = new();
			ResolvedDependencies = new();
			InplaceResources = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
