using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class AIMovementTypeSpec : CVariable
	{
		[Ordinal(0)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }
		[Ordinal(1)]  [RED("useNPCMovementParams")] public CBool UseNPCMovementParams { get; set; }

		public AIMovementTypeSpec(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
