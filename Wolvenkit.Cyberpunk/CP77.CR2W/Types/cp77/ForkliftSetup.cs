using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ForkliftSetup : CVariable
	{
		[Ordinal(0)]  [RED("actionActivateName")] public CName ActionActivateName { get; set; }
		[Ordinal(1)]  [RED("hasDistractionQuickhack")] public CBool HasDistractionQuickhack { get; set; }
		[Ordinal(2)]  [RED("liftingAnimationTime")] public CFloat LiftingAnimationTime { get; set; }

		public ForkliftSetup(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
