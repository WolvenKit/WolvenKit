using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class BaseButtonView : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("ButtonController")] public wCHandle<inkButtonController> ButtonController { get; set; }

		public BaseButtonView(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
