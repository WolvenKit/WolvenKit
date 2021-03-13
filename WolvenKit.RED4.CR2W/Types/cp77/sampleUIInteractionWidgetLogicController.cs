using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class sampleUIInteractionWidgetLogicController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("enableStateColor")] public CColor EnableStateColor { get; set; }
		[Ordinal(2)] [RED("disableStateColor")] public CColor DisableStateColor { get; set; }
		[Ordinal(3)] [RED("textWidget")] public wCHandle<inkTextWidget> TextWidget { get; set; }

		public sampleUIInteractionWidgetLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
