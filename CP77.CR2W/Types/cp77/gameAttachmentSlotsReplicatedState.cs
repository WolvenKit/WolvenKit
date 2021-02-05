using System.IO;
using CP77.CR2W.Reflection;
using FastMember;
using static CP77.CR2W.Types.Enums;

namespace CP77.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotsReplicatedState : netIComponentState
	{
		[Ordinal(0)]  [RED("stateVersion")] public CUInt32 StateVersion { get; set; }
		[Ordinal(1)]  [RED("slots")] public CArray<gameAttachmentSlotReplicatedState> Slots { get; set; }

		public gameAttachmentSlotsReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
