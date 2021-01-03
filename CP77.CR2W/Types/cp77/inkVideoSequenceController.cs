using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class inkVideoSequenceController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("videoSequence")] public CArray<inkVideoSequenceEntry> VideoSequence { get; set; }
		[Ordinal(1)]  [RED("videoWidget")] public inkVideoWidgetReference VideoWidget { get; set; }

		public inkVideoSequenceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
