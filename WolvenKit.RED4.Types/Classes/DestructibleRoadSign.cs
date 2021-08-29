using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class DestructibleRoadSign : BaseDestructibleDevice
	{
		private CHandle<entMeshComponent> _frameMesh;
		private CHandle<entMeshComponent> _uiMesh;
		private CHandle<entMeshComponent> _uiMesh_2;

		[Ordinal(90)] 
		[RED("frameMesh")] 
		public CHandle<entMeshComponent> FrameMesh
		{
			get => GetProperty(ref _frameMesh);
			set => SetProperty(ref _frameMesh, value);
		}

		[Ordinal(91)] 
		[RED("uiMesh")] 
		public CHandle<entMeshComponent> UiMesh
		{
			get => GetProperty(ref _uiMesh);
			set => SetProperty(ref _uiMesh, value);
		}

		[Ordinal(92)] 
		[RED("uiMesh_2")] 
		public CHandle<entMeshComponent> UiMesh_2
		{
			get => GetProperty(ref _uiMesh_2);
			set => SetProperty(ref _uiMesh_2, value);
		}
	}
}
