using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameuiQuestMappinController : gameuiInteractionMappinController
	{
		[Ordinal(0)]  [RED("displayName")] public inkTextWidgetReference DisplayName { get; set; }
		[Ordinal(1)]  [RED("distanceText")] public inkTextWidgetReference DistanceText { get; set; }
		[Ordinal(2)]  [RED("nameplateVisible")] public CBool NameplateVisible { get; set; }

		public gameuiQuestMappinController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
