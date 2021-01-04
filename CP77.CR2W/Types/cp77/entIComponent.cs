using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class entIComponent : IScriptable
	{
		[Ordinal(0)]  [RED("id")] public CRUID Id { get; set; }
		[Ordinal(1)]  [RED("isReplicable")] public CBool IsReplicable { get; set; }
		[Ordinal(2)]  [RED("name")] public CName Name { get; set; }

		public entIComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
