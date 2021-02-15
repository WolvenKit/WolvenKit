using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class CanNPCRun : AIbehaviorconditionScript
	{
		[Ordinal(0)] [RED("maxRunners")] public CInt32 MaxRunners { get; set; }

		public CanNPCRun(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
