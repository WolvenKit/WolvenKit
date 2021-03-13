using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class SampleUIButtons : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("Button")] public inkWidgetReference Button { get; set; }
		[Ordinal(2)] [RED("Toggle1")] public inkWidgetReference Toggle1 { get; set; }
		[Ordinal(3)] [RED("Toggle2")] public inkWidgetReference Toggle2 { get; set; }
		[Ordinal(4)] [RED("Toggle3")] public inkWidgetReference Toggle3 { get; set; }
		[Ordinal(5)] [RED("RadioGroup")] public inkWidgetReference RadioGroup { get; set; }
		[Ordinal(6)] [RED("Text")] public inkTextWidgetReference Text { get; set; }

		public SampleUIButtons(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
