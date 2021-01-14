using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FeedEvent : redEvent
	{
		[Ordinal(0)]  [RED("On")] public CBool On { get; set; }
		[Ordinal(1)]  [RED("cameraID")] public entEntityID CameraID { get; set; }
		[Ordinal(2)]  [RED("virtualComponentName")] public CName VirtualComponentName { get; set; }

		public FeedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
