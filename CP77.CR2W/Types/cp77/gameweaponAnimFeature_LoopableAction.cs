using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameweaponAnimFeature_LoopableAction : animAnimFeature
	{
		[Ordinal(0)]  [RED("loopDuration")] public CFloat LoopDuration { get; set; }
		[Ordinal(1)]  [RED("numLoops")] public CUInt8 NumLoops { get; set; }
		[Ordinal(2)]  [RED("isActive")] public CBool IsActive { get; set; }

		public gameweaponAnimFeature_LoopableAction(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
