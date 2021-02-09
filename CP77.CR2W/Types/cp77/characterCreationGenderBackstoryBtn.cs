using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class characterCreationGenderBackstoryBtn : inkButtonController
	{
		[Ordinal(0)]  [RED("selector")] public inkWidgetReference Selector { get; set; }
		[Ordinal(1)]  [RED("fluffText")] public inkWidgetReference FluffText { get; set; }

		public characterCreationGenderBackstoryBtn(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
