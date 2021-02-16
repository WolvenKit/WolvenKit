using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DPADActionPerformed : redEvent
	{
		[Ordinal(0)] [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(1)] [RED("state")] public CEnum<EUIActionState> State { get; set; }
		[Ordinal(2)] [RED("stateInt")] public CInt32 StateInt { get; set; }
		[Ordinal(3)] [RED("action")] public CEnum<gameEHotkey> Action { get; set; }
		[Ordinal(4)] [RED("successful")] public CBool Successful { get; set; }

		public DPADActionPerformed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
