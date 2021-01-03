using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class DPADActionPerformed : redEvent
	{
		[Ordinal(0)]  [RED("action")] public CEnum<gameEHotkey> Action { get; set; }
		[Ordinal(1)]  [RED("ownerID")] public entEntityID OwnerID { get; set; }
		[Ordinal(2)]  [RED("state")] public CEnum<EUIActionState> State { get; set; }
		[Ordinal(3)]  [RED("stateInt")] public CInt32 StateInt { get; set; }
		[Ordinal(4)]  [RED("successful")] public CBool Successful { get; set; }

		public DPADActionPerformed(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
