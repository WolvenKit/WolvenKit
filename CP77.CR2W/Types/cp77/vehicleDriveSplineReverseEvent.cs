using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class vehicleDriveSplineReverseEvent : redEvent
	{
		[Ordinal(0)]  [RED("backwards")] public CBool Backwards { get; set; }
		[Ordinal(1)]  [RED("reverseSpline")] public CBool ReverseSpline { get; set; }
		[Ordinal(2)]  [RED("splineRef")] public NodeRef SplineRef { get; set; }

		public vehicleDriveSplineReverseEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
