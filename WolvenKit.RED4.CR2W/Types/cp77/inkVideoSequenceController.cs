using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class inkVideoSequenceController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("videoWidget")] public inkVideoWidgetReference VideoWidget { get; set; }
		[Ordinal(2)] [RED("videoSequence")] public CArray<inkVideoSequenceEntry> VideoSequence { get; set; }

		public inkVideoSequenceController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
