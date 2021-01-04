using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiUIInteractionData : CVariable
	{
		[Ordinal(0)]  [RED("interactionListActive")] public CBool InteractionListActive { get; set; }
		[Ordinal(1)]  [RED("terminalInteractionActive")] public CBool TerminalInteractionActive { get; set; }

		public gameuiUIInteractionData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
