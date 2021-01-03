using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AnimFeature_RotatingObject : animAnimFeature
	{
		[Ordinal(0)]  [RED("maxRotationSpeed")] public CFloat MaxRotationSpeed { get; set; }
		[Ordinal(1)]  [RED("randomizeBladesRotation")] public CBool RandomizeBladesRotation { get; set; }
		[Ordinal(2)]  [RED("rotateClockwise")] public CBool RotateClockwise { get; set; }
		[Ordinal(3)]  [RED("timeToMaxRotation")] public CFloat TimeToMaxRotation { get; set; }

		public AnimFeature_RotatingObject(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
