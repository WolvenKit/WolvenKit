using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class animEventsContainer : ISerializable
	{
		[Ordinal(0)] [RED("events")] public CArray<CHandle<animAnimEvent>> Events { get; set; }

		public animEventsContainer(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
