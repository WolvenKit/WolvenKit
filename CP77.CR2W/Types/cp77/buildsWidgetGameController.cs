using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class buildsWidgetGameController : gameuiWidgetGameController
	{
		[Ordinal(0)]  [RED("horizontalPanelsList")] public CArray<wCHandle<inkHorizontalPanelWidget>> HorizontalPanelsList { get; set; }

		public buildsWidgetGameController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
