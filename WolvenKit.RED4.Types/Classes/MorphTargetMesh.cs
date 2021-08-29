using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class MorphTargetMesh : resStreamedResource
	{
		private CResourceReference<CMesh> _baseMesh;
		private CArray<MorphTargetMeshEntry> _targets;
		private Box _boundingBox;
		private CName _baseTextureParamName;
		private CHandle<IRenderResourceBlob> _blob;
		private CName _baseMeshAppearance;
		private CResourceReference<ITexture> _baseTexture;

		[Ordinal(1)] 
		[RED("baseMesh")] 
		public CResourceReference<CMesh> BaseMesh
		{
			get => GetProperty(ref _baseMesh);
			set => SetProperty(ref _baseMesh, value);
		}

		[Ordinal(2)] 
		[RED("targets")] 
		public CArray<MorphTargetMeshEntry> Targets
		{
			get => GetProperty(ref _targets);
			set => SetProperty(ref _targets, value);
		}

		[Ordinal(3)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get => GetProperty(ref _boundingBox);
			set => SetProperty(ref _boundingBox, value);
		}

		[Ordinal(4)] 
		[RED("baseTextureParamName")] 
		public CName BaseTextureParamName
		{
			get => GetProperty(ref _baseTextureParamName);
			set => SetProperty(ref _baseTextureParamName, value);
		}

		[Ordinal(5)] 
		[RED("blob")] 
		public CHandle<IRenderResourceBlob> Blob
		{
			get => GetProperty(ref _blob);
			set => SetProperty(ref _blob, value);
		}

		[Ordinal(6)] 
		[RED("baseMeshAppearance")] 
		public CName BaseMeshAppearance
		{
			get => GetProperty(ref _baseMeshAppearance);
			set => SetProperty(ref _baseMeshAppearance, value);
		}

		[Ordinal(7)] 
		[RED("baseTexture")] 
		public CResourceReference<ITexture> BaseTexture
		{
			get => GetProperty(ref _baseTexture);
			set => SetProperty(ref _baseTexture, value);
		}
	}
}
