using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class scnPerformerSymbol : CVariable
	{
		[Ordinal(0)]  [RED("editorPerformerId")] public CRUID EditorPerformerId { get; set; }
		[Ordinal(1)]  [RED("entityRef")] public gameEntityReference EntityRef { get; set; }
		[Ordinal(2)]  [RED("performerId")] public scnPerformerId PerformerId { get; set; }

		public scnPerformerSymbol(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
