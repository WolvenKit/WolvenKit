using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiCreditsSectionController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("sectionName")] public inkTextWidgetReference SectionName { get; set; }

		public gameuiCreditsSectionController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
