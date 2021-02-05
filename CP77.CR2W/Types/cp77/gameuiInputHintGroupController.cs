using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiInputHintGroupController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("titleTextRef")] public inkTextWidgetReference TitleTextRef { get; set; }
		[Ordinal(1)]  [RED("descriptionTextRef")] public inkTextWidgetReference DescriptionTextRef { get; set; }
		[Ordinal(2)]  [RED("hintsContainerRef")] public inkCompoundWidgetReference HintsContainerRef { get; set; }
		[Ordinal(3)]  [RED("iconRef")] public inkImageWidgetReference IconRef { get; set; }

		public gameuiInputHintGroupController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
