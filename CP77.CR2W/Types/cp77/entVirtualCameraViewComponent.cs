using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class entVirtualCameraViewComponent : entIVisualComponent
	{
		[Ordinal(0)]  [RED("targetPlaneSize")] public Vector2 TargetPlaneSize { get; set; }
		[Ordinal(1)]  [RED("virtualCameraName")] public CName VirtualCameraName { get; set; }

		public entVirtualCameraViewComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
