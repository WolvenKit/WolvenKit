using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PlayerListEntryLogicController : inkWidgetLogicController
	{
		[Ordinal(0)]  [RED("playerClassIcon")] public inkImageWidgetReference PlayerClassIcon { get; set; }
		[Ordinal(1)]  [RED("playerNameLabel")] public inkWidgetReference PlayerNameLabel { get; set; }

		public PlayerListEntryLogicController(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
