using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animTwistOutput : CVariable
	{
		[Ordinal(0)]  [RED("positiveScale")] public CFloat PositiveScale { get; set; }
		[Ordinal(1)]  [RED("negativeScale")] public CFloat NegativeScale { get; set; }
		[Ordinal(2)]  [RED("twistAxis")] public CEnum<animAxis> TwistAxis { get; set; }
		[Ordinal(3)]  [RED("twistedTransform")] public animTransformIndex TwistedTransform { get; set; }
		[Ordinal(4)]  [RED("outputAngleTrack")] public animNamedTrackIndex OutputAngleTrack { get; set; }

		public animTwistOutput(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
