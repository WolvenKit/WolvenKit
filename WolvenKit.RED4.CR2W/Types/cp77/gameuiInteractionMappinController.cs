using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiInteractionMappinController : gameuiMappinBaseController
	{
		[Ordinal(7)] [RED("isCurrentlyClamped")] public CBool IsCurrentlyClamped { get; set; }
		[Ordinal(8)] [RED("isUnderCrosshair")] public CBool IsUnderCrosshair { get; set; }
		[Ordinal(9)] [RED("canvasWidgetName")] public CName CanvasWidgetName { get; set; }
		[Ordinal(10)] [RED("arrowWidgetName")] public CName ArrowWidgetName { get; set; }

		public gameuiInteractionMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
