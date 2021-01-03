using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameSmartObjectGate : CVariable
	{
		[Ordinal(0)]  [RED("animationName")] public CName AnimationName { get; set; }
		[Ordinal(1)]  [RED("movementOrientationType")] public CEnum<moveMovementOrientationType> MovementOrientationType { get; set; }
		[Ordinal(2)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }

		public gameSmartObjectGate(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
