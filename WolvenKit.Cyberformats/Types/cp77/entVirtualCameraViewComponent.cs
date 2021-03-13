using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entVirtualCameraViewComponent : entIVisualComponent
	{
		[Ordinal(8)] [RED("virtualCameraName")] public CName VirtualCameraName { get; set; }
		[Ordinal(9)] [RED("targetPlaneSize")] public Vector2 TargetPlaneSize { get; set; }

		public entVirtualCameraViewComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
