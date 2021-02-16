using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamePlayerProximityPrereq : gameIPrereq
	{
		[Ordinal(0)] [RED("squaredRange")] public CFloat SquaredRange { get; set; }

		public gamePlayerProximityPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
