using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestructibleRoadSign : BaseDestructibleDevice
	{
		private CHandle<entMeshComponent> _frameMesh;
		private CHandle<entMeshComponent> _uiMesh;
		private CHandle<entMeshComponent> _uiMesh_2;

		[Ordinal(89)] 
		[RED("frameMesh")] 
		public CHandle<entMeshComponent> FrameMesh
		{
			get => GetProperty(ref _frameMesh);
			set => SetProperty(ref _frameMesh, value);
		}

		[Ordinal(90)] 
		[RED("uiMesh")] 
		public CHandle<entMeshComponent> UiMesh
		{
			get => GetProperty(ref _uiMesh);
			set => SetProperty(ref _uiMesh, value);
		}

		[Ordinal(91)] 
		[RED("uiMesh_2")] 
		public CHandle<entMeshComponent> UiMesh_2
		{
			get => GetProperty(ref _uiMesh_2);
			set => SetProperty(ref _uiMesh_2, value);
		}

		public DestructibleRoadSign(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
