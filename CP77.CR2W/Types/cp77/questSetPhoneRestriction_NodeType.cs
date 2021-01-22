using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetPhoneRestriction_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)]  [RED("applyPhoneRestriction")] public CBool ApplyPhoneRestriction { get; set; }

		public questSetPhoneRestriction_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
