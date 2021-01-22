using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class inkVideoSequenceController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("videoSequence")] public CArray<inkVideoSequenceEntry> VideoSequence { get; set; }
		[Ordinal(1)]  [RED("videoWidget")] public inkVideoWidgetReference VideoWidget { get; set; }

		public inkVideoSequenceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
