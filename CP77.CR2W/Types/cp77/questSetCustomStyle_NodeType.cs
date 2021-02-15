using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questSetCustomStyle_NodeType : questIPhoneManagerNodeType
	{
		[Ordinal(0)] [RED("style")] public CEnum<questCustomStyle> Style { get; set; }
		[Ordinal(1)] [RED("isActive")] public CBool IsActive { get; set; }

		public questSetCustomStyle_NodeType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
