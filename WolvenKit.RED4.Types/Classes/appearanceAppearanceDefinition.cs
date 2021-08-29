using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class appearanceAppearanceDefinition : ISerializable
	{
		private CName _name;
		private CName _parentAppearance;
		private CArray<CArray<CName>> _partsMasks;
		private CArray<appearanceAppearancePart> _partsValues;
		private CArray<appearanceAppearancePartOverrides> _partsOverrides;
		private CResourceAsyncReference<CMesh> _proxyMesh;
		private CUInt8 _forcedLodDistance;
		private CName _proxyMeshAppearance;
		private CResourceAsyncReference<CResource> _cookedDataPathOverride;
		private entEntityParametersBuffer _parametersBuffer;
		private redTagList _visualTags;
		private redTagList _inheritedVisualTags;
		private CArray<gameHitRepresentationOverride> _hitRepresentationOverrides;
		private SerializationDeferredDataBuffer _compiledData;
		private CArray<CResourceAsyncReference<CResource>> _resolvedDependencies;
		private CArray<CResourceAsyncReference<CResource>> _looseDependencies;
		private CUInt32 _censorFlags;

		[Ordinal(0)] 
		[RED("name")] 
		public CName Name
		{
			get => GetProperty(ref _name);
			set => SetProperty(ref _name, value);
		}

		[Ordinal(1)] 
		[RED("parentAppearance")] 
		public CName ParentAppearance
		{
			get => GetProperty(ref _parentAppearance);
			set => SetProperty(ref _parentAppearance, value);
		}

		[Ordinal(2)] 
		[RED("partsMasks")] 
		public CArray<CArray<CName>> PartsMasks
		{
			get => GetProperty(ref _partsMasks);
			set => SetProperty(ref _partsMasks, value);
		}

		[Ordinal(3)] 
		[RED("partsValues")] 
		public CArray<appearanceAppearancePart> PartsValues
		{
			get => GetProperty(ref _partsValues);
			set => SetProperty(ref _partsValues, value);
		}

		[Ordinal(4)] 
		[RED("partsOverrides")] 
		public CArray<appearanceAppearancePartOverrides> PartsOverrides
		{
			get => GetProperty(ref _partsOverrides);
			set => SetProperty(ref _partsOverrides, value);
		}

		[Ordinal(5)] 
		[RED("proxyMesh")] 
		public CResourceAsyncReference<CMesh> ProxyMesh
		{
			get => GetProperty(ref _proxyMesh);
			set => SetProperty(ref _proxyMesh, value);
		}

		[Ordinal(6)] 
		[RED("forcedLodDistance")] 
		public CUInt8 ForcedLodDistance
		{
			get => GetProperty(ref _forcedLodDistance);
			set => SetProperty(ref _forcedLodDistance, value);
		}

		[Ordinal(7)] 
		[RED("proxyMeshAppearance")] 
		public CName ProxyMeshAppearance
		{
			get => GetProperty(ref _proxyMeshAppearance);
			set => SetProperty(ref _proxyMeshAppearance, value);
		}

		[Ordinal(8)] 
		[RED("cookedDataPathOverride")] 
		public CResourceAsyncReference<CResource> CookedDataPathOverride
		{
			get => GetProperty(ref _cookedDataPathOverride);
			set => SetProperty(ref _cookedDataPathOverride, value);
		}

		[Ordinal(9)] 
		[RED("parametersBuffer")] 
		public entEntityParametersBuffer ParametersBuffer
		{
			get => GetProperty(ref _parametersBuffer);
			set => SetProperty(ref _parametersBuffer, value);
		}

		[Ordinal(10)] 
		[RED("visualTags")] 
		public redTagList VisualTags
		{
			get => GetProperty(ref _visualTags);
			set => SetProperty(ref _visualTags, value);
		}

		[Ordinal(11)] 
		[RED("inheritedVisualTags")] 
		public redTagList InheritedVisualTags
		{
			get => GetProperty(ref _inheritedVisualTags);
			set => SetProperty(ref _inheritedVisualTags, value);
		}

		[Ordinal(12)] 
		[RED("hitRepresentationOverrides")] 
		public CArray<gameHitRepresentationOverride> HitRepresentationOverrides
		{
			get => GetProperty(ref _hitRepresentationOverrides);
			set => SetProperty(ref _hitRepresentationOverrides, value);
		}

		[Ordinal(13)] 
		[RED("compiledData")] 
		public SerializationDeferredDataBuffer CompiledData
		{
			get => GetProperty(ref _compiledData);
			set => SetProperty(ref _compiledData, value);
		}

		[Ordinal(14)] 
		[RED("resolvedDependencies")] 
		public CArray<CResourceAsyncReference<CResource>> ResolvedDependencies
		{
			get => GetProperty(ref _resolvedDependencies);
			set => SetProperty(ref _resolvedDependencies, value);
		}

		[Ordinal(15)] 
		[RED("looseDependencies")] 
		public CArray<CResourceAsyncReference<CResource>> LooseDependencies
		{
			get => GetProperty(ref _looseDependencies);
			set => SetProperty(ref _looseDependencies, value);
		}

		[Ordinal(16)] 
		[RED("censorFlags")] 
		public CUInt32 CensorFlags
		{
			get => GetProperty(ref _censorFlags);
			set => SetProperty(ref _censorFlags, value);
		}
	}
}
