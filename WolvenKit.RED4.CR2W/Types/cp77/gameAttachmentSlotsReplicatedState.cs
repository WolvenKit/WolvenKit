using WolvenKit.RED4.CR2W.Reflection;
using FastMember;
using static WolvenKit.RED4.CR2W.Types.Enums;

namespace WolvenKit.RED4.CR2W.Types
{
	[REDMeta]
	public class gameAttachmentSlotsReplicatedState : netIComponentState
	{
		private CUInt32 _stateVersion;
		private CArray<gameAttachmentSlotReplicatedState> _slots;

		[Ordinal(2)] 
		[RED("stateVersion")] 
		public CUInt32 StateVersion
		{
			get => GetProperty(ref _stateVersion);
			set => SetProperty(ref _stateVersion, value);
		}

		[Ordinal(3)] 
		[RED("slots")] 
		public CArray<gameAttachmentSlotReplicatedState> Slots
		{
			get => GetProperty(ref _slots);
			set => SetProperty(ref _slots, value);
		}

		public gameAttachmentSlotsReplicatedState(CR2WFile cr2w, CVariable parent, string name) : base(cr2w, parent, name) { }
	}
}
