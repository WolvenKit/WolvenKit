using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamesmartGunUITargetParameters : CVariable
	{
		[Ordinal(0)] [RED("pos")] public Vector2 Pos { get; set; }
		[Ordinal(1)] [RED("state")] public CEnum<gamesmartGunTargetState> State { get; set; }
		[Ordinal(2)] [RED("distance")] public CFloat Distance { get; set; }
		[Ordinal(3)] [RED("accuracy")] public CFloat Accuracy { get; set; }
		[Ordinal(4)] [RED("isLocked")] public CBool IsLocked { get; set; }
		[Ordinal(5)] [RED("timeLocking")] public CFloat TimeLocking { get; set; }
		[Ordinal(6)] [RED("timeUnlocking")] public CFloat TimeUnlocking { get; set; }
		[Ordinal(7)] [RED("timeOccluded")] public CFloat TimeOccluded { get; set; }
		[Ordinal(8)] [RED("entityID")] public entEntityID EntityID { get; set; }

		public gamesmartGunUITargetParameters(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
