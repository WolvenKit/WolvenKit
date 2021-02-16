using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Fan : BasicDistractionDevice
	{
		[Ordinal(99)] [RED("animationType")] public CEnum<EAnimationType> AnimationType { get; set; }
		[Ordinal(100)] [RED("rotateClockwise")] public CBool RotateClockwise { get; set; }
		[Ordinal(101)] [RED("randomizeBladesSpeed")] public CBool RandomizeBladesSpeed { get; set; }
		[Ordinal(102)] [RED("maxRotationSpeed")] public CFloat MaxRotationSpeed { get; set; }
		[Ordinal(103)] [RED("timeToMaxRotation")] public CFloat TimeToMaxRotation { get; set; }
		[Ordinal(104)] [RED("animFeature")] public CHandle<AnimFeature_RotatingObject> AnimFeature { get; set; }
		[Ordinal(105)] [RED("updateComp")] public CHandle<UpdateComponent> UpdateComp { get; set; }

		public Fan(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
