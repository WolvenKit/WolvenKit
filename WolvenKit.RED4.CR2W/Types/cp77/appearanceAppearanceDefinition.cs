using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class appearanceAppearanceDefinition : ISerializable
	{
		private CName _name;
		private CName _parentAppearance;
		private CArray<CArray<CName>> _partsMasks;
		private CArray<appearanceAppearancePart> _partsValues;
		private CArray<appearanceAppearancePartOverrides> _partsOverrides;
		private raRef<CMesh> _proxyMesh;
		private CUInt8 _forcedLodDistance;
		private CName _proxyMeshAppearance;
		private raRef<CResource> _cookedDataPathOverride;
		private entEntityParametersBuffer _parametersBuffer;
		private redTagList _visualTags;
		private redTagList _inheritedVisualTags;
		private CArray<gameHitRepresentationOverride> _hitRepresentationOverrides;
		private serializationDeferredDataBuffer _compiledData;
		private CArray<raRef<CResource>> _resolvedDependencies;
		private CArray<raRef<CResource>> _looseDependencies;
		private CUInt32 _censorFlags;

		[Ordinal(0)] 
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

		[Ordinal(1)] 
		[RED("parentAppearance")] 
		public CName ParentAppearance
		{
			get
			{
				if (_parentAppearance == null)
				{
					_parentAppearance = (CName) CR2WTypeManager.Create("CName", "parentAppearance", cr2w, this);
				}
				return _parentAppearance;
			}
			set
			{
				if (_parentAppearance == value)
				{
					return;
				}
				_parentAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(2)] 
		[RED("partsMasks")] 
		public CArray<CArray<CName>> PartsMasks
		{
			get
			{
				if (_partsMasks == null)
				{
					_partsMasks = (CArray<CArray<CName>>) CR2WTypeManager.Create("array:array:CName", "partsMasks", cr2w, this);
				}
				return _partsMasks;
			}
			set
			{
				if (_partsMasks == value)
				{
					return;
				}
				_partsMasks = value;
				PropertySet(this);
			}
		}

		[Ordinal(3)] 
		[RED("partsValues")] 
		public CArray<appearanceAppearancePart> PartsValues
		{
			get
			{
				if (_partsValues == null)
				{
					_partsValues = (CArray<appearanceAppearancePart>) CR2WTypeManager.Create("array:appearanceAppearancePart", "partsValues", cr2w, this);
				}
				return _partsValues;
			}
			set
			{
				if (_partsValues == value)
				{
					return;
				}
				_partsValues = value;
				PropertySet(this);
			}
		}

		[Ordinal(4)] 
		[RED("partsOverrides")] 
		public CArray<appearanceAppearancePartOverrides> PartsOverrides
		{
			get
			{
				if (_partsOverrides == null)
				{
					_partsOverrides = (CArray<appearanceAppearancePartOverrides>) CR2WTypeManager.Create("array:appearanceAppearancePartOverrides", "partsOverrides", cr2w, this);
				}
				return _partsOverrides;
			}
			set
			{
				if (_partsOverrides == value)
				{
					return;
				}
				_partsOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(5)] 
		[RED("proxyMesh")] 
		public raRef<CMesh> ProxyMesh
		{
			get
			{
				if (_proxyMesh == null)
				{
					_proxyMesh = (raRef<CMesh>) CR2WTypeManager.Create("raRef:CMesh", "proxyMesh", cr2w, this);
				}
				return _proxyMesh;
			}
			set
			{
				if (_proxyMesh == value)
				{
					return;
				}
				_proxyMesh = value;
				PropertySet(this);
			}
		}

		[Ordinal(6)] 
		[RED("forcedLodDistance")] 
		public CUInt8 ForcedLodDistance
		{
			get
			{
				if (_forcedLodDistance == null)
				{
					_forcedLodDistance = (CUInt8) CR2WTypeManager.Create("Uint8", "forcedLodDistance", cr2w, this);
				}
				return _forcedLodDistance;
			}
			set
			{
				if (_forcedLodDistance == value)
				{
					return;
				}
				_forcedLodDistance = value;
				PropertySet(this);
			}
		}

		[Ordinal(7)] 
		[RED("proxyMeshAppearance")] 
		public CName ProxyMeshAppearance
		{
			get
			{
				if (_proxyMeshAppearance == null)
				{
					_proxyMeshAppearance = (CName) CR2WTypeManager.Create("CName", "proxyMeshAppearance", cr2w, this);
				}
				return _proxyMeshAppearance;
			}
			set
			{
				if (_proxyMeshAppearance == value)
				{
					return;
				}
				_proxyMeshAppearance = value;
				PropertySet(this);
			}
		}

		[Ordinal(8)] 
		[RED("cookedDataPathOverride")] 
		public raRef<CResource> CookedDataPathOverride
		{
			get
			{
				if (_cookedDataPathOverride == null)
				{
					_cookedDataPathOverride = (raRef<CResource>) CR2WTypeManager.Create("raRef:CResource", "cookedDataPathOverride", cr2w, this);
				}
				return _cookedDataPathOverride;
			}
			set
			{
				if (_cookedDataPathOverride == value)
				{
					return;
				}
				_cookedDataPathOverride = value;
				PropertySet(this);
			}
		}

		[Ordinal(9)] 
		[RED("parametersBuffer")] 
		public entEntityParametersBuffer ParametersBuffer
		{
			get
			{
				if (_parametersBuffer == null)
				{
					_parametersBuffer = (entEntityParametersBuffer) CR2WTypeManager.Create("entEntityParametersBuffer", "parametersBuffer", cr2w, this);
				}
				return _parametersBuffer;
			}
			set
			{
				if (_parametersBuffer == value)
				{
					return;
				}
				_parametersBuffer = value;
				PropertySet(this);
			}
		}

		[Ordinal(10)] 
		[RED("visualTags")] 
		public redTagList VisualTags
		{
			get
			{
				if (_visualTags == null)
				{
					_visualTags = (redTagList) CR2WTypeManager.Create("redTagList", "visualTags", cr2w, this);
				}
				return _visualTags;
			}
			set
			{
				if (_visualTags == value)
				{
					return;
				}
				_visualTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(11)] 
		[RED("inheritedVisualTags")] 
		public redTagList InheritedVisualTags
		{
			get
			{
				if (_inheritedVisualTags == null)
				{
					_inheritedVisualTags = (redTagList) CR2WTypeManager.Create("redTagList", "inheritedVisualTags", cr2w, this);
				}
				return _inheritedVisualTags;
			}
			set
			{
				if (_inheritedVisualTags == value)
				{
					return;
				}
				_inheritedVisualTags = value;
				PropertySet(this);
			}
		}

		[Ordinal(12)] 
		[RED("hitRepresentationOverrides")] 
		public CArray<gameHitRepresentationOverride> HitRepresentationOverrides
		{
			get
			{
				if (_hitRepresentationOverrides == null)
				{
					_hitRepresentationOverrides = (CArray<gameHitRepresentationOverride>) CR2WTypeManager.Create("array:gameHitRepresentationOverride", "hitRepresentationOverrides", cr2w, this);
				}
				return _hitRepresentationOverrides;
			}
			set
			{
				if (_hitRepresentationOverrides == value)
				{
					return;
				}
				_hitRepresentationOverrides = value;
				PropertySet(this);
			}
		}

		[Ordinal(13)] 
		[RED("compiledData")] 
		public serializationDeferredDataBuffer CompiledData
		{
			get
			{
				if (_compiledData == null)
				{
					_compiledData = (serializationDeferredDataBuffer) CR2WTypeManager.Create("serializationDeferredDataBuffer", "compiledData", cr2w, this);
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

		[Ordinal(14)] 
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

		[Ordinal(15)] 
		[RED("looseDependencies")] 
		public CArray<raRef<CResource>> LooseDependencies
		{
			get
			{
				if (_looseDependencies == null)
				{
					_looseDependencies = (CArray<raRef<CResource>>) CR2WTypeManager.Create("array:raRef:CResource", "looseDependencies", cr2w, this);
				}
				return _looseDependencies;
			}
			set
			{
				if (_looseDependencies == value)
				{
					return;
				}
				_looseDependencies = value;
				PropertySet(this);
			}
		}

		[Ordinal(16)] 
		[RED("censorFlags")] 
		public CUInt32 CensorFlags
		{
			get
			{
				if (_censorFlags == null)
				{
					_censorFlags = (CUInt32) CR2WTypeManager.Create("Uint32", "censorFlags", cr2w, this);
				}
				return _censorFlags;
			}
			set
			{
				if (_censorFlags == value)
				{
					return;
				}
				_censorFlags = value;
				PropertySet(this);
			}
		}

		public appearanceAppearanceDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
