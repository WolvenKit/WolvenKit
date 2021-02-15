using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAttitudeAgent : gameComponent
	{
		[Ordinal(4)] [RED("baseAttitudeGroup")] public CName BaseAttitudeGroup { get; set; }

		public gameAttitudeAgent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
