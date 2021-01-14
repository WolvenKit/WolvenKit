using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class SInspectableClue : CVariable
	{
		[Ordinal(0)]  [RED("clueName")] public CName ClueName { get; set; }
		[Ordinal(1)]  [RED("isScanned")] public CBool IsScanned { get; set; }

		public SInspectableClue(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
