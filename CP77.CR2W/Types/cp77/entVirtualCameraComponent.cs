using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entVirtualCameraComponent : entBaseCameraComponent
	{
		[Ordinal(10)] [RED("virtualCameraName")] public CName VirtualCameraName { get; set; }
		[Ordinal(11)] [RED("resolutionWidth")] public CUInt32 ResolutionWidth { get; set; }
		[Ordinal(12)] [RED("resolutionHeight")] public CUInt32 ResolutionHeight { get; set; }
		[Ordinal(13)] [RED("drawBackground")] public CBool DrawBackground { get; set; }
		[Ordinal(14)] [RED("isEnabled")] public CBool IsEnabled { get; set; }

		public entVirtualCameraComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
