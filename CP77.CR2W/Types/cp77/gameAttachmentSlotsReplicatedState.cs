using System.IO;
using WolvenKit.CR2W.Reflection;
using FastMember;
using static WolvenKit.CR2W.Types.Enums;

namespace WolvenKit.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotsReplicatedState : netIComponentState
	{
		[Ordinal(0)]  [RED("slots")] public CArray<gameAttachmentSlotReplicatedState> Slots { get; set; }
		[Ordinal(1)]  [RED("stateVersion")] public CUInt32 StateVersion { get; set; }

		public gameAttachmentSlotsReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
