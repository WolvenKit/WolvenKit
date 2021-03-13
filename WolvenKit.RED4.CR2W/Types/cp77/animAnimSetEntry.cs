using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animAnimSetEntry : ISerializable
	{
		[Ordinal(0)] [RED("animation")] public CHandle<animAnimation> Animation { get; set; }
		[Ordinal(1)] [RED("events")] public CHandle<animEventsContainer> Events { get; set; }

		public animAnimSetEntry(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
