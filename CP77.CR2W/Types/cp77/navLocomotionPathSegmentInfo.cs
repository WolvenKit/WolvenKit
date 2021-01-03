using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class navLocomotionPathSegmentInfo : CVariable
	{
		[Ordinal(0)]  [RED("offMeshLink")] public CUInt64 OffMeshLink { get; set; }
		[Ordinal(1)]  [RED("segmentEnd")] public navSerializableSplineProgression SegmentEnd { get; set; }
		[Ordinal(2)]  [RED("type")] public CEnum<navLocomotionPathSegmentTypes> Type { get; set; }

		public navLocomotionPathSegmentInfo(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
