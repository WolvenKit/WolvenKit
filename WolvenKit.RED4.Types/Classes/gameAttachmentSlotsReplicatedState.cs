using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAttachmentSlotsReplicatedState : netIComponentState
	{
		[Ordinal(2)] 
		[RED("stateVersion")] 
		public CUInt32 StateVersion
		{
			get => GetPropertyValue<CUInt32>();
			set => SetPropertyValue<CUInt32>(value);
		}

		[Ordinal(3)] 
		[RED("slots")] 
		public CArray<gameAttachmentSlotReplicatedState> Slots
		{
			get => GetPropertyValue<CArray<gameAttachmentSlotReplicatedState>>();
			set => SetPropertyValue<CArray<gameAttachmentSlotReplicatedState>>(value);
		}

		public gameAttachmentSlotsReplicatedState()
		{
			Enabled = true;
			Slots = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
