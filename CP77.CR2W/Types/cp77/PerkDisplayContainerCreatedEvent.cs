using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class PerkDisplayContainerCreatedEvent : redEvent
	{
		[Ordinal(0)]  [RED("container")] public wCHandle<PerkDisplayContainerController> Container { get; set; }
		[Ordinal(1)]  [RED("index")] public CInt32 Index { get; set; }
		[Ordinal(2)]  [RED("isTrait")] public CBool IsTrait { get; set; }

		public PerkDisplayContainerCreatedEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
