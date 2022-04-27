using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class MorphTargetMesh : resStreamedResource
	{
		[Ordinal(1)] 
		[RED("baseMesh")] 
		public CResourceReference<CMesh> BaseMesh
		{
			get => GetPropertyValue<CResourceReference<CMesh>>();
			set => SetPropertyValue<CResourceReference<CMesh>>(value);
		}

		[Ordinal(2)] 
		[RED("targets")] 
		public CArray<MorphTargetMeshEntry> Targets
		{
			get => GetPropertyValue<CArray<MorphTargetMeshEntry>>();
			set => SetPropertyValue<CArray<MorphTargetMeshEntry>>(value);
		}

		[Ordinal(3)] 
		[RED("boundingBox")] 
		public Box BoundingBox
		{
			get => GetPropertyValue<Box>();
			set => SetPropertyValue<Box>(value);
		}

		[Ordinal(4)] 
		[RED("baseTextureParamName")] 
		public CName BaseTextureParamName
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(5)] 
		[RED("blob")] 
		public CHandle<IRenderResourceBlob> Blob
		{
			get => GetPropertyValue<CHandle<IRenderResourceBlob>>();
			set => SetPropertyValue<CHandle<IRenderResourceBlob>>(value);
		}

		[Ordinal(6)] 
		[RED("baseMeshAppearance")] 
		public CName BaseMeshAppearance
		{
			get => GetPropertyValue<CName>();
			set => SetPropertyValue<CName>(value);
		}

		[Ordinal(7)] 
		[RED("baseTexture")] 
		public CResourceReference<ITexture> BaseTexture
		{
			get => GetPropertyValue<CResourceReference<ITexture>>();
			set => SetPropertyValue<CResourceReference<ITexture>>(value);
		}

		public MorphTargetMesh()
		{
			Targets = new();
			BoundingBox = new() { Min = new(), Max = new() };

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
