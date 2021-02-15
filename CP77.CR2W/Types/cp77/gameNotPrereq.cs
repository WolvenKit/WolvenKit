using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameNotPrereq : gameIPrereq
	{
		[Ordinal(0)] [RED("negatedPrereq")] public CHandle<gameIPrereq> NegatedPrereq { get; set; }

		public gameNotPrereq(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
