using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameReplicatedEntityEvent : entReplicatedItem
	{
		[Ordinal(2)] [RED("value")] public CHandle<redEvent> Value { get; set; }

		public gameReplicatedEntityEvent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
