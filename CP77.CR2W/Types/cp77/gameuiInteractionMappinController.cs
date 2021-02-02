using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameuiInteractionMappinController : gameuiMappinBaseController
	{
		[Ordinal(0)]  [RED("canvasWidgetName")] public CName CanvasWidgetName { get; set; }
		[Ordinal(1)]  [RED("arrowWidgetName")] public CName ArrowWidgetName { get; set; }
		[Ordinal(2)]  [RED("isCurrentlyClamped")] public CBool IsCurrentlyClamped { get; set; }
		[Ordinal(3)]  [RED("isUnderCrosshair")] public CBool IsUnderCrosshair { get; set; }

		public gameuiInteractionMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
