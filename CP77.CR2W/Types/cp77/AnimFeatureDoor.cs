using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class AnimFeatureDoor : animAnimFeature
	{
		[Ordinal(0)] [RED("progress")] public CFloat Progress { get; set; }
		[Ordinal(1)] [RED("openingSpeed")] public CFloat OpeningSpeed { get; set; }
		[Ordinal(2)] [RED("openingType")] public CInt32 OpeningType { get; set; }
		[Ordinal(3)] [RED("doorSide")] public CInt32 DoorSide { get; set; }

		public AnimFeatureDoor(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
