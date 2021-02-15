using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class DeactivateC4 : ActionBool
	{
		[Ordinal(25)] [RED("itemID")] public gameItemID ItemID { get; set; }

		public DeactivateC4(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
