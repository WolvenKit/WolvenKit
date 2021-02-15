using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SecurityArea : InteractiveMasterDevice
	{
		[Ordinal(93)] [RED("area")] public CHandle<gameStaticTriggerAreaComponent> Area { get; set; }

		public SecurityArea(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
