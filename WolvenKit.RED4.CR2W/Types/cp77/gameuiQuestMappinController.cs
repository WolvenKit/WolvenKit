using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameuiQuestMappinController : gameuiInteractionMappinController
	{
		[Ordinal(11)] [RED("nameplateVisible")] public CBool NameplateVisible { get; set; }
		[Ordinal(12)] [RED("distanceText")] public inkTextWidgetReference DistanceText { get; set; }
		[Ordinal(13)] [RED("displayName")] public inkTextWidgetReference DisplayName { get; set; }

		public gameuiQuestMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
