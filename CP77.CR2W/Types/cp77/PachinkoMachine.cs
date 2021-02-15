using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PachinkoMachine : ArcadeMachine
	{
		[Ordinal(98)] [RED("distractionFXName")] public CName DistractionFXName { get; set; }

		public PachinkoMachine(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
