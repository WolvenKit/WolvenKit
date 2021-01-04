using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class GogErrorNotificationController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("errorMessageWidget")] public inkWidgetReference ErrorMessageWidget { get; set; }

		public GogErrorNotificationController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
