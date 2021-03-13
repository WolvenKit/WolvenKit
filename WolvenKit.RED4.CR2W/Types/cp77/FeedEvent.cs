using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FeedEvent : redEvent
	{
		[Ordinal(0)] [RED("On")] public CBool On { get; set; }
		[Ordinal(1)] [RED("virtualComponentName")] public CName VirtualComponentName { get; set; }
		[Ordinal(2)] [RED("cameraID")] public entEntityID CameraID { get; set; }

		public FeedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
