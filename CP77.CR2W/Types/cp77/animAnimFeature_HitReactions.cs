using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class animAnimFeature_HitReactions : animAnimFeature
	{
		[Ordinal(0)]  [RED("hitDirection")] public Vector4 HitDirection { get; set; }
		[Ordinal(1)]  [RED("hitIntensity")] public CFloat HitIntensity { get; set; }
		[Ordinal(2)]  [RED("hitType")] public CInt32 HitType { get; set; }
		[Ordinal(3)]  [RED("hitBodyPart")] public CInt32 HitBodyPart { get; set; }

		public animAnimFeature_HitReactions(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
