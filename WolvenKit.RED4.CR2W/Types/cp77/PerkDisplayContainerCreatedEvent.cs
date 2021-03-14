using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayContainerCreatedEvent : redEvent
	{
		[Ordinal(0)] [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(1)] [RED("isTrait")] public CBool IsTrait { get; set; }
		[Ordinal(2)] [RED("container")] public wCHandle<PerkDisplayContainerController> Container { get; set; }

		public PerkDisplayContainerCreatedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
