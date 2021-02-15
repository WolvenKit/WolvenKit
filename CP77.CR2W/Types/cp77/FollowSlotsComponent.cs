using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class FollowSlotsComponent : gameScriptableComponent
	{
		[Ordinal(5)] [RED("followSlots")] public CArray<CHandle<FollowSlot>> FollowSlots { get; set; }

		public FollowSlotsComponent(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
