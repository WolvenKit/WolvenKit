using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class worldFoliageBrushItem : ISerializable
	{
		private CResourceReference<CMesh> _mesh;
		private CName _meshAppearance;
		private worldFoliageBrushParams _params;
		private CBool _selected;

		[Ordinal(0)] 
		[RED("Mesh")] 
		public CResourceReference<CMesh> Mesh
		{
			get => GetProperty(ref _mesh);
			set => SetProperty(ref _mesh, value);
		}

		[Ordinal(1)] 
		[RED("MeshAppearance")] 
		public CName MeshAppearance
		{
			get => GetProperty(ref _meshAppearance);
			set => SetProperty(ref _meshAppearance, value);
		}

		[Ordinal(2)] 
		[RED("Params")] 
		public worldFoliageBrushParams Params
		{
			get => GetProperty(ref _params);
			set => SetProperty(ref _params, value);
		}

		[Ordinal(3)] 
		[RED("Selected")] 
		public CBool Selected
		{
			get => GetProperty(ref _selected);
			set => SetProperty(ref _selected, value);
		}
	}
}
