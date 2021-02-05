using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SuspensionLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
		[Ordinal(1)]  [RED("radiusTrack")] public animNamedTrackIndex RadiusTrack { get; set; }
		[Ordinal(2)]  [RED("deviationTrack")] public animNamedTrackIndex DeviationTrack { get; set; }
		[Ordinal(3)]  [RED("axis")] public CEnum<animAxis> Axis { get; set; }

		public animAnimNode_SuspensionLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
