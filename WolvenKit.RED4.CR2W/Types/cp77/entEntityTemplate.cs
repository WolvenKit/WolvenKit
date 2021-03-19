using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class entEntityTemplate : resStreamedResource
	{
		private CArray<entTemplateInclude> _includes;
		private CArray<entTemplateAppearance> _appearances;
		private CName _defaultAppearance;
		private CHandle<entVisualTagsSchema> _visualTagsSchema;
		private CArray<entTemplateComponentResolveSettings> _componentResolveSettings;
		private CArray<entTemplateBindingOverride> _bindingOverrides;
		private CArray<entTemplateComponentBackendDataOverrideInfo> _backendDataOverrides;
		private DataBuffer _localData;
		private DataBuffer _includeInstanceBuffer;
		private DataBuffer _compiledData;
		private CArray<raRef<CResource>> _resolvedDependencies;
		private CArray<rRef<CResource>> _inplaceResources;
		private CUInt16 _compiledEntityLODFlags;

		[Ordinal(1)] 
		[RED("includes")] 
		public CArray<entTemplateInclude> Includes
		{
			get => GetProperty(ref _includes);
			set => SetProperty(ref _includes, value);
		}

		[Ordinal(2)] 
		[RED("appearances")] 
		public CArray<entTemplateAppearance> Appearances
		{
			get => GetProperty(ref _appearances);
			set => SetProperty(ref _appearances, value);
		}

		[Ordinal(3)] 
		[RED("defaultAppearance")] 
		public CName DefaultAppearance
		{
			get => GetProperty(ref _defaultAppearance);
			set => SetProperty(ref _defaultAppearance, value);
		}

		[Ordinal(4)] 
		[RED("visualTagsSchema")] 
		public CHandle<entVisualTagsSchema> VisualTagsSchema
		{
			get => GetProperty(ref _visualTagsSchema);
			set => SetProperty(ref _visualTagsSchema, value);
		}

		[Ordinal(5)] 
		[RED("componentResolveSettings")] 
		public CArray<entTemplateComponentResolveSettings> ComponentResolveSettings
		{
			get => GetProperty(ref _componentResolveSettings);
			set => SetProperty(ref _componentResolveSettings, value);
		}

		[Ordinal(6)] 
		[RED("bindingOverrides")] 
		public CArray<entTemplateBindingOverride> BindingOverrides
		{
			get => GetProperty(ref _bindingOverrides);
			set => SetProperty(ref _bindingOverrides, value);
		}

		[Ordinal(7)] 
		[RED("backendDataOverrides")] 
		public CArray<entTemplateComponentBackendDataOverrideInfo> BackendDataOverrides
		{
			get => GetProperty(ref _backendDataOverrides);
			set => SetProperty(ref _backendDataOverrides, value);
		}

		[Ordinal(8)] 
		[RED("localData")] 
		public DataBuffer LocalData
		{
			get => GetProperty(ref _localData);
			set => SetProperty(ref _localData, value);
		}

		[Ordinal(9)] 
		[RED("includeInstanceBuffer")] 
		public DataBuffer IncludeInstanceBuffer
		{
			get => GetProperty(ref _includeInstanceBuffer);
			set => SetProperty(ref _includeInstanceBuffer, value);
		}

		[Ordinal(10)] 
		[RED("compiledData")] 
		public DataBuffer CompiledData
		{
			get => GetProperty(ref _compiledData);
			set => SetProperty(ref _compiledData, value);
		}

		[Ordinal(11)] 
		[RED("resolvedDependencies")] 
		public CArray<raRef<CResource>> ResolvedDependencies
		{
			get => GetProperty(ref _resolvedDependencies);
			set => SetProperty(ref _resolvedDependencies, value);
		}

		[Ordinal(12)] 
		[RED("inplaceResources")] 
		public CArray<rRef<CResource>> InplaceResources
		{
			get => GetProperty(ref _inplaceResources);
			set => SetProperty(ref _inplaceResources, value);
		}

		[Ordinal(13)] 
		[RED("compiledEntityLODFlags")] 
		public CUInt16 CompiledEntityLODFlags
		{
			get => GetProperty(ref _compiledEntityLODFlags);
			set => SetProperty(ref _compiledEntityLODFlags, value);
		}

		public entEntityTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
