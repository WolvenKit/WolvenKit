using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class DestructibleRoadSign : BaseDestructibleDevice
	{
		[Ordinal(89)] [RED("frameMesh")] public CHandle<entMeshComponent> FrameMesh { get; set; }
		[Ordinal(90)] [RED("uiMesh")] public CHandle<entMeshComponent> UiMesh { get; set; }
		[Ordinal(91)] [RED("uiMesh_2")] public CHandle<entMeshComponent> UiMesh_2 { get; set; }

		public DestructibleRoadSign(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
