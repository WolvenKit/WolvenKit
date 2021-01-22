using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class redTaskNameMessage : CVariable
	{
		[Ordinal(0)]  [RED("id")] public CUInt32 Id { get; set; }
		[Ordinal(1)]  [RED("title")] public CString Title { get; set; }
		[Ordinal(2)]  [RED("uniqueName")] public CName UniqueName { get; set; }

		public redTaskNameMessage(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
