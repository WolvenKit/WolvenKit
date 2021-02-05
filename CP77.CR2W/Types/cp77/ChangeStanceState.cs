using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class ChangeStanceState : ChangeStanceStateAbstract
	{
		[Ordinal(0)]  [RED("changeStateOnDeactivate")] public CBool ChangeStateOnDeactivate { get; set; }
		[Ordinal(1)]  [RED("newState")] public CEnum<gamedataNPCStanceState> NewState { get; set; }

		public ChangeStanceState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
