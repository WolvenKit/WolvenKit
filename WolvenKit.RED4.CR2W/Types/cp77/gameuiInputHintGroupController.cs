using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintGroupController : inkWidgetLogicController
	{
		[Ordinal(1)] [RED("titleTextRef")] public inkTextWidgetReference TitleTextRef { get; set; }
		[Ordinal(2)] [RED("descriptionTextRef")] public inkTextWidgetReference DescriptionTextRef { get; set; }
		[Ordinal(3)] [RED("hintsContainerRef")] public inkCompoundWidgetReference HintsContainerRef { get; set; }
		[Ordinal(4)] [RED("iconRef")] public inkImageWidgetReference IconRef { get; set; }

		public gameuiInputHintGroupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
