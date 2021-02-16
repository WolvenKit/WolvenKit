using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectGate : CVariable
	{
		[Ordinal(0)] [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(1)] [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(2)] [RED("movementOrientationType")] public CEnum<moveMovementOrientationType> MovementOrientationType { get; set; }

		public gameSmartObjectGate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
