using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiRoachRaceObstacle : CVariable
	{
		[Ordinal(0)] [RED("interval")] public CFloat Interval { get; set; }
		[Ordinal(1)] [RED("dynObjectType")] public CName DynObjectType { get; set; }

		public gameuiRoachRaceObstacle(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
