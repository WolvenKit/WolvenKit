using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Fan : BasicDistractionDevice
	{
		[Ordinal(90)]  [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }
		[Ordinal(91)]  [RED("rotateClockwise")] public CBool RotateClockwise { get; set; }
		[Ordinal(92)]  [RED("randomizeBladesSpeed")] public CBool RandomizeBladesSpeed { get; set; }
		[Ordinal(93)]  [RED("maxRotationSpeed")] public CFloat MaxRotationSpeed { get; set; }
		[Ordinal(94)]  [RED("timeToMaxRotation")] public CFloat TimeToMaxRotation { get; set; }
		[Ordinal(95)]  [RED("animFeature")] public CHandle<AnimFeature_RotatingObject> AnimFeature { get; set; }
		[Ordinal(96)]  [RED("updateComp")] public CHandle<UpdateComponent> UpdateComp { get; set; }

		public Fan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
