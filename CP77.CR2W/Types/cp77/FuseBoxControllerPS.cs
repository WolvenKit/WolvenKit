using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FuseBoxControllerPS : MasterControllerPS
	{
		[Ordinal(0)]  [RED("fuseBoxSkillChecks")] public CHandle<EngineeringContainer> FuseBoxSkillChecks { get; set; }
		[Ordinal(1)]  [RED("isGenerator")] public CBool IsGenerator { get; set; }
		[Ordinal(2)]  [RED("isOverloaded")] public CBool IsOverloaded { get; set; }

		public FuseBoxControllerPS(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
