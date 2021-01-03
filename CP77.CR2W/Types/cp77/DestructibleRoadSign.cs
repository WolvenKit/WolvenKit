using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DestructibleRoadSign : BaseDestructibleDevice
	{
		[Ordinal(0)]  [RED("frameMesh")] public CHandle<entMeshComponent> FrameMesh { get; set; }
		[Ordinal(1)]  [RED("uiMesh")] public CHandle<entMeshComponent> UiMesh { get; set; }
		[Ordinal(2)]  [RED("uiMesh_2")] public CHandle<entMeshComponent> UiMesh_2 { get; set; }

		public DestructibleRoadSign(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
