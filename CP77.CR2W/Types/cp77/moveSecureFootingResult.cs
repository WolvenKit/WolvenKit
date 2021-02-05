using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class moveSecureFootingResult : CVariable
	{
		[Ordinal(0)]  [RED("slidingDirection")] public Vector4 SlidingDirection { get; set; }
		[Ordinal(1)]  [RED("normalDirection")] public Vector4 NormalDirection { get; set; }
		[Ordinal(2)]  [RED("lowestLocalPosition")] public Vector4 LowestLocalPosition { get; set; }
		[Ordinal(3)]  [RED("staticGroundFactor")] public CFloat StaticGroundFactor { get; set; }
		[Ordinal(4)]  [RED("reason")] public CEnum<moveSecureFootingFailureReason> Reason { get; set; }
		[Ordinal(5)]  [RED("type")] public CEnum<moveSecureFootingFailureType> Type { get; set; }

		public moveSecureFootingResult(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
