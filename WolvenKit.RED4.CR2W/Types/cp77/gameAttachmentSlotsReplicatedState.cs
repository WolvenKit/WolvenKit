using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotsReplicatedState : netIComponentState
	{
		[Ordinal(2)] [RED("stateVersion")] public CUInt32 StateVersion { get; set; }
		[Ordinal(3)] [RED("slots")] public CArray<gameAttachmentSlotReplicatedState> Slots { get; set; }

		public gameAttachmentSlotsReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
