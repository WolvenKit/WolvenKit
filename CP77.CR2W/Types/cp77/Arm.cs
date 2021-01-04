using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class Arm : redEvent
	{
		[Ordinal(0)]  [RED("requester")] public wCHandle<gameObject> Requester { get; set; }

		public Arm(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
