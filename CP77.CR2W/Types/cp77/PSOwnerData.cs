using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class PSOwnerData : CVariable
	{
		[Ordinal(0)] [RED("id")] public gamePersistentID Id { get; set; }
		[Ordinal(1)] [RED("className")] public CName ClassName { get; set; }

		public PSOwnerData(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
