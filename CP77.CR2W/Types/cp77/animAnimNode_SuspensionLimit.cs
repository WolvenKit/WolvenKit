using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class animAnimNode_SuspensionLimit : animAnimNode_OnePoseInput
	{
		[Ordinal(0)]  [RED("axis")] public CEnum<animAxis> Axis { get; set; }
		[Ordinal(1)]  [RED("constrainedTransform")] public animTransformIndex ConstrainedTransform { get; set; }
		[Ordinal(2)]  [RED("deviationTrack")] public animNamedTrackIndex DeviationTrack { get; set; }
		[Ordinal(3)]  [RED("radiusTrack")] public animNamedTrackIndex RadiusTrack { get; set; }

		public animAnimNode_SuspensionLimit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
