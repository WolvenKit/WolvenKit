using static WolvenKit.RED4.Types.Enums;

namespace WolvenKit.RED4.Types
{
	public partial class gameAttachmentSlotReplicatedState : RedBaseClass
	{
		[Ordinal(0)] 
		[RED("slotID")] 
		public TweakDBID SlotID
		{
			get => GetPropertyValue<TweakDBID>();
			set => SetPropertyValue<TweakDBID>(value);
		}

		[Ordinal(1)] 
		[RED("activeItemID")] 
		public gameItemID ActiveItemID
		{
			get => GetPropertyValue<gameItemID>();
			set => SetPropertyValue<gameItemID>(value);
		}

		[Ordinal(2)] 
		[RED("hasItemObject")] 
		public CBool HasItemObject
		{
			get => GetPropertyValue<CBool>();
			set => SetPropertyValue<CBool>(value);
		}

		public gameAttachmentSlotReplicatedState()
		{
			ActiveItemID = new();

			PostConstruct();
		}

		partial void PostConstruct();
	}
}
