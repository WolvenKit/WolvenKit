using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class AGenericTooltipController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("Root")] public wCHandle<inkCompoundWidget> Root { get; set; }

		public AGenericTooltipController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
