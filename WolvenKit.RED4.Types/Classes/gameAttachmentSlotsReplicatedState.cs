using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	[REDMeta]
	public partial class gameAttachmentSlotsReplicatedState : netIComponentState
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
	}
}
