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
			get
			{
				if (_includes == null)
				{
					_includes = (CArray<entTemplateInclude>) CR2WTypeManager.Create("array:entTemplateInclude", "includes", cr2w, this);
				}
				return _includes;
			}
			set
			{
				if (_includes == value)
				{
					return;
				}
				_includes = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("appearances")] 
		public CArray<entTemplateAppearance> Appearances
		{
			get
			{
				if (_appearances == null)
				{
					_appearances = (CArray<entTemplateAppearance>) CR2WTypeManager.Create("array:entTemplateAppearance", "appearances", cr2w, this);
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

		[Ordinal(3)] 
		[RED("defaultAppearance")] 
		public CName DefaultAppearance
		{
			get
			{
				if (_defaultAppearance == null)
				{
					_defaultAppearance = (CName) CR2WTypeManager.Create("CName", "defaultAppearance", cr2w, this);
				}
				return _defaultAppearance;
			}
			set
			{
				if (_defaultAppearance == value)
				{
					return;
				}
				_defaultAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("visualTagsSchema")] 
		public CHandle<entVisualTagsSchema> VisualTagsSchema
		{
			get
			{
				if (_visualTagsSchema == null)
				{
					_visualTagsSchema = (CHandle<entVisualTagsSchema>) CR2WTypeManager.Create("handle:entVisualTagsSchema", "visualTagsSchema", cr2w, this);
				}
				return _visualTagsSchema;
			}
			set
			{
				if (_visualTagsSchema == value)
				{
					return;
				}
				_visualTagsSchema = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("componentResolveSettings")] 
		public CArray<entTemplateComponentResolveSettings> ComponentResolveSettings
		{
			get
			{
				if (_componentResolveSettings == null)
				{
					_componentResolveSettings = (CArray<entTemplateComponentResolveSettings>) CR2WTypeManager.Create("array:entTemplateComponentResolveSettings", "componentResolveSettings", cr2w, this);
				}
				return _componentResolveSettings;
			}
			set
			{
				if (_componentResolveSettings == value)
				{
					return;
				}
				_componentResolveSettings = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("bindingOverrides")] 
		public CArray<entTemplateBindingOverride> BindingOverrides
		{
			get
			{
				if (_bindingOverrides == null)
				{
					_bindingOverrides = (CArray<entTemplateBindingOverride>) CR2WTypeManager.Create("array:entTemplateBindingOverride", "bindingOverrides", cr2w, this);
				}
				return _bindingOverrides;
			}
			set
			{
				if (_bindingOverrides == value)
				{
					return;
				}
				_bindingOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("backendDataOverrides")] 
		public CArray<entTemplateComponentBackendDataOverrideInfo> BackendDataOverrides
		{
			get
			{
				if (_backendDataOverrides == null)
				{
					_backendDataOverrides = (CArray<entTemplateComponentBackendDataOverrideInfo>) CR2WTypeManager.Create("array:entTemplateComponentBackendDataOverrideInfo", "backendDataOverrides", cr2w, this);
				}
				return _backendDataOverrides;
			}
			set
			{
				if (_backendDataOverrides == value)
				{
					return;
				}
				_backendDataOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("localData")] 
		public DataBuffer LocalData
		{
			get
			{
				if (_localData == null)
				{
					_localData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "localData", cr2w, this);
				}
				return _localData;
			}
			set
			{
				if (_localData == value)
				{
					return;
				}
				_localData = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("includeInstanceBuffer")] 
		public DataBuffer IncludeInstanceBuffer
		{
			get
			{
				if (_includeInstanceBuffer == null)
				{
					_includeInstanceBuffer = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "includeInstanceBuffer", cr2w, this);
				}
				return _includeInstanceBuffer;
			}
			set
			{
				if (_includeInstanceBuffer == value)
				{
					return;
				}
				_includeInstanceBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("compiledData")] 
		public DataBuffer CompiledData
		{
			get
			{
				if (_compiledData == null)
				{
					_compiledData = (DataBuffer) CR2WTypeManager.Create("DataBuffer", "compiledData", cr2w, this);
				}
				return _compiledData;
			}
			set
			{
				if (_compiledData == value)
				{
					return;
				}
				_compiledData = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("resolvedDependencies")] 
		public CArray<raRef<CResource>> ResolvedDependencies
		{
			get
			{
				if (_resolvedDependencies == null)
				{
					_resolvedDependencies = (CArray<raRef<CResource>>) CR2WTypeManager.Create("array:raRef:CResource", "resolvedDependencies", cr2w, this);
				}
				return _resolvedDependencies;
			}
			set
			{
				if (_resolvedDependencies == value)
				{
					return;
				}
				_resolvedDependencies = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("inplaceResources")] 
		public CArray<rRef<CResource>> InplaceResources
		{
			get
			{
				if (_inplaceResources == null)
				{
					_inplaceResources = (CArray<rRef<CResource>>) CR2WTypeManager.Create("array:rRef:CResource", "inplaceResources", cr2w, this);
				}
				return _inplaceResources;
			}
			set
			{
				if (_inplaceResources == value)
				{
					return;
				}
				_inplaceResources = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("compiledEntityLODFlags")] 
		public CUInt16 CompiledEntityLODFlags
		{
			get
			{
				if (_compiledEntityLODFlags == null)
				{
					_compiledEntityLODFlags = (CUInt16) CR2WTypeManager.Create("Uint16", "compiledEntityLODFlags", cr2w, this);
				}
				return _compiledEntityLODFlags;
			}
			set
			{
				if (_compiledEntityLODFlags == value)
				{
					return;
				}
				_compiledEntityLODFlags = value;
				PropertySet(this);
			}
		}

		public entEntityTemplate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
