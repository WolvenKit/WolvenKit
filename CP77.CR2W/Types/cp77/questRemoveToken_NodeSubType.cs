using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class questRemoveToken_NodeSubType : questIContentTokenManager_NodeSubType
	{
		[Ordinal(0)]  [RED("removeAll")] public CBool RemoveAll { get; set; }

		public questRemoveToken_NodeSubType(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
