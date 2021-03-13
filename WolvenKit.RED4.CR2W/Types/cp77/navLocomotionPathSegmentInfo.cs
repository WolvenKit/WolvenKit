using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathSegmentInfo : CVariable
	{
		[Ordinal(0)] [RED("type")] public CEnum<navLocomotionPathSegmentTypes> Type { get; set; }
		[Ordinal(1)] [RED("segmentEnd")] public navSerializableSplineProgression SegmentEnd { get; set; }
		[Ordinal(2)] [RED("offMeshLink")] public CUInt64 OffMeshLink { get; set; }

		public navLocomotionPathSegmentInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
