using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class workFastExit : workIEntry
	{
		[Ordinal(0)]  [RED("animName")] public CName AnimName { get; set; }
		[Ordinal(1)]  [RED("forcedBlendIn")] public CFloat ForcedBlendIn { get; set; }
		[Ordinal(2)]  [RED("movementType")] public CEnum<moveMovementType> MovementType { get; set; }

		public workFastExit(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
