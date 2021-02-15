using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPath : ISerializable
	{
		[Ordinal(0)] [RED("splineNodeRef")] public NodeRef SplineNodeRef { get; set; }
		[Ordinal(1)] [RED("segments")] public CArray<navLocomotionPathSegmentInfo> Segments { get; set; }
		[Ordinal(2)] [RED("backwardSegments")] public CArray<navLocomotionPathSegmentInfo> BackwardSegments { get; set; }
		[Ordinal(3)] [RED("points")] public CArray<navLocomotionPathPointInfo> Points { get; set; }
		[Ordinal(4)] [RED("userData")] public CArray<navLocomotionPathPointUserDataEntry> UserData { get; set; }

		public navLocomotionPath(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
