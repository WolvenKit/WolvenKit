using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class NarrativePlateLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("textWidget")] public inkWidgetReference TextWidget { get; set; }
		[Ordinal(2)] [RED("captionWidget")] public inkWidgetReference CaptionWidget { get; set; }
		[Ordinal(3)] [RED("root")] public inkWidgetReference Root { get; set; }

		public NarrativePlateLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
