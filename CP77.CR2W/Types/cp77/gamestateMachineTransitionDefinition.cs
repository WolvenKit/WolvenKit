using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gamestateMachineTransitionDefinition : graphGraphConnectionDefinition
	{
		[Ordinal(2)] [RED("priority")] public CFloat Priority { get; set; }

		public gamestateMachineTransitionDefinition(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
