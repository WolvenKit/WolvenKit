using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameEffectTriggerEffectDesc : ISerializable
	{
		[Ordinal(0)] [RED("effect")] public raRef<worldEffect> Effect { get; set; }
		[Ordinal(1)] [RED("positionType")] public CEnum<gameEffectTriggerPositioningType> PositionType { get; set; }
		[Ordinal(2)] [RED("rotationType")] public CEnum<gameEffectTriggerRotationType> RotationType { get; set; }
		[Ordinal(3)] [RED("offset")] public Vector3 Offset { get; set; }
		[Ordinal(4)] [RED("playFromHour")] public CUInt32 PlayFromHour { get; set; }
		[Ordinal(5)] [RED("playTillHour")] public CUInt32 PlayTillHour { get; set; }

		public gameEffectTriggerEffectDesc(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
