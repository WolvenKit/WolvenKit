using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FullSystemRestart : ActionBool
	{
		[Ordinal(25)] [RED("restartDuration")] public CInt32 RestartDuration { get; set; }

		public FullSystemRestart(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
