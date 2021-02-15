using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class IsPlayerMovingPrereqState : PlayerStateMachinePrereqState
	{
		[Ordinal(3)] [RED("bbValue")] public CBool BbValue { get; set; }

		public IsPlayerMovingPrereqState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
