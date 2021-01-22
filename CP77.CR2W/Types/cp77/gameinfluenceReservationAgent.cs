using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameinfluenceReservationAgent : gameinfluenceIAgent
	{
		[Ordinal(0)]  [RED("radius")] public CFloat Radius { get; set; }

		public gameinfluenceReservationAgent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
