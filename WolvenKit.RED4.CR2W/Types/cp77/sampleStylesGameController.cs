using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleStylesGameController : gameuiWidgetGameController
	{
		[Ordinal(2)] [RED("stateText")] public wCHandle<inkTextWidget> StateText { get; set; }
		[Ordinal(3)] [RED("button1Controller")] public wCHandle<inkButtonController> Button1Controller { get; set; }
		[Ordinal(4)] [RED("button2Controller")] public wCHandle<inkButtonController> Button2Controller { get; set; }

		public sampleStylesGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
