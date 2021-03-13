using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class FollowSlot : IScriptable
	{
		[Ordinal(0)] [RED("id")] public CInt32 Id { get; set; }
		[Ordinal(1)] [RED("slotTransform")] public Transform SlotTransform { get; set; }
		[Ordinal(2)] [RED("isEnabled")] public CBool IsEnabled { get; set; }
		[Ordinal(3)] [RED("isAvailable")] public CBool IsAvailable { get; set; }

		public FollowSlot(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
