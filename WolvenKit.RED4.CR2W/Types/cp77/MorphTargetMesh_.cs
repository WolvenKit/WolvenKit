using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class MorphTargetMesh_ : resStreamedResource
	{
		private rRef<CMesh> _baseMesh;
		private CArray<MorphTargetMeshEntry> _targets;
		private Box _boundingBox;
		private CName _baseTextureParamName;
		private CHandle<IRenderResourceBlob> _blob;
		private CName _baseMeshAppearance;
		private rRef<ITexture> _baseTexture;

		[Ordinal(1)] 
		[RED("baseMesh")] 
		public rRef<CMesh> BaseMesh
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
		public rRef<ITexture> BaseTexture
		{
			get => GetProperty(ref _baseTexture);
			set => SetProperty(ref _baseTexture, value);
		}

		public MorphTargetMesh_(IRed4EngineFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
