using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameMultiPrereqState : gamePrereqState
	{
		[Ordinal(0)]  [RED("nestedStates")] public CArray<CHandle<gamePrereqState>> NestedStates { get; set; }

		public gameMultiPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
