using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class VehicleQuestSirenEvent : redEvent
	{
		[Ordinal(0)] [RED("lights")] public CBool Lights { get; set; }
		[Ordinal(1)] [RED("sounds")] public CBool Sounds { get; set; }

		public VehicleQuestSirenEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
