using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiMinimapQuestAreaMappinController : gameuiBaseMinimapMappinController
	{
		[Ordinal(0)]  [RED("areaShapeWidget")] public inkShapeWidgetReference AreaShapeWidget { get; set; }

		public gameuiMinimapQuestAreaMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
